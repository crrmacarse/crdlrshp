using System.Collections.Generic;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Settings.User_Control
{
    public partial class ucCarModel : UserControl
    {
        private List<clsCar> carList;

        public ucCarModel()
        { 
            InitializeComponent();
        }

        private void UcCarModel_Load(object sender, System.EventArgs e)
        {
            loadCarModel();
        }

        private void loadCarModel()
        {
            lvCarModel.Items.Clear();
            lvCarModel.SuspendLayout();
            carList = new List<clsCar>();

            clsCar clscar = new clsCar();
            carList = clscar.GetCarList();

            foreach (clsCar car in carList)
            {
                ListViewItem oItem = new ListViewItem();

                oItem.Text = car.Code;
                oItem.SubItems.Add(car.Name);
                oItem.SubItems.Add(car.Status.ToString());
                oItem.Tag = car;

                lvCarModel.Items.Add(oItem);
            }

            tsslCarModelCount.Text = "Row Count: " + lvCarModel.Items.Count;
            lvCarModel.ResumeLayout();
        }

        private void TsmiCreate_Click(object sender, System.EventArgs e)
        {
            frmCreateNewCarModel frm = new frmCreateNewCarModel();
            DialogResult res = frm.ShowDialog();
            if (res == DialogResult.OK) { loadCarModel(); General.showMessageBox("Succes", "Sucesfully added new record", MsgTypes.success); }
        }

        private void LvCarModel_KeyDown(object sender, KeyEventArgs e)
        {
            if (lvCarModel.SelectedItems.Count != 1) { return; }

            clsCar car = new clsCar();

            if (e.KeyCode == Keys.Delete)
            {
                if (General.askQuestion("Delete Record", "Are you sure do you want to delete this record?", "Permanent Deletion") == DialogResult.Yes)
                {
                    if (car.delete((clsCar)lvCarModel.SelectedItems[0].Tag))
                    {
                        General.showMessageBox("Success", "Succesfully deleted the record", MsgTypes.success);
                        lvCarModel.SelectedItems[0].Remove();
                        tsslCarModelCount.Text = "Row Count: " + lvCarModel.Items.Count;
                    }
                }
            }
        }
    }
}
