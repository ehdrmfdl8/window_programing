using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 모델리스형_대화상자
{
    public partial class Form1 : Form
    {
        Form2 Dlg = null; //아직까지 생성이 되지 않은..

        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Dlg == null) // 계속 떠있는 상태에서 작업을 하기때무에 존재하는지 유무 확인
            {
                Dlg = new Form2();
                Dlg.Show();
            }
        }
    }
}
