using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 업다운컨트롤_Domain_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            domainUpDown1.SelectedIndex = 0;
            textBox1.Text = domainUpDown1.Text;
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            textBox1.Text = domainUpDown1.Text;
        }
    }
}
