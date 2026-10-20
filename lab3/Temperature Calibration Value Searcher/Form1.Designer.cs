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
            label1.Location = new Point(8, 45);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(92, 17);
            label1.TabIndex = 0;
            label1.Text = "当前温度范围：";
            // 
            // Range1
            // 
            Range1.AutoSize = true;
            Range1.Location = new Point(98, 45);
            Range1.Margin = new Padding(2, 0, 2, 0);
            Range1.Name = "Range1";
            Range1.Size = new Size(47, 17);
            Range1.TabIndex = 1;
            Range1.Text = "[20,80]";
            // 
            // Input1
            // 
            Input1.Location = new Point(8, 96);
            Input1.Margin = new Padding(2);
            Input1.Name = "Input1";
            Input1.Size = new Size(162, 23);
            Input1.TabIndex = 2;
            // 
            // record1
            // 
            record1.AutoSize = true;
            record1.Location = new Point(8, 71);
            record1.Margin = new Padding(2, 0, 2, 0);
            record1.Name = "record1";
            record1.Size = new Size(80, 17);
            record1.TabIndex = 3;
            record1.Text = "输入候选值：";
            // 
            // button1
            // 
            button1.Location = new Point(222, 95);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 4;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Commit;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Location = new Point(8, 151);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(318, 77);
            button2.TabIndex = 5;
            button2.Text = "开始新一轮";
            button2.UseVisualStyleBackColor = false;
            button2.Click += StartNewCircle;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(8, 11);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(75, 21);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "测试开关";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(15, 243);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 89);
            listBox1.TabIndex = 10;
            // 
            // Easy
            // 
            Easy.AutoSize = true;
            Easy.Checked = true;
            Easy.Location = new Point(224, 12);
            Easy.Name = "Easy";
            Easy.Size = new Size(93, 21);
            Easy.TabIndex = 11;
            Easy.TabStop = true;
            Easy.Text = "简单 [20,80]";
            Easy.UseVisualStyleBackColor = true;
            Easy.CheckedChanged += ChangeDifficulty;
            // 
            // Medium
            // 
            Medium.AutoSize = true;
            Medium.Location = new Point(224, 39);
            Medium.Name = "Medium";
            Medium.Size = new Size(93, 21);
            Medium.TabIndex = 12;
            Medium.Text = "一般 [0,100]";
            Medium.UseVisualStyleBackColor = true;
            Medium.CheckedChanged += ChangeDifficulty;
            // 
            // Hard
            // 
            Hard.AutoSize = true;
            Hard.Location = new Point(224, 66);
            Hard.Name = "Hard";
            Hard.Size = new Size(96, 21);
            Hard.TabIndex = 13;
            Hard.Text = "困难[0,1000]";
            Hard.UseVisualStyleBackColor = true;
            Hard.CheckedChanged += ChangeDifficulty;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 346);
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
            Margin = new Padding(2);
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
