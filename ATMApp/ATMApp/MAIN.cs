using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMApp
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DEPOSİT deposit = new DEPOSİT();
            deposit.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            MAIN main = new MAIN();
            main.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BALANCE bal = new BALANCE();
            bal.Show();
            this.Hide();
        }
        public static String AccNumber;
        private void MAIN_Load(object sender, EventArgs e)
        {
            AccNumlbl.Text = "Account Number:" + Form1.AccNumber;
            AccNumber = Form1.AccNumber;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CHANGEPIN changepin = new CHANGEPIN();
            changepin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FASTCASH fastcash = new FASTCASH();
            fastcash.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WITHDRAWcs wd = new WITHDRAWcs();
            wd.Show();
            this.Hide();
        }
    }
}
