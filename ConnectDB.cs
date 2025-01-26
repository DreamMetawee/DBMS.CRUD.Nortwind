using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBMS.CRUD.Nortwind
{
    internal class ConnectDB
    {
        public static SqlConnection ConnectNorthwind()
        {
            string server = @".\sqlexpress"; // ชื่อ server มาจาก SqlServer
            string db = "northwind";    // ชื่อฐานข้อมูล

            //คำสั่งเชื่อมต่อ Connection String
            string strCon = string.Format(@"Data Source={0};Initial Catalog={1};"
                            + "Integrated Security=True;Encrypt=False", server, db);
            //ประกาศตัวแปรคลาสเชื่อมต่อ
            SqlConnection conn = new SqlConnection(strCon);
            //เปิดการเชื่อมต่อกับฐานข้อมูล
            conn.Open();
            return conn;
        }
    }
}
