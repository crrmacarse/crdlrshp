using System;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Common
{
    public partial class frmSignin : Form
    {
        bool verified = false;

        public frmSignin()
        {
            InitializeComponent();
        }

        private void BtnSignin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Value) || String.IsNullOrEmpty(txtPassword.Value))
            {
                General.showMessageBox("Warning", "Please fill in the blanks", MsgTypes.warning, "Sign-in Error");
           }
            else
            {
                string username = txtUsername.Value.Trim();
                string password = txtPassword.Value.Trim();
                verifyAccount(username, password);
            }

        }

        private void verifyAccount(string username, string password)
        {
            verified = General.VerifyAccount(username, password);

            if (verified)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtPassword.Value = String.Empty;
                txtPassword.Focus();
            }
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void FrmSignin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!verified && this.DialogResult != DialogResult.Abort)
            {
                e.Cancel = true;
            }
        }

        private void FrmSignin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSignin.PerformClick();
            }
        }
    }
}
