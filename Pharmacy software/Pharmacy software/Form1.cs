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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login s = new Login();
            this.Hide();
            s.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homeToolStripMenuItem.Enabled = false;
            stockToolStripMenuItem.Enabled = false;
            sellToolStripMenuItem.Enabled = false;
            timer1.Start();
            label3.Text = "Pharmacy System";
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Sell_product p = new Sell_product();
            //this.Hide();
            //p.Show(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void grad(object sender, PaintEventArgs e)
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black,Color.DarkCyan, 50F);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
