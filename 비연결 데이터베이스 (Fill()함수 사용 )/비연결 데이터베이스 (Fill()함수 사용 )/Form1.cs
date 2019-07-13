using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace 비연결_데이터베이스__Fill__함수_사용__
{
    public partial class Form1 : Form
    {
        SqlConnection Conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter DataAdapter1 = new SqlDataAdapter("SELECT * FROM tblStudent", Conn);
            DataSet dataSet1 = new DataSet();
            DataAdapter1.Fill(dataSet1, "tblStudent");
            dataGridView1.DataSource = dataSet1.Tables[0];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conn = new SqlConnection();
            Conn.ConnectionString = "server = .\\SQLEXPRESS; database = school; uid = test; pwd = 1234";

        }
    }
}
