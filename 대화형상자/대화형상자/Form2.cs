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
    public partial class Form2 : Form
    {
        public int x, y;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = int.Parse(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text); //int.Parse와 같은 역할

            Close(); // Wm_Close 발생 -> Dlg.ShowDialog()로 이동
        }
    }
}
