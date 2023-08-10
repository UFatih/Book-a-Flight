using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text + " " + comboBox2.Text + " " + dateTimePicker1.Text + " " + maskedTextBox1.Text + " " + textBox1.Text + " " + maskedTextBox2 + " " + maskedTextBox3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text;
            comboBox1.Text= label11.Text;
            
        }
    }
}
