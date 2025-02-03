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
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        public string Status { get; set; }
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public Image Photo { get; set; }
        public string Notes { get; set; }
        public string PhotoPath { get; set; }
        public string Extension { get; set; }
        public string ReportsTo { get; set; }
        private void frmEmployees_Load(object sender, EventArgs e)
        {
            txtAddress.Text = Address;
            txtBirthDate.Text = BirthDate.ToString();
            txtCity.Text = City;
            txtCountry.Text = Country;
            txtEmployeeID.Text = EmployeeID.ToString();
            txtExtension.Text = Extension;
            txtFirstName.Text = FirstName;
            txtHireDate.Text = HireDate.ToString();
            txtLastName.Text = LastName;
            txtNotes.Text = Notes;
            txtHomePhone.Text = HomePhone;
            txtPhotoPath.Text = PhotoPath;
            txtPostalCode.Text = PostalCode;
            txtRegion.Text = Region;
            txtReportsTo.Text = ReportsTo;
            txtTitle.Text = Title;
            txtTitleOfCourtesy.Text = TitleOfCourtesy;
            imgPhoto.Image = Photo;
        }

        private void brnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            if (Status == "insert")
            {
                InsertEmployee();
            }
            else if (Status == "update")
            {
                UpdateEmployee();
            }
            this.Close();
        }


        private void InsertEmployee()
        {

            MessageBox.Show("เพิ่มข้อมูล");
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("โปรดกรอกข้อมูล", "เกิดข้อผิดพลาด");
                return;
            }

            string sql = "Insert into Employees(LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Photo,Notes,PhotoPath,Extension,ReportsTo) " +
                         "Values(@LastName,@FirstName,@Title,@TitleOfCourtesy,@BirthDate,@HireDate,@Address,@City,@Region,@PostalCode,@Country,@HomePhone,@Photo,@Notes,@PhotoPath,@Extension,@ReportsTo)";

            using (SqlConnection conn = ConnectDB.ConnectNorthwind())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text);

                    // Convert and validate BirthDate
                    if (DateTime.TryParse(txtBirthDate.Text, out DateTime birthDate))
                    {
                        cmd.Parameters.AddWithValue("@BirthDate", birthDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@BirthDate", DBNull.Value); // Handle invalid or empty input
                    }

                    // Convert and validate HireDate
                    if (DateTime.TryParse(txtHireDate.Text, out DateTime hireDate))
                    {
                        cmd.Parameters.AddWithValue("@HireDate", hireDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@HireDate", DBNull.Value); // Handle invalid or empty input
                    }

                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@City", txtCity.Text);
                    cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                    cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
                    cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
                    cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);

                    // Handle the photo conversion as in the previous example
                    if (imgPhoto.Image != null)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            imgPhoto.Image.Save(ms, imgPhoto.Image.RawFormat);
                            cmd.Parameters.AddWithValue("@Photo", ms.ToArray());
                        }
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Photo", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
                    cmd.Parameters.AddWithValue("@PhotoPath", txtPhotoPath.Text);
                    cmd.Parameters.AddWithValue("@Extension", txtExtension.Text);
                    cmd.Parameters.AddWithValue("@ReportsTo", txtReportsTo.Text);

                    // Open the connection
                    conn.Open();

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว");
                }
            }
        }

        private void UpdateEmployee()
        {
            MessageBox.Show("ปรับปรุงข้อมูล");
            if (string.IsNullOrEmpty(txtEmployeeID.Text))
            {
                MessageBox.Show("โปรดเลือกข้อมูลที่จะปรับปรุงแก้ไข", "เกิดข้อผิดพลาด");
                return;
            }
            string sql = "Update Employees set LastName=@LastName,FirstName=@FirstName,Title=@Title,TitleOfCourtesy=@TitleOfCourtesy,BirthDate=@BirthDate,HireDate=@HireDate,Address=@Address,City=@City,Region=@Region,PostalCode=@PostalCode,Country=@Country,HomePhone=@HomePhone,Photo=@Photo,Notes=@Notes,PhotoPath=@PhotoPath,Extension=@Extension,ReportsTo=@ReportsTo where EmployeeID=@EmployeeID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
            cmd.Parameters.AddWithValue("@TitleOfCourtesy", txtTitleOfCourtesy.Text);
            cmd.Parameters.AddWithValue("@BirthDate", txtBirthDate.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Text);
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
            cmd.Parameters.AddWithValue("@City", txtCity.Text);
            cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
            cmd.Parameters.AddWithValue("@PostalCode", txtPostalCode.Text);
            cmd.Parameters.AddWithValue("@Country", txtCountry.Text);
            cmd.Parameters.AddWithValue("@HomePhone", txtHomePhone.Text);
            cmd.Parameters.AddWithValue("@Photo", imgPhoto.Image);
            cmd.Parameters.AddWithValue("@Notes", txtNotes.Text);
            cmd.Parameters.AddWithValue("@PhotoPath", txtPhotoPath.Text);
            cmd.Parameters.AddWithValue("@Extension", txtExtension.Text);
            cmd.Parameters.AddWithValue("@ReportsTo", txtReportsTo.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("ปรับปรุงข้อมูลเรียบร้อยแล้ว");
        }

        private void imgPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Display the selected image in the PictureBox
                    imgPhoto.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
    }
}
