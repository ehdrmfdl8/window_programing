using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace 색상설정
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //파란색의 ARGB확인
            string str = "Alpha: " + Color.Blue.A + " Red: " + Color.Blue.R +
                " Green: " + Color.Blue.G + " Blue: " + Color.Blue.B;
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 10);
            //펜 색상
            Color myColor = Color.FromArgb(255, 0, 0);
            Pen newPen = new Pen(myColor);
            newPen.Width = 5.0f;           
            e.Graphics.DrawLine(newPen, 10, 30, 100, 30);
            e.Graphics.DrawLine(Pens.Blue, 10, 40, 100, 40);
            newPen.Dispose();
            //펜 스타일
            Pen myPen = new Pen(Color.Black, 3.0f);
            myPen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(myPen, 10, 50, 100, 50);
            myPen.DashStyle = DashStyle.DashDot;
            e.Graphics.DrawLine(myPen, 10, 60, 100, 60);
            //채우기 색
            SolidBrush myBrush = new SolidBrush(Color.Blue);
            e.Graphics.FillEllipse(myBrush, 35, 70, 100, 100);
            myBrush.Dispose();
            //HatchBrush 패턴 브러시
            HatchBrush Hash = new HatchBrush(HatchStyle.Plaid,
                Color.Red, Color.Blue);
            e.Graphics.FillRectangle(Hash, 35, 200, 100, 100);
        }
    }
}
