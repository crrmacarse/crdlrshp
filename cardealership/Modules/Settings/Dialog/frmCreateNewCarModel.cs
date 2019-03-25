using System;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Settings
{
    public partial class frmCreateNewCarModel : Form
    {
        public frmCreateNewCarModel()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(txtCarModelCode.Value) || String.IsNullOrEmpty(txtCarModelName.Value))
            {
                General.showMessageBox("Warning", "Please fill in the blanks", MsgTypes.warning);
                return;
            }
      

            if(this.saveCar(txtCarModelCode.Value.Trim(), txtCarModelName.Value.Trim()))
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }

        }

        private bool saveCar(string code, string name)
        {
            clsCar car = new clsCar();
            car.Code = code;
            car.Name = name;

            if (car.save())
            {
                return true;
            }

            return false;
        }

      

    }
}
