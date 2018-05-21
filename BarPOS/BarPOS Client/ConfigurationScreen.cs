// Bar POS, class ConfigurationScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Close method for the windows and the program

using System;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class ConfigurationScreen : Form
    {
        public BillList Bills { get; }
        public ProductsList Products { get; }
        public UsersList Users { get; }
        public bool LogIn { get; set; }

        public ConfigurationScreen()
        {
            Products = new ProductsList();
            Bills = new BillList();
            Users = new UsersList();
            LogIn = false;
            InitializeComponent();
        }

        public void PrintDailyAccounts()
        {
            //TO DO
        }

        public void LogInUser()
        {
            LogIn = true;
            lblLogin.Text = "";
        }

        public void LogOutUser()
        {
            LogIn = false;
            lblLogin.Text = "Login Required!!!!";
        }

        public void OpenTheDrawer()
        {
            //TO DO
        }

        //Method to close the windows
        private void btnBack_Click(object sender, System.EventArgs e)
        {
            if (LogIn)
            {
                TableScreen tableScreen = new TableScreen(Products, Bills, Users);
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
            LogInUser();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOutUser();
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
