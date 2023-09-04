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
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OpenFolder;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(446, 30);
            textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(3, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(594, 533);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox2.FormattingEnabled = true;
            listBox2.HorizontalScrollbar = true;
            listBox2.ItemHeight = 23;
            listBox2.Location = new Point(3, 3);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(628, 533);
            listBox2.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(263, 30);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(272, 40);
            button2.Name = "button2";
            button2.Size = new Size(183, 34);
            button2.TabIndex = 8;
            button2.Text = "Find Files by Text";
            button2.UseVisualStyleBackColor = true;
            button2.Click += FindKeyWord;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(442, 3);
            button3.Name = "button3";
            button3.Size = new Size(252, 57);
            button3.TabIndex = 9;
            button3.Text = "Change File Name";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ChangeFileName;
            // 
            // button4
            // 
            button4.Location = new Point(573, 3);
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
            comboBox1.Location = new Point(3, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(454, 31);
            comboBox1.TabIndex = 11;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 1);
            tableLayoutPanel1.Controls.Add(splitContainer2, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.701492F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.29851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 222F));
            tableLayoutPanel1.Size = new Size(1260, 846);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(textBox1);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(653, 45);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(3, 63);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listBox2);
            splitContainer1.Size = new Size(1254, 557);
            splitContainer1.SplitterDistance = 600;
            splitContainer1.SplitterWidth = 20;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(3, 626);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(flowLayoutPanel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button3);
            splitContainer2.Size = new Size(1254, 168);
            splitContainer2.SplitterDistance = 556;
            splitContainer2.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(comboBox1);
            flowLayoutPanel2.Controls.Add(textBox2);
            flowLayoutPanel2.Controls.Add(button2);
            flowLayoutPanel2.Location = new Point(3, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(464, 150);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1278, 859);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "ReNameP";
            TopMost = true;
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}