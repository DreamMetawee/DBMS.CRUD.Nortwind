using Microsoft.Data.SqlClient;
using System.Data;

namespace DBMS.CRUD.Nortwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ประกาศตัวแปรเชื่อมต่อ Database 
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        //ประกาศตัวแปรเพิ่มเติม
        int CustomerID = 0;
        string CompanyName = string.Empty;
        string ContactName = string.Empty;
        string ContactTitle = string.Empty;
        string Address = string.Empty;
        string City = string.Empty;
        string Region = string.Empty;
        string PostalCode = string.Empty;
        string Country = string.Empty;
        string Phone = string.Empty;

        public string Status { get; set; }
        public int SupplierID { get; private set; }
        public string HomePage { get; private set; }
        public int EmployeeID { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string Title { get; private set; }
        public string TitleOfCourtesy { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime HireDate { get; private set; }
        public string HomePhone { get; private set; }
        public string Notes { get; private set; }
        public Image Photo { get; private set; }
        public string PhotoPath { get; private set; }
        public string Extension { get; private set; }
        public string ReportsTo { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            showdata();
        }
        private void showdata()
        {
            string sql = "Select * from Customers";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvCustomer.DataSource = ds.Tables[0];
        }

        private void dgvCustomer_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvCustomer.CurrentRow != null)
            {
                CustomerID = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value.ToString());
                CompanyName = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
                ContactName = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
                ContactTitle = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
                Address = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
                City = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
                Region = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
                PostalCode = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
                Country = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
                Phone = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
            }
        }



        private void btnInsert_Click(object sender, EventArgs e)
        {
            //frmCustomers f = new frmCustomers();
            //f.Status = "insert";
            //f.ShowDialog();
            //showdata();

            //frmSupplier frm = new frmSupplier();
            //frm.Status = "insert";
            //frm.ShowDialog();
            //showdata();

            frmEmployees frmEm = new frmEmployees();
            frmEm.Status = "insert";
            frmEm.ShowDialog();
            showdata();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerID <= 0)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            frmCustomers f = new frmCustomers();
            f.Status = "update";
            f.CustomerID = CustomerID;
            f.CompanyName = CompanyName;
            f.Phone = Phone;
            f.ShowDialog();
            showdata();

            frmSupplier frm = new frmSupplier();
            frm.Status = "update";
            frm.SupplierID = SupplierID;
            frm.CompanyName = CompanyName;
            frm.ContactName = ContactName;
            frm.ContactTitle = ContactTitle;
            frm.Address = Address;
            frm.City = City;
            frm.Region = Region;
            frm.PostalCode = PostalCode;
            frm.Country = Country;
            frm.HomePage = HomePage;
            frm.Phone = Phone;
            frm.ShowDialog();
            showdata();

            frmEmployees frmEm = new frmEmployees();
            frmEm.Status = "update";
            frmEm.EmployeeID = EmployeeID;
            frmEm.LastName = LastName;
            frmEm.FirstName = FirstName;
            frmEm.Title = Title;
            frmEm.TitleOfCourtesy = TitleOfCourtesy;
            frmEm.BirthDate = BirthDate;
            frmEm.HireDate = HireDate;
            frmEm.Address = Address;
            frmEm.City = City;
            frmEm.Region = Region;
            frmEm.PostalCode = PostalCode;
            frmEm.Country = Country;
            frmEm.HomePhone = HomePhone;
            frmEm.Photo = Photo;
            frmEm.Notes = Notes;
            frmEm.PhotoPath = PhotoPath;
            frmEm.Extension = Extension;
            frmEm.ReportsTo = ReportsTo;
            frmEm.ShowDialog();
            showdata();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Employees";
            using (SqlConnection conn = ConnectDB.ConnectNorthwind())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomer.DataSource = dt;
                }
            }
        }
        private void btnCustomers_Click(object sender, EventArgs e)
        {

            string sql = "Select * from Customers";
            using (SqlConnection conn = ConnectDB.ConnectNorthwind())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomer.DataSource = dt;
                }
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            string sql = "Select * from Suppliers";
            using (SqlConnection conn = ConnectDB.ConnectNorthwind())
            {
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCustomer.DataSource = dt;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomer.CurrentRow == null)
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะลบ", "ข้อผิดพลาด");
                return;
            }

            // แสดงกล่องข้อความยืนยันก่อนลบ
            DialogResult result = MessageBox.Show("คุณต้องการลบข้อมูลนี้ใช่หรือไม่?", "ยืนยันการลบ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // ดึงข้อมูลจากแถวที่เลือก
                int customerID = Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value);

                // เรียกใช้ฟังก์ชันลบข้อมูล
                DeleteCustomer(customerID);
            }
        }
        private void DeleteCustomer(int customerID)
        {
            try
            {
                // เชื่อมต่อฐานข้อมูล
                using (SqlConnection conn = ConnectDB.ConnectNorthwind()) // ใช้ using statement
                {
                    // เขียนคำสั่ง SQL สำหรับการลบข้อมูล
                    string sql = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

                    // สร้างคำสั่ง SQL
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);

                        // เปิดการเชื่อมต่อ
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();
                        }
                        conn.Open();

                        // ลบข้อมูล
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("ลบข้อมูลสำเร็จ", "ผลการดำเนินการ");
                            showdata(); // รีเฟรชข้อมูลใน DataGridView
                        }
                        else
                        {
                            MessageBox.Show("ไม่พบข้อมูลที่ต้องการลบ", "ข้อผิดพลาด");
                        }
                    }
                } // การใช้ 'using' statement จะช่วยปิดการเชื่อมต่ออัตโนมัติ
            }
            catch (Exception ex)
            {
                MessageBox.Show("เกิดข้อผิดพลาดในการลบข้อมูล: " + ex.Message, "ข้อผิดพลาด");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReceipt_Details frm = new frmReceipt_Details();
            frm.ShowDialog();
        }
    }
}

    

