namespace WinFormsApp13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            numericUpDown1 = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(30, 41);
            button1.Name = "button1";
            button1.Size = new Size(154, 33);
            button1.TabIndex = 0;
            button1.Text = "Ex 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(232, 41);
            button2.Name = "button2";
            button2.Size = new Size(162, 33);
            button2.TabIndex = 1;
            button2.Text = "Ex 2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(218, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 201);
            panel1.TabIndex = 2;
            panel1.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(129, 121);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(47, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(20, 32);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(91, 112);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(37, 153);
            button3.Name = "button3";
            button3.Size = new Size(127, 33);
            button3.TabIndex = 0;
            button3.Text = "Start";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(446, 41);
            button4.Name = "button4";
            button4.Size = new Size(144, 33);
            button4.TabIndex = 3;
            button4.Text = "Ex 3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(642, 41);
            button5.Name = "button5";
            button5.Size = new Size(110, 33);
            button5.TabIndex = 4;
            button5.Text = "Ex 4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private NumericUpDown numericUpDown1;
        private RichTextBox richTextBox1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}