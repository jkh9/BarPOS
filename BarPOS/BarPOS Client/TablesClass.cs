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
    }
}
