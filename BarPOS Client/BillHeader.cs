// Bar POS, class BillHeader

// Versiones: 
// V0.01 14-May-2018 Mois�s: Basic skeleton

using System;

namespace BarPOS
{
    public class BillHeader
    {
        public string CompanyData { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
    }
}