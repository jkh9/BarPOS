// Bar POS, class Bill

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 18-May-2018 Moisés: Method ToString, method ToPrintable

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

        //Method to make the bill printable, in order to print it
        public string[] ToPrintable()
        {
            List<string> image = new List<string>();
            image.Add(Header.CompanyData.Name);
            image.Add(Header.CompanyData.Address);
            image.Add("Table: " + Header.Table);
            image.Add("Date: " + Header.Date);
            image.Add("Worker: "+Header.Employee.Name);
            image.Add(new string('-', 20));
            for (int i = 0; i < Lines.Count; i++)
            {
                image.Add(Lines[i].LineProduct.Description + "    " +
                    Lines[i].Amount + "   " + Lines[i].Total);
            }
            image.Add("Total: " + Total);

            return image.ToArray();
        }

        public override string ToString()
        {
            string bill = "";
            bill += Lines[0];
            for (int i = 1; i < Lines.Count; i++)
            {
                bill += "$" + Lines[i].ToString();
            }

            bill += "|" + Header.ToString();
            bill += "|" + Total;
            return bill;
        }
    }
}
