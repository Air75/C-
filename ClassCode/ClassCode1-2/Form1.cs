using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassCode1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = 0;
            if (x > 0) y = x + 10;
            else if (x == 0) y = 10;
            else y = x * 5;
            String d = Convert.ToString(y);
            lblShow.Text = d;
        }
    }
}
