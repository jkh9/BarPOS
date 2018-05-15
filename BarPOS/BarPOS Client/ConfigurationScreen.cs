// Bar POS, class ConfigurationScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;

using System.Windows.Forms;

namespace BarPOS
{
    public partial class ConfigurationScreen : Form
    {
        BillList bills;
        ProductsList products;

        public ConfigurationScreen(ProductsList products, BillList bills)
        {
            this.products = products;
            this.bills = bills;
            InitializeComponent();
        }

        public void PrintDailyAccounts()
        {
            //TO DO
        }

        public void OpenUser()
        {
            //TO DO
        }

        public void CloseUser()
        {
            //TO DO
        }

        public void OpenTheDrawer()
        {
            //TO DO
        }
    }
}
