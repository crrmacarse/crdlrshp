using System;
using System.Collections.Generic;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Sales
{
    public partial class frmSalesData : Form
    {
        // @03271901
        // temporary bcos i can't submit seem to pass an object of a class to form
        public int idCurrentSales { get; set; }
        public DateTime SalesControlsoldDate { get; set; }

        public frmSalesData()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void loadInventory()
        {
            cmbInventory.Items.Clear();

            List<clsInventory> list = new List<clsInventory>();

            clsInventory inventoryClass = new clsInventory();
            list = inventoryClass.getList();

            foreach (clsInventory oInventory in list)
            {
                clsComboboxItem oItem = new clsComboboxItem();
                oItem.Text = "[" + oInventory.TrackingCode + "] " + oInventory.Car.Name;
                oItem.Value = oInventory;

                cmbInventory.Items.Add(oItem);
            }
        }

        private void frmSalesData_Load(object sender, EventArgs e)
        {
            loadInventory();
        }

        private void cmbInventory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbInventory.SelectedIndex == -1) { return; }

            clsInventory currentInventory = (clsInventory)(cmbInventory.SelectedItem as clsComboboxItem).Value;
           
            this.loadSales(currentInventory);
        }

        private void loadSales(clsInventory oInventory)
        {
            lblCarModel.Text = oInventory.Car.Name;
            lblDetails.Text = oInventory.Details;
            lblSupplier.Text = oInventory.Supplier;
        }

        private bool saveSalesData(clsInventory oInventory, int idSalesControl, DateTime salescontrolsolddate)
        {
            clsSalesData oSalesData = new clsSalesData();
            oSalesData.Inventory = oInventory;
            oSalesData.idSalesControl = idSalesControl;
            oSalesData.SalesControlsoldDate = salescontrolsolddate;

            if (oSalesData.save(oInventory))
            {
                return true;
            }

            return false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (cmbInventory.SelectedIndex == -1)
            {
                General.showMessageBox("Warning", "Please fill in the blanks", MsgTypes.warning);
                return;
            }

            clsInventory currentInventory = (clsInventory)(cmbInventory.SelectedItem as clsComboboxItem).Value;

            if (this.saveSalesData(currentInventory, idCurrentSales, SalesControlsoldDate))
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
