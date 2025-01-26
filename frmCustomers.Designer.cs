namespace DBMS.CRUD.Nortwind
{
    partial class frmCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label10 = new Label();
            txtCompanyName = new TextBox();
            label9 = new Label();
            txtAddress = new TextBox();
            label8 = new Label();
            txtCountry = new TextBox();
            label7 = new Label();
            txtPostcode = new TextBox();
            label6 = new Label();
            txtRegion = new TextBox();
            label5 = new Label();
            txtCity = new TextBox();
            label4 = new Label();
            txtTitle = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtCustomerName = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            label1 = new Label();
            txtCustomerID = new TextBox();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(45, 90);
            label10.Name = "label10";
            label10.Size = new Size(59, 20);
            label10.TabIndex = 43;
            label10.Text = "ชื่อบริษัท";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(83, 113);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(188, 27);
            txtCompanyName.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(45, 223);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 41;
            label9.Text = "ที่อยู่";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(83, 246);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(169, 27);
            txtAddress.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(258, 90);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 39;
            label8.Text = "ประเทศ";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(296, 113);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(45, 282);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 37;
            label7.Text = "รหัสไปรษณีย์";
            // 
            // txtPostcode
            // 
            txtPostcode.Location = new Point(83, 305);
            txtPostcode.Name = "txtPostcode";
            txtPostcode.Size = new Size(103, 27);
            txtPostcode.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(258, 282);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 35;
            label6.Text = "ภูมิภาค";
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(296, 305);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(125, 27);
            txtRegion.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(258, 229);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 33;
            label5.Text = "เมือง";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(296, 252);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(125, 27);
            txtCity.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 32);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 31;
            label4.Text = "ตำแหน่ง";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(296, 55);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 158);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 29;
            label3.Text = "เบอร์โทรศัพท์";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(296, 181);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 158);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 27;
            label2.Text = "ชื่อ-นามสกุล";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(83, 181);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(190, 27);
            txtCustomerName.TabIndex = 26;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(662, 389);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(562, 389);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 32);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 45;
            label1.Text = "CustomerID";
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(83, 55);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(188, 27);
            txtCustomerID.TabIndex = 44;
            // 
            // frmCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtCustomerID);
            Controls.Add(label10);
            Controls.Add(txtCompanyName);
            Controls.Add(label9);
            Controls.Add(txtAddress);
            Controls.Add(label8);
            Controls.Add(txtCountry);
            Controls.Add(label7);
            Controls.Add(txtPostcode);
            Controls.Add(label6);
            Controls.Add(txtRegion);
            Controls.Add(label5);
            Controls.Add(txtCity);
            Controls.Add(label4);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtCustomerName);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmCustomers";
            Text = "frmCustomers";
            Load += frmCustomers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private TextBox txtCompanyName;
        private Label label9;
        private TextBox txtAddress;
        private Label label8;
        private TextBox txtCountry;
        private Label label7;
        private TextBox txtPostcode;
        private Label label6;
        private TextBox txtRegion;
        private Label label5;
        private TextBox txtCity;
        private Label label4;
        private TextBox txtTitle;
        private Label label3;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtCustomerName;
        private Button btnCancel;
        private Button btnSave;
        private Label label1;
        private TextBox txtCustomerID;
    }
}