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
            frmSalesData frm = new frmSalesData();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { /*loadCarModel(); lvInventory.Items.Clear();*/ General.showMessageBox("Succes", "Sucesfully added new record", MsgTypes.success); }
        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            frmNewSales frm = new frmNewSales();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { /*loadCarModel(); lvInventory.Items.Clear();*/ General.showMessageBox("Succes", "Sucesfully added new record", MsgTypes.success); }
        }

        private void ucSales_Load(object sender, System.EventArgs e)
        {
            loadSalesControl();
        }

        private void loadSalesControl()
        {
            lvSalesControl.Items.Clear();
            lvSalesControl.SuspendLayout();
            List<clsSales> list = new List<clsSales>();

            clsSales salesClass = new clsSales();
            list = salesClass.Getsales();

            foreach (clsSales oSales in list)
            {
                ListViewItem oItem = new ListViewItem();

                oItem.Text = oSales.Code;
                oItem.SubItems.Add(oSales.CustFullName);
                oItem.ImageKey = "folder";


                oItem.Tag = oSales;

                lvSalesControl.Items.Add(oItem);
            }

            lvSalesControl.ResumeLayout();
        }
    }
}
