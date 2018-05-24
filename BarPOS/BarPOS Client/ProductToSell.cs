// Bar POS, class ProductToSell

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;

using System;

namespace BarPOS
{
    [Serializable]
    public class ProductToSell
    {
        public Product ActualProduct { get; set; }
        public int Amount { get; set; }
    }
}
