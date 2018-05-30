// Bar POS, class AdminScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Events to open the different windows
// V0.03 21-May-2018 Moisés: Loader method

using System.Windows.Forms;

namespace BarPOS
{
    public partial class AdminScreen : Form
    {
        public UsersList Users { get; set; }
        public BillList Bills { get; set; }
        public ProductsList Products { get; set; }

        AccountingManagmentScreen accountingScreen;
        UsersManagmentScreen usersScreen;
        ProductsManagmentScreen productsScreen;

        public AdminScreen()
        {
            this.Users = new UsersList();
            this.Bills = new BillList();
            this.Products = new ProductsList();

            LoadComponents();
            InitializeComponent();
        }

        //Method to check if everything loads correctly
        public void LoadComponents()
        {
            string productsErrorCode = Products.Load();
            if (productsErrorCode != "")
            {
                MessageBox.Show(productsErrorCode);
            }
            string billsErrorCode = Bills.Load();
            if (billsErrorCode != "")
            {
                MessageBox.Show(billsErrorCode);
            }
            string usersErrorCode = Users.Load();
            if (usersErrorCode != "")
            {
                MessageBox.Show(usersErrorCode);
            }
        }

        //Event to open the accouting screen
        private void btn_Click(object sender, System.EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "btnUsers":
                    usersScreen = new
                        UsersManagmentScreen(Users);
                    usersScreen.StartPosition = 
                        FormStartPosition.CenterScreen;
                    usersScreen.Show();
                    break;
                case "btnProducts":
                    productsScreen = new
                        ProductsManagmentScreen(Products);
                    productsScreen.StartPosition = 
                        FormStartPosition.CenterScreen;
                    productsScreen.Show();
                    break;
                case "btnAccount":
                    accountingScreen =
                        new AccountingManagmentScreen(Bills);
                    accountingScreen.StartPosition = 
                        FormStartPosition.CenterScreen;
                    accountingScreen.Show();
                    break;
                default:
                    break;
            }
            
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
