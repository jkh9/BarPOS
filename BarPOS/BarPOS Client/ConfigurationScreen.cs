﻿// Bar POS, class ConfigurationScreen

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

        public ConfigurationScreen(ProductsList products, BillList bills,
            UsersList users)
        {
            LogIn = false;
            this.Products = products;
            this.Bills = bills;
            Users = Users;
            InitializeComponent();
        }

        public void PrintDailyAccounts()
        {
            //TO DO
        }

        public void OpenUser()
        {
            LogIn = true;
            lblLogin.Text = "";
        }

        public void CloseUser()
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
                this.Close();
            }
        }

        //Method to close the program
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminScreen_Click(object sender, EventArgs e)
        {
            AdminScreen adminScreen = new AdminScreen(Users, Bills, Products);
            adminScreen.StartPosition = FormStartPosition.CenterScreen;
            adminScreen.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            OpenUser();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            CloseUser();
        }
    }
}