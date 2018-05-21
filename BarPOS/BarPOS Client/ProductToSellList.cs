// Bar POS, class SelledProductsList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds

using System.Collections.Generic;

namespace BarPOS
{
    public class ProductToSellList
    {
        public List<ProductToSell> ProductsToSell { get; set; }
        public int Count { get { return ProductsToSell.Count; } }

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
    }
}
