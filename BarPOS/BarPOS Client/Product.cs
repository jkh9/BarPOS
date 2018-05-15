// Bar POS, class Product

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System;
using System.Drawing;

namespace BarPOS
{
    [Serializable]
    public class Product
    {
        public string Description { get; set; }
        public double Price { get; set; }
        public Image Image { get; set; }
        public int Stock { get; set; }
        public int MinimunStock { get; set; }
        public int Code { get; set; }
        public int Category { get; set; }
        public int BuyPrice { get; set; }
    }
}