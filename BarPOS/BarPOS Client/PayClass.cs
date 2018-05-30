// Bar POS, class PayClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    PayScreen

using System;

namespace BarPOS
{
    public class PayClass
    {
        public ProductToSellList Products { get; set; }
        public BillList Bills { get; set; }
        public Bill ActualBill { get; set; }
        public double Total { get { return ActualBill.Total; } }
        User actualUser;
        int table;

        public PayClass(ProductToSellList products, BillList bills, 
            User actualUser, int table, double total)
        {
            Products = products;
            Bills = bills;
            ActualBill = new Bill();
            ActualBill.Total = Products.CalculeTotal();
            this.actualUser = actualUser;
            this.table = table;
            doTheBill();
            ActualBill.Total = total;
        }

        public string CalculateMoneyToReturn(string strTotal, string strGiven)
        {
            double total = Convert.ToDouble(strTotal);
            double given = Convert.ToDouble(strGiven);
            return (given - total).ToString("0.##");
        }

        private void doTheBill()
        {
            BillHeader header = new BillHeader(Bills.Count,actualUser,table);
            ActualBill.Header = header;

            for (int i = 1; i <= Products.Count; i++)
            {
                BillLine line = new BillLine(Products.Get(i).ActualProduct,
                    Products.Get(i).Amount);
                ActualBill.AddLine(line);
            }
        }
    }
}
