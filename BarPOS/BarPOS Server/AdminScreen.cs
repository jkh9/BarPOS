// Bar POS, class AdminScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Events to open the different windows

using System.Windows.Forms;

namespace BarPOS
{
    public partial class AdminScreen : Form
    {
        UsersList users;
        BillList bills;
        ProductsList products;

        public AdminScreen()
        {
            this.users = new UsersList();
            this.bills = new BillList();
            this.products = new ProductsList();

            InitializeComponent();
        }

        //Event to open the accouting screen
        private void btnAccount_Click(object sender, System.EventArgs e)
        {
            AccountingManagmentScreen accountingScreen = 
                new AccountingManagmentScreen(bills);
            accountingScreen.StartPosition = FormStartPosition.CenterScreen;
            accountingScreen.Show();
        }

        //Event to open the users screen
        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            UsersManagmentScreen usersScreen = new
                UsersManagmentScreen(users);
            usersScreen.StartPosition = FormStartPosition.CenterScreen;
            usersScreen.Show();
        }

        //Event to open the products screen
        private void btnProducts_Click(object sender, System.EventArgs e)
        {
            ProductsManagmentScreen productsScreen = new
                ProductsManagmentScreen(products);
            productsScreen.StartPosition = FormStartPosition.CenterScreen;
            productsScreen.Show();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
