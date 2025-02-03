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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DBMS.CRUD.Nortwind
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            if (f.Login_status == "pass")
            {
                this.Text = "โปรแกรม Northwind รหัส : " + f.employeeID.ToString();
                this.Text += " ชื่อ-สกุล : " + f.employeeName + " ตำแหน่ง : " + f.employeeTitle;
                groupBoxManageData.Visible = true;
                btnlogout.Visible = true;
                btnLogin.Visible = false;
            }
            else
            {
                MessageBox.Show("Login fail");
            }

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Text = "โปรแกรม Northwind";
            groupBoxManageData.Visible = false;
            btnlogout.Visible = false;
            btnLogin.Visible = true;

        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReceipt_Details frm = new frmReceipt_Details();
            frm.ShowDialog();
        }
    }
}
