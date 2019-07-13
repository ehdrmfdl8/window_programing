using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 더블버퍼링
{
    public partial class Form1 : Form
    {
        BufferedGraphicsContext context;
        BufferedGraphics graphics;
        Image myImage;

        public Form1()
        {
            InitializeComponent();

            context = BufferedGraphicsManager.Current; //static 선언
            context.MaximumBuffer = new Size(800, 600); //버퍼크기 설정
            graphics = context.Allocate(CreateGraphics(), 
                new Rectangle(0, 0, 800, 600));//버퍼 그래픽스 객체생성 및 참조
            graphics.Graphics.Clear(Color.Yellow); //버퍼 지우기
            myImage = Image.FromFile("photo.jpg");
            SetClientSizeCore(800, 600);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //더블 버퍼에 출력
            Random rand = new Random();
            for (int i=0; i<100; i++)
            {
                graphics.Graphics.DrawImage(myImage, rand.Next(0, 700),
                    rand.Next(0, 500));
            }

            //화면에 출력
            graphics.Render(e.Graphics);
        }
    }
}
