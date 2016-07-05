using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace calculator_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);
            double result = firstValue+secondValue;
            textBox3.Text = result.ToString();
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);
            double result = firstValue * secondValue;
            textBox3.Text = result.ToString();
        }

       private void button4_Click(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);
            double result = firstValue - secondValue;
            textBox3.Text = result.ToString();
        }

      

        private void button3_Click_1(object sender, EventArgs e)
        {
            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);
            double result = firstValue / secondValue;
            textBox3.Text = result.ToString();
        }
        
    }
}
