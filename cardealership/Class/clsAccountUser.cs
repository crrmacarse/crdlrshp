using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using cardealership.Class;

namespace cardealership.Class
{
    class clsAccountUser
    {
        private int id;
        private string username;
        private string password;
        private string firstname;
        private string middlename;
        private string lastname;
        private DateTime datecreated;
        private bool status;

        clsConnection conn = new clsConnection();

        public int ID { get { return this.id;  } set { this.id = value; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string Firstname { get { return this.firstname; } set { this.firstname = value; } }
        public string Middlename { get { return this.middlename; } set { this.middlename = value; } }
        public string Lastname { get { return this.lastname; } set { this.lastname = value; } }
        public DateTime DateCreated { get { return this.datecreated; } set { this.datecreated = value; } }
        public bool Status { get { return this.status; } set { this.status = value; } }
        public string FullName { get { return this.lastname.ToUpper() + "," + this.firstname + " " + this.middlename.ToUpper()[0]; } }

       public bool authenticate(string username, string password)
        {
            using (SqlConnection oConnection = new SqlConnection(conn.getConnectionString()))
            {
                try
                {
                    oConnection.Open();
                    using(SqlCommand oCommand = new SqlCommand("SELECT idEmployee, EMPUsername, EMPFirstName, EMPLastName, EMPDateCreated, EMPStatus FROM Employee " +
                        " WHERE EMPUsername = @username AND EMPPassword = @password AND EMPStatus = 1", oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@username", username);
                        oCommand.Parameters.AddWithValue("@password", password);
                        using (SqlDataReader oReader = oCommand.ExecuteReader())
                        {
                            if (oReader.HasRows)
                            {
                                if (oReader.Read()) {
                                    clsAccountUser clsAccountUser = new clsAccountUser();
                                    clsAccountUser.ID = oReader.GetInt32(oReader.GetOrdinal("idEmployee"));
                                    clsAccountUser.Username = oReader.GetString(oReader.GetOrdinal("EMPUsername"));
                                    clsAccountUser.Firstname = oReader.GetString(oReader.GetOrdinal("EMPFirstName"));
                                    clsAccountUser.Middlename = oReader.GetString(oReader.GetOrdinal("EMPLastName"));
                                    clsAccountUser.Lastname = oReader.GetString(oReader.GetOrdinal("EMPLastName"));
                                    clsAccountUser.DateCreated = oReader.GetDateTime(oReader.GetOrdinal("EMPDateCreated"));
                                    clsAccountUser.Status = oReader.GetBoolean(oReader.GetOrdinal("EMPStatus"));
                                }
                                return true;
                            }

                            MessageBox.Show("There seems to be an error in username or password");
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); ;
                }
            }

            return false;
        }

        // change pass func


        // save 


        // update

    }
}
