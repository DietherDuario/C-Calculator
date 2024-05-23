using System.Windows.Forms;
using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(first_number_tb.Text);
            double second_number = Convert.ToDouble(second_number_tb.Text);

            double result = first_number + second_number;
            result_label.Text = "Result: " + result.ToString();
        }

        private void subtract_button_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(first_number_tb.Text);
            double second_number = Convert.ToDouble(second_number_tb.Text);

            double result = first_number - second_number;
            result_label.Text = "Result: " + result.ToString();
        }

        private void multiply_button_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(first_number_tb.Text);
            double second_number = Convert.ToDouble(second_number_tb.Text);

            double result = first_number * second_number;
            result_label.Text = "Result: " + result.ToString();
        }

        private void divide_button_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(first_number_tb.Text);
            double second_number = Convert.ToDouble(second_number_tb.Text);

            double result = first_number / second_number;
            result_label.Text = "Result: " + result.ToString();
        }

        private void modulus_button_Click(object sender, EventArgs e)
        {
            double first_number = Convert.ToDouble(first_number_tb.Text);
            double second_number = Convert.ToDouble(second_number_tb.Text);

            double result = first_number % second_number;
            result_label.Text = "Result: " + result.ToString();
        }
    }
}