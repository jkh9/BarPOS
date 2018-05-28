// Bar POS, class SelledProductsList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 28-May-2018 Moisés: Methods contains, index of, CalculateTotal

using System.Collections.Generic;

namespace BarPOS
{
    public class ProductToSellList
    {
        public List<ProductToSell> ProductsToSell { get; set; }
        public int Count { get { return ProductsToSell.Count; } }
        public double Total { get; set; }

        public ProductToSellList()
        {
            ProductsToSell = new List<ProductToSell>();
        }

        public ProductToSell Get(int index)
        {
            return ProductsToSell[index - 1];
        }

        public void Add(ProductToSell product)
        {
            ProductsToSell.Add(product);
        }

        public void Remove(int index)
        {
            ProductsToSell.RemoveAt(index - 1);
        }

        public bool Contains(ProductToSell product)
        {
            for (int i = 0; i < Count; i++)
            {
                if (ProductsToSell[i].ActualProduct.Code ==
                    product.ActualProduct.Code)
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(ProductToSell product)
        {
            for (int i = 0; i < Count; i++)
            {
                if (ProductsToSell[i].ActualProduct.Code ==
                    product.ActualProduct.Code)
                {
                    return (i);
                }
            }
            return 0;
        }

        public ProductToSell Get(ProductToSell product)
        {
            return ProductsToSell[IndexOf(product)];
        }

        public void Remove(ProductToSell product)
        {
            ProductsToSell.RemoveAt(IndexOf(product));
        }

        public void CalculeTotal()
        {
            Total = 0;

            for (int i = 0; i < Count; i++)
            {
                Total += ProductsToSell[i].ActualProduct.Price *
                    ProductsToSell[i].Amount;
            }
        }
    }
}
