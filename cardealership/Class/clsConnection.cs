using System;
using System.Data.SqlClient;

namespace cardealership.Class
{
    class clsConnection
    {
        private string server = "localhost";
        private string username = "sa";
        private string password = "garudatiger";
        private string database = "CarDealership";

        public string Server { get { return this.server; } set { this.server = value; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value; } }
        public string Database { get { return this.database; } set { this.database = value; } }

        public string Connection { get { return "server=" + this.server + ";uid=" + this.username + ";pwd=" + this.password + ";initial catalog=" + this.database; } }

        public clsConnection(string server, string username, string password, string database)
        {
            this.server = server;
            this.username = username;
            this.password = password;
            this.database = database;
        }

        public clsConnection()
        {

        }

        public string createConnectionString()
        {
            return "server=" + this.server + ";uid=" + this.username + ";pwd=" + this.password + ";initial catalog=" + this.database;
            //return "server=" + this.servername + "," + this.port + ";uid=" + this.username + ";pwd=" + this.password + ";initial catalog=" + this.database;            
        }

        public string getConnectionString(string database = null)
        {
            if (database != null) { this.database = database; }

            return this.createConnectionString();
        }

        public bool TestConnection()
        {
            using(SqlConnection connection = new SqlConnection(this.getConnectionString())){
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception ex)
                {
                    General.showMessageBox("Error", ex.Message, MsgTypes.danger);
                    return false;
                }
            }
        }


    }
}
