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
            switch (((Button)sender).Name)
            {
                case "button_plus":
                    result = firstValue + secondValue;
                    break;
                case "button_division":
                    result = firstValue - secondValue;
                    break;
                case "button_multiplication":
                    result = firstValue*secondValue;
                    break;
                case "button_substraction":
                    result = firstValue/secondValue;
                    break;
                default:
                    throw new Exception("Неизвестная операция");
            }
            textBox3.Text = result.ToString();
        }
        
    }
}
