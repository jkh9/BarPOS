// Bar POS, class ConfigurationClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    ConfigurationScreen

namespace BarPOS
{
    public class ConfigurationClass
    {
        public BillList Bills { get; }
        public ProductsList Products { get; }
        public UsersList Users { get; }
        public bool LogIn { get; set; }

        public ConfigurationClass()
        {
            Products = new ProductsList();
            Bills = new BillList();
            Users = new UsersList();
            LogIn = false;
        }

        public void LogInUser()
        {
            LogIn = true;
        }

        public void LogOutUser()
        {
            LogIn = false;
        }

        public void PrintDailyAccounts()
        {
            //TO DO
        }

        public void OpenTheDrawer()
        {
            //TO DO
        }
    }
}
