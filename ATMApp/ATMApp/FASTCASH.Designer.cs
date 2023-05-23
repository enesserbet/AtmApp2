namespace ATMApp
{
    partial class FASTCASH
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
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            balancelbl = new Label();
            label7 = new Label();
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
            panel1.TabIndex = 40;
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
            // button6
            // 
            button6.Location = new Point(568, 347);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 46;
            button6.Text = "1000";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(118, 347);
            button5.Name = "button5";
            button5.Size = new Size(106, 29);
            button5.TabIndex = 45;
            button5.Text = "500";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(549, 251);
            button4.Name = "button4";
            button4.Size = new Size(134, 29);
            button4.TabIndex = 41;
            button4.Text = "200";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(118, 251);
            button3.Name = "button3";
            button3.Size = new Size(106, 29);
            button3.TabIndex = 42;
            button3.Text = "100";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(568, 154);
            button2.Name = "button2";
            button2.Size = new Size(105, 29);
            button2.TabIndex = 43;
            button2.Text = "50";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 154);
            button1.Name = "button1";
            button1.Size = new Size(106, 29);
            button1.TabIndex = 44;
            button1.Text = "20";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateGray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 13);
            panel2.TabIndex = 47;
            // 
            // balancelbl
            // 
            balancelbl.AutoSize = true;
            balancelbl.BackColor = SystemColors.Control;
            balancelbl.Font = new Font("Roboto", 18F, FontStyle.Regular, GraphicsUnit.Point);
            balancelbl.ForeColor = Color.DarkSlateGray;
            balancelbl.Location = new Point(302, 211);
            balancelbl.Name = "balancelbl";
            balancelbl.Size = new Size(310, 37);
            balancelbl.TabIndex = 48;
            balancelbl.Text = "AVAILABLE BALANCE";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(355, 414);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 49;
            label7.Text = "BACK";
            label7.Click += label7_Click;
            // 
            // FASTCASH
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(balancelbl);
            Controls.Add(panel2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FASTCASH";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FASTCASH";
            Load += FASTCASH_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Label balancelbl;
        private Label label7;
    }
}