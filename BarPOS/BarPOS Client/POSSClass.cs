// Bar POS, class POSSClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    POSScreen
// V0.02 24-May-2018 Moisés: Changed moveToTable method
// V0.03 28-May-2018 Moisés: Methods to add, substract, move to 
//   the ProductsToSell

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
            Tables.Get(Index).InUse = true;
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

        public void MoveToTableProducts(ProductToSell product)
        {
            if (!Tables.Get(Index).Products.Contains(product))
            {
                Tables.Get(Index).Products.Add(product);
            }
            Tables.Get(Index).Products.Get(product).Amount++;
        }

        public TableProductsList GetTableProducts()
        {
            return Tables.Get(Index).Products;
        }

        public void AddTableProduct(ProductToSell product)
        {
            Tables.Get(Index).Products.Get(product).Amount++;
        }

        public void SubstractTableProduct(ProductToSell product)
        {
            if (Tables.Get(Index).Products.Get(product).Amount < 2)
            {
                Tables.Get(Index).Products.Remove(product);
            }
            else
            {
                Tables.Get(Index).Products.Get(product).Amount--;
            }
        }

        public void MoveToProductsToSell(ProductToSell product)
        {
            if (!ProductsToSell.Contains(product))
            {
                ProductsToSell.Add(product);
            }
            ProductsToSell.Get(product).Amount++;
            SubstractTableProduct(product);
        }

        public ProductToSellList GetProductsToSell()
        {
            return ProductsToSell;
        }

        public void AddProductToSell(ProductToSell product)
        {
            ProductsToSell.Get(product).Amount++;
        }

        public void SubstractPayProduct(ProductToSell product)
        {
            if (ProductsToSell.Get(product).Amount < 2)
            {
                ProductsToSell.Remove(product);
            }
            else
            {
                ProductsToSell.Get(product).Amount--;
            }
        }
    }
}
