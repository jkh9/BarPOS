// Bar POS, class Product

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 18-May-2018 Moisés: Method ToString, image is now ImagePath
// V0.03 22-May-2018 Moisés: Property found added

using System;

namespace BarPOS
{
    [Serializable]
    public class Product
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImagePath { get; set; }
        public int Stock { get; set; }
        public int MinimunStock { get; set; }
        public int Code { get; set; }
        public string Category { get; set; }
        public double BuyPrice { get; set; }
        public bool Found { get; set; }

        public override string ToString()
        {
            return Description + "·" + Price + "·" + ImagePath + "·" + Stock +
                "·" + MinimunStock + "·" + Code + "·" + Category + "·" + 
                BuyPrice;
        }
    }
}