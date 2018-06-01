// Bar POS, class TableList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Load and Save Methods, minor changes, 
//       added save PATH
// V0.03 16-May-2018 Moisés: Get method
// V0.04 21-May-2018 Moisés: Changes in load and save methods

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BarPOS
{
    public class TableList
    {
        private const string PATH = "tables.dat";
        private List<Table> Tables;
        public int Count { get { return Tables.Count; } }

        public TableList()
        {

        }

        ~TableList()
        {
            Save();
        }

        public Table Get(int index)
        {
            return Tables[index - 1];
        }


        public void Add(Table newTable)
        {
            Tables.Add(newTable);
        }

        public void Remove(int removeIndex)
        {
            Tables.RemoveAt(removeIndex - 1);
        }

        public void ChangePosition(int newX, int newY, int Index)
        {
            Tables[Index - 1].X = newX;
            Tables[Index - 1].Y = newY;
            Save();
        }

        public string Load()
        {
            Tables = new List<Table>();
            if (!(File.Exists(PATH)))
            {
                return ("Creating the tables file");
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(PATH, FileMode.Open);

                    Tables = (List<Table>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    return ("Error loading the tables file: " 
                        + e.Message);
                }
            }
            return "";
        }

        public string Save()
        {
            try
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream output = new FileStream(PATH, FileMode.Create);

                binaryFormatter.Serialize(output, Tables);

                output.Close();
            }
            catch (Exception e)
            {
                return ("Error saving the tables file: " 
                    + e.Message);
            }

            return "";
        }

        public void ClearTableProducts()
        {
            for (int i = 0; i < Count; i++)
            {
                Tables[i].Products = new TableProductsList();
            }
        }
    }
}
