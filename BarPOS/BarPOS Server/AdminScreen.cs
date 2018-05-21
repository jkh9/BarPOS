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
        private void btnAccount_Click(object sender, System.EventArgs e)
        {
            AccountingManagmentScreen accountingScreen = 
                new AccountingManagmentScreen(Bills);
            accountingScreen.StartPosition = FormStartPosition.CenterScreen;
            accountingScreen.Show();
        }

        //Event to open the users screen
        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            UsersManagmentScreen usersScreen = new
                UsersManagmentScreen(Users);
            usersScreen.StartPosition = FormStartPosition.CenterScreen;
            usersScreen.Show();
        }

        //Event to open the products screen
        private void btnProducts_Click(object sender, System.EventArgs e)
        {
            ProductsManagmentScreen productsScreen = new
                ProductsManagmentScreen(Products);
            productsScreen.StartPosition = FormStartPosition.CenterScreen;
            productsScreen.Show();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
