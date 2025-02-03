namespace DBMS.CRUD.Nortwind
{
    partial class Form2
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
            groupBoxManageData = new GroupBox();
            btnEmployees = new Button();
            btnShipper = new Button();
            btnSupplier = new Button();
            btnCustomer = new Button();
            btnlogout = new Button();
            btnLogin = new Button();
            button1 = new Button();
            groupBoxManageData.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxManageData
            // 
            groupBoxManageData.Controls.Add(button1);
            groupBoxManageData.Controls.Add(btnEmployees);
            groupBoxManageData.Controls.Add(btnShipper);
            groupBoxManageData.Controls.Add(btnSupplier);
            groupBoxManageData.Controls.Add(btnCustomer);
            groupBoxManageData.Location = new Point(72, 132);
            groupBoxManageData.Name = "groupBoxManageData";
            groupBoxManageData.Size = new Size(656, 264);
            groupBoxManageData.TabIndex = 5;
            groupBoxManageData.TabStop = false;
            groupBoxManageData.Text = "Manage Data";
            groupBoxManageData.Visible = false;
            // 
            // btnEmployees
            // 
            btnEmployees.Location = new Point(57, 98);
            btnEmployees.Name = "btnEmployees";
            btnEmployees.Size = new Size(94, 29);
            btnEmployees.TabIndex = 9;
            btnEmployees.Text = "Employees";
            btnEmployees.UseVisualStyleBackColor = true;
            btnEmployees.Click += btnEmployees_Click;
            // 
            // btnShipper
            // 
            btnShipper.Location = new Point(57, 205);
            btnShipper.Name = "btnShipper";
            btnShipper.Size = new Size(94, 29);
            btnShipper.TabIndex = 8;
            btnShipper.Text = "shipper";
            btnShipper.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(57, 151);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(94, 29);
            btnSupplier.TabIndex = 7;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(57, 48);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(94, 29);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnlogout
            // 
            btnlogout.Location = new Point(634, 55);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(94, 29);
            btnlogout.TabIndex = 4;
            btnlogout.Text = "Logout";
            btnlogout.UseVisualStyleBackColor = true;
            btnlogout.Visible = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(513, 55);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button1
            // 
            button1.Location = new Point(540, 48);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "Receipt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxManageData);
            Controls.Add(btnlogout);
            Controls.Add(btnLogin);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupBoxManageData.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxManageData;
        private Button btnShipper;
        private Button btnSupplier;
        private Button btnCustomer;
        private Button btnlogout;
        private Button btnLogin;
        private Button btnEmployees;
        private Button button1;
    }
}