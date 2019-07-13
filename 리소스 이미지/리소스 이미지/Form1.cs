using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리소스_이미지
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetClientSizeCore(Properties.Resources.test1.Width,
                Properties.Resources.test1.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = Properties.Resources.test1;
            e.Graphics.DrawImage(bitmap, 0, 0);
            bitmap = Properties.Resources.photo;
            e.Graphics.DrawImage(bitmap, 20, 20);
        }
    }
}
