using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using cardealership.Common.UserControls;
using cardealership.Class;

namespace cardealership.Common.Forms
{
    public partial class frmMain : Form
    {
        bool connected = false;
        List<clsMenu> listClsMenu = new List<clsMenu>();

        public enum ApplicationMenu
        {
            Inventory,
            Settings,
            Sales
        }

        public enum ApplicationState
        {
            Busy,
            Ready,
            Processing,
            SigningIn
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void initApplicatioon()
        {
            this.setApplicationState(ApplicationState.SigningIn);

            this.scMain.Visible = false;
            this.tsddbAccountUser.Visible = false;
            this.tssDivider.Visible = false;

            this.pnlMenu.Controls.Clear();

            if (!this.connected)
            {
                
                frmSignin frm = new frmSignin();
                frm.StartPosition = FormStartPosition.CenterParent;

                DialogResult result = frm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.scMain.Visible = true;
                    this.tssDivider.Visible = true;
                    this.tsddbAccountUser.Visible = true;

                    this.tsslApplicationState.Text = "Ready.";

                    // fills menu list
                    addMenu();
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }

            this.setApplicationState(ApplicationState.Ready);
        }

        private void loadMenu()
        {
            // soon add image here
            foreach (ApplicationMenu menu in Enum.GetValues(typeof(ApplicationMenu)))
            {
                clsMenu menuClass = new clsMenu();

                switch (menu.ToString())
                {
                    case "Inventory":
                        menuClass.Title = menu.ToString();
                        break;
                    case "Sales":
                        menuClass.Title = menu.ToString();
                        break;
                    case "Settings":
                        menuClass.Title = menu.ToString();
                        break;
                    default:
                        break;
                }

                if (String.IsNullOrEmpty(menuClass.Title)) { return; }

                listClsMenu.Add(menuClass);
            }

        }


        // could add account level heirarchy here
        private void addMenu()
        {
            scMain.Panel2.SuspendLayout();
        
            foreach(clsMenu menu in listClsMenu)
            {
                ucMenuItem menuItem = new ucMenuItem();
                menuItem.Caption = menu.Title;
                menuItem.Dock = DockStyle.Top;
                menuItem.BringToFront();
                //menuItem.HandleAddTabPage += this.addTabPage;

                this.pnlMenu.Controls.Add(menuItem);
            }
            
            scMain.Panel2.ResumeLayout();
        
        }

        public void addTabPage(string page) {

            foreach(TabPage item in tpPage.TabPages)
            {
                 if(item.Text == page) { tpPage.SelectedTab = item; return; }
            }

            UserControl uc = null;

            switch (page)
            {
                case "Inventory":
                    break;
                case "Sales":
                    break;
                case "Settings":
                    break;
            }

            if(uc == null) { return; }

            this.setApplicationState(ApplicationState.Busy);
            scMain.Panel2.SuspendLayout();


            scMain.Panel2.ResumeLayout();
            this.setApplicationState(ApplicationState.Ready);

        }

        public void setApplicationState(ApplicationState appstate)
        {

            switch (appstate)
            {
                case ApplicationState.Busy:
                    tsMain.BackColor = Color.FromArgb(242, 155, 26);
                    tsslApplicationState.Text = "Busy...";
                    break;
                case ApplicationState.Ready:
                    tsMain.BackColor = Color.FromArgb(233, 84, 32);
                    tsslApplicationState.Text = "Ready.";
                    break;
                case ApplicationState.Processing:
                    tsMain.BackColor = Color.FromArgb(242, 155, 26);
                    tsslApplicationState.Text = "Processing...";
                    break;
                case ApplicationState.SigningIn:
                    tsMain.BackColor = Color.FromArgb(242, 155, 26);
                    tsslApplicationState.Text = "Sign-in first..";
                    break;
                default:
                    tsMain.BackColor = Color.FromArgb(233, 84, 32);
                    break;

            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            loadMenu();

            this.initApplicatioon();
        }

        private void TsmiRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void TsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TsmiSignout_Click(object sender, EventArgs e)
        {
            this.connected = false;

            this.initApplicatioon();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            setApplicationState(ApplicationState.Busy);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmMessageBox frm = new frmMessageBox();
            frm.ShowDialog();
            setApplicationState(ApplicationState.Ready);
        }

    }
}
