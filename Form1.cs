using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Chix4");
            listBox1.Items.Add("Chix3");
            listBox1.Items.Add("Chix5");
            listBox1.Items.Add("Chix6");
            listBox1.Items.Add("Chix7");
            listBox1.Items.Add("Chix2");
            listBox1.Items.Add("Chix1");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text=listBox1.Items.Count.ToString();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.GetItemText(listBox1.SelectedItem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
