// Bar POS, class AdminScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton

using System.Windows.Forms;

namespace BarPOS
{
    public partial class AdminScreen : Form
    {
        UsersList users;
        BillList bills;
        ProductsList products;

        public AdminScreen(UsersList users, BillList bills, 
            ProductsList products)
        {
            this.users = users;
            this.bills = bills;
            this.products = products;

            InitializeComponent();
        }
    }
}
