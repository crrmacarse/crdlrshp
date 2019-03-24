namespace cardealership.Modules.Settings
{
    partial class ucSettings
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpAccounts = new System.Windows.Forms.TabPage();
            this.tpCarModel = new System.Windows.Forms.TabPage();
            this.ucAccountUser1 = new cardealership.Modules.Settings.User_Control.ucAccountUser();
            this.ucCarModel1 = new cardealership.Modules.Settings.User_Control.ucCarModel();
            this.panel1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpAccounts.SuspendLayout();
            this.tpCarModel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.tabControl2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 580);
            this.panel1.TabIndex = 3;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tpAccounts);
            this.tabControl2.Controls.Add(this.tpCarModel);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1008, 580);
            this.tabControl2.TabIndex = 2;
            // 
            // tpAccounts
            // 
            this.tpAccounts.Controls.Add(this.ucAccountUser1);
            this.tpAccounts.Location = new System.Drawing.Point(4, 29);
            this.tpAccounts.Name = "tpAccounts";
            this.tpAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccounts.Size = new System.Drawing.Size(1000, 547);
            this.tpAccounts.TabIndex = 0;
            this.tpAccounts.Text = "Accounts";
            this.tpAccounts.UseVisualStyleBackColor = true;
            // 
            // tpCarModel
            // 
            this.tpCarModel.Controls.Add(this.ucCarModel1);
            this.tpCarModel.Location = new System.Drawing.Point(4, 29);
            this.tpCarModel.Name = "tpCarModel";
            this.tpCarModel.Padding = new System.Windows.Forms.Padding(3);
            this.tpCarModel.Size = new System.Drawing.Size(1000, 547);
            this.tpCarModel.TabIndex = 1;
            this.tpCarModel.Text = "Car Models";
            this.tpCarModel.UseVisualStyleBackColor = true;
            // 
            // ucAccountUser1
            // 
            this.ucAccountUser1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.ucAccountUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAccountUser1.Location = new System.Drawing.Point(3, 3);
            this.ucAccountUser1.Name = "ucAccountUser1";
            this.ucAccountUser1.Size = new System.Drawing.Size(994, 541);
            this.ucAccountUser1.TabIndex = 0;
            // 
            // ucCarModel1
            // 
            this.ucCarModel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCarModel1.Location = new System.Drawing.Point(3, 3);
            this.ucCarModel1.Name = "ucCarModel1";
            this.ucCarModel1.Size = new System.Drawing.Size(994, 541);
            this.ucCarModel1.TabIndex = 0;
            // 
            // ucSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ucSettings";
            this.Size = new System.Drawing.Size(1008, 604);
            this.panel1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpAccounts.ResumeLayout(false);
            this.tpCarModel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpAccounts;
        private System.Windows.Forms.TabPage tpCarModel;
        private User_Control.ucCarModel ucCarModel1;
        private User_Control.ucAccountUser ucAccountUser1;
    }
}
