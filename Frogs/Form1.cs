﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frogs
{
    public partial class Form1 : Form
    {
        char[] symbols = { '*', '*', '*', '-', '#', '#', '#' };
        Button[] buttons = new Button[7];
        int indexOfButton;
        int indexOfNextButton;
        char temp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FillingArrayButtons();
        }

        private void FillingArrayButtons()
        {
            buttons[0] = first;
            buttons[1] = second;
            buttons[2] = third;
            buttons[3] = fourth;
            buttons[4] = fifth;
            buttons[5] = sixth;
            buttons[6] = seventh;
        }

        private void CanJump(object sender, EventArgs e)
        {
            Button button = sender as Button;
            indexOfButton = Array.IndexOf(buttons, button);
            for(int i = -2; i < 3; i++)
            {
                indexOfNextButton = indexOfButton+ i;
                if (indexOfButton + i >= 0 && indexOfNextButton < symbols.Length && symbols[indexOfNextButton] == '-') 
                {
                    temp = Convert.ToChar(button.Text);
                    button.Text = buttons[indexOfNextButton].Text;
                    buttons[indexOfNextButton].Text = temp.ToString();

                    symbols[indexOfButton] = symbols[indexOfNextButton];
                    symbols[indexOfNextButton] = temp;
                }
            }
        }
    }
}
