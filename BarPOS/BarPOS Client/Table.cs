// Bar POS, class Table

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Added name, constructor,Products, deleted sprite

using System;

namespace BarPOS
{
    [Serializable]
    public class Table
    {
        public TableProductsList Products { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public Table(int x, int y , string name)
        {
            X = x;
            Y = y;
            Name = name;
            Products = new TableProductsList();
        }
    }
}

