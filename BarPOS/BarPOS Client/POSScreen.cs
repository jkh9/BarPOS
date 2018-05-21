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
        public POSSClass POS { get; set; }

        public POSScreen(ProductsList products, TableList tables,
            BillList bills, int index)
        {
            POS = new POSSClass(products, tables, bills, index);

            InitializeComponent();
            this.lblTableNumber.Text = POS.Index.ToString();
        }

        private void DrawProducts()
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
            PayScreen PayScreen = new PayScreen(
                POS.ProductsToSell,POS.Bills);
            PayScreen.StartPosition = FormStartPosition.CenterScreen;
            PayScreen.Show();
        }

        //Event to move to next table taking care of the tables in use
        private void btnTableUp_Click(object sender, System.EventArgs e)
        {
            POS.TableUp();
            lblTableNumber.Text = POS.Index.ToString();
        }

        //Event to move to previous table taking care of the tables in use
        private void btnTableDown_Click(object sender, System.EventArgs e)
        {
            POS.TableDown();
            lblTableNumber.Text = POS.Index.ToString();
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
