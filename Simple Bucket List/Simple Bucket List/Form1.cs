using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Bucket_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(button1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(button7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(button5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(button4.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(button3.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
