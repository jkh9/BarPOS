// Bar POS, class Bill

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds

using System;
using System.Collections.Generic;

namespace BarPOS
{
    [Serializable]
    public class Bill
    {
        public List<BillLine> Lines { get; set; }
        public BillHeader Header { get; set; }
        public double Total { get; set; }

        public void AddLine(BillLine line)
        {
            Lines.Add(line);
        }

        public void RemoveLine(int index)
        {
            Lines.RemoveAt(index -1);
        }

        public void CalculateTotal()
        {
            for (int i = 0; i < Lines.Count; i++)
            {
                Total += (Lines[i].Amount * Lines[i].LineProduct.Price);
            }
        }

    }
}
