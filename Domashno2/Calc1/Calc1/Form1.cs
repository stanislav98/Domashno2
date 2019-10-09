using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);
            double descriminanta = (b * b) - 4 * a * c;

            if (descriminanta < 0)
            {
                this.Controls.Remove(label5);
                label4.Text="THERE IS NO SOLUTION";
            }
            else
            {
                double sqrt = Math.Sqrt(descriminanta);
                double x1 = (-b + sqrt) / (2 * a);
                double x2 = (-b - sqrt) / (2 * a);
                label4.Text = "x1 = " + x1;
                label5.Text = "x2 = " + x2;

            }
        }
    }
}
