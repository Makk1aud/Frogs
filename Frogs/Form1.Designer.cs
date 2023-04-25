namespace Frogs
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.first = new System.Windows.Forms.Button();
            this.second = new System.Windows.Forms.Button();
            this.third = new System.Windows.Forms.Button();
            this.fourth = new System.Windows.Forms.Button();
            this.sixth = new System.Windows.Forms.Button();
            this.fifth = new System.Windows.Forms.Button();
            this.seventh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // first
            // 
            this.first.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first.Location = new System.Drawing.Point(12, 163);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(119, 87);
            this.first.TabIndex = 0;
            this.first.Text = "*";
            this.first.UseVisualStyleBackColor = true;
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.Location = new System.Drawing.Point(137, 163);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(119, 87);
            this.second.TabIndex = 0;
            this.second.Text = "*";
            this.second.UseVisualStyleBackColor = true;
            // 
            // third
            // 
            this.third.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.third.Location = new System.Drawing.Point(262, 163);
            this.third.Name = "third";
            this.third.Size = new System.Drawing.Size(119, 87);
            this.third.TabIndex = 0;
            this.third.Text = "*";
            this.third.UseVisualStyleBackColor = true;
            // 
            // fourth
            // 
            this.fourth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourth.Location = new System.Drawing.Point(387, 163);
            this.fourth.Name = "fourth";
            this.fourth.Size = new System.Drawing.Size(119, 87);
            this.fourth.TabIndex = 0;
            this.fourth.Text = "-";
            this.fourth.UseVisualStyleBackColor = true;
            // 
            // sixth
            // 
            this.sixth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sixth.Location = new System.Drawing.Point(637, 163);
            this.sixth.Name = "sixth";
            this.sixth.Size = new System.Drawing.Size(119, 87);
            this.sixth.TabIndex = 0;
            this.sixth.Text = "#";
            this.sixth.UseVisualStyleBackColor = true;
            // 
            // fifth
            // 
            this.fifth.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fifth.Location = new System.Drawing.Point(512, 163);
            this.fifth.Name = "fifth";
            this.fifth.Size = new System.Drawing.Size(119, 87);
            this.fifth.TabIndex = 0;
            this.fifth.Text = "#";
            this.fifth.UseVisualStyleBackColor = true;
            // 
            // seventh
            // 
            this.seventh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seventh.Location = new System.Drawing.Point(762, 163);
            this.seventh.Name = "seventh";
            this.seventh.Size = new System.Drawing.Size(119, 87);
            this.seventh.TabIndex = 0;
            this.seventh.Text = "#";
            this.seventh.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(924, 382);
            this.Controls.Add(this.fifth);
            this.Controls.Add(this.seventh);
            this.Controls.Add(this.sixth);
            this.Controls.Add(this.fourth);
            this.Controls.Add(this.third);
            this.Controls.Add(this.second);
            this.Controls.Add(this.first);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button second;
        private System.Windows.Forms.Button third;
        private System.Windows.Forms.Button fourth;
        private System.Windows.Forms.Button sixth;
        private System.Windows.Forms.Button fifth;
        private System.Windows.Forms.Button seventh;
    }
}

