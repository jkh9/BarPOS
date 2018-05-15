// Bar POS, class AccountingManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton

using System.Windows.Forms;

namespace BarPOS
{
    public partial class AccoutingManagmentScreen : Form
    {
        public int Index { get; set; }
        public BillList Bills { get; set; }

        public AccoutingManagmentScreen(BillList bills)
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
    }
}
