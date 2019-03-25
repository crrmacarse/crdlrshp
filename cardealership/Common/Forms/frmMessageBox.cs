using System;
using System.Drawing;
using System.Windows.Forms;


namespace cardealership.Common.Forms
{
    public partial class frmMessageBox : Form
    {
        private string title;
        private string subtitle = "";
        private string description;
        private string msgtype;
        private Image icon;

        public string Title { get { return this.title; } set { this.title = value;  } }
        public string SubTitle { get { return this.subtitle; } set { this.subtitle = value; } }
        public string Description { get { return this.description;  } set { this.description = value;  } }
        public string MsgType { get { return this.msgtype; } set { this.msgtype = value; } }
        public Image IconImage { get { return this.icon; } set { this.icon = value; } }

        
        public frmMessageBox()
        {
            InitializeComponent();

        }

        public frmMessageBox(string title, string description, string msgtype = "info", string subtitle = "")
        {
            this.title = title;
            this.subtitle = subtitle;
            this.description = description;

            InitializeComponent();
        }

        private void processRequest()
        { 
            switch (this.msgtype)
            {
                case "info":
                    lblTitle.ForeColor = Color.FromArgb(25, 182, 238);
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.FromArgb(25, 182, 238);
                    break;
                case "danger":
                    lblTitle.ForeColor = Color.FromArgb(220, 53, 69);
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.FromArgb(220, 53, 69);
                    break;
                case "warning":
                    lblTitle.ForeColor = Color.FromArgb(242, 155, 26);
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.FromArgb(242, 155, 26);
                    break;
                case "question":
                    lblTitle.ForeColor = Color.FromArgb(233, 84, 32);
                    btnYes.Visible = true;
                    btnNo.Visible = true;
                    break;
                case "success":
                    lblTitle.ForeColor = Color.FromArgb(82, 179, 79);
                    btnOk.Visible = true;
                    btnOk.BackColor = Color.FromArgb(82, 179, 79);
                    break;
                default:
                    lblTitle.ForeColor = Color.FromArgb(232, 85, 36);
                    btnOk.BackColor = Color.FromArgb(232, 85, 36);
                    break;
            }
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {
            this.processRequest();

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
