// Bar POS, class TableScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class TableScreen : Form
    {
        Image image;

        TableList tables;
        ProductsList products;
        BillList bills;
        UsersList user;
        ConfigurationScreen configuration;
        POSScreenList POSScreens;

        public TableScreen()
        {
            tables = new TableList();
            products = new ProductsList();
            bills = new BillList();
            user = new UsersList();
            configuration = new ConfigurationScreen(products, bills);
            POSScreens = new POSScreenList(products);
            InitializeComponent();
        }
    }
}
