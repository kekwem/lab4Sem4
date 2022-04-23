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

        private void Lambda1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(zmienna1.Text);
            double n = Convert.ToDouble(zmienna2.Text);
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
            textBox.Text = potega(x, n).ToString();
        }

        private void Lambda2_Click(object sender, EventArgs e)
        {
            string str = zmienna1.Text;
            double n = Convert.ToDouble(zmienna2.Text);
            Func<string, double, string> napis = (a, b) =>
            {
                string result = "";
                for (int i = 0; i < b; i++)
                {
                    result += a;
                }
                return result;
            };
            textBox.Text = napis(str, n);
        }

        public Func<double, double, double> potega2()
        {
            return (a, b) => Math.Pow(a, b);
        }

        private void Lambda3_Click(object sender, EventArgs e)
        {
            Func<double, double, double> funk = potega2();
            textBox.Text = funk(Double.Parse(zmienna1.Text), Double.Parse(zmienna2.Text)).ToString();
        }

        delegate bool Dzialanie(double a, double b);
        
        private void Lambda4_Click(object sender, EventArgs e)
        {
            Dzialanie dz;
            if (checkBox.Checked)
            {
                dz = (a, b) =>
                {
                    if (a > b)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }
            else
            {
                dz = (a, b) =>
                {
                    if (a < b)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                };
            }

            Func<double[], Dzialanie, double[]> sortowanie = (input, porow) =>
            {
                for (int i = 0; i < input.Length; i++)
                {
                    for (int j = 0; j < input.Length - i - 1; j++)
                    {
                        if (!porow(input[j], input[j + 1]))
                        {
                            double temp = input[j];
                            input[j] = input[j + 1];
                            input[j + 1] = temp;
                        }
                    }
                }
                return input;
            };

            string[] tablica_str = textBox.Text.Split(' ');
            tablica_str[0].zwCo2();
            double[] tablica = new double[tablica_str.Length];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Convert.ToDouble(tablica_str[i]);
            }

            tablica = sortowanie(tablica, dz);
            textBox.Text = "";
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                textBox.Text += tablica[i] + " ";
            }
            textBox.Text += tablica[tablica.Length - 1];
        }

        //

        private void metoda1_Click(object sender, EventArgs e)
        {
            string str = textBox.Text;
            textBox.Text = str.zwCo2();
        }

        private void metoda2_Click(object sender, EventArgs e)
        {
            string str = textBox.Text;
            textBox.Text = str.usunSamog();
        }

        private void metoda3_Click(object sender, EventArgs e)
        {
            string str = textBox.Text;
            int[] tablica = str.dlugosciWyrazow();
            textBox.Text = "";
            for (int i = 0; i < tablica.Length; i++)
            {
                textBox.Text += " " + tablica[i];
            }
        }

        private void metoda4_Click(object sender, EventArgs e)
        {
            string str = textBox.Text;
            textBox.Text = str.czyZdanie().ToString();
        }

        private void metoda5_Click(object sender, EventArgs e)
        {
            string[] str = textBox.Text.Split(' ');
            textBox.Text = str.najwiec();
        }
    }
}
