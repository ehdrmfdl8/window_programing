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

namespace 연결형_데이터베이스_윈도우폼_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "server=.\\SQLEXPRESS;database=school;uid=test;password=1234;";
            Conn.Open();
            SqlCommand Comm = new SqlCommand(textBox1.Text, Conn);
            Comm.ExecuteNonQuery();
            Comm.CommandText = "SELECT * FROM tblStudent";
            SqlDataReader Reader = Comm.ExecuteReader();
            listView1.Clear();

            string strRecord;
            while(Reader.Read())
            {
                strRecord = string.Format("이름:{0} 나이:{1} 성별:{2}", Reader["Name"], Reader["Age"], Reader["Male"]);
                listView1.Items.Add(strRecord);
            }
            Reader.Close();
            Conn.Close();
        }
    }
}
