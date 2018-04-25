using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_software
{
    public partial class change_passwrd : Form
    {
        public change_passwrd()
        {
            InitializeComponent();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            this.Hide();
            m.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dial == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login d = new Login();
            this.Hide();
            d.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            localhost.Service1 q = new localhost.Service1();

            bool is_valid = false;
            bool is_validpas = false;
            q.resetPassword(textBox1.Text, textBox2.Text, out is_valid, out is_validpas);
          
            if (is_valid)
            {
                MessageBox.Show("reset successfully");
            }
            else
            {
                MessageBox.Show("Old password is incorrect");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void change_passwrd_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = "Pharmacy System";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
