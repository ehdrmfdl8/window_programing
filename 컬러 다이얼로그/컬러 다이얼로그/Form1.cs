using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 컬러_다이얼로그
{
    public partial class Form1 : Form
    {
        int Red, Green, Blue;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            string str = "Red : " + Red + " Green: " + Green + " Blue: " + Blue;
            e.Graphics.DrawString(str, Font, Brushes.Black, 10, 20);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Color Color1 = colorDialog1.Color;
                Red = Color1.R;
                Green = Color1.G;
                Blue = Color1.B;
                Invalidate();
            }
        }
    }
}
