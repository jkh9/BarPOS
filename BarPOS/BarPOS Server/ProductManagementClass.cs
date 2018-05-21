// Bar POS, class ProductManagmentScreen

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//   ProductsManagementScreen

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
            Products.Remove(Index);
            MoveBackward();
        }

        public void Modify()
        {
            //TO DO
        }

        public void Search()
        {
            //TO DO
        }

        public void MoveForward()
        {
            if (Index < Count)
            {
                Index++;
            }
        }

        public void MoveBackward()
        {
            if (Index > 1)
            {
                Index--;
            }
        }
    }
}
