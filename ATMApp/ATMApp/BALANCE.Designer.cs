namespace ATMApp
{
    partial class BALANCE
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
            AccNumberlbl = new Label();
            Balancelbl = new Label();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
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
            panel1.TabIndex = 2;
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
            label5.Location = new Point(74, 155);
            label5.Name = "label5";
            label5.Size = new Size(179, 20);
            label5.TabIndex = 10;
            label5.Text = "ACCOUNT NUMBER:";
            label5.Click += label5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(74, 244);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 11;
            label3.Text = "YOUR BALANCE:";
            // 
            // AccNumberlbl
            // 
            AccNumberlbl.AutoSize = true;
            AccNumberlbl.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            AccNumberlbl.ForeColor = Color.DarkSlateGray;
            AccNumberlbl.Location = new Point(361, 155);
            AccNumberlbl.Name = "AccNumberlbl";
            AccNumberlbl.Size = new Size(86, 20);
            AccNumberlbl.TabIndex = 12;
            AccNumberlbl.Text = "ACCNUM";
            // 
            // Balancelbl
            // 
            Balancelbl.AutoSize = true;
            Balancelbl.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            Balancelbl.ForeColor = Color.DarkSlateGray;
            Balancelbl.Location = new Point(361, 244);
            Balancelbl.Name = "Balancelbl";
            Balancelbl.Size = new Size(132, 20);
            Balancelbl.TabIndex = 13;
            Balancelbl.Text = "BALANCEINRS";
            Balancelbl.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(361, 410);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 14;
            label7.Text = "BACK";
            label7.Click += label7_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkSlateGray;
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 433);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 17);
            flowLayoutPanel1.TabIndex = 15;
            // 
            // BALANCE
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label7);
            Controls.Add(Balancelbl);
            Controls.Add(AccNumberlbl);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BALANCE";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BALANCE:";
            Load += BALANCE_Load;
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
        private Label AccNumberlbl;
        private Label Balancelbl;
        private Label label7;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}