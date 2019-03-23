using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            // sign in method here
            verified = true;

            this.DialogResult = DialogResult.OK;
            this.Close();
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
