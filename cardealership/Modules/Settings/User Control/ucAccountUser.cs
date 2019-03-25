using System.Collections.Generic;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Settings.User_Control
{
    public partial class ucAccountUser : UserControl
    {
        public ucAccountUser()
        {
            InitializeComponent();
        }

        private void UcAccountUser_Load(object sender, System.EventArgs e)
        {
            loadEmployee();
        }

        private void loadEmployee()
        {
            lvEmployee.Items.Clear();
            lvEmployee.SuspendLayout();
            List<clsAccountUser> list = new List<clsAccountUser>();

            clsAccountUser clsAccount = new clsAccountUser();
            list = clsAccount.getList();

            foreach (clsAccountUser account in list)
            {
                ListViewItem oItem = new ListViewItem();

                oItem.Text = account.Username;
                oItem.SubItems.Add(account.FullName);
                oItem.SubItems.Add(account.Status.ToString());

                oItem.Tag = account;

                lvEmployee.Items.Add(oItem);
            }

            tsslEmployee.Text = "Row Count: " + lvEmployee.Items.Count;
            lvEmployee.ResumeLayout();
        }

        private void TsmiCreate_Click(object sender, System.EventArgs e)
        {
            frmCreateNewAccountUser frm = new frmCreateNewAccountUser();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { loadEmployee(); }
        }

        private void LvEmployee_KeyDown(object sender, KeyEventArgs e)
        {
            if(lvEmployee.SelectedItems.Count != 1) { return; }

            clsAccountUser account = new clsAccountUser();

            if(e.KeyCode == Keys.Delete)
            {
                if (General.askQuestion("Delete Record", "Are you sure do you want to delete this record?", "Permanent Deletion") == DialogResult.Yes)
                {
                    if (account.delete((clsAccountUser)lvEmployee.SelectedItems[0].Tag)){
                        General.showMessageBox("Success", "Succesfully deleted the record", MsgTypes.success);
                        lvEmployee.SelectedItems[0].Remove();
                    }
                }
            }
        }
    }
}
