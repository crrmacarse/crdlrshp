using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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

                            General.showMessageBox("Warning", "There seems to be an error in username or password", MsgTypes.warning, "Sign-in Error");
                        }

                    }
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger);
                }
            }

            return false;
        }


        public List<clsAccountUser> getList()
        {
            List<clsAccountUser> list = new List<clsAccountUser>();
            clsAccountUser account;

            string sQuery = "SELECT idEmployee, EMPUsername, EMPFirstName, EMPMiddleName, EMPLastName, EMPDateCreated, EMPStatus FROM Employee ";
            using(SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                try
                {
                    oConnection.Open();
                    using (SqlCommand oCommand = new SqlCommand(sQuery, oConnection))
                    {
                        using (SqlDataReader oReader = oCommand.ExecuteReader())
                        {
                            while (oReader.Read())
                            {
                                account = new clsAccountUser();
                                account.id = oReader.GetInt32(oReader.GetOrdinal("idEmployee"));
                                account.Username = oReader.GetString(oReader.GetOrdinal("EMPUsername"));
                                account.firstname = oReader.GetString(oReader.GetOrdinal("EMPFirstName"));
                                account.middlename = oReader.GetString(oReader.GetOrdinal("EMPMiddleName"));
                                account.lastname = oReader.GetString(oReader.GetOrdinal("EMPLastName"));
                                account.datecreated = oReader.GetDateTime(oReader.GetOrdinal("EMPDateCreated"));
                                account.status = oReader.GetBoolean(oReader.GetOrdinal("EMPStatus"));

                                list.Add(account);
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
            string sqlQuery = "INSERT INTO Employee(EMPUsername, EMPPassword, EMPFirstName, EMPMiddleName, EMPLastName, EMPDateCreated, EMPStatus) " +
                              "VALUES(@username,@password,@firstname,@middlename,@lastname,GETDATE(),1)";
            using(SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                oConnection.Open();
                try
                {
                    using(SqlCommand oCommand = new SqlCommand(sqlQuery, oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@username", this.username);
                        oCommand.Parameters.AddWithValue("@password", this.password);
                        oCommand.Parameters.AddWithValue("@firstname", this.firstname);
                        oCommand.Parameters.AddWithValue("@middlename", this.middlename);
                        oCommand.Parameters.AddWithValue("@lastname", this.lastname);

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

        public bool delete(clsAccountUser account)
        {
            using (SqlConnection oConnection = new SqlConnection(General.connectionString()))
            {
                oConnection.Open();
                try
                {
                    using (SqlCommand oCommand = new SqlCommand("DELETE FROM Employee WHERE idEmployee = @idEmployee", oConnection))
                    {
                        oCommand.Parameters.AddWithValue("@idEmployee", account.ID);

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


        // change pass func

        // password hash function

        // update

    }
}
