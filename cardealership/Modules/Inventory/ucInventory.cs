using System.Collections.Generic;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Inventory
{
    public partial class ucInventory : UserControl
    {
        public ucInventory()
        {
            InitializeComponent();
        }

        private void UcInventory_Load(object sender, System.EventArgs e)
        {
            loadCarModel();
        }

        // must pass car model. check username
        private void loadInventory(clsCar car)
        {
            lvInventory.Items.Clear();
            lvInventory.SuspendLayout();
            List <clsInventory> list = new List<clsInventory>();

            clsInventory clsinventory = new clsInventory();
            list = clsinventory.getList(car);

            foreach (clsInventory inventory in list) 
            {
                ListViewItem oItem = new ListViewItem();
                
                oItem.Text = inventory.TrackingCode;
                oItem.SubItems.Add(inventory.Details);
                oItem.SubItems.Add(inventory.Supplier);
                oItem.Tag = inventory;

                lvInventory.Items.Add(oItem);
            }

            tsslInventoryAvailableStocks.Text = "Available Stocks: " + lvInventory.Items.Count;
            lvInventory.ResumeLayout();
        }

        private void loadCarModel()
        {
            lvCarModel.Items.Clear();
            lvCarModel.SuspendLayout();
            List<clsCar> list = new List<clsCar>();

            clsCar oCar = new clsCar();
            list = oCar.GetCarList();

            foreach (clsCar car in list)
            {
                ListViewItem oItem = new ListViewItem();

                oItem.Text = car.Code;
                oItem.SubItems.Add(car.Name);
                oItem.ImageKey = "folder";


                oItem.Tag = car;

                lvCarModel.Items.Add(oItem);
            }

            lvCarModel.ResumeLayout();
        }

        private void LvCarModel_SelectedIndexChanged(object sender, System.EventArgs e)
        {
           if(lvCarModel.SelectedItems.Count != 1) { return; }
            // app state busy
            loadInventory((clsCar)lvCarModel.SelectedItems[0].Tag);
            
            // app state ready
        }

        private void tsmiNew_Click(object sender, System.EventArgs e)
        {
            frmNewInventory frm = new frmNewInventory();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { loadCarModel(); lvInventory.Items.Clear(); General.showMessageBox("Succes", "Sucesfully added new record", MsgTypes.success); }
        }

        private void lvInventory_KeyDown(object sender, KeyEventArgs e)
        {
            if (lvInventory.SelectedItems.Count != 1) { return; }

            clsInventory oInventory = new clsInventory();

            if (e.KeyCode == Keys.Delete)
            {
                if (General.askQuestion("Delete Record", "Are you sure do you want to delete this record?", "Permanent Deletion") == DialogResult.Yes)
                {
                    if (oInventory.delete((clsInventory)lvInventory.SelectedItems[0].Tag))
                    {
                        General.showMessageBox("Success", "Succesfully deleted the record", MsgTypes.success);
                        lvInventory.SelectedItems[0].Remove();
                        tsslInventoryAvailableStocks.Text = "Available Stocks: " + lvInventory.Items.Count;
                    }
                }
            }
        }
    }
}
