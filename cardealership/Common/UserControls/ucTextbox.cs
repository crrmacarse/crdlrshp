using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace cardealership.Common.UserControls
{
    public partial class ucTextbox : UserControl
    {
        private string value;

        public string Value { get { return this.value;  } set { this.value = value; } }

        public bool UseSystemPasswordChar
        {
            get { return txtValue.UseSystemPasswordChar; }
            set { txtValue.UseSystemPasswordChar = value; }
        }

        public ucTextbox()
        {
            InitializeComponent();
        }

        private void TxtValue_TextChanged(object sender, EventArgs e)
        {
            this.value = txtValue.Text;
        }

        private void UcTextbox_Load(object sender, EventArgs e)
        {
            txtValue.Text = this.value;
        }
    }
}
