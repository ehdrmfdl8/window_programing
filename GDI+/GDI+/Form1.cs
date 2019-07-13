using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Form1 : Form
    {
        Point[] ptCircle;
        int nCount;

        public Form1()
        {
            InitializeComponent();

            ptCircle = new Point[100];
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i =0; i < nCount; i++)
            {
                e.Graphics.DrawEllipse(Pens.Black, ptCircle[i].X - 10,
                    ptCircle[i].Y - 10, 20, 20);
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ptCircle[nCount].X = e.X;
            ptCircle[nCount].Y = e.Y;

            Graphics g = CreateGraphics();
            g.DrawEllipse(Pens.Black, ptCircle[nCount].X - 10
                , ptCircle[nCount].Y - 10, 20, 20);
            nCount++;
            g.Dispose();
            //Invalidate();
        }
    }
}
