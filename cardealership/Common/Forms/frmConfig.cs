using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace cardealership.Common.Forms
{
    public partial class frmConfig : Form
    {

        RegistryKey MainKey = Registry.CurrentUser;
        string sKey = @"Software\CPUSTIK";
        

        public frmConfig()
        {
            InitializeComponent();
        }

        public bool ProcessRegistry()
        {

            if(this.ReadRegistryKey("SQLServer") == string.Empty) {
                return false;
            }
            else {
                txtSQLServer.Text = this.ReadRegistryKey("SQLServer");
            }

            if(this.ReadRegistryKey("SQLDatabase") == string.Empty)
            {
                return false;
            }
            else
            {
                txtDatabase.Value = this.ReadRegistryKey("SQLDatabase");
            }

            if(this.ReadRegistryKey("SQLUsername") == string.Empty)
            {
                return false;
            }
            else
            {
                txtUserName.Value = this.ReadRegistryKey("SQLUsername");
            }

            if(this.ReadRegistryKey("SQLPassword ") == string.Empty)
            {
                return false;
            }
            else
            {
                txtPassword.Value = this.ReadRegistryKey("SQLPassword");
            }

            return true;
        }

        public bool CreateRegistrySubKey()
        {
            RegistryKeyPermissionCheck KeyPermissions;
            KeyPermissions = RegistryKeyPermissionCheck.Default;

            try
            {
                MainKey.CreateSubKey(sKey, KeyPermissions);
                return true;
            }
            catch (Exception ex)
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
                if (rkKey == null)
                {
                    CreateRegistrySubKey();
                }

                val = rkKey.GetValue(sKeyName).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return val;
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
