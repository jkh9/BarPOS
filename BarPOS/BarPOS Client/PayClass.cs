// Bar POS, class PayClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    PayScreen

namespace BarPOS
{
    public class PayClass
    {
        ProductToSellList Products { get; set; }
        BillList Bills { get; set; }

        public PayClass(ProductToSellList products, BillList bills)
        {
            Products = products;
            Bills = bills;
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
    }
}
