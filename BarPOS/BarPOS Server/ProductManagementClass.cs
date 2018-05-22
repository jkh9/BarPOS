﻿// Bar POS, class ProductManagmentScreen

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//   ProductsManagementScreen
// V0.02 22-May-2018 Moisés: search ,modify method simplementeds, minor changes

namespace BarPOS
{
    public class ProductManagementClass
    {
        public int Index { get; set; }
        public ProductsList Products { get; set; }
        public int Count { get { return Products.Count; } }

        public ProductManagementClass(ProductsList products)
        {
            Products = products;
            Index = 1;
        }

        public Product GetActualProduct()
        {
            return Products.Get(Index);
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Remove()
        {
            if (Count > 0)
            {
                Products.Remove(Index);
            }
            MoveBackward();
        }

        public void Modify(Product newProduct)
        {
            Products.Reeplace(Index,newProduct);
        }

        public bool Search(string text)
        {
            if (text != null)
            {
                text = text.ToLower();

                bool found = false;

                for (int i = 1; i <= Count; i++)
                {
                    Product ActualProduct = Products.Get(i);

                    if (ActualProduct.ToString().ToLower().Contains(text))
                    {
                        ActualProduct.Found = true;
                        found = true;
                    }
                }
                return found;
            }
            return false;
        }

        public void MoveForward()
        {
            if (Index < Count)
            {
                Index++;
            }
            else
            {
                Index = 1;
            }
        }

        public void MoveBackward()
        {
            if (Index > 1)
            {
                Index--;
            }
            else
            {
                Index = Count;
            }
        }
    }
}
