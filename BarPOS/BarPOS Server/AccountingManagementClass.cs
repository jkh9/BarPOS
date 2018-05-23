// Bar POS, class AccountingManagmentClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    AccountingManagementScreen
// V0.02 22-May-2018 Moisés: Search method implemented
//    print method deleted and minor changes

namespace BarPOS
{
    public class AccountingManagementClass
    {
        public int Index { get; set; }
        public BillList Bills { get; set; }
        public int Count { get { return Bills.Count; } }
        public bool DrawFounds { get; set; }

        public AccountingManagementClass(BillList bills)
        {
            Bills = bills;
            Index = 1;
        }
        
        public Bill GetActualBill()
        {
            return Bills.Get(Index);
        }

        public bool Search(string text)
        {
            if (text != null)
            {
                text = text.ToLower();

                bool found = false;

                for (int i = 1; i <= Count; i++)
                {
                    Bill ActualBill = Bills.Get(i);

                    if (ActualBill.ToString().ToLower().Contains(text))
                    {
                        ActualBill.Found = true;
                        found = true;
                        DrawFounds = true;
                    }

                    if (!GetActualBill().Found)
                    {
                        MoveForward();
                    }
                }
                return found;
            }

            return false;
        }

        public void MoveForward()
        {
            if (Index < Count)
            {
                Index++;
            }
            else
            {
                Index = 1;
            }

            if (DrawFounds && !Bills.Get(Index).Found)
            {
                do
                {
                    if (Index < Count)
                    {
                        Index++;
                    }
                    else
                    {
                        Index = 1;
                    }
                } while (!Bills.Get(Index).Found);
            }

        }

        public void MoveBackward()
        {
            if (Index > 1)
            {
                Index--;
            }
            else
            {
                Index = Count;
            }

            if (DrawFounds && !Bills.Get(Index).Found)
            {
                do
                {
                    if (Index > 1)
                    {
                        Index--;
                    }
                    else
                    {
                        Index = Count;
                    }
                } while (!Bills.Get(Index).Found);
            }
        }


        public void ChangeDate()
        {
            //TO DO
        }
    }
}
