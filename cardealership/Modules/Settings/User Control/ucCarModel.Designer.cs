namespace cardealership.Modules.Settings.User_Control
{
    partial class ucCarModel
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCarModel = new System.Windows.Forms.ToolStrip();
            this.tsslCarModelCount = new System.Windows.Forms.ToolStripLabel();
            this.lvCarModel = new System.Windows.Forms.ListView();
            this.chCarModelCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cICarModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsCarModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.scMain.Panel1.Controls.Add(this.menuStrip1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tsCarModel);
            this.scMain.Panel2.Controls.Add(this.lvCarModel);
            this.scMain.Size = new System.Drawing.Size(945, 471);
            this.scMain.SplitterDistance = 32;
            this.scMain.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiCreate
            // 
            this.tsmiCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiCreate.ForeColor = System.Drawing.Color.White;
            this.tsmiCreate.Name = "tsmiCreate";
            this.tsmiCreate.Size = new System.Drawing.Size(52, 20);
            this.tsmiCreate.Text = "Create";
            this.tsmiCreate.Click += new System.EventHandler(this.TsmiCreate_Click);
            // 
            // tsCarModel
            // 
            this.tsCarModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsCarModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsCarModel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCarModel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslCarModelCount});
            this.tsCarModel.Location = new System.Drawing.Point(0, 410);
            this.tsCarModel.Name = "tsCarModel";
            this.tsCarModel.Size = new System.Drawing.Size(945, 25);
            this.tsCarModel.TabIndex = 3;
            this.tsCarModel.Text = "toolStrip1";
            // 
            // tsslCarModelCount
            // 
            this.tsslCarModelCount.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsslCarModelCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.tsslCarModelCount.Margin = new System.Windows.Forms.Padding(3);
            this.tsslCarModelCount.Name = "tsslCarModelCount";
            this.tsslCarModelCount.Size = new System.Drawing.Size(78, 19);
            this.tsslCarModelCount.Text = "Row Count: 0";
            // 
            // lvCarModel
            // 
            this.lvCarModel.BackColor = System.Drawing.SystemColors.Window;
            this.lvCarModel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCarModelCode,
            this.cICarModelName,
            this.chStatus});
            this.lvCarModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCarModel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCarModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvCarModel.FullRowSelect = true;
            this.lvCarModel.Location = new System.Drawing.Point(0, 0);
            this.lvCarModel.Name = "lvCarModel";
            this.lvCarModel.Size = new System.Drawing.Size(945, 435);
            this.lvCarModel.TabIndex = 2;
            this.lvCarModel.UseCompatibleStateImageBehavior = false;
            this.lvCarModel.View = System.Windows.Forms.View.Details;
            this.lvCarModel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvCarModel_KeyDown);
            // 
            // chCarModelCode
            // 
            this.chCarModelCode.Text = "Inventory Code";
            this.chCarModelCode.Width = 150;
            // 
            // cICarModelName
            // 
            this.cICarModelName.Text = "Car Model";
            this.cICarModelName.Width = 350;
            // 
            // chStatus
            // 
            this.chStatus.Text = "Status";
            this.chStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chStatus.Width = 100;
            // 
            // ucCarModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Name = "ucCarModel";
            this.Size = new System.Drawing.Size(945, 471);
            this.Load += new System.EventHandler(this.UcCarModel_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsCarModel.ResumeLayout(false);
            this.tsCarModel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip tsCarModel;
        private System.Windows.Forms.ToolStripLabel tsslCarModelCount;
        private System.Windows.Forms.ListView lvCarModel;
        private System.Windows.Forms.ColumnHeader chCarModelCode;
        private System.Windows.Forms.ColumnHeader cICarModelName;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
        private System.Windows.Forms.ColumnHeader chStatus;
    }
}
