using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 폼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form Load Event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?",
                "종료", MessageBoxButtons.YesNo) == DialogResult.No)
                e.Cancel = true;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //Control control = (Control)sender;
            //control.Width = 500;
            //control.Height = 500;
            Width = 500;
            Height = 500;
        }
    }
}
