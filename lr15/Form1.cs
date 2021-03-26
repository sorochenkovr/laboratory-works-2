using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.FullOpen = true;
            cd.ShowHelp = true;
            cd.Color = panelColor.BackColor;
            if(cd.ShowDialog() == DialogResult.OK)
            {
                panelColor.BackColor = cd.Color;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowHelp = true;
            fd.Font = textBoxFont.Font;
            if(fd.ShowDialog() == DialogResult.OK)
            {
                textBoxFont.Font = fd.Font;
                textBoxFont.ForeColor = fd.Color;
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "choose a folder for dialog work demonstration";
            fbd.ShowNewFolderButton = true;
            fbd.SelectedPath = Application.StartupPath;
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = fbd.SelectedPath;
            }
        }

        private void buttonFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.InitialDirectory = Application.StartupPath;
            d.Filter = "txt files (*.txt)|*.txt|" +
                "My files ()|*.xxx|" + "Build (*.exe)|*.exe";
            d.FilterIndex = 3;
            d.Title = "Choosine file";
            if (d.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = d.FileName;
            }
        }

        private void buttonMath_Click(object sender, EventArgs e)
        {
            int N = 0;
            double U = 1;
            double X = Convert.ToDouble(textMath1.Text);
            double Y = Convert.ToDouble(textMath2.Text);
            string result = Microsoft.VisualBasic.Interaction.InputBox("Введите N:");
            if (result == "")
                result = "0";
            N = Convert.ToInt32(result);       

            int m = 1;
            for (int i = 1; i < N; i++)
            {
                if (i % 2 != 0)
                {
                    U -= (Math.Pow(Math.Sin(X), i + 1) * Math.Pow(Y, m)) / i + 1;
                }
                else
                { 
                    U += (Math.Pow(Math.Sin(X), i + 1) * Math.Pow(Y, m)) / i + 1; 
                }
                m = i + 2;
            }
            Math.Round(U, 3);
            textMath3.Text = U.ToString();
            MessageBox.Show(Convert.ToString(U));
        }

        private void textMath1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //калькулятор
            {
                e.Handled = true;
            }
        }

        private void textMath2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61) //калькулятор
            {
                e.Handled = true;
            }
        }
    }
}
