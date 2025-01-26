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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DBMS.CRUD.Nortwind
{
    public partial class frmSupplier : Form
    {
        public frmSupplier()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public int SupplierID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string HomePage { get; set; }
        public string Status { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSupplier_Load(object sender, EventArgs e)
        {
            txtSupplierID.Text = SupplierID.ToString();
            txtCompanyName.Text = CompanyName;
            txtContactName.Text = ContactName;
            txtContactTitle.Text = ContactTitle;
            txtAddress.Text = Address;
            txtCity.Text = City;
            txtRegion.Text = Region;
            txtPostalCode.Text = PostalCode;
            txtPhone.Text = Phone;
            txtCountry.Text = Country;
            txtHomePage.Text = HomePage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertSuppliers();
            }
            else if (Status == "update")
            {
                UpdateSuppliers();
            }
            this.Close();
        }


        private void InsertSuppliers()
        {
            MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(txtContactName.Text))
            {
                MessageBox.Show("โปรดกรอกข้อมูล", "เกิดข้อผิดพลาด");
                return;
            }
            conn = ConnectDB.ConnectNorthwind();
            string sql = "Insert into Suppliers(CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, HomePage) " +
                "Values(@CompanyName, @ContactName, @ContactTitle, @Address, @City, @Region, @PostalCode, @Country, @Phone, @HomePage)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text);
            cmd.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@HomePage", txtHomePage.Text);
            int n = cmd.ExecuteNonQuery(); ;
        }

        private void UpdateSuppliers()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(txtSupplierID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            int customerID;
            if (!int.TryParse(txtSupplierID.Text.Trim(), out customerID))
            {
                MessageBox.Show("CustomerID ต้องเป็นตัวเลข", "ข้อผิดพลาด");
                return;
            }

            if (string.IsNullOrEmpty(txtCompanyName.Text))
            {
                MessageBox.Show("โปรดกรอกชื่อบริษัท", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "Update Suppliers set CompanyName = @CompanyName, ContactName = @ContactName, ContactTitle = @ContactTitle, Address = @Address, City = @City, Region = @Region, PostalCode = @PostalCode, Country = @Country, Phone = @Phone, HomePage = @HomePage where SupplierID = @SupplierID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", txtCompanyName.Text);
            cmd.Parameters.AddWithValue("@ContactName", txtContactName.Text);
            cmd.Parameters.AddWithValue("@ContactTitle", txtContactTitle.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@HomePage", txtHomePage.Text);
            cmd.Parameters.AddWithValue("@SupplierID", txtSupplierID.Text);
            int n = cmd.ExecuteNonQuery();
        }
    }
}
