// Bar POS, class BillLine

// Versiones: 
// V0.01 14-May-2018 Mois�s: Basic skeleton
// V0.02 15-May-2018 Mois�s: Added constructor
// V0.03 18-May-2018 Mois�s: Method ToString

namespace BarPOS
{
    public class BillLine
    {
        public Product LineProduct { get; set; }
        public int Amount { get; set; }
        public double Total { get { return LineProduct.Price * Amount; } }

        public BillLine(Product product, int amount)
        {
            LineProduct = product;
            Amount = amount;
        }

        public override string ToString()
        {
            return LineProduct.ToString() + "=" + Amount;
        }
    }
}