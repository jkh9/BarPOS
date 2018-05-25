// Bar POS, class TablesClass

// Versiones: 
// V0.01 21-May-2018 Moisés: Basic skeleton, updated from 
//    TablesScreen

namespace BarPOS
{
    public class TablesClass
    {
        public string ImagePath { get; set; }
        public TableList Tables { get; set; }
        public ProductsList Products { get; set; }
        public BillList Bills { get; set; }
        public int Count { get { return Tables.Count; } }
        public User Employee { get; set; }

        public TablesClass(ProductsList products, BillList bills,
            User employee)
        {
            Tables = new TableList();
            Products = products;
            Bills = bills;
            Employee = employee;
        }

        public Table GetTable(int index)
        {
            return Tables.Get(index);
        }

        public void RefreshTablesInUse()
        {
            for (int i = 1; i <= Count; i++)
            {
                if (Tables.Get(i).Products.Count == 0)
                {
                    Tables.Get(i).InUse = false;
                }
            }
            Tables.Save();
        }

    }
}
