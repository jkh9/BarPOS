// Bar POS, class Bill

// Versiones: 
// V0.01 14-May-2018 Mois�s: Basic skeleton

using System.Collections.Generic;

namespace BarPOS
{
    public class Bill
    {
        public List<BillLine> Lines { get; set; }
        public BillHeader Header { get; set; }
        public int Total { get; set; }

        public void AddLine()
        {
            //TO DO
        }

        public void RemoveLine()
        {
            //TO DO
        }

        public void CalculateTotal()
        {
            //TO DO
        }

    }
}
