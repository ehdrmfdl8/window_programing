using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비트맵
{

    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(400, 300);
            SetClientSizeCore(400, 300);
        }
        //로딩한 이미지와 폼의 크기가 같도록 출력
        private void Form1_Paint(object sender, PaintEventArgs e)
        {   //메모리에서 그려지는 부분
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.Yellow);
            for(int i = 0;i<10;i++)
            {
                bitmapGraphics.DrawString("C# Programming", Font, Brushes.Black, 10, 10 *2*i);
                bitmapGraphics.DrawRectangle(Pens.Black, 100, 10, 200, 100);
            }

            //폼에 출력
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
