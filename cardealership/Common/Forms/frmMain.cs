using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace cardealership.Common.Forms
{
    public partial class frmMain : Form
    {
        bool connected = false; 

        public frmMain()
        {
            InitializeComponent();
        }

        private void initApplicatioon()
        {
            this.scMain.Visible = false;
            this.tssDivider.Visible = false;

            this.tsslApplicationState.Text = "Sign-in first..";

            // check connection of database here;

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

                    this.tsslApplicationState.Text = "Application Ready..";
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                    this.Close();
                }
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmMessageBox frm = new frmMessageBox();
            frm.ShowDialog();

        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
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

    }
}
