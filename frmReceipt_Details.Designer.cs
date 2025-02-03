namespace DBMS.CRUD.Nortwind
{
    partial class frmReceipt_Details
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
            label1 = new Label();
            txtEmployeeID = new TextBox();
            txtEmployeeName = new TextBox();
            label2 = new Label();
            lblNetPrice = new Label();
            label4 = new Label();
            btnAdd = new Button();
            btnClear = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            lsvProduct = new ListView();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtTotal = new TextBox();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductName = new TextBox();
            txtProductID = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "EmployeesID";
            // 
            // txtEmployeeID
            // 
            txtEmployeeID.Location = new Point(128, 27);
            txtEmployeeID.Name = "txtEmployeeID";
            txtEmployeeID.Size = new Size(74, 27);
            txtEmployeeID.TabIndex = 1;
            txtEmployeeID.KeyDown += txtEmployeeID_KeyDown;
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(339, 27);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.ReadOnly = true;
            txtEmployeeName.Size = new Size(245, 27);
            txtEmployeeName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 30);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "First-Last Name";
            // 
            // lblNetPrice
            // 
            lblNetPrice.AutoSize = true;
            lblNetPrice.BackColor = SystemColors.ActiveCaptionText;
            lblNetPrice.Font = new Font("Showcard Gothic", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNetPrice.ForeColor = SystemColors.ButtonHighlight;
            lblNetPrice.Location = new Point(590, 30);
            lblNetPrice.Name = "lblNetPrice";
            lblNetPrice.Size = new Size(278, 50);
            lblNetPrice.TabIndex = 4;
            lblNetPrice.Text = "lblNetPrice";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(826, 10);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Total";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ActiveBorder;
            btnAdd.Location = new Point(724, 164);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ActiveBorder;
            btnClear.Location = new Point(724, 218);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveBorder;
            btnSave.Enabled = false;
            btnSave.Location = new Point(724, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(144, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(724, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(144, 29);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvProduct);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(txtQuantity);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(txtProductID);
            groupBox1.Location = new Point(57, 108);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 296);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Order list";
            // 
            // lsvProduct
            // 
            lsvProduct.Location = new Point(24, 100);
            lsvProduct.Name = "lsvProduct";
            lsvProduct.Size = new Size(570, 178);
            lsvProduct.TabIndex = 20;
            lsvProduct.UseCompatibleStateImageBehavior = false;
            lsvProduct.DoubleClick += lsvProduct_DoubleClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(439, 33);
            label9.Name = "label9";
            label9.Size = new Size(42, 20);
            label9.TabIndex = 19;
            label9.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(361, 33);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 18;
            label8.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 33);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 17;
            label7.Text = "UnitPrice";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(151, 33);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 16;
            label6.Text = "Product Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 33);
            label5.Name = "label5";
            label5.Size = new Size(79, 20);
            label5.TabIndex = 11;
            label5.Text = "Product ID";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(439, 56);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 15;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(361, 56);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(72, 27);
            txtQuantity.TabIndex = 14;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(282, 56);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.ReadOnly = true;
            txtUnitPrice.Size = new Size(73, 27);
            txtUnitPrice.TabIndex = 13;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(151, 56);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 12;
            // 
            // txtProductID
            // 
            txtProductID.Location = new Point(20, 56);
            txtProductID.Name = "txtProductID";
            txtProductID.Size = new Size(125, 27);
            txtProductID.TabIndex = 11;
            txtProductID.KeyDown += txtProductID_KeyDown;
            // 
            // frmReceipt_Details
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(label4);
            Controls.Add(lblNetPrice);
            Controls.Add(txtEmployeeName);
            Controls.Add(label2);
            Controls.Add(txtEmployeeID);
            Controls.Add(label1);
            Name = "frmReceipt_Details";
            Text = "frmReceipt_Details";
            Load += frmReceipt_Details_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmployeeID;
        private TextBox txtEmployeeName;
        private Label label2;
        private Label lblNetPrice;
        private Label label4;
        private Button btnAdd;
        private Button btnClear;
        private Button btnSave;
        private Button btnCancel;
        private GroupBox groupBox1;
        private ListView lsvProduct;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtTotal;
        private TextBox txtQuantity;
        private TextBox txtUnitPrice;
        private TextBox txtProductName;
        private TextBox txtProductID;
    }
}