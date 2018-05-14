// Bar POS, class POSScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;

using System.Windows.Forms;

namespace BarPOS
{
    public partial class POSScreen : Form
    {
        POSProductsList products;
        TableProductsList tableProducts;
        SelledProductsList selledProducts;
        PayScreen payScreen;

        public POSScreen(ProductsList products)
        {
            this.products = new POSProductsList(products);
            InitializeComponent();
        }

        private void DrawProducts()
        {
            //TO DO
        }
    }
}
