using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace El_calculator
{
    public partial class Form1 : Form
    {
        double obshto = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void изходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Общо : "+(obshto/2).ToString(),"Обща сума за плащане");

            Application.Exit();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void новКлиентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cl_number = Int32.Parse(label5.Text);
            cl_number++;
            label5.Text = cl_number.ToString();
            textBox1.Clear();
            textBox2.Clear();
            label6.ResetText();
            label8.ResetText();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox2.Text)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                int isNumber = 0;
                if (!int.TryParse(textBox1.Text, out isNumber) && !int.TryParse(textBox1.Text, out isNumber))
                {
                    MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО ЗА ПОТРЕБЛЕНИЕТО ! ");
                }
                else
                {
                    double novo = Double.Parse(textBox1.Text);
                    double staro = Double.Parse(textBox2.Text);
                    label6.Text = (staro - novo).ToString();
                    double button = 0;
                    if (radioButton1.Checked)
                    {
                        button = 0.34;
                    }else if (radioButton2.Checked)
                    {
                        button = 0.44;
                    }
                    else if (radioButton3.Checked)
                    {
                        button = 0.54;
                    }


                  label8.Text = ((staro - novo)*(button)).ToString();
                    obshto += (staro - novo) * (button); 
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox2.Text)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                int isNumber = 0;
                if (!int.TryParse(textBox1.Text, out isNumber) && !int.TryParse(textBox1.Text, out isNumber))
                {
                    MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО ЗА ПОТРЕБЛЕНИЕТО ! ");
                }
                else
                {
                    double novo = Double.Parse(textBox1.Text);
                    double staro = Double.Parse(textBox2.Text);
                    label6.Text = (staro - novo).ToString();
                    double button = 0;
                    if (radioButton1.Checked)
                    {
                        button = 0.34;
                    }
                    else if (radioButton2.Checked)
                    {
                        button = 0.44;
                    }
                    else if (radioButton3.Checked)
                    {
                        button = 0.54;
                    }
                    label8.Text = ((staro - novo) * (button)).ToString();
                    obshto += (staro - novo) * (button);
                }
            }

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox2.Text)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                int isNumber = 0;
                if (!int.TryParse(textBox1.Text, out isNumber) && !int.TryParse(textBox1.Text, out isNumber))
                {
                    MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО ЗА ПОТРЕБЛЕНИЕТО ! ");
                }
                else
                {
                    double novo = Double.Parse(textBox1.Text);
                    double staro = Double.Parse(textBox2.Text);
                    label6.Text = (staro - novo).ToString();
                    double button = 0;
                    if (radioButton1.Checked)
                    {
                        button = 0.34;
                    }
                    else if (radioButton2.Checked)
                    {
                        button = 0.44;
                    }
                    else if (radioButton3.Checked)
                    {
                        button = 0.54;
                    }
                    label8.Text = ((staro - novo) * (button)).ToString();
                    obshto += (staro - novo) * (button);
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox2.Text)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                int isNumber = 0;
                if (!int.TryParse(textBox1.Text, out isNumber) && !int.TryParse(textBox1.Text, out isNumber))
                {
                    MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО ЗА ПОТРЕБЛЕНИЕТО ! ");
                }
                else
                {
                    double novo = Double.Parse(textBox1.Text);
                    double staro = Double.Parse(textBox2.Text);
                    label6.Text = (staro - novo).ToString();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(string.IsNullOrWhiteSpace(textBox2.Text)) && !(string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                int isNumber = 0;
                if (!int.TryParse(textBox1.Text, out isNumber) && !int.TryParse(textBox1.Text, out isNumber))
                {
                    MessageBox.Show("МОЛЯ ВЪВЕДЕТЕ ЧИСЛО ЗА ПОТРЕБЛЕНИЕТО ! ");
                }
                else
                {
                    double novo = Double.Parse(textBox1.Text);
                    double staro = Double.Parse(textBox2.Text);
                    label6.Text = (staro - novo).ToString();
                }
            }
        }
    }
}
