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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            stock k = new stock();

            localhost.Service1 r = new localhost.Service1();
         bool   is_valid = false;
         bool   is_validresult = false;
            r.login(textBox1.Text, textBox2.Text,out is_valid, out is_validresult);
            //if (textBox1.Text == admin.username && textBox2.Text == admin.password)
            //{
            if (is_valid) { 
                MessageBox.Show("valid");
                this.Hide();
                k.Show();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            change_passwrd p = new change_passwrd();
            p.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forget_passwrd g = new Forget_passwrd();
            g.Show();
            this.Hide();
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

        private void Login_Load(object sender, EventArgs e)
        {
            label5.Text = "Pharmacy System";
            timer1.Start();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
            label3.Text = DateTime.Now.ToLongTimeString();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
         
        }

        private void lnklblNewuser(object sender, EventArgs e)
        {
            Register r = new Register();
            this.Hide();
            r.Show();

        }
    }
}
