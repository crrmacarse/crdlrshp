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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsInventoryData = new System.Windows.Forms.ToolStrip();
            this.tsslInventoryData = new System.Windows.Forms.ToolStripLabel();
            this.lvInventoryControl = new System.Windows.Forms.ListView();
            this.chICode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cICarModelName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chIYearRelease = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsInventoryData.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tsInventoryData);
            this.splitContainer1.Panel2.Controls.Add(this.lvInventoryControl);
            this.splitContainer1.Size = new System.Drawing.Size(945, 471);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(945, 111);
            this.splitContainer2.SplitterDistance = 370;
            this.splitContainer2.TabIndex = 1;
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
            // tsInventoryData
            // 
            this.tsInventoryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsInventoryData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInventoryData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsInventoryData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInventoryData});
            this.tsInventoryData.Location = new System.Drawing.Point(0, 307);
            this.tsInventoryData.Name = "tsInventoryData";
            this.tsInventoryData.Size = new System.Drawing.Size(945, 25);
            this.tsInventoryData.TabIndex = 3;
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
            // lvInventoryControl
            // 
            this.lvInventoryControl.BackColor = System.Drawing.SystemColors.Window;
            this.lvInventoryControl.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chICode,
            this.cICarModelName,
            this.chIYearRelease});
            this.lvInventoryControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInventoryControl.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvInventoryControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvInventoryControl.FullRowSelect = true;
            this.lvInventoryControl.Location = new System.Drawing.Point(0, 0);
            this.lvInventoryControl.Name = "lvInventoryControl";
            this.lvInventoryControl.Size = new System.Drawing.Size(945, 332);
            this.lvInventoryControl.TabIndex = 2;
            this.lvInventoryControl.UseCompatibleStateImageBehavior = false;
            this.lvInventoryControl.View = System.Windows.Forms.View.Details;
            // 
            // chICode
            // 
            this.chICode.Text = "Inventory Code";
            this.chICode.Width = 150;
            // 
            // cICarModelName
            // 
            this.cICarModelName.Text = "Car Model";
            this.cICarModelName.Width = 350;
            // 
            // chIYearRelease
            // 
            this.chIYearRelease.Text = "Year Release";
            this.chIYearRelease.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chIYearRelease.Width = 120;
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
            // ucCarModel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ucCarModel";
            this.Size = new System.Drawing.Size(945, 471);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsInventoryData.ResumeLayout(false);
            this.tsInventoryData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip tsInventoryData;
        private System.Windows.Forms.ToolStripLabel tsslInventoryData;
        private System.Windows.Forms.ListView lvInventoryControl;
        private System.Windows.Forms.ColumnHeader chICode;
        private System.Windows.Forms.ColumnHeader cICarModelName;
        private System.Windows.Forms.ColumnHeader chIYearRelease;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
    }
}
