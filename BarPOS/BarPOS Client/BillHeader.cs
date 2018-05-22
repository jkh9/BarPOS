// Bar POS, class BillHeader

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: CompanyData spreed into name,addres
// V0.03 18-May-2018 Moisés: Method ToString

using System;

namespace BarPOS
{
    public struct Company
    {
        public string Name;
        public string Address;
    }
    public class BillHeader
    {
        public Company CompanyData { get; set; }
        public int Table { get; set; }
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public User Employee { get; set; }

        public BillHeader(int number, User employee, int table)
        {
            CompanyData = new Company
            {
                Name = "Moisex S.L",
                Address = "C/ Lillo Juan, 128"
            };

            Table = table;
            Employee = employee;
            Number = number;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return Table + "·" + Number + "·" + Date + "=" + 
                Employee.ToString();
        }
    }
}