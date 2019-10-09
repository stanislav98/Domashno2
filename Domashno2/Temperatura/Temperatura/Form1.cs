using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                double x = Double.Parse(textBox1.Text);
                if (comboBox1.Text == "C")
                {
                    double f = (x * 9) / 5 + 32;
                    textBox2.Text = f.ToString();
                }
                else if (comboBox1.Text == "F")
                {
                    double c = (x - 32) * 5 / 9;
                    textBox2.Text = c.ToString();
                }
            }
            catch
            {
                MessageBox.Show("CHECK YOUR INPUT.","ERROR", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            }
        }
    }
}
