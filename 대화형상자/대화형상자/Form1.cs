using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 대화형상자
{
    public partial class Form1 : Form
    {
        int Sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Dlg = new Form2();
            Dlg.ShowDialog();

            Sum = Dlg.x + Dlg.y;
            Dlg.Dispose(); //Dlg의 메모리를 해제
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString("계산된 결과는 " + Sum.ToString() + "입니다.",
                Font, Brushes.Black, 10, 30);
        }
    }
}
