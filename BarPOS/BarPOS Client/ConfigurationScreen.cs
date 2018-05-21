// Bar POS, class ConfigurationScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Close method for the windows and the program
// V0.03 21-May-2018 Moisés: Load method

using System;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class ConfigurationScreen : Form
    {
        public ConfigurationClass Configuration {get; set;}
        public ConfigurationScreen()
        {
            Configuration = new ConfigurationClass();
            LoadComponents();
            InitializeComponent();
        }

        //Method to check if everything loads correctly
        public void LoadComponents()
        {
            string productsErrorCode = Configuration.Products.Load();
            if (productsErrorCode != "")
            {
                MessageBox.Show(productsErrorCode);
            }
            string billsErrorCode = Configuration.Bills.Load();
            if (billsErrorCode != "")
            {
                MessageBox.Show(billsErrorCode);
            }
            string usersErrorCode = Configuration.Users.Load();
            if (usersErrorCode != "")
            {
                MessageBox.Show(usersErrorCode);
            }
        }

        //Method to close the windows
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            if (Configuration.LogIn)
            {
                TableScreen tableScreen = 
                    new TableScreen(Configuration.Products,
                    Configuration.Bills,
                    Configuration.Users);
                tableScreen.StartPosition = FormStartPosition.CenterScreen;
                tableScreen.Show();
            }
        }

        //Method to close the program
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            Configuration.LogInUser();
            lblLogin.Text = "";
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Configuration.LogOutUser();
            lblLogin.Text = "Login Required!!!!";
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            picHelp.BringToFront();
            picHelp.Visible = true;
            btnExitHelp.BringToFront();
            btnExitHelp.Visible = true;
        }

        private void btnExitHelp_Click(object sender, System.EventArgs e)
        {
            picHelp.Visible = false;
            btnExitHelp.Visible = false;
        }
    }
}
