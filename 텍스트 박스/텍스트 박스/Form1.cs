using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 텍스트_박스
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CLang = Convert.ToInt32(textBox1.Text);
            int CPlus = Convert.ToInt32(textBox2.Text);
            int CShap = Convert.ToInt32(textBox3.Text);

            float Average = (CLang + CPlus + CShap) / 3.0f;
            string Result = Average.ToString("f2"); //소수점 2째자리
            MessageBox.Show(Result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Clear(); // 같은 결과
        }
    }
}
