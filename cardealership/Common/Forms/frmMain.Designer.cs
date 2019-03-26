namespace cardealership.Common.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsddbAccountUser = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSignout = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiRestart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tssDivider = new System.Windows.Forms.ToolStripSeparator();
            this.tsslApplicationState = new System.Windows.Forms.ToolStripLabel();
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tpPage = new System.Windows.Forms.TabControl();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.tsMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsddbAccountUser,
            this.tssDivider,
            this.tsslApplicationState});
            this.tsMain.Location = new System.Drawing.Point(0, 638);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1194, 25);
            this.tsMain.TabIndex = 1;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsddbAccountUser
            // 
            this.tsddbAccountUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddbAccountUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout,
            this.tsmiPreferences,
            this.tsmiSettings,
            this.tsmiSignout,
            this.tssSeparator,
            this.tsmiRestart,
            this.tsmiExit});
            this.tsddbAccountUser.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsddbAccountUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.tsddbAccountUser.Image = ((System.Drawing.Image)(resources.GetObject("tsddbAccountUser.Image")));
            this.tsddbAccountUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddbAccountUser.Margin = new System.Windows.Forms.Padding(3);
            this.tsddbAccountUser.Name = "tsddbAccountUser";
            this.tsddbAccountUser.Size = new System.Drawing.Size(83, 23);
            this.tsddbAccountUser.Text = "@username";
            this.tsddbAccountUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tsddbAccountUser.Visible = false;
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiAbout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(135, 22);
            this.tsmiAbout.Text = "About";
            this.tsmiAbout.Click += new System.EventHandler(this.TsmiAbout_Click);
            // 
            // tsmiPreferences
            // 
            this.tsmiPreferences.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiPreferences.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsmiPreferences.Name = "tsmiPreferences";
            this.tsmiPreferences.Size = new System.Drawing.Size(135, 22);
            this.tsmiPreferences.Text = "Preferences";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsmiSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(135, 22);
            this.tsmiSettings.Text = "Settings";
            // 
            // tsmiSignout
            // 
            this.tsmiSignout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsmiSignout.Name = "tsmiSignout";
            this.tsmiSignout.Size = new System.Drawing.Size(135, 22);
            this.tsmiSignout.Text = "Sign-out";
            this.tsmiSignout.Click += new System.EventHandler(this.TsmiSignout_Click);
            // 
            // tssSeparator
            // 
            this.tssSeparator.Name = "tssSeparator";
            this.tssSeparator.Size = new System.Drawing.Size(132, 6);
            // 
            // tsmiRestart
            // 
            this.tsmiRestart.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiRestart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsmiRestart.Name = "tsmiRestart";
            this.tsmiRestart.Size = new System.Drawing.Size(135, 22);
            this.tsmiRestart.Text = "Restart";
            this.tsmiRestart.Click += new System.EventHandler(this.TsmiRestart_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(135, 22);
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.TsmiExit_Click);
            // 
            // tssDivider
            // 
            this.tssDivider.ForeColor = System.Drawing.Color.LightGray;
            this.tssDivider.Margin = new System.Windows.Forms.Padding(3);
            this.tssDivider.Name = "tssDivider";
            this.tssDivider.Size = new System.Drawing.Size(6, 23);
            this.tssDivider.Visible = false;
            // 
            // tsslApplicationState
            // 
            this.tsslApplicationState.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tsslApplicationState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.tsslApplicationState.Margin = new System.Windows.Forms.Padding(3);
            this.tsslApplicationState.Name = "tsslApplicationState";
            this.tsslApplicationState.Size = new System.Drawing.Size(75, 19);
            this.tsslApplicationState.Text = "Sign-in first..";
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "inventory");
            this.ilMain.Images.SetKeyName(1, "sales");
            this.ilMain.Images.SetKeyName(2, "settings");
            // 
            // scMain
            // 
            this.scMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.scMain.Panel1.Controls.Add(this.pnlMenu);
            this.scMain.Panel1.Controls.Add(this.panel2);
            this.scMain.Panel1.Controls.Add(this.pnlTitle);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scMain.Panel2.Controls.Add(this.tpPage);
            this.scMain.Size = new System.Drawing.Size(1194, 638);
            this.scMain.SplitterDistance = 174;
            this.scMain.TabIndex = 2;
            this.scMain.Visible = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMenu.Location = new System.Drawing.Point(0, 88);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(174, 550);
            this.pnlMenu.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 1);
            this.panel2.TabIndex = 38;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(84)))), ((int)(((byte)(32)))));
            this.pnlTitle.Controls.Add(this.label3);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(174, 87);
            this.pnlTitle.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.label3.Location = new System.Drawing.Point(11, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 35;
            this.label3.Text = "Car Dealership Project v1.1.0";
            // 
            // tpPage
            // 
            this.tpPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpPage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPage.Location = new System.Drawing.Point(0, 0);
            this.tpPage.Name = "tpPage";
            this.tpPage.SelectedIndex = 0;
            this.tpPage.Size = new System.Drawing.Size(1016, 638);
            this.tpPage.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1194, 663);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.tsMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripSeparator tssDivider;
        private System.Windows.Forms.ToolStripLabel tsslApplicationState;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.TabControl tpPage;
        private System.Windows.Forms.ToolStripDropDownButton tsddbAccountUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestart;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiPreferences;
        private System.Windows.Forms.ToolStripSeparator tssSeparator;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiSignout;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.ImageList ilMain;
    }
}