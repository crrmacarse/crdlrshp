using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace cardealership.Class
{
    class clsSales
    {
        private int id;
        private string code;
        private clsAccountUser employee;
        private string custfullname;
        private string custaddress;
        private string custcontactno;
        private DateTime dateofpurchase;
        private DateTime datecreated;
        private bool status;

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Code { get { return this.code; } set { this.code = value; } }
        public clsAccountUser Employee { get { return this.employee; } set { this.employee = value; } }
        public string CustFullName { get { return this.custfullname; } set { this.custfullname = value; } }
        public string CustAddress { get { return this.custaddress; } set { this.custaddress = value; } }
        public string CustContactNo { get { return this.custcontactno; } set { this.custcontactno = value; } }
        public DateTime DateOfPurchase { get { return this.dateofpurchase; } set { this.dateofpurchase = value; } }
        public DateTime DateCreated { get { return this.datecreated; } set { this.datecreated = value; } }
        public bool Status { get { return this.status; } set { this.status = value; } }
        
        public clsSales()
        {

        }

        public List<clsSales> getSales(DateTime from, DateTime to)
        {
            List<clsSales> list = new List<clsSales>();
            clsSales oSales;
            clsAccountUser oEmployee;

            string sQuery = "SELECT idSalesControl, SalesControl.SCReceiptCode, Employee.idEmployee, Employee.EMPLastName, Employee.EMPFirstName, Employee.EMPMIddleName, " +
                " SalesControl.SCCustFullName, SalesControl.SCCustAddress, SalesControl.SCCustContactNo, SalesControl.SCDateOfPurchase, SCDateCreated, SCStatus " +
                " FROM SalesControl INNER JOIN Employee on Employee.idEmployee = SalesControl.idEmployee WHERE SalesControl.SCDateOfPurchase >= @fromdate " + 
                "AND SalesControl.SCDateOfPurchase <= @todate";
            using (SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                try
                {
                    oConnection.Open();
                    using (SqlCommand oCommand = new SqlCommand(sQuery, oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@fromdate", from);
                        oCommand.Parameters.AddWithValue("@todate", to);
                        using (SqlDataReader oReader = oCommand.ExecuteReader())
                        {
                            if (oReader.HasRows)
                            {
                                while (oReader.Read())
                                {
                                    oSales = new clsSales();
                                    oEmployee = new clsAccountUser();
                                    
                                    oSales.ID = oReader.GetInt32(oReader.GetOrdinal("idSalesControl"));
                                    oSales.Code = oReader.GetString(oReader.GetOrdinal("SCReceiptCode"));
                                    oEmployee.ID = oReader.GetInt32(oReader.GetOrdinal("idEmployee"));
                                    oEmployee.Firstname = oReader.GetString(oReader.GetOrdinal("EMPFirstName"));
                                    oEmployee.Middlename = oReader.GetString(oReader.GetOrdinal("EMPMiddleName"));
                                    oEmployee.Lastname = oReader.GetString(oReader.GetOrdinal("EMPLastName"));
                                    oSales.Employee = oEmployee;
                                    oSales.CustFullName = oReader.GetString(oReader.GetOrdinal("SCCustFullName"));
                                    oSales.CustAddress = oReader.GetString(oReader.GetOrdinal("SCCustAddress"));
                                    oSales.CustContactNo = oReader.GetString(oReader.GetOrdinal("SCCustContactNo"));
                                    oSales.DateOfPurchase = oReader.GetDateTime(oReader.GetOrdinal("SCDateOfPurchase"));
                                    oSales.DateCreated = oReader.GetDateTime(oReader.GetOrdinal("SCDateCreated"));
                                    oSales.Status = oReader.GetBoolean(oReader.GetOrdinal("SCStatus"));

                                    list.Add(oSales);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger, System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
            }
            return list;
        }


        public bool save()
        {
            string sqlQuery = "INSERT INTO SalesControl(SCReceiptCode, idEmployee, SCCustFullName, SCCustAddress, SCCustContactNo, SCDateOfPurchase, " +
                "SCDateCreated, SCStatus) VALUES(@code, @idemployee, @custfullname, @custaddress, @custcontactno, @dateofpurchase, GETDATE(),1)";

            using (SqlConnection connection = new SqlConnection(General.connectionString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand oCommand = new SqlCommand(sqlQuery, connection))
                    {
                        oCommand.Parameters.AddWithValue("@code", this.code);
                        oCommand.Parameters.AddWithValue("@idemployee", General.currentUser.ID);
                        oCommand.Parameters.AddWithValue("@custfullname", this.CustFullName);
                        oCommand.Parameters.AddWithValue("@custaddress", this.CustAddress);
                        oCommand.Parameters.AddWithValue("@custcontactno", this.CustAddress);
                        oCommand.Parameters.AddWithValue("@dateofpurchase", this.DateOfPurchase);
                        oCommand.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger, System.Reflection.MethodBase.GetCurrentMethod().Name);
                }

            }
            return false;
        }

        public bool delete(clsSales car)
        {
            using (SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                oConnection.Open();
                try
                {
                    using (SqlCommand oCommand = new SqlCommand("DELETE FROM SalesControl WHERE idSalesControl = @id", oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@id", car.ID);

                        oCommand.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger, System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
            }

            return false;
        }
    }

    class clsSalesData
    {
        private int id;
        private clsSales salescontrol;
        private clsInventory inventory;
        private DateTime datecreated;
        private bool status;

        public int ID { get { return this.id; } set { this.id = value; } }
        public clsSales SalesControl { get { return this.salescontrol; } set { this.salescontrol = value; } }
        public clsInventory Inventory { get { return this.inventory; } set { this.inventory = value; } }
        public DateTime DateCreated { get { return this.datecreated; } set { this.datecreated = value; } }
        public bool Status { get { return this.status; } set { this.status = value; } }

        // @03271901 : temporary
        public int idSalesControl { get; set; }
        public DateTime SalesControlsoldDate { get; set; }

        public clsSalesData()
        {   

        }

        public List<clsSalesData> getSalesData(clsSales salesClass)
        {
            List<clsSalesData> list = new List<clsSalesData>();
            clsSalesData oSalesData;
            clsInventory oInventory;
            clsCar oCar;
            string sQuery = "SELECT idSalesData, ITrackingCode, Inventory.idInventory, CarModel.CMCode, CarModel.idCarMOdel, CarModel.CMName, Inventory.IDetails, Inventory.IDateCreated, Inventory.IIsSoldDate, " +
                    "Inventory.IStatus FROM Inventory INNER JOIN CarModel ON CarModel.idCarModel = Inventory.idCarModel INNER JOIN SalesData " +
                    "ON Inventory.idInventory = SalesData.idInventory INNER JOIN SalesControl ON SalesControl.idSalesControl = SalesData.idSalesData " +
                    "INNER JOIN Employee ON Employee.idEmployee = SalesControl.idEmployee WHERE Inventory.IIsSold = 'True' AND SalesControl.idSalesControl = @salesid";
            using (SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                try
                {
                    oConnection.Open();
                    using (SqlCommand oCommand = new SqlCommand(sQuery, oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@salesid", salesClass.ID);
                        using (SqlDataReader oReader = oCommand.ExecuteReader())
                        {
                            if (oReader.HasRows)
                            {
                                while (oReader.Read())
                                {
                                    oSalesData = new clsSalesData();
                                    oInventory = new clsInventory();
                                    oCar = new clsCar();

                                    oSalesData.ID = oReader.GetInt32(oReader.GetOrdinal("idSalesData"));
                                    oCar.ID = oReader.GetInt32(oReader.GetOrdinal("idCarMOdel"));
                                    oCar.Name = oReader.GetString(oReader.GetOrdinal("CMName"));
                                    oInventory.Car = oCar;
                                    oInventory.ID = oReader.GetInt32(oReader.GetOrdinal("idInventory"));
                                    oInventory.TrackingCode = oReader.GetString(oReader.GetOrdinal("ITrackingCode"));
                                    oInventory.Details = oReader.GetString(oReader.GetOrdinal("IDetails"));
                                    oInventory.SoldDate = oReader.GetDateTime(oReader.GetOrdinal("IIsSoldDate"));
                                    oSalesData.Inventory = oInventory;
                                    oSalesData.SalesControl = salescontrol;
                                    oSalesData.DateCreated = oReader.GetDateTime(oReader.GetOrdinal("IDateCreated"));
                                    oSalesData.Status = oReader.GetBoolean(oReader.GetOrdinal("IStatus"));

                                    list.Add(oSalesData);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger, System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
            }
            return list;
        }

        //public bool save(clsInventory oInventory, clsSales oSales)

        // @03271901 : temporary
        public bool save(clsInventory oInventory)
        {
            string sqlQuery = "INSERT INTO SalesData(idSalesControl, idInventory, SDDateCreated, SDStatus) " +
                "VALUES(@idsalescontrol,@inventory, GETDATE(), 1)";

            using (SqlConnection connection = new SqlConnection(General.connectionString()))
            {
                connection.Open();
                try
                {
                    
                    using (SqlCommand oCommand = new SqlCommand(sqlQuery, connection))
                    {
                        // @03271901 : temporary
                        oCommand.Parameters.AddWithValue("@idsalescontrol", this.idSalesControl);

                        //oCommand.Parameters.AddWithValue("@idsalescontrol", oSales.ID);
                        oCommand.Parameters.AddWithValue("@inventory", oInventory.ID);
                        oCommand.ExecuteNonQuery();
                
                    }

                    using(SqlCommand oCommand = new SqlCommand("UPDATE Inventory SET IIsSold = 'true', IIsSoldDate = @solddate WHERE idInventory = @idinventory", connection))
                    {
                        oCommand.Parameters.AddWithValue("@idinventory", oInventory.ID);
                        oCommand.Parameters.AddWithValue("@solddate", this.SalesControlsoldDate);
                        oCommand.ExecuteNonQuery();

                        return true;
                    }

                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger, ex.Source);
                }

            }
            return false;
        }

        public bool delete(clsSales car)
        {
            using (SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                oConnection.Open();
                try
                {
                    using (SqlCommand oCommand = new SqlCommand("DELETE FROM SalesControl WHERE idSalesControl = @id", oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@id", car.ID);

                        oCommand.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger, System.Reflection.MethodBase.GetCurrentMethod().Name);
                }
            }

            return false;
        }

    }
}
