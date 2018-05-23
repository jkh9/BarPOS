// Bar POS, class POSSClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    POSScreen

namespace BarPOS
{
    public class POSSClass
    {
        public ProductsList Products { get; }
        public TableList Tables { get; }
        public ProductToSellList ProductsToSell { get; }
        public BillList Bills { get; set; }
        public int Index { get; set; }
        public int Count { get { return Tables.Count; } }
        public User Employee { get; set; }

        public POSSClass(ProductsList products, TableList tables,
            BillList bills, int index, User employee)
        {
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

        public Product MoveToTable(int index)
        {
            return Products.Get(index);
        }

    }
}
