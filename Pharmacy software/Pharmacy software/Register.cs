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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        
        }

        private void lnkblNewuser(object sender, EventArgs e)
        {

        }

        private void lnklblbacktologin(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void cmdRegister(object sender, EventArgs e)
        {
            //admin.username = textBox1.Text; 
            //admin.password = textBox2.Text;
            localhost.Service1 s = new localhost.Service1();
            s.Register(textBox1.Text, textBox2.Text);
            MessageBox.Show("Successfull");

        }

        private void Register_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label5.Text = "Pharmacy system";

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void grad(object sender, PaintEventArgs e)
        {
          
        }

        private void Register_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.DarkCyan, 50F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToLongDateString();
            label4.Text = DateTime.Now.ToLongTimeString();

        }
    }
}
