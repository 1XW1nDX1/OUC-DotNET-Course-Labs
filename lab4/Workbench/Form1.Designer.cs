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
            history1 = new Button();
            SuspendLayout();
            // 
            // status1
            // 
            status1.AutoCheck = false;
            status1.AutoSize = true;
            status1.CheckAlign = ContentAlignment.MiddleRight;
            status1.Location = new Point(8, 8);
            status1.Margin = new Padding(2);
            status1.Name = "status1";
            status1.Size = new Size(63, 21);
            status1.TabIndex = 0;
            status1.Text = "可计算";
            status1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft YaHei UI", 24F);
            textBox1.Location = new Point(242, 96);
            textBox1.Margin = new Padding(2);
            textBox1.MaximumSize = new Size(100, 70);
            textBox1.MinimumSize = new Size(4, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 50);
            textBox1.TabIndex = 1;
            // 
            // current
            // 
            current.AutoSize = true;
            current.Font = new Font("Microsoft YaHei UI", 24F);
            current.Location = new Point(11, 94);
            current.Margin = new Padding(2, 0, 2, 0);
            current.MinimumSize = new Size(0, 50);
            current.Name = "current";
            current.Size = new Size(37, 50);
            current.TabIndex = 2;
            current.Text = "0";
            // 
            // operator1
            // 
            operator1.DropDownStyle = ComboBoxStyle.DropDownList;
            operator1.FormattingEnabled = true;
            operator1.Items.AddRange(new object[] { "加法", "减法", "乘法", "除法", "平方", "开平方", "倒数", "log10", "ln", "阶乘", "a的b次方", "a的y次根" });
            operator1.DropDownWidth = 120;
            operator1.Location = new Point(165, 102);
            operator1.Margin = new Padding(2);
            operator1.Name = "operator1";
            operator1.Size = new Size(73, 25);
            operator1.TabIndex = 3;
            operator1.SelectedIndexChanged += SelectOp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 72);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 4;
            label1.Text = "当前值";
            // 
            // load1
            // 
            load1.Font = new Font("Microsoft YaHei UI", 12F);
            load1.Location = new Point(395, 8);
            load1.Margin = new Padding(2);
            load1.Name = "load1";
            load1.Size = new Size(106, 60);
            load1.TabIndex = 5;
            load1.Text = "载入初始值";
            load1.UseVisualStyleBackColor = true;
            load1.Click += Load1;
            // 
            // do1
            // 
            do1.Font = new Font("Microsoft YaHei UI", 12F);
            do1.Location = new Point(395, 72);
            do1.Margin = new Padding(2);
            do1.Name = "do1";
            do1.Size = new Size(106, 60);
            do1.TabIndex = 6;
            do1.Text = "执行";
            do1.UseVisualStyleBackColor = true;
            do1.Click += Do;
            // 
            // reset1
            // 
            reset1.Font = new Font("Microsoft YaHei UI", 12F);
            reset1.Location = new Point(395, 136);
            reset1.Margin = new Padding(2);
            reset1.Name = "reset1";
            reset1.Size = new Size(106, 60);
            reset1.TabIndex = 7;
            reset1.Text = "重置";
            reset1.UseVisualStyleBackColor = true;
            reset1.Click += Reset;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 72);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 8;
            label2.Text = "初始值";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft YaHei UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(8, 215);
            listBox1.Margin = new Padding(2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(495, 109);
            listBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 196);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(32, 17);
            label3.TabIndex = 10;
            label3.Text = "消息";
            // 
            // history1
            //
            history1.Location = new Point(8, 31);
            history1.Name = "history1";
            history1.Size = new Size(73, 37);
            history1.TabIndex = 11;
            history1.Text = "运算历史";
            history1.UseVisualStyleBackColor = true;
            history1.Click += ShowHistory;
            //
            // Workbench
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 341);
            Controls.Add(history1);
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
            Margin = new Padding(2);
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
        private Button history1;
    }
}
