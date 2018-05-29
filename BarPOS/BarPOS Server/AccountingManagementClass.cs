// Bar POS, class AccountingManagmentClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    AccountingManagementScreen
// V0.02 22-May-2018 Moisés: Search method implemented
//    print method deleted and minor changes
// V0.03 23-May-2018 Moisés: DateTime property added


using System;
using System.Collections.Generic;

namespace BarPOS
{
    public class AccountingManagementClass : Management
    {
        public BillList Bills { get; set; }
        public Bill[] DateBills { get; set; }
        public int Count { get { return DateBills.Length; } }
        public DateTime Date { get; set; }

        public AccountingManagementClass(BillList bills)
        {
            Bills = bills;
            Index = 1;
            Date = DateTime.Today;
            doDateBills();
        }
        
        public Bill GetActualBill()
        {
            return DateBills[Index - 1];
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

        private void doDateBills()
        {
            List<Bill> bills = new List<Bill>();

            for (int i = 1; i <=  Bills.Count; i++)
            {
                if (Date.ToString("dd/MM/yyyy") == 
                    Bills.Get(i).Header.Date.ToString("dd/MM/yyyy"))
                {
                    bills.Add(Bills.Get(i));
                }
            }

            DateBills = bills.ToArray();
        }

        public void ChangeDate(DateTime date)
        {
            Date = date;
            doDateBills();
        }
    }
}
