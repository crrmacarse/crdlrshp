using System;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Settings
{
    public partial class frmCreateNewAccountUser : Form
    {
        public frmCreateNewAccountUser()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUsername.Value) || string.IsNullOrEmpty(txtPassword.Value) || string.IsNullOrEmpty(txtFirstName.Value)
                || string.IsNullOrEmpty(txtMiddleName.Value) || string.IsNullOrEmpty(txtLastName.Value)){
                General.showMessageBox("Warning", "Please fill in the blanks", MsgTypes.warning);
                return;
            }

            if(this.saveAccount(txtUsername.Value.Trim(), txtPassword.Value.Trim(), txtFirstName.Value.Trim(), 
                txtMiddleName.Value.Trim(), txtLastName.Value.Trim())){
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool saveAccount(string username, string password, string firstname, string middlename, string lastname)
        {
            clsAccountUser account = new clsAccountUser();
            account.Username = username;
            account.Password = password;
            account.Firstname = firstname;
            account.Middlename = middlename;
            account.Lastname = lastname;

            if (account.save())
            {
                return true;
            }

            return false;
        }
    }
}
