using System;
using System.Windows.Forms;
using System.Data.SqlClient;

using cardealership.Class;
using System.Collections.Generic;

namespace cardealership.Modules.Inventory
{
    public partial class frmNewInventory : Form
    {
        public frmNewInventory()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void loadCarModel()
        {
            cmbCarModel.Items.Clear();

            List<clsCar> carList = new List<clsCar>();

            clsCar carClass = new clsCar();
            carList = carClass.GetCarList();

            foreach (clsCar oCar in carList)
            {
                clsComboboxItem oItem = new clsComboboxItem();
                oItem.Text = oCar.Name;
                oItem.Value = oCar;

                cmbCarModel.Items.Add(oItem);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtTrackingCode.Value) || String.IsNullOrEmpty(txtSupplier.Value)
                || String.IsNullOrEmpty(rtbDetails.Text) || cmbCarModel.SelectedIndex  == -1)
            {
                General.showMessageBox("Warning", "Please fill in the blanks", MsgTypes.warning);
                return;
            }

            clsCar car = (clsCar)(cmbCarModel.SelectedItem as clsComboboxItem).Value;
            if (this.saveinventory(car, txtTrackingCode.Value.Trim(), txtSupplier.Value.Trim(), rtbDetails.Text.Trim()))
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool saveinventory(clsCar car, string trackingcode, string supplier, string details)
        {
            clsInventory oInventory = new clsInventory();
            oInventory.Car = car;
            oInventory.TrackingCode = trackingcode;
            oInventory.Supplier = supplier;
            oInventory.Details = details;

            if (oInventory.save())
            {
                return true;
            }

            return false;
        }

        private void frmNewInventory_Load(object sender, EventArgs e)
        {
            this.loadCarModel();
        }
    }
}
