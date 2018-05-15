// Bar POS, class ConfigurationScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Close method for the windows and the program

using System.Windows.Forms;

namespace BarPOS
{
    public partial class ConfigurationScreen : Form
    {
        BillList Bills { get; set; }
        ProductsList Products { get; set; }

        public ConfigurationScreen(ProductsList products, BillList bills)
        {
            this.Products = products;
            this.Bills = bills;
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

        //Method to close the windows
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        //Method to close the program
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}
