using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace 비연결형_데이터베이스_콘솔_
{
    class Program
    {
        static void Main(string[] args)
        {
            //1단계 DataTalbe과 DataColumn 만들기
            DataTable table1 = new DataTable("table1");
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
            row["Name"] = "수지";
            row["Age"] = 11;
            row["Male"] = false;
            table1.Rows.Add(row);

            row = table1.NewRow();
            row["Name"] = "차돌";
            row["Age"] = 9;
            row["Male"] = true;
            table1.Rows.Add(row);
            table1.AcceptChanges(); //이부분은 굳이 안써도 됨..
            //테이블에 적용됬음을 알리는 함수

            foreach(DataRow PrintRow in table1.Rows)
            {
                string str;
                if (PrintRow["Male"].ToString() == "True")
                    str = "남자";
                else
                    str = "여자";

                Console.WriteLine("이름:{0} 나이:{1:d2} 성별:{2}", PrintRow["Name"], PrintRow[1], str);
            }

        }
    }
}
