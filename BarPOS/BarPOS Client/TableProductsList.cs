// Bar POS, class TableProductsList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 24-May-2018 Moisés: Methods contains and indexOf
// V0.04 25-May-2018 Moisés: methods get by a product and delete by a product

using System;
using System.Collections.Generic;

namespace BarPOS
{
    [Serializable]
    public class TableProductsList
    {
        public List<ProductToSell> Products { get; set; }
        public int Count { get { return Products.Count; } }

        public TableProductsList()
        {
            Products = new List<ProductToSell>();
        }

        public ProductToSell Get(int index)
        {
            return Products[index - 1];
        }

        public ProductToSell Get(ProductToSell product)
        {
            return Products[IndexOf(product)];
        }

        public void Add(ProductToSell product)
        {
            Products.Add(product);
        }

        public void Remove(int index)
        {
            Products.RemoveAt(index -1);
        }

        public void Remove(ProductToSell product)
        {
            Products.RemoveAt(IndexOf(product));
        }

        public ProductToSell MoveToSelled(int index)
        {
            return Products[index - 1];
        }

        public bool Contains(ProductToSell product)
        {
            for (int i = 0; i < Count; i++)
            {
                if (Products[i].ActualProduct.Code == 
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
                if (Products[i].ActualProduct.Code ==
                    product.ActualProduct.Code)
                {
                    return (i);
                }
            }
            return 0;
        }
    }
}
