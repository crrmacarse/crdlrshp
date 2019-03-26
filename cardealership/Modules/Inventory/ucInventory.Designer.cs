namespace cardealership.Modules.Inventory
{
    partial class ucInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucInventory));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lvCarModel = new System.Windows.Forms.ListView();
            this.chCarModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCarName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.msControl = new System.Windows.Forms.MenuStrip();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.scSub = new System.Windows.Forms.SplitContainer();
            this.scInfo = new System.Windows.Forms.SplitContainer();
            this.lvInventory = new System.Windows.Forms.ListView();
            this.chICode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDetails = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSupplier = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsInventoryData = new System.Windows.Forms.ToolStrip();
            this.tsslInventoryAvailableStocks = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.msControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).BeginInit();
            this.scSub.Panel1.SuspendLayout();
            this.scSub.Panel2.SuspendLayout();
            this.scSub.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scInfo)).BeginInit();
            this.scInfo.SuspendLayout();
            this.tsInventoryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.lvCarModel);
            this.scMain.Panel1.Controls.Add(this.msControl);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Panel2.Controls.Add(this.scSub);
            this.scMain.Size = new System.Drawing.Size(1003, 505);
            this.scMain.SplitterDistance = 170;
            this.scMain.TabIndex = 0;
            // 
            // lvCarModel
            // 
            this.lvCarModel.BackColor = System.Drawing.SystemColors.Window;
            this.lvCarModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCarModel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCarModel,
            this.chCarName});
            this.lvCarModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCarModel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCarModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvCarModel.FullRowSelect = true;
            this.lvCarModel.LargeImageList = this.ilMain;
            this.lvCarModel.Location = new System.Drawing.Point(0, 24);
            this.lvCarModel.Name = "lvCarModel";
            this.lvCarModel.Size = new System.Drawing.Size(170, 481);
            this.lvCarModel.SmallImageList = this.ilMain;
            this.lvCarModel.TabIndex = 4;
            this.lvCarModel.UseCompatibleStateImageBehavior = false;
            this.lvCarModel.View = System.Windows.Forms.View.Tile;
            this.lvCarModel.SelectedIndexChanged += new System.EventHandler(this.LvCarModel_SelectedIndexChanged);
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
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "folder");
            // 
            // msControl
            // 
            this.msControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.msControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNew});
            this.msControl.Location = new System.Drawing.Point(0, 0);
            this.msControl.Name = "msControl";
            this.msControl.Size = new System.Drawing.Size(170, 24);
            this.msControl.TabIndex = 3;
            this.msControl.Text = "menuStrip1";
            // 
            // tsmiNew
            // 
            this.tsmiNew.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiNew.ForeColor = System.Drawing.Color.White;
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(43, 20);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // scSub
            // 
            this.scSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSub.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scSub.Location = new System.Drawing.Point(0, 0);
            this.scSub.Name = "scSub";
            this.scSub.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scSub.Panel1
            // 
            this.scSub.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.scSub.Panel1.Controls.Add(this.scInfo);
            // 
            // scSub.Panel2
            // 
            this.scSub.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.scSub.Panel2.Controls.Add(this.lvInventory);
            this.scSub.Panel2.Controls.Add(this.tsInventoryData);
            this.scSub.Size = new System.Drawing.Size(829, 505);
            this.scSub.SplitterDistance = 25;
            this.scSub.TabIndex = 0;
            // 
            // scInfo
            // 
            this.scInfo.BackColor = System.Drawing.Color.Gainsboro;
            this.scInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scInfo.IsSplitterFixed = true;
            this.scInfo.Location = new System.Drawing.Point(0, 0);
            this.scInfo.Name = "scInfo";
            // 
            // scInfo.Panel1
            // 
            this.scInfo.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            // 
            // scInfo.Panel2
            // 
            this.scInfo.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.scInfo.Size = new System.Drawing.Size(829, 25);
            this.scInfo.SplitterDistance = 489;
            this.scInfo.TabIndex = 0;
            // 
            // lvInventory
            // 
            this.lvInventory.BackColor = System.Drawing.SystemColors.Window;
            this.lvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chICode,
            this.chDetails,
            this.chSupplier});
            this.lvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvInventory.FullRowSelect = true;
            this.lvInventory.Location = new System.Drawing.Point(0, 0);
            this.lvInventory.Name = "lvInventory";
            this.lvInventory.Size = new System.Drawing.Size(829, 451);
            this.lvInventory.TabIndex = 3;
            this.lvInventory.UseCompatibleStateImageBehavior = false;
            this.lvInventory.View = System.Windows.Forms.View.Details;
            this.lvInventory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvInventory_KeyDown);
            // 
            // chICode
            // 
            this.chICode.Text = "Inventory Tracking Code";
            this.chICode.Width = 200;
            // 
            // chDetails
            // 
            this.chDetails.Text = "Car Model Details";
            this.chDetails.Width = 400;
            // 
            // chSupplier
            // 
            this.chSupplier.Text = "Supplier";
            this.chSupplier.Width = 150;
            // 
            // tsInventoryData
            // 
            this.tsInventoryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsInventoryData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInventoryData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsInventoryData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInventoryAvailableStocks});
            this.tsInventoryData.Location = new System.Drawing.Point(0, 451);
            this.tsInventoryData.Name = "tsInventoryData";
            this.tsInventoryData.Size = new System.Drawing.Size(829, 25);
            this.tsInventoryData.TabIndex = 2;
            this.tsInventoryData.Text = "toolStrip1";
            // 
            // tsslInventoryAvailableStocks
            // 
            this.tsslInventoryAvailableStocks.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsslInventoryAvailableStocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.tsslInventoryAvailableStocks.Margin = new System.Windows.Forms.Padding(3);
            this.tsslInventoryAvailableStocks.Name = "tsslInventoryAvailableStocks";
            this.tsslInventoryAvailableStocks.Size = new System.Drawing.Size(106, 19);
            this.tsslInventoryAvailableStocks.Text = "Available Stocks: 0";
            // 
            // ucInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.scMain);
            this.Name = "ucInventory";
            this.Size = new System.Drawing.Size(1003, 505);
            this.Load += new System.EventHandler(this.UcInventory_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.msControl.ResumeLayout(false);
            this.msControl.PerformLayout();
            this.scSub.Panel1.ResumeLayout(false);
            this.scSub.Panel2.ResumeLayout(false);
            this.scSub.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).EndInit();
            this.scSub.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scInfo)).EndInit();
            this.scInfo.ResumeLayout(false);
            this.tsInventoryData.ResumeLayout(false);
            this.tsInventoryData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scSub;
        private System.Windows.Forms.ToolStrip tsInventoryData;
        private System.Windows.Forms.ToolStripLabel tsslInventoryAvailableStocks;
        private System.Windows.Forms.SplitContainer scInfo;
        private System.Windows.Forms.MenuStrip msControl;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ListView lvInventory;
        private System.Windows.Forms.ColumnHeader chICode;
        private System.Windows.Forms.ColumnHeader chDetails;
        private System.Windows.Forms.ColumnHeader chSupplier;
        private System.Windows.Forms.ListView lvCarModel;
        private System.Windows.Forms.ColumnHeader chCarModel;
        private System.Windows.Forms.ImageList ilMain;
        private System.Windows.Forms.ColumnHeader chCarName;
    }
}
