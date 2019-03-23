using System;
using System.Drawing;
using System.Windows.Forms;

using cardealership.Common.Forms;
using Microsoft.Win32;

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

        private void Button1_Click(object sender, EventArgs e)
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
            frm.StartPosition = FormStartPosition.CenterScreen;

            frm.ShowDialog();

            this.Show();
        }

        private void FrmGenesis_Load(object sender, EventArgs e)
        {
                // read registry here

        }

        
    }
}
