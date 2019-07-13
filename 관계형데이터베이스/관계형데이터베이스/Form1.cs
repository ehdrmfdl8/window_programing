using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 관계형데이터베이스
{
    public partial class Form1 : Form
    {
        DataSet DataSet1;
        DataRelation Relation1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet1 = new DataSet("Info");
            DataSet1.Tables.Add(new DataTable("Table1"));
            DataSet1.Tables.Add(new DataTable("Table2"));

            //테이블1
            DataColumn Col;
            Col = new DataColumn("id", typeof(string));
            Col.MaxLength = 10;
            Col.Unique = true;
            DataSet1.Tables[0].Columns.Add(Col);
            DataSet1.Tables[0].PrimaryKey = new DataColumn[] { Col };

            Col = new DataColumn("pwd", typeof(string));
            Col.MaxLength = 8;
            DataSet1.Tables[0].Columns.Add(Col);
            Col = new DataColumn("name", typeof(string));
            Col.MaxLength = 15;
            DataSet1.Tables[0].Columns.Add(Col);

            DataRow Row;
            Row = DataSet1.Tables[0].NewRow();
            Row["id"] = "12345";
            Row["pwd"] = "12345";
            Row["name"] = "대한";
            DataSet1.Tables[0].Rows.Add(Row);

            Row = DataSet1.Tables[0].NewRow();
            Row["id"] = "22222";
            Row["pwd"] = "12345";
            Row["name"] = "민국";
            DataSet1.Tables[0].Rows.Add(Row);

            //테이블2
            Col = new DataColumn("id", typeof(string));
            Col.MaxLength = 10;
            DataSet1.Tables[1].Columns.Add(Col);
            ForeignKeyConstraint FK = new ForeignKeyConstraint("FK", DataSet1.Tables[0].Columns["id"],DataSet1.Tables[1].Columns["id"]);
            DataSet1.Tables[1].Constraints.Add(FK);

            Col = new DataColumn("fruit_name", typeof(string));
            Col.MaxLength = 20;
            DataSet1.Tables[1].Columns.Add(Col);

            Row = DataSet1.Tables[1].NewRow();
            Row["id"] = "22222";
            Row["fruit_name"] = "수박";
            DataSet1.Tables[1].Rows.Add(Row);

            Row = DataSet1.Tables[1].NewRow();
            Row["id"] = "12345";
            Row["fruit_name"] = "딸기";
            DataSet1.Tables[1].Rows.Add(Row);

            Row = DataSet1.Tables[1].NewRow();
            Row["id"] = "12345";
            Row["fruit_name"] = "메론";
            DataSet1.Tables[1].Rows.Add(Row);

            //객체를 통한 관계 설정
            Relation1 = new DataRelation("Test", DataSet1.Tables[0].Columns["id"],
                DataSet1.Tables[1].Columns["id"]);
            DataSet1.Relations.Add(Relation1);
            dataGridView1.DataSource = DataSet1.Tables[0];
            dataGridView2.DataSource = DataSet1.Tables[1];
        }

        //과일 보기
        private void button1_Click(object sender, EventArgs e)
        {
            string id = (string)dataGridView1.CurrentRow.Cells[0].Value;
            //Parent에서 먼저 찾아준다.
            DataRow[] people = DataSet1.Tables[0].Select("id = '" + id + "'");
            //찾은 부모클래스의 자식클래스의 열을 찾는다.
            DataRow[] Item = people[0].GetChildRows("Test");
            string Fruit;
            if(Item.Length >0)
            {
                foreach(DataRow row in Item)
                {
                    Fruit = row["fruit_name"].ToString();
                    MessageBox.Show(Fruit);
                }
            }
        }
        //이름 보기
        private void button2_Click(object sender, EventArgs e)
        {
            string id = (string)dataGridView2.CurrentRow.Cells[0].Value;
            DataRow[] people = DataSet1.Tables[1].Select("id = '" + id + "'");
            DataRow Item = people[0].GetParentRow("Test");
            MessageBox.Show(Item["name"].ToString());
        }
    }
}
