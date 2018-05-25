// Bar POS, class LogInScreen

// Versiones: 
// V0.01 23-May-2018 Moisés: Class implemented

using System;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class LogInScreen : Form
    {
        public User LogedUser { get; set; }
        public bool Login { get; set; }
        UsersList users;

        public LogInScreen(UsersList users)
        {
            LogedUser = new User();
            Login = false;
            this.users = users;
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                int code = Convert.ToInt32(txtCode.Text);
                string pass = txtPass.Text;

                LogedUser = users.GetUserByCode(code);

                if (LogedUser == null)
                {
                    MessageBox.Show("User not found");
                }
                else if (LogedUser.Pass == pass)
                {
                    Login = true;
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Wrong data");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er);
            }

            this.Close();
        }

        
    }
}
