using System;
using System.Drawing;
using System.Windows.Forms;

namespace cardealership.Common.UserControls
{
    public partial class ucMenuItem : UserControl
    {
        private string caption;
        private Image icon;

        //public event EventHandler HandleAddTabPage;

        public ucMenuItem()
        {
            InitializeComponent();
        }

        public string Caption { get { return this.caption; } set { this.caption = value; } }

        public Image Icon { get { return this.icon; } set { this.icon = value; } }

        private void UcMenuItem_Load(object sender, System.EventArgs e)
        {
            lblCaption.Text = this.caption;
            pbIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pbIcon.Image = this.icon;
        }

        private void UC_Click(object sender, System.EventArgs e)
        {

            // call parent addtabPage()
            MessageBox.Show("Hello world");
        }



    }
}