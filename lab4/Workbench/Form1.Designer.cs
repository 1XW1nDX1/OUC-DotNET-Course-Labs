namespace Workbench
{
    partial class Workbench
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
            status1 = new CheckBox();
            textBox1 = new TextBox();
            current = new Label();
            operator1 = new ComboBox();
            label1 = new Label();
            load1 = new Button();
            do1 = new Button();
            reset1 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // status1
            // 
            status1.AutoCheck = false;
            status1.AutoSize = true;
            status1.CheckAlign = ContentAlignment.MiddleRight;
            status1.Location = new Point(12, 12);
            status1.Name = "status1";
            status1.Size = new Size(90, 28);
            status1.TabIndex = 0;
            status1.Text = "可计算";
            status1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 24F);
            textBox1.Location = new Point(469, 116);
            textBox1.MaximumSize = new Size(100, 70);
            textBox1.MinimumSize = new Size(0, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(70, 70);
            textBox1.TabIndex = 1;
            // 
            // current
            // 
            current.AutoSize = true;
            current.Font = new Font("Microsoft YaHei UI", 24F);
            current.Location = new Point(109, 116);
            current.MinimumSize = new Size(0, 70);
            current.Name = "current";
            current.Size = new Size(55, 70);
            current.TabIndex = 2;
            current.Text = "0";
            // 
            // operator1
            // 
            operator1.DropDownStyle = ComboBoxStyle.DropDownList;
            operator1.FormattingEnabled = true;
            operator1.Items.AddRange(new object[] { "加法", "减法", "乘法", "除法", "乘方", "开平方", "倒数" });
            operator1.Location = new Point(260, 132);
            operator1.Name = "operator1";
            operator1.Size = new Size(112, 32);
            operator1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(100, 92);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 4;
            label1.Text = "当前值";
            // 
            // load1
            // 
            load1.Font = new Font("Microsoft YaHei UI", 12F);
            load1.Location = new Point(621, 12);
            load1.Name = "load1";
            load1.Size = new Size(167, 84);
            load1.TabIndex = 5;
            load1.Text = "载入初始值";
            load1.UseVisualStyleBackColor = true;
            load1.Click += Load;
            // 
            // do1
            // 
            do1.Font = new Font("Microsoft YaHei UI", 12F);
            do1.Location = new Point(621, 102);
            do1.Name = "do1";
            do1.Size = new Size(167, 84);
            do1.TabIndex = 6;
            do1.Text = "执行";
            do1.UseVisualStyleBackColor = true;
            do1.Click += Do;
            // 
            // reset1
            // 
            reset1.Font = new Font("Microsoft YaHei UI", 12F);
            reset1.Location = new Point(621, 192);
            reset1.Name = "reset1";
            reset1.Size = new Size(167, 84);
            reset1.TabIndex = 7;
            reset1.Text = "重置";
            reset1.UseVisualStyleBackColor = true;
            reset1.Click += Reset;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 92);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 8;
            label2.Text = "初始值";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft YaHei UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 304);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 159);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 277);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 10;
            label3.Text = "消息";
            // 
            // Workbench
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 482);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(reset1);
            Controls.Add(do1);
            Controls.Add(load1);
            Controls.Add(label1);
            Controls.Add(operator1);
            Controls.Add(current);
            Controls.Add(textBox1);
            Controls.Add(status1);
            Name = "Workbench";
            Text = "Workbench";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox status1;
        private TextBox textBox1;
        private Label current;
        private ComboBox operator1;
        private Label label1;
        private Button load1;
        private Button do1;
        private Button reset1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
    }
}
