// Bar POS, class TableProductsList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds

using System;
using System.Collections.Generic;

namespace BarPOS
{
    [Serializable]
    public class TableProductsList
    {
        public List<SellProduct> Products { get; set; }
        public int Count { get { return Products.Count; } }

        public SellProduct Get(int index)
        {
            return Products[index - 1];
        }

        public void Add(SellProduct product)
        {
            Products.Add(product);
        }

        public void Remove(int index)
        {
            Products.RemoveAt(index -1);
        }

        public SellProduct MoveToSelled(int index)
        {
            return Products[index - 1];
        }
    }
}
