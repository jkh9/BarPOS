// Bar POS, class POSScreenList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System.Collections.Generic;

namespace BarPOS
{
    class POSScreenList
    {
        private ProductsList products;
        private List<POSScreen> POSScreens;
        public int Index { get; set; }

        public POSScreenList(ProductsList Products)
        {
            this.products = Products;
        }

        public void Add(POSScreen newPOSScreen)
        {
            POSScreens.Add(new POSScreen(products));
        }

        public void Remove(int removeIndex)
        {
            POSScreens.RemoveAt(removeIndex - 1);
        }

        public void ChangePosition()
        {
            //TO DO
        }
    }
}

