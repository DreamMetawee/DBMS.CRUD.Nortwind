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
    public partial class frmReceipt_Details : Form
    {
        public frmReceipt_Details()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand com;
        SqlTransaction tr;
        public int empID { get; set; }
        public string empName { get; set; }
        public string position { get; set; }
        public string userName { get; set; }

        private void frmReceipt_Details_Load(object sender, EventArgs e)
        {
            conn = ConnectDB.ConnectNorthwind();
            ListViewFormat();
            ClearProductData();
            txtEmployeeID.Text = this.empID.ToString();
            txtEmployeeName.Text = this.empName;
        }

        private void ClearProductData() //เคลียร์ข ้อมูลใน Textbox รายการสนิ คา้
        {
            txtProductID.Text = "";
            txtProductName.Text = "";
            txtUnitPrice.Text = "0";
            txtQuantity.Text = "1";
            txtTotal.Text = "0";
        }
        private void ListViewFormat()
        {

            lsvProduct.Columns.Add("ProductID", 120);
            lsvProduct.Columns.Add("ProductName", 170);
            lsvProduct.Columns.Add("UnitPrice", 120);
            lsvProduct.Columns.Add("Quantity", 75);
            lsvProduct.Columns.Add("Total", 100);
            lsvProduct.View = View.Details;
            lsvProduct.GridLines = true;
            lsvProduct.FullRowSelect = true;
        }

        private void ClearEmployeeData() //เคลยี รช์ อื่ และรหัสพนักงาน
        {
            txtEmployeeID.Text = "";
            txtEmployeeName.Text = "";
        }
        private void CalculateTotal() //เอาไว้ค านวณราคารวมของแต่ละรายการ
        {
            double total = Convert.ToDouble(txtUnitPrice.Text) * Convert.ToDouble(txtQuantity.Text);
            txtTotal.Text = total.ToString("#,##0.00");
            txtProductID.Focus();
            txtProductID.SelectAll();
        }
        private void CalculateNetPrice() //เอาไว้ค านวณราคารวมทั้งหมด
        {
            double tmpNetPeice = 0.0;
            for (int i = 0; i <= lsvProduct.Items.Count - 1; i++)
            {
                tmpNetPeice += Convert.ToDouble(lsvProduct.Items[i].SubItems[4].Text);
            }
            lblNetPrice.Text = tmpNetPeice.ToString("#,##0.00");
        }

        private void txtEmployeeID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select EmployeeID, TitleOfCourtesy+FirstName+space(2)+LastName EmpName, Title"
                + " from Employees"
                + " Where EmployeeID = @EmployeeID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text);
                
                if (conn.State == ConnectionState.Open) 
                {
                conn.Close();
                }
                
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtEmployeeID.Text = dt.Rows[0][0].ToString();
                    txtEmployeeName.Text = dt.Rows[0][1].ToString();
                    txtProductID.Focus();
                }
                else
                {
                    ClearEmployeeData();
                    txtEmployeeID.Focus();
                }
                dr.Close();
                conn.Close();
            }
        }

        private void txtProductID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = "Select ProductID, ProductName,UnitPrice,UnitsInStock"
                + " from Products where productID = @ProductID";
                SqlCommand comm = new SqlCommand(sql, conn);
                comm.Parameters.AddWithValue("@ProductID", txtProductID.Text);
                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();
                if (dr.HasRows)
                {
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    txtProductID.Text = dt.Rows[0][0].ToString();
                    txtProductName.Text = dt.Rows[0][1].ToString();
                    txtUnitPrice.Text = dt.Rows[0][2].ToString();
                    CalculateTotal();
                    txtProductID.Focus();
                    txtProductID.SelectAll();
                }
                else
                {
                    MessageBox.Show("ไมพ่ บสนิ คา้รหัสนี้", "ผิดพลาด");
                    ClearProductData();
                }
                txtQuantity.Focus();

                txtQuantity.SelectAll();
                dr.Close();
                conn.Close();
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Trim() == "") txtQuantity.Text = "1";
            if (Convert.ToInt16(txtQuantity.Text) == 0) txtQuantity.Text = "1";
            CalculateTotal();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Trim() == "" || txtProductName.Text.Trim() == "")
            {
                txtProductID.Focus();
                txtProductID.SelectAll();
                return;
            }
            if (Convert.ToInt16(txtQuantity.Text) == 0)
            {
                txtProductID.Focus();
                txtProductID.SelectAll();
                return;
            }
            ListViewItem lvi;
            string tmpProductID = "";
            for (int i = 0; i <= lsvProduct.Items.Count - 1; i++)
            {
                tmpProductID = lsvProduct.Items[i].SubItems[0].Text;
                if (txtProductID.Text == tmpProductID)
                {
                    int qty = Convert.ToInt16(lsvProduct.Items[i].SubItems[3].Text)
                    + Convert.ToInt16(txtQuantity.Text);
                    double newTotal = Convert.ToDouble(lsvProduct.Items[i].SubItems[4].Text)
                    + Convert.ToDouble(txtTotal.Text);
                    lsvProduct.Items[i].SubItems[3].Text = qty.ToString();
                    lsvProduct.Items[i].SubItems[4].Text = newTotal.ToString("#,##0.00");
                    ClearProductData();
                    CalculateTotal();
                    CalculateNetPrice();
                    return;
                }
            }
            string[] anyData;
            anyData = new string[] { txtProductID.Text , txtProductName.Text,txtUnitPrice.Text,
                                     txtQuantity.Text , txtTotal.Text};
            lvi = new ListViewItem(anyData);
            lsvProduct.Items.Add(lvi);
            CalculateNetPrice(); ClearProductData(); btnSave.Enabled = true;
            txtProductID.Focus(); txtProductID.SelectAll();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductData();
        }

        private void lsvProduct_DoubleClick(object sender, EventArgs e)
        {
            //เมื่อ Double click บนขอ้มลู สนิ คา้จะลบสนิ คา้ออกจากรายการ
            for (int i = 0; i <= lsvProduct.SelectedItems.Count - 1; i++)
            {
                ListViewItem lvi = lsvProduct.SelectedItems[i];
                lsvProduct.Items.Remove(lvi);
            }
            CalculateNetPrice();
            txtProductID.Focus();
            txtProductID.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lsvProduct.Clear();
            ClearProductData();
            ListViewFormat();
            lblNetPrice.Text = "0.00";
            txtProductID.Focus();
            txtProductID.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int lastOrderID = 0; //จะเอําไว้เก็บรหัสที่ใหม่ที่สุดตอนที่ insert order แล ้ว
            if (txtEmployeeID.Text.Trim() == "")
            {
                MessageBox.Show("โปรดระบผุ ูข้ ํายสนิคํา้กอ่ น", "มีข ้อผิดพลําด");
                txtEmployeeID.Focus();
                return;
            }
            if (lsvProduct.Items.Count > 0) //ตรวจสอบวํา่ เลอื กสนิคํา้ไวห้ รอื ยัง
            {
                if (MessageBox.Show("ต้องกํารบันทึกรายการสั่งซื้อหรือไม่" , "กรุณายืนยัน", MessageBoxButtons.YesNo)
                == DialogResult.Yes)
                {
                    //ประกําศเริ่ม Transaction
                    conn.Open();
                    tr = conn.BeginTransaction();
                    string sql = "insert into Orders(OrderDate,EmployeeID)"
                    + " values (getdate(),@EmployeeID)";
                    SqlCommand comm = new SqlCommand(sql, conn, tr);
                    comm.Parameters.AddWithValue("@EmployeeID", txtEmployeeID.Text.Trim());
                    comm.ExecuteNonQuery();
                    //อ่ําน OrderID ล่าสุด ใสไว้ใ้นตัวแปร lastOrderID
                    string sql1 = "select Top 1 OrderID from Orders order by orderID DESC";
                    SqlCommand comm1 = new SqlCommand(sql1, conn, tr);
                    SqlDataReader dr = comm1.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        lastOrderID = dr.GetInt32(dr.GetOrdinal("OrderID"));
                    }
                    dr.Close();
                    //เพมิ่ ขอ้มลู รํายกํารสนิคํา้ OrderDetail ที่ตรงกับ lastOrderID
                    for (int i = 0; i <= lsvProduct.Items.Count - 1; i++)
                    {
                        string sql2 = "insert into [Order Details](OrderID,ProductID,UnitPrice,Quantity)"
                        + " values(@OrderID,@ProductID,@UnitPrice,@Quantity)";
                        SqlCommand comm3 = new SqlCommand(sql2, conn, tr);
                        comm3.Parameters.AddWithValue("@OrderID", lastOrderID);
                        comm3.Parameters.AddWithValue("@ProductID", lsvProduct.Items[i].SubItems[0].Text);
                        comm3.Parameters.AddWithValue("@UnitPrice", lsvProduct.Items[i].SubItems[2].Text);
                        comm3.Parameters.AddWithValue("@Quantity", lsvProduct.Items[i].SubItems[3].Text);
                        comm3.ExecuteNonQuery();
                    }
                    tr.Commit();
                    conn.Close();
                    MessageBox.Show("บันทึกรํายกํารขํายเรียบร้อยแล้ว", "ผลกํารทำงาน");
                }
                btnCancel.PerformClick(); //สั่งใหไ้ปกดป่ม ุ cancel เคลีย์หน้ําจอทั้งหมดใหม่เพื่อเริ่มรํายกํารใหม่
            }
        }
    } 
}
