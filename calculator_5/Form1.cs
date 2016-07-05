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

        private void button_Click(object sender, EventArgs e)
        {

            double firstValue = double.Parse(textBox1.Text);
            double secondValue = double.Parse(textBox2.Text);
            double result ;
            ITwoArgumentCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button) sender).Name);
            result = calculator.Calculate(firstValue, secondValue);
            textBox3.Text = result.ToString();
        }
        
    }
}
