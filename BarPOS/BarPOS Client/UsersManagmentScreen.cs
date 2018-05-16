// Bar POS, class UserManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form

using System.Windows.Forms;

namespace BarPOS
{
    public partial class UsersManagmentScreen : Form
    {
        public int Index { get; set; }
        public UsersList Users { get; set; }

        public UsersManagmentScreen(UsersList users)
        {
            Users = users;
            InitializeComponent();
        }

        public void Add()
        {
            //TO DO
        }

        public void Modify()
        {
            //TO DO
        }

        public void Search()
        {
            //TO DO
        }

        public void Delete()
        {
            //TO DO
        }

        public void MoveForward()
        {
            //TO DO
        }

        public void MoveBackward()
        {
            //TO DO
        }

        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
