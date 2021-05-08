using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace lr_17
{
    public partial class Form1 : Form
    {
        Region regResult = new Region();
        Region regResult2 = new Region();
        Brush active = Brushes.Red;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var gr = e.Graphics;
            Rectangle rect = new Rectangle(280, 70, 120, 130);
            Rectangle circle = new Rectangle(150, 70, 250, 250);
            Rectangle circle2 = new Rectangle(183, 100, 185, 185);
            Rectangle circle3 = new Rectangle(160, 200, 120, 130);

            Pen pen = new Pen((Color.Black),3);
            pen.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen, 120, 200, 430, 200);
            Pen pen2 = new Pen((Color.Black), 3);
            pen2.EndCap = LineCap.ArrowAnchor;
            e.Graphics.DrawLine(pen2, 280, 340, 280, 40);
            Pen pen3 = new Pen((Color.Black), 3);
            e.Graphics.DrawLine(pen3, 170, 310, 420, 50);

            GraphicsPath gpRect = new GraphicsPath();
            gpRect.AddRectangle(rect);
            GraphicsPath gpEllip = new GraphicsPath();
            gpEllip.AddEllipse(circle);
            GraphicsPath gpEllip2 = new GraphicsPath();
            gpEllip2.AddEllipse(circle2);
            GraphicsPath gpEllip3 = new GraphicsPath();
            gpEllip3.AddEllipse(circle3);
            GraphicsPath gpSector = new GraphicsPath();
            gpSector.AddPie(circle, -270, 42);

            Region regRect = new Region(gpRect);
            Region regEllip = new Region(gpEllip);
            
            regResult = new Region(gpRect);
            regResult.Intersect(regEllip);
            regResult.Exclude(gpEllip2);
            regResult2 = new Region(gpSector);
            regResult2.Intersect(gpEllip3);
            regResult2.Exclude(gpEllip2);

            gr.DrawRectangle(Pens.Red, rect);
            gr.DrawEllipse(Pens.Green, circle);
            gr.DrawEllipse(Pens.Green, circle2);
            gr.DrawEllipse(Pens.Red, circle3);

            gr.FillRegion(active, regResult);
            gr.FillRegion(active, regResult2);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X, Y = e.Y;
            Brush one = active;
            if (regResult.IsVisible(X, Y))
            {
                active = Brushes.Red;
            }
            else active = Brushes.Green;
            Invalidate();

            Text = string.Format("Коорд: {0},{1}", e.X, e.Y);
            
        }
    }
}
