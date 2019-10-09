using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Rectangle rect = new Rectangle();
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            rect.x = Double.Parse(hScrollBar1.Value.ToString());
            label1.Text ="WIDTH : " + rect.x.ToString();
            if (vScrollBar1.Value > 0 || hScrollBar1.Value > 0)
            {
                label3.Text=(rect.Calc(rect.x, rect.y)).ToString();
            }

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            rect.y = Double.Parse(vScrollBar1.Value.ToString());
            label2.Text ="HEIGHT : " + rect.y.ToString();
            if (vScrollBar1.Value > 0 || hScrollBar1.Value > 0)
            {
                label3.Text = (rect.Calc(rect.x, rect.y)).ToString();
            }
        }
    }
}
