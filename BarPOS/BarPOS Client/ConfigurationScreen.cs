// Bar POS, class ConfigurationScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Close method for the windows and the program
// V0.03 21-May-2018 Moisés: Load method
// V0.04 23-May-2018 Moisés: Methods to LogIn and LogOut implementeds

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class ConfigurationScreen : Form
    {
        public ConfigurationClass Configuration {get; set;}
        LogInScreen LogInScreen;

        public ConfigurationScreen()
        {
            Configuration = new ConfigurationClass();
            LoadComponents();
            InitializeComponent();
            draw();
        }

        private void draw()
        {
            switch (Configuration.Languaje)
            {
                case Languajes.Castellano:
                    btnBack.Text = "Mesas";
                    btnPrint.Text = "Imprimir Cuentas Diarias";
                    btnBox.Text = "Abrir caja";
                    lblLogin.Text = "Inicio de sesión requerido!!";
                    btnClose.Text = "Cerrar";
                    btnLogIn.Text = "Iniciar Sesion";
                    btnLogOut.Text = "Cerrar Sesion";
                    btnHelp.Text = "Ayuda";
                    break;
                case Languajes.English:
                    btnBack.Text = "Tables";
                    btnPrint.Text = "Print Daily Accounts";
                    btnBox.Text = "Open box";
                    lblLogin.Text = "Login required!!";
                    btnClose.Text = "Close";
                    btnLogIn.Text = "Log In";
                    btnLogOut.Text = "Log Out";
                    btnHelp.Text = "Help";
                    break;
            }
        }

        //Method to check if everything loads correctly
        private void LoadComponents()
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
                    LogInScreen.LogedUser, Configuration.Languaje);
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
            LogInScreen = new LogInScreen(Configuration.Users,
                Configuration.Languaje);
            LogInScreen.StartPosition = FormStartPosition.CenterScreen;
            LogInScreen.ShowDialog();
            if (LogInScreen.Login)
            {
                Configuration.LogInUser();
                lblLogin.Text = "";
                btnLogIn.Enabled = false;
                btnPrint.Enabled = true;
                btnLogOut.Enabled = true;
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogInScreen.LogedUser.LogoutTime = DateTime.Now;
            PrintDailyAccounts();
            Configuration.LogOutUser();
            lblLogin.Text = "Login Required!!!!";
            btnLogIn.Enabled = true;
            btnPrint.Enabled = false;
            btnLogOut.Enabled = false;
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

        public void PrintDailyAccounts()
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            double total = Configuration.CalculateTotalWon(
                LogInScreen.LogedUser);
            e.Graphics.DrawString("Total earned: " + total, new
                    Font("Times new Roman", 40, FontStyle.Regular),
                    Brushes.Black, new PointF(0, 0));
        }

        private void btnEnglish_Click(object sender, EventArgs e)
        {
            Configuration.Languaje = Languajes.English;
            draw();
        }

        private void btnSpanish_Click(object sender, EventArgs e)
        {
            Configuration.Languaje = Languajes.Castellano;
            draw();
        }
    }
}
