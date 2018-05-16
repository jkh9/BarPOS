// Bar POS, class BillList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 16-May-2018 Moisés: Get method

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BarPOS
{
    public class BillList
    {
        public const string PATH = "bills.dat";
        public List<Bill> Bills { get; set; }
        public int Count { get { return Bills.Count; } }

        public BillList()
        {
            Load();
        }

        ~BillList()
        {
            Save();
        }

        public Bill Get(int index)
        {
            return Bills[index - 1];
        }

        public void Add(Bill bill)
        {
            Bills.Add(bill);
        }

        public void Remove(int index)
        {
            Bills.RemoveAt(index - 1);
        }

        public void Load()
        {
            if (!(File.Exists(PATH)))
            {
                MessageBox.Show("Creating the bills file");
                Bills = new List<Bill>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(PATH, FileMode.Open);

                    Bills = (List<Bill>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error loading the bills file: "
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

                binaryFormatter.Serialize(output, Bills);

                output.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving the bills file: "
                    + e.Message);
            }
        }
    }
}

