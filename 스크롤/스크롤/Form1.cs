using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 스크롤
{
    public partial class Form1 : Form
    {
        Image myImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myImage = Image.FromFile("test.jpg");
            this.AutoScrollMinSize = myImage.Size; //스크롤바 출현
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(myImage, AutoScrollPosition.X, AutoScrollPosition.Y);
        }
    }
}
