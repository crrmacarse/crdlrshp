namespace cardealership.Modules.Sales
{
    partial class ucSales
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucSales));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvSalesControl = new System.Windows.Forms.ListView();
            this.chSalesCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.msControl = new System.Windows.Forms.MenuStrip();
            this.tsmiNewSales = new System.Windows.Forms.ToolStripMenuItem();
            this.scSub = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCreateSalesData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsInventoryData = new System.Windows.Forms.ToolStrip();
            this.tsslInventoryData = new System.Windows.Forms.ToolStripLabel();
            this.lvSalesData = new System.Windows.Forms.ListView();
            this.chICode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cICarModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateOfPurchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.msControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).BeginInit();
            this.scSub.Panel1.SuspendLayout();
            this.scSub.Panel2.SuspendLayout();
            this.scSub.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsInventoryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lvSalesControl);
            this.scMain.Panel1.Controls.Add(this.pnlMain);
            this.scMain.Panel1.Controls.Add(this.msControl);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Panel2.Controls.Add(this.scSub);
            this.scMain.Size = new System.Drawing.Size(1003, 505);
            this.scMain.SplitterDistance = 163;
            this.scMain.TabIndex = 1;
            // 
            // lvSalesControl
            // 
            this.lvSalesControl.BackColor = System.Drawing.SystemColors.Window;
            this.lvSalesControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSalesControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chSalesCode,
            this.chCustName});
            this.lvSalesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSalesControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSalesControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvSalesControl.FullRowSelect = true;
            this.lvSalesControl.LargeImageList = this.ilMain;
            this.lvSalesControl.Location = new System.Drawing.Point(0, 148);
            this.lvSalesControl.Name = "lvSalesControl";
            this.lvSalesControl.Size = new System.Drawing.Size(163, 357);
            this.lvSalesControl.TabIndex = 5;
            this.lvSalesControl.UseCompatibleStateImageBehavior = false;
            this.lvSalesControl.View = System.Windows.Forms.View.Tile;
            this.lvSalesControl.DoubleClick += new System.EventHandler(this.lvSalesControl_DoubleClick);
            // 
            // chSalesCode
            // 
            this.chSalesCode.Text = "Car Model";
            this.chSalesCode.Width = 0;
            // 
            // chCustName
            // 
            this.chCustName.Text = "Car Name";
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "folder");
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.btnGenerate);
            this.pnlMain.Controls.Add(this.dtTo);
            this.pnlMain.Controls.Add(this.dtFrom);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 24);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(163, 124);
            this.pnlMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "To:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 50;
            this.label7.Text = "From:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.btnGenerate.Location = new System.Drawing.Point(0, 101);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(163, 23);
            this.btnGenerate.TabIndex = 49;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtTo
            // 
            this.dtTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTo.Location = new System.Drawing.Point(12, 70);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(139, 20);
            this.dtTo.TabIndex = 48;
            // 
            // dtFrom
            // 
            this.dtFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFrom.Location = new System.Drawing.Point(12, 25);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(139, 20);
            this.dtFrom.TabIndex = 47;
            // 
            // msControl
            // 
            this.msControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.msControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewSales});
            this.msControl.Location = new System.Drawing.Point(0, 0);
            this.msControl.Name = "msControl";
            this.msControl.Size = new System.Drawing.Size(163, 24);
            this.msControl.TabIndex = 6;
            this.msControl.Text = "menuStrip1";
            // 
            // tsmiNewSales
            // 
            this.tsmiNewSales.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiNewSales.ForeColor = System.Drawing.Color.White;
            this.tsmiNewSales.Name = "tsmiNewSales";
            this.tsmiNewSales.Size = new System.Drawing.Size(43, 20);
            this.tsmiNewSales.Text = "New";
            this.tsmiNewSales.Click += new System.EventHandler(this.tsmiNewSales_Click);
            // 
            // scSub
            // 
            this.scSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSub.Location = new System.Drawing.Point(0, 0);
            this.scSub.Name = "scSub";
            this.scSub.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSub.Panel1
            // 
            this.scSub.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.scSub.Panel1.Controls.Add(this.menuStrip1);
            // 
            // scSub.Panel2
            // 
            this.scSub.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.scSub.Panel2.Controls.Add(this.tsInventoryData);
            this.scSub.Panel2.Controls.Add(this.lvSalesData);
            this.scSub.Size = new System.Drawing.Size(836, 505);
            this.scSub.SplitterDistance = 51;
            this.scSub.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateSalesData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(836, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCreateSalesData
            // 
            this.tsmiCreateSalesData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiCreateSalesData.ForeColor = System.Drawing.Color.White;
            this.tsmiCreateSalesData.Name = "tsmiCreateSalesData";
            this.tsmiCreateSalesData.Size = new System.Drawing.Size(110, 20);
            this.tsmiCreateSalesData.Text = "Create Sales Data";
            this.tsmiCreateSalesData.Click += new System.EventHandler(this.tsmiCreateSalesData_Click);
            // 
            // tsInventoryData
            // 
            this.tsInventoryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsInventoryData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInventoryData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsInventoryData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInventoryData});
            this.tsInventoryData.Location = new System.Drawing.Point(0, 425);
            this.tsInventoryData.Name = "tsInventoryData";
            this.tsInventoryData.Size = new System.Drawing.Size(836, 25);
            this.tsInventoryData.TabIndex = 2;
            this.tsInventoryData.Text = "toolStrip1";
            // 
            // tsslInventoryData
            // 
            this.tsslInventoryData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsslInventoryData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.tsslInventoryData.Margin = new System.Windows.Forms.Padding(3);
            this.tsslInventoryData.Name = "tsslInventoryData";
            this.tsslInventoryData.Size = new System.Drawing.Size(78, 19);
            this.tsslInventoryData.Text = "Row Count: 0";
            // 
            // lvSalesData
            // 
            this.lvSalesData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvSalesData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chICode,
            this.cICarModelName,
            this.chDetails,
            this.chDateOfPurchase});
            this.lvSalesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSalesData.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSalesData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvSalesData.FullRowSelect = true;
            this.lvSalesData.Location = new System.Drawing.Point(0, 0);
            this.lvSalesData.Name = "lvSalesData";
            this.lvSalesData.Size = new System.Drawing.Size(836, 450);
            this.lvSalesData.TabIndex = 1;
            this.lvSalesData.UseCompatibleStateImageBehavior = false;
            this.lvSalesData.View = System.Windows.Forms.View.Details;
            // 
            // chICode
            // 
            this.chICode.Text = "Inventory Code";
            this.chICode.Width = 150;
            // 
            // cICarModelName
            // 
            this.cICarModelName.Text = "Car Model";
            this.cICarModelName.Width = 250;
            // 
            // chDetails
            // 
            this.chDetails.Text = "Details";
            this.chDetails.Width = 300;
            // 
            // chDateOfPurchase
            // 
            this.chDateOfPurchase.Text = "Date of Release";
            this.chDateOfPurchase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chDateOfPurchase.Width = 130;
            // 
            // ucSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.scMain);
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(1003, 505);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.msControl.ResumeLayout(false);
            this.msControl.PerformLayout();
            this.scSub.Panel1.ResumeLayout(false);
            this.scSub.Panel1.PerformLayout();
            this.scSub.Panel2.ResumeLayout(false);
            this.scSub.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).EndInit();
            this.scSub.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsInventoryData.ResumeLayout(false);
            this.tsInventoryData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scSub;
        private System.Windows.Forms.ToolStrip tsInventoryData;
        private System.Windows.Forms.ToolStripLabel tsslInventoryData;
        private System.Windows.Forms.ListView lvSalesData;
        private System.Windows.Forms.ColumnHeader chICode;
        private System.Windows.Forms.ColumnHeader cICarModelName;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateSalesData;
        private System.Windows.Forms.ListView lvSalesControl;
        private System.Windows.Forms.ColumnHeader chSalesCode;
        private System.Windows.Forms.ColumnHeader chCustName;
        private System.Windows.Forms.ColumnHeader chDetails;
        private System.Windows.Forms.ColumnHeader chDateOfPurchase;
        private System.Windows.Forms.ImageList ilMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip msControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewSales;
    }
}
