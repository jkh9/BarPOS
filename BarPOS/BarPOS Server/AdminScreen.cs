// Bar POS, class AdminScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Events to open the different windows
// V0.03 21-May-2018 Moisés: Loader method

using System;
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
        Languajes languaje;

        public AdminScreen()
        {
            this.Users = new UsersList();
            this.Bills = new BillList();
            this.Products = new ProductsList();

            LoadComponents();
            InitializeComponent();
            languaje = Languajes.English;
        }

        private void drawTexts()
        {
            switch (languaje)
            {
                case Languajes.Castellano:
                    btnAccount.Text = "Facturas";
                    btnProducts.Text = "Productos";
                    btnUsers.Text = "Usuarios";
                    break;
                case Languajes.English:
                    btnAccount.Text = "Accounts";
                    btnProducts.Text = "Products";
                    btnUsers.Text = "Users";
                    break;
            }
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
                        UsersManagmentScreen(Users, languaje);
                    usersScreen.StartPosition = 
                        FormStartPosition.CenterScreen;
                    usersScreen.Show();
                    break;
                case "btnProducts":
                    productsScreen = new
                        ProductsManagmentScreen(Products, languaje);
                    productsScreen.StartPosition = 
                        FormStartPosition.CenterScreen;
                    productsScreen.Show();
                    break;
                case "btnAccount":
                    accountingScreen =
                        new AccountingManagmentScreen(Bills, languaje);
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

        private void btnEnglish_Click(object sender, System.EventArgs e)
        {
            this.languaje = Languajes.English;
            drawTexts();
        }

        private void btnSpanish_Click(object sender, System.EventArgs e)
        {
            this.languaje = Languajes.Castellano;
            drawTexts();
        }
    }
}
