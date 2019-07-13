using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 리스트뷰
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox1.Text);
            int CPlus = int.Parse(textBox2.Text);
            int CShap = int.Parse(textBox3.Text);
            int Total = CLanguage + CPlus + CShap;
            float Average = Total / 3.0f;
            listView1.Items.Add(new ListViewItem(new string[]
            {
                CLanguage.ToString(), CPlus.ToString(),CShap.ToString(),
                Total.ToString(), Average.ToString("f1") }));
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox1.Text);
            int CPlus = int.Parse(textBox2.Text);
            int CShap = int.Parse(textBox3.Text);
            int Total = CLanguage + CPlus + CShap;
            float Average = Total / 3.0f;

            listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
            listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
            listView1.SelectedItems[0].SubItems[2].Text = textBox3.Text;
            listView1.SelectedItems[0].SubItems[3].Text = Total.ToString();
            listView1.SelectedItems[0].SubItems[4].Text = Average.ToString("f1");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox3.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.RemoveAt(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int CLanguage = int.Parse(textBox1.Text);
            int CPlus = int.Parse(textBox2.Text);
            int CShap = int.Parse(textBox3.Text);
            int Total = CLanguage + CPlus + CShap;
            float Average = Total / 3.0f;

            int index = listView1.SelectedIndices[0];
            listView1.Items.Insert(index,new ListViewItem(
                new string[] { CLanguage.ToString(),CPlus.ToString(),
                CShap.ToString(),Total.ToString(),Average.ToString("f1")}));
        }
    }
}
