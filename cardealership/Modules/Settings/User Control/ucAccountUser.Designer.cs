namespace cardealership.Modules.Settings.User_Control
{
    partial class ucAccountUser
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsEmployee = new System.Windows.Forms.ToolStrip();
            this.tsslEmployee = new System.Windows.Forms.ToolStripLabel();
            this.lvEmployee = new System.Windows.Forms.ListView();
            this.chEmployeeUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmplyeeFullname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmplyeeStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsmiCreate = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tsEmployee.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.splitContainer2);
            this.scMain.Panel1.Controls.Add(this.menuStrip1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tsEmployee);
            this.scMain.Panel2.Controls.Add(this.lvEmployee);
            this.scMain.Size = new System.Drawing.Size(1000, 547);
            this.scMain.SplitterDistance = 33;
            this.scMain.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 24);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(1000, 9);
            this.splitContainer2.SplitterDistance = 392;
            this.splitContainer2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCreate});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsEmployee
            // 
            this.tsEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsEmployee.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsEmployee.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsEmployee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslEmployee});
            this.tsEmployee.Location = new System.Drawing.Point(0, 485);
            this.tsEmployee.Name = "tsEmployee";
            this.tsEmployee.Size = new System.Drawing.Size(1000, 25);
            this.tsEmployee.TabIndex = 3;
            this.tsEmployee.Text = "toolStrip1";
            // 
            // tsslEmployee
            // 
            this.tsslEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsslEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.tsslEmployee.Margin = new System.Windows.Forms.Padding(3);
            this.tsslEmployee.Name = "tsslEmployee";
            this.tsslEmployee.Size = new System.Drawing.Size(78, 19);
            this.tsslEmployee.Text = "Row Count: 0";
            // 
            // lvEmployee
            // 
            this.lvEmployee.BackColor = System.Drawing.SystemColors.Window;
            this.lvEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chEmployeeUsername,
            this.chEmplyeeFullname,
            this.chEmplyeeStatus});
            this.lvEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.lvEmployee.FullRowSelect = true;
            this.lvEmployee.Location = new System.Drawing.Point(0, 0);
            this.lvEmployee.Name = "lvEmployee";
            this.lvEmployee.Size = new System.Drawing.Size(1000, 510);
            this.lvEmployee.TabIndex = 2;
            this.lvEmployee.UseCompatibleStateImageBehavior = false;
            this.lvEmployee.View = System.Windows.Forms.View.Details;
            this.lvEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LvEmployee_KeyDown);
            // 
            // chEmployeeUsername
            // 
            this.chEmployeeUsername.Text = "Username";
            this.chEmployeeUsername.Width = 150;
            // 
            // chEmplyeeFullname
            // 
            this.chEmplyeeFullname.Text = "Fullname";
            this.chEmplyeeFullname.Width = 300;
            // 
            // chEmplyeeStatus
            // 
            this.chEmplyeeStatus.Text = "Status";
            this.chEmplyeeStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.chEmplyeeStatus.Width = 100;
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
            // ucAccountUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.scMain);
            this.Name = "ucAccountUser";
            this.Size = new System.Drawing.Size(1000, 547);
            this.Load += new System.EventHandler(this.UcAccountUser_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsEmployee.ResumeLayout(false);
            this.tsEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ListView lvEmployee;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ToolStrip tsEmployee;
        private System.Windows.Forms.ToolStripLabel tsslEmployee;
        private System.Windows.Forms.ColumnHeader chEmployeeUsername;
        private System.Windows.Forms.ColumnHeader chEmplyeeFullname;
        private System.Windows.Forms.ColumnHeader chEmplyeeStatus;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreate;
    }
}
