// Bar POS, class PayScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: close event added and minor changes

using System.Windows.Forms;

namespace BarPOS
{
    public partial class PayScreen : Form
    {
        ProductToSellList Products { get; set; }
        BillList Bills { get; set; }

        public PayScreen(ProductToSellList products, BillList bills)
        {
            Products = products;
            Bills = bills;

            InitializeComponent();
        }

        public void CalculateMoneyToReturn()
        {
           //TO DO 
        }

        public void DoTheBill()
        {
            //TO DO
        }

        public void PrintBill()
        {
            //TO DO
        }

        //Event to close the actual windows
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
