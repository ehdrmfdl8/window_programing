using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 비연결_데이터베이스_DataGridView_
{
    public partial class Form1 : Form
    {
        DataTable table1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1단계 DataTalbe과 DataColumn 만들기
            table1 = new DataTable("table1");
            DataColumn Col1 = new DataColumn("Name", typeof(string));
            table1.Columns.Add(Col1);
            Col1 = new DataColumn("Age", typeof(int));
            table1.Columns.Add(Col1);
            Col1 = new DataColumn("Male", typeof(bool));
            table1.Columns.Add(Col1);

            //2단계 행 생성 및 입력
            DataRow row = table1.NewRow();
            row["Name"] = "철수";
            row["Age"] = 12;
            row["Male"] = true;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "다은";
            row["Age"] = 11;
            row["Male"] = false;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "은성";
            row["Age"] = 9;
            row["Male"] = true;
            table1.Rows.Add(row);
            dataGridView1.DataSource = table1;
            dataGridView1.MultiSelect = false; // 한 행만 선택 속성에서 변경가능
        }

        // 입력 OR 추가
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow row = table1.NewRow();
            row["Name"] = textBox1.Text;
            row["Age"] = int.Parse(textBox2.Text);
            if (radioButton1.Checked)
                row["Male"] = true;
            else
                row["Male"] = false;
            table1.Rows.Add(row);
        }

        //삭제 2가지 방법
        private void button2_Click(object sender, EventArgs e)
        {
            //선택한 행 가져오기
            DataGridViewSelectedRowCollection Rows = dataGridView1.SelectedRows;
            int SelectedRowIndex = Rows[0].Index;
            DataRow Row = table1.Rows[SelectedRowIndex];
            Row.Delete();
            table1.AcceptChanges();

            //dataGridView 에서 선택한 행 가져오기
            //DataGridViewRow row = dataGridView1.SelectedRows[0];
            //dataGridView1.Rows.Remove(row);
            ////다수가 선택된 경우 처리
            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //        dataGridView1.Rows.Remove(row);
            //}

        }
        //수정 부분
        private void button3_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection Rows = dataGridView1.SelectedRows;
            int SelectedRowIndex = Rows[0].Index;
            DataRow Row = table1.Rows[SelectedRowIndex];
            Row["Name"] = textBox1.Text;
            Row["Age"] = int.Parse(textBox2.Text);
            if (radioButton1.Checked)
                Row["Male"] = true;
            else
                Row["Male"] = false;
        }
    }
}
