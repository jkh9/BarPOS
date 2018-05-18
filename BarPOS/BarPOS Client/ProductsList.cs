// Bar POS, class ProductList

// Versiones: 
// V0.01 14-May-2018 Mois�s: Basic skeleton
// V0.02 15-May-2018 Mois�s: Methods completeds
// V0.03 16-May-2018 Mois�s: Get method
// V0.04 18-May-2018 Mois�s: Load and Save changeds to txt

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace BarPOS
{
    public class ProductsList
    {
        public const string PATH = @"..\..\..\Files\products.txt";
        public List<Product> Products { get; set; }
        public int Count { get { return Products.Count; } }

        public ProductsList()
        {
            Load();
        }

        ~ProductsList()
        {
            Save();
        }
        
        public Product Get(int index)
        {
            return Products[index -1];
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
            Products = new List<Product>();

            if (!(File.Exists(PATH)))
            {
                MessageBox.Show("Creating the products file");
            }
            else
            {
                try
                {
                    StreamReader input = new StreamReader(PATH);

                    string line = "";
                    do
                    {
                        line = input.ReadLine();
                        if (line != null)
                        {
                            string[] parts = line.Split('�');

                            Product product = new Product();

                            product.Description = parts[0];
                            product.Price = Convert.ToDouble(parts[1]);
                            product.ImagePath = parts[2];
                            product.Stock = Convert.ToInt32(parts[3]);
                            product.MinimunStock = Convert.ToInt32(parts[4]);
                            product.Code = Convert.ToInt32(parts[5]);
                            product.Category = parts[6];
                            product.BuyPrice = Convert.ToDouble(parts[7]);
                            this.Add(product);
                        }
                    } while (line != null);

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
                StreamWriter output = new StreamWriter(PATH);

                foreach (Product product in Products)
                {
                    output.WriteLine(product);
                }

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