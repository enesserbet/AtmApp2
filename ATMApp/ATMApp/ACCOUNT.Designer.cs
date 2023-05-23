namespace ATMApp
{
    partial class ACCOUNT
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            AccNumTb = new TextBox();
            AccNameTb = new TextBox();
            FanameTb = new TextBox();
            AddressTb = new TextBox();
            PhoneTb = new TextBox();
            pinTb = new TextBox();
            dobdate = new DateTimePicker();
            panel2 = new Panel();
            button1 = new Button();
            label13 = new Label();
            educationtb = new ComboBox();
            occupationtb = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSlateGray;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 91);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(755, 0);
            label2.Name = "label2";
            label2.Size = new Size(45, 48);
            label2.TabIndex = 1;
            label2.Text = "X";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Roboto", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(125, 21);
            label1.Name = "label1";
            label1.Size = new Size(551, 48);
            label1.TabIndex = 1;
            label1.Text = "ATM MANAGEMENT SYSTEM";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(49, 168);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 9;
            label5.Text = "ACC NUM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(49, 264);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 10;
            label3.Text = "FNANME";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(49, 216);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 11;
            label4.Text = "NAME";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkSlateGray;
            label6.Location = new Point(49, 363);
            label6.Name = "label6";
            label6.Size = new Size(71, 20);
            label6.TabIndex = 12;
            label6.Text = "PHONE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(49, 312);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 13;
            label7.Text = "ADDRESS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkSlateGray;
            label8.Location = new Point(416, 232);
            label8.Name = "label8";
            label8.Size = new Size(110, 20);
            label8.TabIndex = 14;
            label8.Text = "EDUCATION";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkSlateGray;
            label9.Location = new Point(416, 294);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 15;
            label9.Text = "OCCUPATION";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkSlateGray;
            label10.Location = new Point(416, 363);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 16;
            label10.Text = "DOB";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.DarkSlateGray;
            label12.Location = new Point(416, 168);
            label12.Name = "label12";
            label12.Size = new Size(40, 20);
            label12.TabIndex = 18;
            label12.Text = "PIN";
            // 
            // AccNumTb
            // 
            AccNumTb.Location = new Point(146, 165);
            AccNumTb.Name = "AccNumTb";
            AccNumTb.Size = new Size(224, 27);
            AccNumTb.TabIndex = 19;
            // 
            // AccNameTb
            // 
            AccNameTb.Location = new Point(146, 213);
            AccNameTb.Name = "AccNameTb";
            AccNameTb.Size = new Size(224, 27);
            AccNameTb.TabIndex = 20;
            // 
            // FanameTb
            // 
            FanameTb.Location = new Point(146, 261);
            FanameTb.Name = "FanameTb";
            FanameTb.Size = new Size(224, 27);
            FanameTb.TabIndex = 21;
            // 
            // AddressTb
            // 
            AddressTb.Location = new Point(146, 309);
            AddressTb.Name = "AddressTb";
            AddressTb.Size = new Size(224, 27);
            AddressTb.TabIndex = 22;
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(146, 360);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(224, 27);
            PhoneTb.TabIndex = 23;
            // 
            // pinTb
            // 
            pinTb.Location = new Point(541, 165);
            pinTb.Name = "pinTb";
            pinTb.Size = new Size(224, 27);
            pinTb.TabIndex = 24;
            // 
            // dobdate
            // 
            dobdate.Location = new Point(541, 358);
            dobdate.Name = "dobdate";
            dobdate.Size = new Size(224, 27);
            dobdate.TabIndex = 29;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 530);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 14);
            panel2.TabIndex = 30;
            // 
            // button1
            // 
            button1.Location = new Point(343, 456);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 31;
            button1.Text = "SUBMIT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Roboto", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkSlateGray;
            label13.Location = new Point(360, 488);
            label13.Name = "label13";
            label13.Size = new Size(63, 15);
            label13.TabIndex = 32;
            label13.Text = "LOGOUT";
            label13.Click += label13_Click;
            // 
            // educationtb
            // 
            educationtb.FormattingEnabled = true;
            educationtb.Items.AddRange(new object[] { "Non Graduate", "Under Graduate", "Post Graduate" });
            educationtb.Location = new Point(541, 228);
            educationtb.Name = "educationtb";
            educationtb.Size = new Size(224, 28);
            educationtb.TabIndex = 33;
            // 
            // occupationtb
            // 
            occupationtb.Location = new Point(541, 291);
            occupationtb.Name = "occupationtb";
            occupationtb.Size = new Size(224, 27);
            occupationtb.TabIndex = 34;
            // 
            // ACCOUNT
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 544);
            Controls.Add(occupationtb);
            Controls.Add(educationtb);
            Controls.Add(label13);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(dobdate);
            Controls.Add(pinTb);
            Controls.Add(PhoneTb);
            Controls.Add(AddressTb);
            Controls.Add(FanameTb);
            Controls.Add(AccNameTb);
            Controls.Add(AccNumTb);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ACCOUNT";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ACCOUNT";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private TextBox AccNumTb;
        private TextBox AccNameTb;
        private TextBox FanameTb;
        private TextBox AddressTb;
        private TextBox PhoneTb;
        private TextBox pinTb;
        private DateTimePicker dobdate;
        private Panel panel2;
        private Button button1;
        private Label label13;
        private ComboBox educationtb;
        private TextBox occupationtb;
    }
}