using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr_1_4
{
    public partial class Form1 : Form
    {
        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBoxA.SelectedIndex = 0;
            toolStripComboBoxB.SelectedIndex = 0;
        }
        public enum DateTimeFormat
        {
            ShowTime,
            ShowDate
        }
        DateTimeFormat dtFormat = DateTimeFormat.ShowTime;
        ToolStripMenuItem currentCheckedItem;
        public Form1()
        {
            InitializeComponent();
            Text = "Пример строки состояния";
            CenterToScreen();
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }
        private void timerDateTimeUpdate_Tick(object sender, EventArgs e)
        {
            string info = "";
            if (dtFormat == DateTimeFormat.ShowTime)
                info = DateTime.Now.ToLongTimeString();
            else
                info = DateTime.Now.ToLongDateString();
            toolStripStatusLabelClock.Text = info;
        }
        private void toolStripMenuItemDate_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowDate;
            currentCheckedItem = toolStripMenuItemDate;
            currentCheckedItem.Checked = true;
        }
        private void toolStripMenuItemTime_Click(object sender, EventArgs e)
        {
            currentCheckedItem.Checked = false;
            dtFormat = DateTimeFormat.ShowTime;
            currentCheckedItem = toolStripMenuItemTime;
            currentCheckedItem.Checked = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabelState.Text = (e.X, e.Y).ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double R = 0;
            double X = Convert.ToDouble(toolStripTextBoxX.Text);
            double Y = Convert.ToDouble(toolStripTextBoxY.Text);
            double Z = Convert.ToDouble(toolStripTextBoxZ.Text);
            int A = Convert.ToInt32(toolStripComboBoxA.Text);
            int B = Convert.ToInt32(toolStripComboBoxB.Text);

            if (Math.Log10(Z) != 0 || Math.Cos(Y) != 0)
            {
                R = A * X + (B * Y / Math.Log10(Z)) + (Math.Sin(Z) / Math.Cos(Y));
                Text = Convert.ToString(R);
            }
            else
            {
                MessageBox.Show("Divide by 0");
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(MousePosition, ToolStripDropDownDirection.Right);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            double RR = 0;
            double XX = Convert.ToDouble(toolStripTextBoxXX.Text);
            double YY = Convert.ToDouble(toolStripTextBoxYY.Text);
            double ZZ = Convert.ToDouble(toolStripTextBoxZZ.Text);
            int AA = Convert.ToInt32(toolStripComboBoxAA.Text);
            int BB = Convert.ToInt32(toolStripComboBoxBB.Text);

            if (Math.Log10(ZZ) != 0 || Math.Cos(YY) != 0)
            {
                RR = AA * XX + (BB * YY / Math.Log10(ZZ)) + (Math.Sin(ZZ) / Math.Cos(YY));
                Text = Convert.ToString(RR);
            }
            else
            {
                MessageBox.Show("Divide by 0");
            }
        }
        private void toolSMItem1_CheckedChanged(object sender, EventArgs e)
        {
            var c = (ToolStripMenuItem)sender;
            if (c == toolSMItem1)
            {
                toolSMItem2.Checked = false;
                toolSMItem3.Checked = false;
            }
            if (c == toolSMItem2)
            {
                toolSMItem1.Checked = false;
                toolSMItem3.Checked = false;
            }
            if (c == toolSMItem3)
            {
                toolSMItem2.Checked = false;
                toolSMItem1.Checked = false;
            }
        }
        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            double x = e.Location.X, y = e.Location.Y, f;
            if (toolSMItem1.Checked == true)
            {
                if (Math.Abs(y-Math.Pow(x,2)) != 0)
                {
                    f = x / (Math.Abs(y - Math.Pow(x, 2)));
                    toolStripStatusLabel1.Text = $"The answer is: {f}";
                }
            }
            else if (toolSMItem2.Checked == true)
            {
                f = Math.Sqrt(Math.Abs(x - Math.Sqrt(y)));
                toolStripStatusLabel1.Text = $"The answer is: {f}";
            }
            else
            {
                f = Math.Cos(x) + Math.Sin(y);
                toolStripStatusLabel1.Text = $"The answer is: {f}";
            }

        }
    }
}
