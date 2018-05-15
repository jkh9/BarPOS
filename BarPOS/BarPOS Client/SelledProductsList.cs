// Bar POS, class SelledProductsList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds

using System.Collections.Generic;

namespace BarPOS
{
    public class SelledProductsList
    {
        public List<SellProduct> ProductsToSell { get; set; }
        public int Index { get; set; }

        public void Add(SellProduct product)
        {
            ProductsToSell.Add(product);
        }

        public void Remove(int index)
        {
            ProductsToSell.RemoveAt(index - 1);
        }
    }
}
