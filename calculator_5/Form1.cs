using System;
using System.Windows.Forms;
using calculator_5.Array;
using calculator_5.OneArgument;
using calculator_5.TwoArgument;

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
            try
            {
                double firstValue = double.Parse(textBox1.Text);
                double secondValue = double.Parse(textBox2.Text);
                ITwoArgumentCalculator calculator = TwoArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstValue, secondValue);

                textBox3.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }

        private void one_button_Click(object sender, EventArgs e)
        {
            try
            {
                double firstValue = double.Parse(textBox1.Text);
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstValue);
                textBox3.Text = result.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            string[] stringArray = textBox1.Text.Split(' ');
            int[] intArray = new int[stringArray.Length];
            for (int i = 0; i < stringArray.Length; i++)
            {
                intArray[i] = int.Parse(stringArray[i]);
            }
            IArraySorting array = ArraySortingFactory.CreateSorter(((Button) sender).Name);
            int[] result = array.Sorting(intArray);
            for (int i = 0; i < stringArray.Length; i++)
            {
                textBox3.Text += result[i].ToString() + ' ';
            }
                }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка " + ex.Message);
            }
        }
    }
}
