using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double convert = Double.Parse(textBox2.Text);
            if (comboBox1.Text == "inch" && comboBox2.Text == "feet") {
                double result = convert * 0.8341;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "yard" && comboBox2.Text == "feet")
            {
                double result = convert * 3;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "mile" && comboBox2.Text == "feet")
            {
                double result = convert * 1760;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "feet" && comboBox2.Text == "feet")
            {
                double result = convert;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "inch" && comboBox2.Text == "yard")
            {
                double result = convert * 0.278;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "yard" && comboBox2.Text == "yard")
            {
                double result = convert;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "mile" && comboBox2.Text == "yard")
            {
                double result = convert * 1760;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "feet" && comboBox2.Text == "yard")
            {
                double result = convert * 0.3333;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "inch" && comboBox2.Text == "inch")
            {
                double result = convert;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "yard" && comboBox2.Text == "inch")
            {
                double result = convert * 3.5966;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "mile" && comboBox2.Text == "inch")
            {
                double result = convert * 6330;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "feet" && comboBox2.Text == "mile")
            {
                double result = convert * 1.1989;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "inch" && comboBox2.Text == "mile")
            {
                double result = convert * 0.0001579;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "yard" && comboBox2.Text == "mile")
            {
                double result = convert * 0.0005682;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "mile" && comboBox2.Text == "mile")
            {
                double result = convert;
                textBox1.Text = result.ToString();
            }
            else if (comboBox1.Text == "feet" && comboBox2.Text == "mile")
            {
                double result = convert * 0.0001893;
                textBox1.Text = result.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
