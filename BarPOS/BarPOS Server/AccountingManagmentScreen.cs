// Bar POS, class AccountingManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form

using System.Windows.Forms;

namespace BarPOS
{
    public partial class AccountingManagmentScreen : Form
    {
        public int Index { get; set; }
        public BillList Bills { get; set; }

        public AccountingManagmentScreen(BillList bills)
        {
            Bills = bills;
            InitializeComponent();
        }

        public void Search()
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

        public void Print()
        {
            //TO DO
        }

        public void ChangeDate()
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
