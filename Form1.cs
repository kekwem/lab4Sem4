using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lambda_i_metody_rozszerzajace
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void potegaButton_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double n = Convert.ToDouble(textBox2.Text);
            Func<double, double, double> potega = (a, b) =>
            {
                double result = a;
                if (b == 0)
                {
                    return 1;
                }
                else
                {
                    for (int i = 1; i < b; i++)
                    {
                        result *= a;
                    }
                    return result;
                }
            };
            textBox3.Text = potega(x, n).ToString();
        }

        private void napisButton_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            double n = Convert.ToDouble(textBox2.Text);
            Func<string, double, string> napis = (a, b) =>
            {
                string result = "";
                for (int i = 0; i < b; i++)
                {
                    result += a;
                }
                return result;
            };
            textBox3.Text = napis(str, n);
        }
    }
}
