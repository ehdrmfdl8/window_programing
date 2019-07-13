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
    public partial class Form2 : Form
    {
        string Message;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 MainForm = (Form1)Owner;
            Message = MainForm.message;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(Message, Font, Brushes.Black, 10, 30);
        }
    }
}
