// Bar POS, class POSScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Added moveToTable, minor changes, 
//      added the close method, open the payScreen

using System.Windows.Forms;

namespace BarPOS
{
    public partial class POSScreen : Form
    {
        ProductsList Products { get; set; }
        TableProductsList TableProducts { get; set; }
        SelledProductsList SelledProducts { get; set; }
        BillList Bills { get; set; }

        public POSScreen(ProductsList products, 
            TableProductsList tableProducts,
            BillList bills)
        {
            this.Bills = bills;
            this.Products = products;
            this.TableProducts = tableProducts;
            InitializeComponent();
        }

        private void DrawProducts()
        {
            //TO DO
        }

        public void MoveToTable()
        {
            //TO DO
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        //Event to open the payScreen
        private void btnPay_Click(object sender, System.EventArgs e)
        {
            PayScreen PayScreen = new PayScreen(SelledProducts, Bills);
            PayScreen.StartPosition = FormStartPosition.CenterScreen;
            PayScreen.Show();
        }
    }
}
