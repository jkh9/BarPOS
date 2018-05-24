// Bar POS, class POSSClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    POSScreen
// V0.02 24-May-2018 Moisés: Changed moveToTable method

namespace BarPOS
{
    public class POSSClass
    {
        public ProductsList Products { get; }
        public TableList Tables { get; }
        public ProductToSellList ProductsToSell { get; set; }
        public BillList Bills { get; set; }
        public int Index { get; set; }
        public int Count { get { return Tables.Count; } }
        public User Employee { get; set; }

        public POSSClass(ProductsList products, TableList tables,
            BillList bills, int index, User employee)
        {
            ProductsToSell = new ProductToSellList();
            Bills = bills;
            Products = products;
            Tables = tables;
            Index = index;
            Employee = employee;
        }

        public void TableUp()
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
        }

        public void TableDown()
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
        }

        public void MoveToTable(ProductToSell product)
        {
            if (Tables.Get(Index).Products.Contains(product))
            {
                Tables.Get(Index).Products.Get(
                    Tables.Get(Index).Products.IndexOf(product)).Amount++;
            }
            else
            {
                Tables.Get(Index).Products.Add(product);
            }
        }

        public TableProductsList GetTableProducts()
        {
            return Tables.Get(Index).Products;
        }
    }
}
