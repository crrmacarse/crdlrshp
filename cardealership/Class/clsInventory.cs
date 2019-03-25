using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace cardealership.Class
{
    class clsInventory
    {
        private int id;
        private clsCar car;
        private string trackingcode;
        private string supplier;
        private string details;
        private bool issold;
        private DateTime soldate;
        private DateTime datecreated;
        private bool status;

        public int ID { get { return this.id; } set { this.id = value; } }
        public clsCar Car { get { return this.car; } set { this.car = value; } }
        public string TrackingCode { get { return this.trackingcode; } set { this.trackingcode = value; } }
        public string Supplier { get { return this.supplier; } set { this.supplier = value; } }
        public string Details { get { return this.details; } set { this.details = value; } }
        public bool IsSold { get { return this.issold; } set { this.issold = value; } }
        public DateTime SoldDate { get { return this.soldate; } set { this.soldate = value; } }
        public DateTime DateCreated { get { return this.datecreated; } set { this.datecreated = value; } }
        public bool Status { get { return this.status; } set { this.status = value; } }

        public clsInventory()
        {

        }

        public List<clsInventory> getList()
        {
            List<clsInventory> list = new List<clsInventory>();
            clsInventory inventory;
            clsCar car;

            string SQuery = "SELECT idInventory, CarModel.idCarModel, Inventory.ITrackingCode, CarModel.CMCode, CarModel.CMName, IDetails, " +
                "ISupplier, IIsSold, IIsSoldDate, IDateCreated, IStatus FROM Inventory " +
                "INNER JOIN CarModel ON CarModel.idCarModel = Inventory.idCarModel WHERE Inventory.IIsSold = 'False' ";
            using(SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                oConnection.Open();
                try
                {
                    using(SqlCommand oCommand = new SqlCommand(SQuery, oConnection))
                    {
                        using(SqlDataReader oReader = oCommand.ExecuteReader())
                        {
                            if (oReader.HasRows)
                            {
                                while (oReader.Read())
                                {
                                    inventory = new clsInventory();
                                    car = new clsCar();
                                    inventory.ID = oReader.GetInt32(oReader.GetOrdinal("idInventory"));
                                    inventory.TrackingCode = oReader.GetString(oReader.GetOrdinal("ITrackingCode"));
                                    car.ID = oReader.GetInt32(oReader.GetOrdinal("idCarModel"));
                                    car.Code = oReader.GetString(oReader.GetOrdinal("CMCode"));
                                    car.Name = oReader.GetString(oReader.GetOrdinal("CMName"));
                                    inventory.car = car;
                                    inventory.Details = oReader.GetString(oReader.GetOrdinal("IDetails"));
                                    inventory.Supplier = oReader.GetString(oReader.GetOrdinal("ISupplier"));
                                    inventory.IsSold = oReader.GetBoolean(oReader.GetOrdinal("IIsSold"));
                                    inventory.SoldDate = oReader.GetDateTime(oReader.GetOrdinal("IIsSoldDate"));
                                    inventory.DateCreated = oReader.GetDateTime(oReader.GetOrdinal("IDateCreated"));
                                    inventory.Status = oReader.GetBoolean(oReader.GetOrdinal("IStatus"));

                                    list.Add(inventory);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    General.showMessageBox("Error", ex.Message, MsgTypes.danger);
                }
            }
            return list;
        }

    }
}
