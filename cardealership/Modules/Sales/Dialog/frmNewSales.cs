using System;
using System.Windows.Forms;

using cardealership.Class;

namespace cardealership.Modules.Sales
{
    public partial class frmNewSales : Form
    {
        public frmNewSales()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtReceiptCode.Value) || String.IsNullOrEmpty(txtCustomerFullName.Value) || String.IsNullOrEmpty(txtCustomerAddress.Value) ||
               String.IsNullOrEmpty(txtCustomerContactNo.Value))
            {
                General.showMessageBox("Warning", "Please fill in the blanks", MsgTypes.warning);
                return;
            }

            if (this.saveSales(txtReceiptCode.Value.Trim(), txtCustomerFullName.Value.Trim(), txtCustomerAddress.Value.Trim(), txtCustomerContactNo.Value.Trim(), dtpDateOfPurchase.Value.Date
                ))
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool saveSales(string code, string custfullname, string custaddress, string contactno, DateTime dateofpurchase)
        {
            clsSales oSales = new clsSales();
            oSales.Code = code;
            oSales.CustFullName = custfullname;
            oSales.CustAddress = custaddress;
            oSales.CustContactNo = contactno;
            oSales.DateOfPurchase = dateofpurchase;

            if (oSales.save())
            {
                return true;
            }

            return false;
        }


    }
}
