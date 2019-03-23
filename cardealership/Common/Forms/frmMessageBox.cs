using System;
using System.Windows.Forms;

namespace cardealership.Common.Forms
{
    public partial class frmMessageBox : Form
    {
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {

        }
    }
}
