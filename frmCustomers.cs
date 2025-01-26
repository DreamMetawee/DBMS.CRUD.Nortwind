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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
        public string Status { get; set; }
        private void frmCustomers_Load(object sender, EventArgs e)
        {
            
            txtCustomerName.Text = CustomerName;
            txtCompanyName.Text = CompanyName;
            txtTitle.Text = Title;
            txtAddress.Text = Address;
            txtCity.Text = City;
            txtRegion.Text = Region;
            txtPostcode.Text = PostalCode;
            txtCountry.Text = Country;
            txtPhone.Text = Phone;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertCustomer();
            }
            else if (Status == "update")
            {
                UpdateCustomer();
            }
            this.Close();
        }

        private void InsertCustomer()
        {

            MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(txtCustomerName.Text))
            {
                MessageBox.Show("โปรดกรอกข้อมูล", "เกิดข้อผิดพลาด");
                return;
            }

            //เพิ่มข้อมูลลงฐานข้อมูล
            string sql = "INSERT INTO Customers (CustomerID,ContactName, CompanyName, ContactTitle, Address, City, Region, PostalCode, Country, Phone) "
                         + "VALUES (@CustomerID,@ContactName, @CompanyName, @ContactTitle, @Address, @City, @Region, @Postcode, @Country, @Phone)";
            using (SqlConnection conn = ConnectDB.ConnectNorthwind())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactName", txtCustomerName.Text.Trim());
                    cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
                    cmd.Parameters.AddWithValue("@ContactTitle", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text.Trim());
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
                    cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                   
                    int n = cmd.ExecuteNonQuery();


                }
            }

        }
        private void UpdateCustomer()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(txtCustomerID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            int customerID;
            if (!int.TryParse(txtCustomerID.Text.Trim(), out customerID))
            {
                MessageBox.Show("CustomerID ต้องเป็นตัวเลข", "ข้อผิดพลาด");
                return;
            }

            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }


            string sql = "UPDATE Customers "
                       + "SET ContactName = @ContactName, CompanyName = @CompanyName, ContactTitle = @ContactTitle, "
                       + "Address = @Address, City = @City, Region = @Region, "
                       + "PostalCode = @Postcode, Country = @Country, Phone = @Phone "
                       + "WHERE CustomerID = @CustomerID";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerID", txtCustomerID.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactName", txtCustomerName.Text.Trim());
                cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text.Trim());
                cmd.Parameters.AddWithValue("@ContactTitle", txtTitle.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@City", txtCity.Text.Trim());
                cmd.Parameters.AddWithValue("@Region", txtRegion.Text.Trim());
                cmd.Parameters.AddWithValue("@Postcode", txtPostcode.Text.Trim());
                cmd.Parameters.AddWithValue("@Country", txtCountry.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text.Trim());

                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show($"{rowsAffected} แถวถูกปรับปรุง", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
    }
}
