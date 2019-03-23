namespace cardealership.Class
{
    class clsRegistryKey
    {
        private const string root = "HKEY_CURRENT_USER";
        private string subkey;

        public string Subkey
        {
            get
            {
                return this.subkey;
            }
            set
            {
                this.subkey = value;
            }
        }

        public string RegKey
        {
            get
            {
                return this.RegKey;
            }
        }

       public clsRegistryKey(string _subkey)
        {
            this.subkey = _subkey;
        }


    }
}
