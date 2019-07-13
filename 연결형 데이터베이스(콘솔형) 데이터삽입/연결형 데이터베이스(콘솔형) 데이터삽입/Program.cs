using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace 연결형_데이터베이스_콘솔형__데이터삽입
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "server=.\\SQLEXPRESS;database=school;uid = test;password=1234;";
            Conn.Open();
            //데이터 삽입하기 위한 문장
            string strSQL1 = "INSERT INTO tblStudent VALUES('이민우', 25, 1)";
            string strSQL2 = "INSERT INTO tblStudent VALUES('김지우', 40, 0)";


            SqlCommand Command = new SqlCommand(strSQL1, Conn);
            //ExecuteNoneQuery 사용: 삽입 실행
            Command.ExecuteNonQuery();
            Command.CommandText = strSQL2;
            Command.ExecuteNonQuery();

            Command.CommandText = "SELECT * FROM tblStudent";
            SqlDataReader Reader = Command.ExecuteReader();
            //메서드 ExcuteReader : CommandText의 SQL문을 Connection에 보내고 SqlDataReader를 생성
            //SqlDataReader 역할: 데이터 베이스에서 전용행 스트림으로 읽는 역할
            while (Reader.Read())
            {
                Console.WriteLine("{0} {1} {2}", Reader["Name"], Reader[1], Reader["Male"]);
            }
            Reader.Close();
            Conn.Close();
        }
    }
}
