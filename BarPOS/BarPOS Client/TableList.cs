// Bar POS, class TableList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton

using System.Collections.Generic;

namespace BarPOS
{
    public class TableList
    {
        private List<Table> tables;
        public int Index { get; set; }

        public void Add(Table newTable)
        {
            tables.Add(newTable);
        }

        public void Remove(int removeIndex)
        {
            tables.RemoveAt(removeIndex - 1);
        }

        public void ChangePosition()
        {
            //TO DO
        }
    }
}
