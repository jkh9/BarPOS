// Bar POS, class POSScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Added moveToTable, minor changes, 
//      added the close method, open the payScreen
// V0.03 16-May-2018 Moisés: Changes in the constructor, method move to table
// method tableup, tabledown
// V0.04 17-May-2018 César: Added the help button so that a help menu appears 
// on the screen with its different options that will be made later.

using System.Windows.Forms;

namespace BarPOS
{
    public partial class POSScreen : Form
    {
        public ProductsList Products { get; set; }
        public TableList Tables { get; set; }
        public ProductToSellList ProductsToSell { get; set; }
        public BillList Bills { get; set; }
        public int Index { get; set; }

        public POSScreen(ProductsList products, TableList tables,
            BillList bills, int index)
        {
            this.Bills = bills;
            this.Products = products;
            this.Tables = tables;
            this.Index = index;

            InitializeComponent();
            this.lblTableNumber.Text = Index.ToString();
        }

        private void DrawProducts()
        {
            //TO DO
        }

        public Product MoveToTable(int index)
        {
            return Products.Get(index);
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        //Event to open the payScreen
        private void btnPay_Click(object sender, System.EventArgs e)
        {
            PayScreen PayScreen = new PayScreen(ProductsToSell, Bills);
            PayScreen.StartPosition = FormStartPosition.CenterScreen;
            PayScreen.Show();
        }

        //Event to move to next table taking care of the tables in use
        private void btnTableUp_Click(object sender, System.EventArgs e)
        {
            do
            {
                if (Index < Tables.Count)
                {
                    Index++;
                }
                else
                {
                    Index = 1;
                }
            } while (!Tables.Get(Index).InUse);
            
            lblTableNumber.Text = Index.ToString();
        }

        //Event to move to previous table taking care of the tables in use
        private void btnTableDown_Click(object sender, System.EventArgs e)
        {
            do
            {
                if (Index > 1)
                {
                    Index--;
                }
                else
                {
                    Index = Tables.Count;
                }
            } while (!Tables.Get(Index).InUse);

            lblTableNumber.Text = Index.ToString();
        }

        //Event to show 
        private void btnHelp_Click(object sender, System.EventArgs e)
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
    }
}
