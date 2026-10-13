namespace Desktop
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 54);
            label1.Name = "label1";
            label1.Size = new Size(63, 24);
            label1.TabIndex = 0;
            label1.Text = "Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 209);
            label2.Name = "label2";
            label2.Size = new Size(69, 24);
            label2.TabIndex = 1;
            label2.Text = "Height";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 378);
            label3.Name = "label3";
            label3.Size = new Size(68, 24);
            label3.TabIndex = 2;
            label3.Text = "Border";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(194, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 209);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(194, 378);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 30);
            textBox3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 60);
            label4.Name = "label4";
            label4.Size = new Size(36, 24);
            label4.TabIndex = 6;
            label4.Text = "cm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(368, 215);
            label5.Name = "label5";
            label5.Size = new Size(36, 24);
            label5.TabIndex = 7;
            label5.Text = "cm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(368, 384);
            label6.Name = "label6";
            label6.Size = new Size(36, 24);
            label6.TabIndex = 8;
            label6.Text = "cm";
            // 
            // button1
            // 
            button1.Location = new Point(500, 136);
            button1.Name = "button1";
            button1.Size = new Size(187, 218);
            button1.TabIndex = 9;
            button1.Text = "计算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(778, 36);
            label7.Name = "label7";
            label7.Size = new Size(100, 48);
            label7.TabIndex = 10;
            label7.Text = "内部宽度：\r\n内部高度：\r\n";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(778, 136);
            label8.Name = "label8";
            label8.Size = new Size(136, 24);
            label8.TabIndex = 11;
            label8.Text = "可用展示面积：";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(778, 330);
            label9.Name = "label9";
            label9.Size = new Size(136, 24);
            label9.TabIndex = 12;
            label9.Text = "边框材料面积：";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(778, 437);
            label10.Name = "label10";
            label10.Size = new Size(118, 24);
            label10.TabIndex = 13;
            label10.Text = "外边缘周长：";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 530);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Lab02_25030021018_郭一凡";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
