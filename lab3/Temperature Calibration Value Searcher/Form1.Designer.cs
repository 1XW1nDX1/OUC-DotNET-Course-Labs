namespace Temperature_Calibration_Value_Searcher
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
            label1 = new Label();
            Range1 = new Label();
            Input1 = new TextBox();
            record1 = new Label();
            button1 = new Button();
            button2 = new Button();
            checkBox1 = new CheckBox();
            listBox1 = new ListBox();
            Easy = new RadioButton();
            Medium = new RadioButton();
            Hard = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 64);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 0;
            label1.Text = "当前温度范围：";
            // 
            // Range1
            // 
            Range1.AutoSize = true;
            Range1.Location = new Point(154, 64);
            Range1.Name = "Range1";
            Range1.Size = new Size(70, 24);
            Range1.TabIndex = 1;
            Range1.Text = "[20,80]";
            // 
            // Input1
            // 
            Input1.Location = new Point(13, 136);
            Input1.Name = "Input1";
            Input1.Size = new Size(252, 30);
            Input1.TabIndex = 2;
            // 
            // record1
            // 
            record1.AutoSize = true;
            record1.Location = new Point(13, 100);
            record1.Name = "record1";
            record1.Size = new Size(118, 24);
            record1.TabIndex = 3;
            record1.Text = "输入候选值：";
            // 
            // button1
            // 
            button1.Location = new Point(349, 134);
            button1.Name = "button1";
            button1.Size = new Size(163, 32);
            button1.TabIndex = 4;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Commit;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(13, 213);
            button2.Name = "button2";
            button2.Size = new Size(500, 109);
            button2.TabIndex = 5;
            button2.Text = "开始新一轮";
            button2.UseVisualStyleBackColor = false;
            button2.Click += StartNewCircle;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(13, 16);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 28);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "测试开关";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 343);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(493, 124);
            listBox1.TabIndex = 10;
            // 
            // Easy
            // 
            Easy.AutoSize = true;
            Easy.Checked = true;
            Easy.Location = new Point(352, 17);
            Easy.Margin = new Padding(5, 4, 5, 4);
            Easy.Name = "Easy";
            Easy.Size = new Size(136, 28);
            Easy.TabIndex = 11;
            Easy.TabStop = true;
            Easy.Text = "简单 [20,80]";
            Easy.UseVisualStyleBackColor = true;
            Easy.CheckedChanged += ChangeDifficulty;
            // 
            // Medium
            // 
            Medium.AutoSize = true;
            Medium.Location = new Point(352, 55);
            Medium.Margin = new Padding(5, 4, 5, 4);
            Medium.Name = "Medium";
            Medium.Size = new Size(136, 28);
            Medium.TabIndex = 12;
            Medium.Text = "一般 [0,100]";
            Medium.UseVisualStyleBackColor = true;
            Medium.CheckedChanged += ChangeDifficulty;
            // 
            // Hard
            // 
            Hard.AutoSize = true;
            Hard.Location = new Point(352, 93);
            Hard.Margin = new Padding(5, 4, 5, 4);
            Hard.Name = "Hard";
            Hard.Size = new Size(142, 28);
            Hard.TabIndex = 13;
            Hard.Text = "困难[0,1000]";
            Hard.UseVisualStyleBackColor = true;
            Hard.CheckedChanged += ChangeDifficulty;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 488);
            Controls.Add(Hard);
            Controls.Add(Medium);
            Controls.Add(Easy);
            Controls.Add(listBox1);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(record1);
            Controls.Add(Input1);
            Controls.Add(Range1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "温度校准值搜寻器";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Range1;
        private TextBox Input1;
        private Label record1;
        private Button button1;
        private Button button2;
        private CheckBox checkBox1;
        private ListBox listBox1;
        private RadioButton Easy;
        private RadioButton Medium;
        private RadioButton Hard;
    }
}
