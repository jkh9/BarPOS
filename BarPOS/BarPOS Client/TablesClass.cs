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
        public UsersList Users { get; set; }
        public int Count { get { return Tables.Count; } }

        public TablesClass(ProductsList products, BillList bills,
            UsersList users)
        {
            Tables = new TableList();
            Products = products;
            Bills = bills;
            Users = users;
        }

        public Table GetTable(int index)
        {
            return Tables.Get(index);
        }
    }
}
