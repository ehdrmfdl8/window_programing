using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 다중폼_MDI_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 폼1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 MdiChildForm1 = new Form2();
            MdiChildForm1.MdiParent = this;
            MdiChildForm1.Show();
        }

        private void 폼2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 MdiChildForm2 = new Form3();
            MdiChildForm2.MdiParent = this;
            MdiChildForm2.Show();
        }

        private void 폼3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 MdiChildForm3 = new Form4();
            MdiChildForm3.MdiParent = this;
            MdiChildForm3.Show();
        }

        private void 폼4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 MdiChildForm4 = new Form5();
            MdiChildForm4.MdiParent = this;
            MdiChildForm4.Show();
        }
    }
}
