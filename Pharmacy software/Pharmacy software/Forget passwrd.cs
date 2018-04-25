using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_software
{
    public partial class Forget_passwrd : Form
    {
        public Forget_passwrd()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dial == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            this.Hide();
            m.Show();
        }

        private void cmdReset(object sender, EventArgs e)
        {
          
            localhost.Service1 s = new localhost.Service1();
            bool is_valid = false;
            bool is_validresult = false;
            s.forgetPassword(textBox1.Text, textBox3.Text,out is_valid,out is_validresult);
            if (is_valid)
            {
                MessageBox.Show("reset successfully");
            }
            else
            {
                MessageBox.Show("username is invalid/not exist ");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Forget_passwrd_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = "Pharmacy system";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();
        }

        private void Forgetpassword(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.DarkCyan, 50F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
