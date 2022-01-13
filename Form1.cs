using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Calculatorius : Form
    {
        public Calculatorius()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text +="1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "9";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "0";
        }
        private void Enter_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string output = dt.Compute(textBoxOutput.Text, "").ToString();
            textBoxOutput.Text = output;
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "+";
        }
        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "-";
        }
        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "*";
        }
        private void buttonDivide_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text += "/";
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "";
        }
    }
}
