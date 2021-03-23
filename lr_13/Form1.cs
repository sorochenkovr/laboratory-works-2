using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            listBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Z = 0;
            double X = Convert.ToDouble(tB1.Text);
            double P = Convert.ToDouble(tB2.Text);
            int N = Convert.ToInt32(tB3.Text);
            double a = Convert.ToDouble(comboBox1.SelectedItem.ToString());
            double b = Convert.ToDouble(listBox1.SelectedItem.ToString());
        
            if (rB1.Checked)
            {
                try
                {
                    int f;
                    Z = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        f = i + 1;
                        if (i % 2 == 0)
                        {
                            f = f * i;
                            Z += Math.Pow(P, (i - 1)) + Math.Pow(X, i) / f;
                        }
                        else
                        {
                            f = f * i;
                            Z -= Math.Pow(P, (i - 1)) + Math.Pow(X, i) / f;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }
            }
            else
            {
                try
                {
                    for (int i = 1; i <= N; i++)
                    {
                        for (int j = 1; j <= N; j++)
                        {
                            Z += Math.Pow((a * i) + j, 2) / (Math.Pow(i, 3) + b * Math.Pow(j, 3)); ;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Что-то пошло не так");
                }

            }
            tB4.Text = Z.ToString();
        }

        private void tB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void tB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void tB3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }
    }
}
