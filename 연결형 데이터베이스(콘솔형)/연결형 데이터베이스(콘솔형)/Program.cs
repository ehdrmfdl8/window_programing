using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace 연결형_데이터베이스_콘솔형_
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "server=.\\SQLEXPRESS;database=school;uid = test;password=1234;";
            Conn.Open();
        
            SqlCommand Command = new SqlCommand("SELECT * FROM tblStudent", Conn);
            SqlDataReader Reader = Command.ExecuteReader();
            //메서드 ExcuteReader : CommandText의 SQL문을 Connection에 보내고 SqlDataReader를 생성
            //SqlDataReader 역할: 데이터 베이스에서 전용행 스트림으로 읽는 역할
            while(Reader.Read())
            {
                Console.WriteLine("{0} {1} {2}", Reader["Name"], Reader[1], Reader["Male"]);
            }
            Reader.Close();
            Conn.Close();
        }
    }
}
