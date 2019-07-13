using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 키보드
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show("KeyDown");
            if(e.KeyCode == Keys.O && e.Shift && e.Control)//2순위 keyData와 동시 실행
            {
                MessageBox.Show("KeyCode+Shift+Control");
            }
            switch(e.KeyCode)
            {
                case Keys.A:
                    MessageBox.Show("A키");
                    break;
                case Keys.B:
                    MessageBox.Show("B키");
                    break;
                case Keys.C:
                    MessageBox.Show("C키");
                    break;
            }
            //if (e.Modifiers == (Keys.Shift | Keys.Control)) // 우선 실행
               //MessageBox.Show("Modifiers + Shift + Control");
            if (e.KeyCode == Keys.P && e.Modifiers == (Keys.Shift | Keys.Alt))
                MessageBox.Show("P + Shift + Alt");
            if (e.KeyData == (Keys.O | Keys.Shift | Keys.Control)) //2순위
                MessageBox.Show("A + Shift + Control");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("KeyPress");
        }
    }
}
