﻿namespace ATMApp
{
    partial class CHANGEPIN
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
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            Pin1Tb = new TextBox();
            Pin2Tb = new TextBox();
            button1 = new Button();
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
            panel1.TabIndex = 3;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkSlateGray;
            label7.Location = new Point(377, 414);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 19;
            label7.Text = "BACK";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateGray;
            label4.Location = new Point(367, 159);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateGray;
            label3.Location = new Point(80, 248);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 16;
            label3.Text = "CONFIRM PIN:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Roboto", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateGray;
            label5.Location = new Point(80, 159);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 15;
            label5.Text = "NEW PIN:";
            // 
            // Pin1Tb
            // 
            Pin1Tb.Location = new Point(269, 156);
            Pin1Tb.Name = "Pin1Tb";
            Pin1Tb.Size = new Size(224, 27);
            Pin1Tb.TabIndex = 20;
            // 
            // Pin2Tb
            // 
            Pin2Tb.Location = new Point(269, 245);
            Pin2Tb.Name = "Pin2Tb";
            Pin2Tb.Size = new Size(224, 27);
            Pin2Tb.TabIndex = 21;
            // 
            // button1
            // 
            button1.Location = new Point(357, 382);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 32;
            button1.Text = "CHANGE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CHANGEPIN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Pin2Tb);
            Controls.Add(Pin1Tb);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CHANGEPIN";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CHANGEPIN";
            Load += CHANGEPIN_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox Pin1Tb;
        private TextBox Pin2Tb;
        private Button button1;
    }
}