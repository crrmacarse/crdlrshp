using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

using cardealership.Class;
using cardealership.Common.Forms;

namespace cardealership
{
    public partial class frmGenesis : Form
    {

        public frmGenesis()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
           
            this.Hide();

            frmMain frm = new frmMain();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);

            DialogResult result = frm.ShowDialog();

            if (result == DialogResult.Abort)
            {
                this.Show();
            }
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmConfig frm = new frmConfig();
            //frm.ProcessRegistry();
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

            this.Show();
        }

        private void FrmGenesis_Load(object sender, EventArgs e)
        {
            // pass connection string here
            clsConnection con = new clsConnection();
            con.TestConnection();
            

            // read registry here
        }

        RegistryKey MainKey = Registry.CurrentUser;
        string sKey = @"Software\CPUSTIK";

        public bool CreateRegistrySubKey()
        {
            RegistryKeyPermissionCheck KeyPermissions;
            KeyPermissions = RegistryKeyPermissionCheck.Default;

            try
            {
                MainKey.CreateSubKey(sKey, KeyPermissions);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public string ReadRegistryKey(string sKeyName)
        {
            RegistryKey rkKey;
            string val = string.Empty;

            try
            {
                rkKey = MainKey.OpenSubKey(sKeyName, true);
                if(rkKey == null)
                {
                    CreateRegistrySubKey();
                }

                val = rkKey.GetValue(sKeyName).ToString() ;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }



        
    }
}
