// Bar POS, class TableList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System.Collections.Generic;
using System.Windows.Forms;

namespace BarPOS
{
    public class TableList
    {
        private List<Table> Tables;
        public int Index { get; set; }

        public void Add(Table newTable)
        {
            Tables.Add(newTable);
        }

        public void Remove(int removeIndex)
        {
            Tables.RemoveAt(removeIndex - 1);
        }

        public void ChangePosition()
        {
            //TO DO
        }
    }
}
