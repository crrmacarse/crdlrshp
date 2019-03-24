using Microsoft.Win32;

namespace cardealership.Class
{
    class clsRegistryKey
    {

        private  RegistryKey  MAINKEY = Registry.CurrentUser;
        private string SKEY = "Software/CARDEALERSHIP";

        public RegistryKey  MainKey { get { return this.MAINKEY;  } }
        public string SKey { get { return this.SKEY; } }

  
    }
}
