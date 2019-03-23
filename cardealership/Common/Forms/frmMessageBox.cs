using System;
using System.Drawing;
using System.Windows.Forms;

namespace cardealership.Common.Forms
{
    public partial class frmMessageBox : Form
    {
        private string title;
        private string subtitle;
        private string description;
        private Image icon;

        public string Title { get { return this.title; } set { this.title = value;  } }
        public string SubTitle { get { return this.subtitle; } set { this.subtitle = value; } }
        public string Description { get { return this.description;  } set { this.description = value;  } }
        public Image IconImage { get { return this.icon; } set { this.icon = value; } }
        
        public frmMessageBox()
        {
            InitializeComponent();
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {
            lblTitle.Text = this.title;
            lblSemiTitle.Text = this.subtitle;
            lblDescription.Text = this.description;

        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void BtnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            Close();
        }

        private void FrmMessageBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = this.DialogResult;

            if (res != DialogResult.OK && res != DialogResult.Yes && res != DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
