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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.tsInventoryData = new System.Windows.Forms.ToolStrip();
            this.tsslInventoryData = new System.Windows.Forms.ToolStripLabel();
            this.scSub = new System.Windows.Forms.SplitContainer();
            this.msControl = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.lvIInventoryData = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.scInfo = new System.Windows.Forms.SplitContainer();
            this.colInventoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCarModel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAdjustment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscrepancy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClosed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tsInventoryData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).BeginInit();
            this.scSub.Panel1.SuspendLayout();
            this.scSub.Panel2.SuspendLayout();
            this.scSub.SuspendLayout();
            this.msControl.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scInfo)).BeginInit();
            this.scInfo.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.lvIInventoryData);
            this.scMain.Panel1.Controls.Add(this.pnlMain);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.scMain.Panel2.Controls.Add(this.scSub);
            this.scMain.Size = new System.Drawing.Size(1003, 505);
            this.scMain.SplitterDistance = 170;
            this.scMain.TabIndex = 0;
            // 
            // tsInventoryData
            // 
            this.tsInventoryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsInventoryData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsInventoryData.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsInventoryData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInventoryData});
            this.tsInventoryData.Location = new System.Drawing.Point(0, 332);
            this.tsInventoryData.Name = "tsInventoryData";
            this.tsInventoryData.Size = new System.Drawing.Size(829, 25);
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
            this.scSub.Panel2.Controls.Add(this.dataGridView1);
            this.scSub.Panel2.Controls.Add(this.tsInventoryData);
            this.scSub.Size = new System.Drawing.Size(829, 505);
            this.scSub.SplitterDistance = 144;
            this.scSub.TabIndex = 0;
            // 
            // msControl
            // 
            this.msControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(62)))));
            this.msControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.msControl.Location = new System.Drawing.Point(0, 0);
            this.msControl.Name = "msControl";
            this.msControl.Size = new System.Drawing.Size(170, 24);
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
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.pnlMain.Controls.Add(this.msControl);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(170, 136);
            this.pnlMain.TabIndex = 0;
            // 
            // lvIInventoryData
            // 
            this.lvIInventoryData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvIInventoryData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvIInventoryData.Location = new System.Drawing.Point(0, 136);
            this.lvIInventoryData.Name = "lvIInventoryData";
            this.lvIInventoryData.Size = new System.Drawing.Size(170, 369);
            this.lvIInventoryData.TabIndex = 0;
            this.lvIInventoryData.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInventoryCode,
            this.colCarModel,
            this.colStart,
            this.colSold,
            this.colEnd,
            this.colAdjustment,
            this.colDiscrepancy,
            this.colClosed});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(829, 332);
            this.dataGridView1.TabIndex = 3;
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
            this.scInfo.Size = new System.Drawing.Size(829, 144);
            this.scInfo.SplitterDistance = 489;
            this.scInfo.TabIndex = 0;
            // 
            // colInventoryCode
            // 
            this.colInventoryCode.HeaderText = "Inventory Code";
            this.colInventoryCode.Name = "colInventoryCode";
            this.colInventoryCode.Width = 200;
            // 
            // colCarModel
            // 
            this.colCarModel.HeaderText = "Car Model";
            this.colCarModel.Name = "colCarModel";
            this.colCarModel.Width = 400;
            // 
            // colStart
            // 
            this.colStart.HeaderText = "Start";
            this.colStart.Name = "colStart";
            // 
            // colSold
            // 
            this.colSold.HeaderText = "Sold";
            this.colSold.Name = "colSold";
            // 
            // colEnd
            // 
            this.colEnd.HeaderText = "End";
            this.colEnd.Name = "colEnd";
            // 
            // colAdjustment
            // 
            this.colAdjustment.HeaderText = "Adjustment";
            this.colAdjustment.Name = "colAdjustment";
            this.colAdjustment.Width = 130;
            // 
            // colDiscrepancy
            // 
            this.colDiscrepancy.HeaderText = "Discrepancy";
            this.colDiscrepancy.Name = "colDiscrepancy";
            this.colDiscrepancy.Width = 130;
            // 
            // colClosed
            // 
            this.colClosed.HeaderText = "Closed";
            this.colClosed.Name = "colClosed";
            this.colClosed.Width = 110;
            // 
            // ucInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.scMain);
            this.Name = "ucInventory";
            this.Size = new System.Drawing.Size(1003, 505);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tsInventoryData.ResumeLayout(false);
            this.tsInventoryData.PerformLayout();
            this.scSub.Panel1.ResumeLayout(false);
            this.scSub.Panel2.ResumeLayout(false);
            this.scSub.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSub)).EndInit();
            this.scSub.ResumeLayout(false);
            this.msControl.ResumeLayout(false);
            this.msControl.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scInfo)).EndInit();
            this.scInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ListView lvIInventoryData;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip msControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.SplitContainer scSub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsInventoryData;
        private System.Windows.Forms.ToolStripLabel tsslInventoryData;
        private System.Windows.Forms.SplitContainer scInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInventoryCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCarModel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAdjustment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiscrepancy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClosed;
    }
}
