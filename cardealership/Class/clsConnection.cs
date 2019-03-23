namespace cardealership.Class
{
    class clsConnection
    {
        private string servername;
        private int port;
        private string username;
        private string password;
        private string database;

        public string ServerName { get { return this.servername; } set { this.servername = value; } }
        public int Port { get { return this.port; } set { this.port = value; } }
        public string Username { get { return this.username;  } set { this.username = value; } }
        public string Password { get { return this.password; } set { this.password = value;  } }
        public string Database { get { return this.database; } set { this.database = value; } }

        public string Sever { get { return this.servername + "," + this.port; }}
        public string Connection { get { return this.servername + "," + this.port + ";" + this.database + "," + this.username + "," + this.password; } }

        public clsConnection(string servername, int port, string username, string password, string database)
        {
            this.servername = servername;
            this.port = port;
            this.username = username;
            this.password = password;
            this.database = database;
        }

        public void TestConnection()
        {
            // test connection
        }

        public void ChangeDB()
        {
            // can change db
        }


    }
}
