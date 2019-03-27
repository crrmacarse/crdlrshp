namespace cardealership.Modules.Sales
{
    partial class frmNewSales
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
            this.dtpDateOfPurchase = new System.Windows.Forms.DateTimePicker();
            this.lblCustomerContactNo = new System.Windows.Forms.Label();
            this.lblCustomerAddress = new System.Windows.Forms.Label();
            this.lblCustomerFullName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReceiptCode = new System.Windows.Forms.Label();
            this.txtCustomerContactNo = new cardealership.Common.UserControls.ucTextbox();
            this.txtCustomerAddress = new cardealership.Common.UserControls.ucTextbox();
            this.txtCustomerFullName = new cardealership.Common.UserControls.ucTextbox();
            this.txtReceiptCode = new cardealership.Common.UserControls.ucTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpDateOfPurchase
            // 
            this.dtpDateOfPurchase.CalendarForeColor = System.Drawing.Color.Gray;
            this.dtpDateOfPurchase.CalendarTitleForeColor = System.Drawing.Color.Gray;
            this.dtpDateOfPurchase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateOfPurchase.Location = new System.Drawing.Point(26, 416);
            this.dtpDateOfPurchase.Name = "dtpDateOfPurchase";
            this.dtpDateOfPurchase.Size = new System.Drawing.Size(328, 29);
            this.dtpDateOfPurchase.TabIndex = 132;
            // 
            // lblCustomerContactNo
            // 
            this.lblCustomerContactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerContactNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCustomerContactNo.Location = new System.Drawing.Point(23, 307);
            this.lblCustomerContactNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerContactNo.Name = "lblCustomerContactNo";
            this.lblCustomerContactNo.Size = new System.Drawing.Size(334, 24);
            this.lblCustomerContactNo.TabIndex = 131;
            this.lblCustomerContactNo.Text = "Customer Contact No";
            this.lblCustomerContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerAddress
            // 
            this.lblCustomerAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCustomerAddress.Location = new System.Drawing.Point(21, 230);
            this.lblCustomerAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerAddress.Name = "lblCustomerAddress";
            this.lblCustomerAddress.Size = new System.Drawing.Size(334, 24);
            this.lblCustomerAddress.TabIndex = 130;
            this.lblCustomerAddress.Text = "Customer Address";
            this.lblCustomerAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerFullName
            // 
            this.lblCustomerFullName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblCustomerFullName.Location = new System.Drawing.Point(21, 153);
            this.lblCustomerFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerFullName.Name = "lblCustomerFullName";
            this.lblCustomerFullName.Size = new System.Drawing.Size(334, 24);
            this.lblCustomerFullName.TabIndex = 129;
            this.lblCustomerFullName.Text = "Customer Full Name";
            this.lblCustomerFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(385, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 507);
            this.panel3.TabIndex = 126;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Sitka Text", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTitle.Location = new System.Drawing.Point(21, 23);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 27);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "New Sales";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 507);
            this.panel2.TabIndex = 128;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(386, 1);
            this.panel4.TabIndex = 127;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(179)))), ((int)(((byte)(79)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(-2, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(195, 41);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(193, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(195, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(386, 41);
            this.panel1.TabIndex = 125;
            // 
            // lblReceiptCode
            // 
            this.lblReceiptCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiptCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.lblReceiptCode.Location = new System.Drawing.Point(22, 68);
            this.lblReceiptCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReceiptCode.Name = "lblReceiptCode";
            this.lblReceiptCode.Size = new System.Drawing.Size(334, 24);
            this.lblReceiptCode.TabIndex = 124;
            this.lblReceiptCode.Text = "Receipt Code";
            this.lblReceiptCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCustomerContactNo
            // 
            this.txtCustomerContactNo.BackColor = System.Drawing.Color.White;
            this.txtCustomerContactNo.Location = new System.Drawing.Point(27, 339);
            this.txtCustomerContactNo.Name = "txtCustomerContactNo";
            this.txtCustomerContactNo.Size = new System.Drawing.Size(330, 37);
            this.txtCustomerContactNo.TabIndex = 122;
            this.txtCustomerContactNo.UseSystemPasswordChar = false;
            this.txtCustomerContactNo.Value = null;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.Color.White;
            this.txtCustomerAddress.Location = new System.Drawing.Point(25, 262);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(330, 37);
            this.txtCustomerAddress.TabIndex = 121;
            this.txtCustomerAddress.UseSystemPasswordChar = false;
            this.txtCustomerAddress.Value = null;
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.BackColor = System.Drawing.Color.White;
            this.txtCustomerFullName.Location = new System.Drawing.Point(27, 185);
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.Size = new System.Drawing.Size(330, 37);
            this.txtCustomerFullName.TabIndex = 120;
            this.txtCustomerFullName.UseSystemPasswordChar = false;
            this.txtCustomerFullName.Value = null;
            // 
            // txtReceiptCode
            // 
            this.txtReceiptCode.BackColor = System.Drawing.Color.White;
            this.txtReceiptCode.Location = new System.Drawing.Point(27, 100);
            this.txtReceiptCode.Name = "txtReceiptCode";
            this.txtReceiptCode.Size = new System.Drawing.Size(330, 37);
            this.txtReceiptCode.TabIndex = 119;
            this.txtReceiptCode.UseSystemPasswordChar = false;
            this.txtReceiptCode.Value = null;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(23, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 24);
            this.label1.TabIndex = 133;
            this.label1.Text = "Date of Purchase";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(386, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDateOfPurchase);
            this.Controls.Add(this.txtCustomerContactNo);
            this.Controls.Add(this.lblCustomerContactNo);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerFullName);
            this.Controls.Add(this.lblCustomerAddress);
            this.Controls.Add(this.lblCustomerFullName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtReceiptCode);
            this.Controls.Add(this.lblReceiptCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNewSales";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDateOfPurchase;
        private Common.UserControls.ucTextbox txtCustomerContactNo;
        private System.Windows.Forms.Label lblCustomerContactNo;
        private Common.UserControls.ucTextbox txtCustomerAddress;
        private Common.UserControls.ucTextbox txtCustomerFullName;
        private System.Windows.Forms.Label lblCustomerAddress;
        private System.Windows.Forms.Label lblCustomerFullName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private Common.UserControls.ucTextbox txtReceiptCode;
        private System.Windows.Forms.Label lblReceiptCode;
        private System.Windows.Forms.Label label1;
    }
}