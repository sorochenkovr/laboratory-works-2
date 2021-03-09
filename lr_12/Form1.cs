using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            tB1.Text = (e.X).ToString();
            tB2.Text = (e.Y).ToString();

            double az = e.Location.X, g = e.Location.Y;
            double q = 10, t;
            tB4.Text = (q).ToString();
            if ((Math.Sqrt(Math.Pow(g,3)) == 0) | (az == 0))
                { 
                tB3.Text = ("DivisionByZero").ToString();
                Text = string.Format("Error");
            } 
            else 
            {
                t = az / Math.Sqrt(Math.Pow(g, 3)) + Math.Cos(g * q) / az - g + Math.Abs(Math.Sin(q) + Math.Sqrt(Math.Abs(12 - q)));
                tB3.Text = (t).ToString();
                Text = string.Format("Результат: {0:0.000}", t);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
