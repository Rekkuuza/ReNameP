namespace ReNameP
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 22);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenFolder;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(141, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 30);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(23, 74);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(564, 510);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(633, 74);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(588, 510);
            listBox2.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 656);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 30);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(292, 656);
            button2.Name = "button2";
            button2.Size = new Size(183, 34);
            button2.TabIndex = 8;
            button2.Text = "Find Files by Text";
            button2.UseVisualStyleBackColor = true;
            button2.Click += FindKeyWord;
            // 
            // button3
            // 
            button3.Location = new Point(1034, 618);
            button3.Name = "button3";
            button3.Size = new Size(187, 34);
            button3.TabIndex = 9;
            button3.Text = "Change File Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ChangeFileName;
            // 
            // button4
            // 
            button4.Location = new Point(593, 19);
            button4.Name = "button4";
            button4.Size = new Size(57, 34);
            button4.TabIndex = 10;
            button4.Text = "⟳";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Refresh;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 614);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(454, 31);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 750);
            Controls.Add(comboBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "ReNameP";
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox textBox1;
        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
    }
}