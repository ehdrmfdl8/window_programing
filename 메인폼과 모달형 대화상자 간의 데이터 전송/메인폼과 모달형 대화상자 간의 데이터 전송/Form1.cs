using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 메인폼과_모달형_대화상자_간의_데이터_전송
{
    
    public partial class Form1 : Form
    {
        public string message;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Dlg = new Form2();
            Dlg.Owner = this;
            message = textBox1.Text;
            Dlg.ShowDialog();
            Dlg.Dispose();

        }
    }
}
