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
                MessageBox.Show("Please Fill in the blanks");
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
            clsAccountUser auth = new clsAccountUser();
            verified = auth.authenticate(username, password);
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

    }
}
