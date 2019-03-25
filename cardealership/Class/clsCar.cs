using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace cardealership.Class
{
    class clsCar
    {
        private int id;
        private string code;
        private string name;
        private DateTime datecreated;
        private bool status;

        clsConnection conn = new clsConnection();

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Code { get { return this.code; } set { this.code = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public DateTime DateCreated { get { return this.datecreated; } set { this.datecreated = value; } }
        public bool Status { get { return this.status; } set { this.status = value; } }

        public clsCar()
        {

        }

        public  List<clsCar> GetCarList()
        {
            List<clsCar> list = new List<clsCar>();
            clsCar car;

            string sQuery = "SELECT idCarModel, CMCode, CMName, CMDateCreated, CMStatus FROM CarModel";
            using (SqlConnection oConnection = new SqlConnection(conn.getConnectionString()))
            {
                try
                {
                    oConnection.Open();
                    using(SqlCommand oCommand = new SqlCommand(sQuery, oConnection))
                    {
                        
                        using(SqlDataReader oReader = oCommand.ExecuteReader())
                        {
                            if (oReader.HasRows)
                            {
                                while (oReader.Read())
                                {
                                    car = new clsCar();
                                    car.ID = oReader.GetInt32(oReader.GetOrdinal("idCarModel"));
                                    car.Code = oReader.GetString(oReader.GetOrdinal("CMCode"));
                                    car.Name = oReader.GetString(oReader.GetOrdinal("CMName"));
                                    car.DateCreated = oReader.GetDateTime(oReader.GetOrdinal("CMDateCreated"));
                                    car.Status = oReader.GetBoolean(oReader.GetOrdinal("CMStatus"));

                                    list.Add(car);
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

        public bool save()
        {
            string sqlQuery = "INSERT INTO CarModel(CMCode, CMName, CMDateCreated, CMStatus) " +
                              "VALUES(@cmcode,@cmname,GETDATE(),1)";

            using (SqlConnection connection = new SqlConnection(General.connectionString()))
            {
                connection.Open();
                try
                {
                    using (SqlCommand oCommand = new SqlCommand(sqlQuery, connection))
                    {
                        oCommand.Parameters.AddWithValue("@cmcode", this.code);
                        oCommand.Parameters.AddWithValue("@cmname", this.name);
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

        public bool delete(clsCar car)
        {
            using (SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                oConnection.Open();
                try
                {
                    using (SqlCommand oCommand = new SqlCommand("DELETE FROM CarModel WHERE idCarModel = @idCarModel", oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@idCarModel", car.ID);

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

        // update car

    }
}
