// Bar POS, class ProductList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 16-May-2018 Moisés: Get method
// V0.04 18-May-2018 Moisés: Load and Save changeds to txt
// V0.05 21-May-2018 Moisés: Changes in load and save methods
// V0.06 22-May-2018 Moisés: Reeplace method

using System;
using System.Collections.Generic;
using System.IO;

namespace BarPOS
{
    public class ProductsList
    {
        private const string PATH = @"..\..\..\Files\products.txt";
        private List<Product> Products;
        public int Count { get { return Products.Count; } }

        public ProductsList()
        {

        }

        ~ProductsList()
        {
            Save();
        }

        public Product Get(int index)
        {
            return Products[index - 1];
        }

        public void Add(Product product)
        {
            Products.Add(product);
        }

        public void Remove(int index)
        {
            Products.RemoveAt(index - 1);
        }

        public void Reeplace(int index, Product newProduct)
        {
            Products[index -1] = newProduct;
        }

        public string Load()
        {
            Products = new List<Product>();

            if (!(File.Exists(PATH)))
            {
                return ("Creating the products file");
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
                            string[] parts = line.Split('·');

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
                    return ("Error loading the products file: "
                        + e.Message);
                }
            }
            return "";
        }

        public string Save()
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
                return ("Error saving the products file: "
                    + e.Message);
            }
            return "";
        }
    }
}