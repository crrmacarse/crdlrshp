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
            loadInventory();
        }

        // must pass car model. check username
        private void loadInventory()
        {
            lvInventory.Items.Clear();
            lvInventory.SuspendLayout();
            List <clsInventory> list = new List<clsInventory>();

            clsInventory clsinventory = new clsInventory();
            list = clsinventory.getList();

            foreach (clsInventory inventory in list) 
            {
                ListViewItem oItem = new ListViewItem();
                

                oItem.Text = inventory.TrackingCode;
                oItem.SubItems.Add("[" + inventory.Car.Code + "] " + inventory.Car.Name);
                oItem.SubItems.Add(inventory.Details);
                oItem.SubItems.Add(inventory.Supplier);

                oItem.Tag = inventory;

                lvInventory.Items.Add(oItem);
            }

            tsslInventoryAvailableStocks.Text = "Available Stocks: " + lvInventory.Items.Count;
            lvInventory.ResumeLayout();
        }
    }
}
