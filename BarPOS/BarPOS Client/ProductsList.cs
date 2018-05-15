// Bar POS, class ProductList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace BarPOS
{
    public class ProductsList
    {
        public const string PATH = "products.dat";
        public List<Product> Products { get; set; }
        public int Index { get; set; }

        public ProductsList()
        {
            Load();
        }

        ~ProductsList()
        {
            Save();
        }
        
        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Remove(int index)
        {
            Products.RemoveAt(index - 1);
        }

        public void Load()
        {
            if (!(File.Exists(PATH)))
            {
                MessageBox.Show("Creating the products file");
                Products = new List<Product>();
            }
            else
            {
                try
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    FileStream input = new FileStream(PATH, FileMode.Open);

                    Products = (List<Product>)binaryFormatter.Deserialize(input);

                    input.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error loading the products file: "
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

                binaryFormatter.Serialize(output, Products);

                output.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error saving the products file: "
                    + e.Message);
            }
        }
    }
}