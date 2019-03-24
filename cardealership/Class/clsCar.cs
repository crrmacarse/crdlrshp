using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cardealership.Class
{
    class clsCar
    {
        private int id;
        private string code;
        private string name;
        private DateTime yearrelease;
        private DateTime datecreated;
        private bool status;
        List<clsCar> listCar;

        clsConnection conn = new clsConnection();

        public int ID { get { return this.id; } set { this.id = value; } }
        public string Code { get { return this.code; } set { this.code = value; } }
        public string Name { get { return this.name; } set { this.name = value; } }
        public DateTime YearRelease { get { return this.yearrelease; } set { this.yearrelease = value; } }
        public DateTime DateCreated { get { return this.datecreated; } set { this.datecreated = value; } }
        public bool Status { get { return this.status; } set { this.status = value; } }

        public clsCar()
        {

        }

        public  List<clsCar> GetCarList(string search = null)
        {
            List<clsCar> list = new List<clsCar>();
            clsCar car;

            string sQuery = "SELECT idCarModel, CMCode, CMName, CMDateCreated, CMStatus FROM CarModel WHERE (CMCode LIKE '%'+@search+'%' OR CMName LIKE '%'+@search+'%')";
            using (SqlConnection oConnection = new SqlConnection(conn.getConnectionString()))
            {
                try
                {
                    oConnection.Open();
                    using(SqlCommand oCommand = new SqlCommand(sQuery, oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@search", search);
                        
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
                    MessageBox.Show(ex.Message);
                }
            }
            return list;
        }

        public bool saveCar(clsCar car)
        {
            bool validation;
            string sQuery;


           if(car.ID > 0)
            {
                // update query here
            }
            else
            {
                // save query here
            }

           using(SqlConnection oConnection = new SqlConnection(conn.getConnectionString()))
            {
                try
                {
                    oConnection.Open();
                    //using(SqlCommand oCommand = new SqlCommand(sQuery, oConnection))
                    //{

                    //}
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return true;
        }



        // get all cars

        // save car

        // update car
    }
}
