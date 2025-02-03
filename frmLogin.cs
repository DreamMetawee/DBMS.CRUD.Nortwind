using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS.CRUD.Nortwind
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;

        public string Login_status { get; set; } //เก็บค่าสถานะการเข้าสู่ระบบ pass/fail
        public int employeeID { get; set; } //เก็บค่ารหัสพนักงาน
        public string employeeName { get; set; } //เก็บค่าชื่อพนักงาน
        public string employeeTitle { get; set; } //เก็บค่าตำแหน่งพนักงาน

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "txtPassword.Text";
            string sql = "select EmployeeID, TitleOfCourtesy+FirstName+' '+ LastName employeeName, Title" +
                         " FROM Employees WHERE username = @username AND Password = @password";

            com = new SqlCommand(sql, conn);
            com.Parameters.AddWithValue("@username", txtUsername.Text);
            com.Parameters.AddWithValue("@password", txtPassword.Text);
            da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            //ทดสอบการทำงานาว่า login สำเร็จหรือไม่
            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Login_status = "pass";
                this.employeeID = Convert.ToInt16(ds.Tables[0].Rows[0]["EmployeeID"].ToString());
                this.employeeName = ds.Tables[0].Rows[0]["employeeName"].ToString();
                this.employeeTitle = ds.Tables[0].Rows[0]["Title"].ToString();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "An error occurred");
            }
            this.Close();

        }
    }
}
