// Bar POS, class AccountingManagmentClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    AccountingManagementScreen

namespace BarPOS
{
    public class AccountingManagementClass
    {
        public int Index { get; set; }
        public BillList Bills { get; set; }
        public int Count { get { return Bills.Count; } }

        public AccountingManagementClass(BillList bills)
        {
            Bills = bills;
            Index = 1;
        }
        
        public Bill GetActualBill()
        {
            return Bills.Get(Index);
        }

        public void Search()
        {
            //TO DO
        }

        public void MoveForward()
        {
            if (Index < Count)
            {
                Index++;
            }
        }

        public void MoveBackward()
        {
            if (Index > 1)
            {
                Index--;
            }
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
