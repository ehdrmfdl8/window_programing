using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 마우스_드래그
{
    public partial class Form1 : Form
    {
        Rectangle rectMouse;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "Left: " + rectMouse.X +
                         "top: " + rectMouse.Y +
                         "Right: " + rectMouse.Right +
                         "bottom: " + rectMouse.Bottom;
            e.Graphics.DrawRectangle(Pens.Black, rectMouse);
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rectMouse.X = e.X;
            rectMouse.Y = e.Y;
            rectMouse.Width = 0;
            rectMouse.Height = 0;
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                rectMouse.Width = e.X - rectMouse.X + 1;
                rectMouse.Height = e.Y - rectMouse.Y + 1;
                Invalidate();
            }
        }
    }
}
