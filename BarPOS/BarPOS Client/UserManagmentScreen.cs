// Bar POS, class UserManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton

using System.Windows.Forms;

namespace BarPOS
{
    public partial class UserManagmentScreen : Form
    {
        public int Index { get; set; }
        public UsersList Users { get; set; }

        public UserManagmentScreen(UsersList users)
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
    }
}
