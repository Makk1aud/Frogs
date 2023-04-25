using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Frogs
{
    public partial class MainForm : Form
    {
        char[] symbols = { '*', '*', '*', '-', '#', '#', '#' };
        Button[] buttons = new Button[7];
        int indexOfButton;
        int indexOfNextButton;
        char temp;

        public MainForm()
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

        //Check the index for out of bounds
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < symbols.Length;
        }

        //Change the text of the buttons among themselves
        private void ChangeButtonText(Button button)
        {
            temp = Convert.ToChar(button.Text);
            button.Text = buttons[indexOfNextButton].Text;
            buttons[indexOfNextButton].Text = temp.ToString();
        }

        //Change the symbols of the array among themselves
        private void ChangeSymbolsInArray()
        {
            symbols[indexOfButton] = symbols[indexOfNextButton];
            symbols[indexOfNextButton] = temp;
        }

        //Jump check function
        private void CanJump(object sender, EventArgs e)
        {
            Button button = sender as Button;
            indexOfButton = Array.IndexOf(buttons, button); //Index of Button in array
            for(int i = -2; i < 3; i++)
            {
                //Index of button which maybe will change
                indexOfNextButton = indexOfButton+ i;
                if (CheckIndex(indexOfNextButton) && symbols[indexOfNextButton] == '-') //Check of empty postion
                {
                    ChangeButtonText(button);                  
                    ChangeSymbolsInArray();
                }
            }
        }
    }
}
