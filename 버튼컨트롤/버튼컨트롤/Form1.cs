using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 버튼컨트롤
{
    public partial class Form1 : Form
    {
        RadioButton SelectedRadio;

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string strResult = "체크 1: " + checkBox1.CheckState +
                "체크 2: " + checkBox2.CheckState +
                "체크 3: " + checkBox3.CheckState;
            MessageBox.Show(strResult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                MessageBox.Show("radio 1 선택");
            else if (radioButton2.Checked)
                MessageBox.Show("radio 2 선택");
            if (radioButton3.Checked)
                MessageBox.Show("radio 3 선택");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (SelectedRadio == radioButton4)
                MessageBox.Show("radio 4 선택");
            else if(SelectedRadio == radioButton5)
                MessageBox.Show("radio 5 선택");
            if(SelectedRadio == radioButton6)
                MessageBox.Show("radio 6 선택");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender; //언 박싱
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            SelectedRadio = (RadioButton)sender;
        }
    }
}
