// Bar POS, class ConfigurationClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    ConfigurationScreen

using System;

namespace BarPOS
{
    public class ConfigurationClass
    {
        public BillList Bills { get; }
        public ProductsList Products { get; }
        public UsersList Users { get; }
        public bool LogIn { get; set; }
        public Languajes Languaje { get; set; }

        public ConfigurationClass()
        {
            Products = new ProductsList();
            Bills = new BillList();
            Users = new UsersList();
            LogIn = false;
            Languaje = Languajes.English;
        }

        public void LogInUser()
        {
            LogIn = true;
        }

        public void LogOutUser()
        {
            LogIn = false;
        }

        public double CalculateTotalWon(User actualUser)
        {
            double totalMoney = 0;

            for (int i = 1; i <= Bills.Count; i++)
            {
                User newUser = Users.GetUserByCode(Bills.Get(i).Header.
                    Employee.Code);
                DateTime newDate = Bills.Get(i).Header.Date;

                if (newUser == actualUser &&
                    newDate > newUser.LoginTime &&
                    newDate < newUser.LogoutTime)
                {
                    totalMoney += Bills.Get(i).Total;
                }
            }

            return totalMoney;
        }
    }
}
