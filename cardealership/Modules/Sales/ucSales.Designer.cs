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
            this.lvIInventoryData = new System.Windows.Forms.ListView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.msControl = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scSub = new System.Windows.Forms.SplitContainer();
            this.tsInventoryData = new System.Windows.Forms.ToolStrip();
            this.tsslInventoryData = new System.Windows.Forms.ToolStripLabel();
            this.lvSalesData = new System.Windows.Forms.ListView();
            this.chICode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cICarModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCreateSalesData = new System.Windows.Forms.ToolStripMenuItem();
            this.lvSalesControl = new System.Windows.Forms.ListView();
            this.chCarModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCarName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDateOfPurchase = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
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
            this.tsInventoryData.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.lvIInventoryData);
            this.scMain.Panel1.Controls.Add(this.pnlMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Panel2.Controls.Add(this.scSub);
            this.scMain.Size = new System.Drawing.Size(1003, 505);
            this.scMain.SplitterDistance = 155;
            this.scMain.TabIndex = 1;
            // 
            // lvIInventoryData
            // 
            this.lvIInventoryData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvIInventoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIInventoryData.Location = new System.Drawing.Point(0, 161);
            this.lvIInventoryData.Name = "lvIInventoryData";
            this.lvIInventoryData.Size = new System.Drawing.Size(155, 344);
            this.lvIInventoryData.TabIndex = 0;
            this.lvIInventoryData.UseCompatibleStateImageBehavior = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.button4);
            this.pnlMain.Controls.Add(this.dateTimePicker2);
            this.pnlMain.Controls.Add(this.dateTimePicker1);
            this.pnlMain.Controls.Add(this.msControl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(155, 161);
            this.pnlMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(2, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 46;
            this.label1.Text = "To:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(2, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "From:";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI Semibold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.button4.Location = new System.Drawing.Point(84, 132);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 23);
            this.button4.TabIndex = 44;
            this.button4.Text = "Generate";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(5, 96);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 51);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(142, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // msControl
            // 
            this.msControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.msControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msControl.Location = new System.Drawing.Point(0, 0);
            this.msControl.Name = "msControl";
            this.msControl.Size = new System.Drawing.Size(155, 24);
            this.msControl.TabIndex = 2;
            this.msControl.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "New";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
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
            this.scSub.Size = new System.Drawing.Size(844, 505);
            this.scSub.SplitterDistance = 51;
            this.scSub.TabIndex = 0;
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
            this.tsInventoryData.Size = new System.Drawing.Size(844, 25);
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
            this.lvSalesData.Size = new System.Drawing.Size(844, 450);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreateSalesData});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 24);
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
            // lvSalesControl
            // 
            this.lvSalesControl.BackColor = System.Drawing.SystemColors.Window;
            this.lvSalesControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvSalesControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCarModel,
            this.chCarName});
            this.lvSalesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSalesControl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSalesControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvSalesControl.FullRowSelect = true;
            this.lvSalesControl.LargeImageList = this.ilMain;
            this.lvSalesControl.Location = new System.Drawing.Point(0, 161);
            this.lvSalesControl.Name = "lvSalesControl";
            this.lvSalesControl.Size = new System.Drawing.Size(155, 344);
            this.lvSalesControl.TabIndex = 5;
            this.lvSalesControl.UseCompatibleStateImageBehavior = false;
            this.lvSalesControl.View = System.Windows.Forms.View.Tile;
            // 
            // chCarModel
            // 
            this.chCarModel.Text = "Car Model";
            this.chCarModel.Width = 0;
            // 
            // chCarName
            // 
            this.chCarName.Text = "Car Name";
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
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "folder");
            // 
            // ucSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.scMain);
            this.Name = "ucSales";
            this.Size = new System.Drawing.Size(1003, 505);
            this.Load += new System.EventHandler(this.ucSales_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.msControl.ResumeLayout(false);
            this.msControl.PerformLayout();
            this.scSub.Panel1.ResumeLayout(false);
            this.scSub.Panel1.PerformLayout();
            this.scSub.Panel2.ResumeLayout(false);
            this.scSub.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).EndInit();
            this.scSub.ResumeLayout(false);
            this.tsInventoryData.ResumeLayout(false);
            this.tsInventoryData.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ListView lvIInventoryData;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip msControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer scSub;
        private System.Windows.Forms.ToolStrip tsInventoryData;
        private System.Windows.Forms.ToolStripLabel tsslInventoryData;
        private System.Windows.Forms.ListView lvSalesData;
        private System.Windows.Forms.ColumnHeader chICode;
        private System.Windows.Forms.ColumnHeader cICarModelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreateSalesData;
        private System.Windows.Forms.ListView lvSalesControl;
        private System.Windows.Forms.ColumnHeader chCarModel;
        private System.Windows.Forms.ColumnHeader chCarName;
        private System.Windows.Forms.ColumnHeader chDetails;
        private System.Windows.Forms.ColumnHeader chDateOfPurchase;
        private System.Windows.Forms.ImageList ilMain;
    }
}
