// Bar POS, class TableList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Load and Save Methods, minor changes, 
//       added save PATH

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BarPOS
{
    public class TableList
    {
        private const string PATH = "tables.dat";
        public List<Table> Tables { get; set; }
        public int Index { get; set; }

        public TableList()
        {
            Load();
        }

        ~TableList()
        {
            Save();
        }

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

        public void Load()
        {
            if (!(File.Exists(PATH)))
            {
                MessageBox.Show("Creating the tables file");
                Tables = new List<Table>();
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
                    MessageBox.Show("Error loading the tables file: " 
                        + e.Message);
                }
            }
        }

        public void Save()
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
                MessageBox.Show("Error saving the tables file: " 
                    + e.Message);
            }
        }
    }
}
