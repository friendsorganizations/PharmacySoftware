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
    public partial class stock : Form
    {
        public stock()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 m = new Form1();
            this.Hide();
            m.Show();
        }
        DataTable t = new DataTable();
        int selected_row;
        private void stock_Load(object sender, EventArgs e)
        {
            sellToolStripMenuItem.Enabled = false;
            t.Columns.Add("ExpiryDate", typeof(string));
            t.Columns.Add("ItemFormula", typeof(string));
            t.Columns.Add("ItemName", typeof(string));
            t.Columns.Add("ItemPrice", typeof(int));
            t.Columns.Add("ItemQuantity", typeof(int));
            t.Columns.Add("ItemType", typeof(string));
            dataGridView1.DataSource = t;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dial = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dial == DialogResult.Yes)
            {
                Application.Exit();
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 s = new localhost.Service1();
            //   s.add(textBox1.Text,comboBox1.Text,textBox2.Text,int.Parse(textBox10.Text),pr,int.Parse(textBox9.Text),pr,DateTime.Parse(dateTimePicker1.Text),pr,)
            bool prc_spec = true;
            t.Rows.Add(dateTimePicker1.Value, textBox2.Text, textBox1.Text, int.Parse(textBox10.Text), int.Parse(textBox9.Text), comboBox1.Text);
            s.add(textBox1.Text, comboBox1.Text, textBox2.Text, int.Parse(textBox10.Text), prc_spec, int.Parse(textBox9.Text), prc_spec, DateTime.Parse(dateTimePicker1.Text), prc_spec);
            MessageBox.Show("Product added successfully");
            dataGridView1.DataSource = t;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            selected_row = dataGridView1.CurrentCell.RowIndex;

            bool ind_spec = true;
            localhost.Service1 w = new localhost.Service1();

            w.delete_product(selected_row, ind_spec);

            BindingSource s = new BindingSource();
            s.DataSource = w.showAll();
            dataGridView1.DataSource = s;

            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            MessageBox.Show("Deleted successfully");

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            BindingSource q = new BindingSource();
           
         

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
         
        }

        private void cmdCellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_row = e.RowIndex;
            DataGridViewRow r = dataGridView1.Rows[selected_row];
       
            textBox4.Text = r.Cells[3].Value.ToString();
            textBox3.Text = r.Cells[4].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
