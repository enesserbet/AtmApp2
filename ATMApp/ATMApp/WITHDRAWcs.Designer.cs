namespace ATMApp
{
    partial class WITHDRAWcs
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
            button1 = new Button();
            label3 = new Label();
            wdamtTb = new TextBox();
            label7 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            balanceblb = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(356, 374);
            button1.Name = "button1";
            button1.Size = new Size(97, 29);
            button1.TabIndex = 43;
            button1.Text = "WITHDRAW";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(318, 112);
            label3.Name = "label3";
            label3.Size = new Size(175, 37);
            label3.TabIndex = 38;
            label3.Text = "WITHDRAW";
            // 
            // wdamtTb
            // 
            wdamtTb.Location = new Point(269, 248);
            wdamtTb.Name = "wdamtTb";
            wdamtTb.Size = new Size(224, 27);
            wdamtTb.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(376, 406);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(57, 20);
            label7.TabIndex = 41;
            label7.Text = "BACK";
            label7.Click += label7_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(221, 20);
            label5.TabIndex = 40;
            label5.Text = "AMOUNT TO WITHDRAW:";
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
            panel1.TabIndex = 39;
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
            // balanceblb
            // 
            balanceblb.AutoSize = true;
            balanceblb.BackColor = SystemColors.Control;
            balanceblb.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            balanceblb.ForeColor = Color.DarkSlateGray;
            balanceblb.Location = new Point(241, 174);
            balanceblb.Name = "balanceblb";
            balanceblb.Size = new Size(324, 37);
            balanceblb.TabIndex = 44;
            balanceblb.Text = "AVAILABLE BALANCE: ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 433);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 17);
            panel2.TabIndex = 45;
            // 
            // WITHDRAWcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(balanceblb);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(wdamtTb);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "WITHDRAWcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WITHDRAWcs";
            Load += WITHDRAWcs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private TextBox wdamtTb;
        private Label label7;
        private Label label5;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label balanceblb;
        private Panel panel2;
    }
}