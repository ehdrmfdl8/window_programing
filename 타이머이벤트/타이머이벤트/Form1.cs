using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 타이머이벤트
{
    public partial class Form1 : Form
    {
        Rectangle[] rectangle;

        public Form1()
        {
            InitializeComponent();
            rectangle = new Rectangle[100];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            for(int i = 0; i <100; i++)
            {
                rectangle[i].X = random.Next(200);
                rectangle[i].Y = random.Next(200);
                rectangle[i].Width = 60;
                rectangle[i].Height = 60;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i = 0; i< 100; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, rectangle[i]);
            }
        }
    }
}
