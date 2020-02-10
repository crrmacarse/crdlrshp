using System;
using System.Collections.Generic;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Sales
{
    public partial class ucSales : UserControl
    {
        public ucSales()
        {
            InitializeComponent();
        }

        private void tsmiCreateSalesData_Click(object sender, System.EventArgs e)
        {
            if(lvSalesControl.SelectedItems.Count != 1) { General.showMessageBox("Warning", "Please select first a Receipt", MsgTypes.warning); return; }
            
            // @03271901 : root of the problem can't pass the sales data
            clsSales currentSalesControl = (clsSales)this.lvSalesControl.SelectedItems[0].Tag;

            frmSalesData frm = new frmSalesData();
            frm.idCurrentSales = currentSalesControl.ID;
            frm.SalesControlsoldDate = currentSalesControl.DateOfPurchase;       

            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { lvSalesData.Items.Clear(); General.showMessageBox("Succes", "Sucesfully added new record", MsgTypes.success); }
        }

        private void loadSalesControl(DateTime from, DateTime to)
        {
            lvSalesControl.Items.Clear();
            lvSalesControl.SuspendLayout();
            List<clsSales> list = new List<clsSales>();

            clsSales salesClass = new clsSales();
            list = salesClass.getSales(from, to);

            foreach (clsSales oSales in list)
            {
                ListViewItem oItem = new ListViewItem();

                oItem.Text = "[" + oSales.DateOfPurchase.ToString("MMM-dd-yyyy") + "] " + oSales.Code;
                oItem.SubItems.Add(oSales.CustFullName);
                oItem.ImageKey = "folder";

                oItem.Tag = oSales;

                lvSalesControl.Items.Add(oItem);
            }

            lvSalesControl.ResumeLayout();
        }

        private void loadSalesData(clsSales oSales)
        {
            lvSalesData.Items.Clear();
            lvSalesData.SuspendLayout();
            List<clsSalesData> list = new List<clsSalesData>();

            clsSalesData salesDataClass = new clsSalesData();
            list = salesDataClass.getSalesData(oSales);

            foreach (clsSalesData clsSalesData in list)
            {
                ListViewItem oItem = new ListViewItem();

                oItem.Text = clsSalesData.Inventory.TrackingCode;
                oItem.SubItems.Add(clsSalesData.Inventory.Car.Name);
                oItem.SubItems.Add(clsSalesData.Inventory.Details);
                oItem.SubItems.Add(clsSalesData.Inventory.SoldDate.ToString("MMM dd, yyyy"));
                oItem.ImageKey = "folder";

                oItem.Tag = clsSalesData;

                lvSalesData.Items.Add(oItem);
            }

            lvSalesData.ResumeLayout();
        }

        private void btnGenerate_Click(object sender, System.EventArgs e)
        {
            if(dtFrom.Value.Date > dtTo.Value.Date)
            {
                General.showMessageBox("Warning", "Date to must be higher than date from", MsgTypes.warning);
                return;
            }

            this.loadSalesControl(dtFrom.Value.Date, dtTo.Value.Date);
        }

        private void lvSalesControl_DoubleClick(object sender, EventArgs e)
        {
            if(lvSalesControl.SelectedItems.Count != 1) { return; }

            this.loadSalesData((clsSales)this.lvSalesControl.SelectedItems[0].Tag);
        }

        private void tsmiNewSales_Click(object sender, EventArgs e)
        {
            frmNewSales frm = new frmNewSales();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { this.loadSalesControl(dtFrom.Value.Date, dtTo.Value.Date); lvSalesData.Items.Clear(); General.showMessageBox("Succes", "Sucesfully added new record", MsgTypes.success); }
        }

        private void lvSalesControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (lvSalesControl.SelectedItems.Count != 1) { return; }

            clsSales oSales = new clsSales();

            if (e.KeyCode == Keys.Delete)
            {
                if (General.askQuestion("Delete Record", "Are you sure do you want to delete this record?", "Permanent Deletion") == DialogResult.Yes)
                {
                    if (oSales.delete((clsSales)lvSalesControl.SelectedItems[0].Tag))
                    {
                        General.showMessageBox("Success", "Succesfully deleted the record", MsgTypes.success);
                        lvSalesControl.SelectedItems[0].Remove();
                    }
                }
            }
        }
    }
}
