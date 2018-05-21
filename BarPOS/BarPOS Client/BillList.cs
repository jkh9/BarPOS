// Bar POS, class BillList

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Methods completeds
// V0.03 16-May-2018 Moisés: Get method
// V0.04 18-May-2018 Moisés: Load and Save method changeds
// V0.05 21-May-2018 Moisés: Changes in load and save methods

using System;
using System.Collections.Generic;
using System.IO;

namespace BarPOS
{
    public class BillList
    {
        public const string PATH = @"..\..\..\Files\bills.txt";
        public List<Bill> Bills { get; set; }
        public int Count { get { return Bills.Count; } }

        public BillList()
        {

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

        public string Load()
        {
            Bills = new List<Bill>();

            if (!(File.Exists(PATH)))
            {
                return ("Creating the bills file");
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
                            Bill bill = new Bill();

                            string[] parts = line.Split('|');
                            //Bill lines
                            string[] billLines = parts[0].Split('$');
                            for (int i = 0; i < billLines.Length; i++)
                            {
                                string[] billLineParts = billLines[i].Split('=');
                                //Product
                                string[] productsParts = billLineParts[0].Split('·');
                                Product product = new Product();

                                product.Description = productsParts[0];
                                product.Price = Convert.ToDouble(productsParts[1]);
                                product.ImagePath = productsParts[2];
                                product.Stock = Convert.ToInt32(productsParts[3]);
                                product.MinimunStock = Convert.ToInt32(productsParts[4]);
                                product.Code = Convert.ToInt32(productsParts[5]);
                                product.Category = productsParts[6];
                                product.BuyPrice = Convert.ToDouble(productsParts[7]);

                                //amount
                                int amount = Convert.ToInt32(billLineParts[1]);

                                BillLine billLine = new BillLine(product, amount);
                                bill.AddLine(billLine);
                            }

                            //Header
                            string[] headerParts = parts[1].Split('=');

                            //Other things
                            string[] otherParts = headerParts[0].Split('·');
                            int table = Convert.ToInt32(otherParts[0]);
                            int number = Convert.ToInt32(otherParts[1]);
                            string date = otherParts[2];

                            //User
                            string[] userParts = headerParts[1].Split('·');

                            User employee = new User();

                            employee.Name = userParts[0];
                            employee.Code = Convert.ToInt32(userParts[1]);
                            employee.ImagePath = userParts[2];


                            BillHeader billHeader =
                                new BillHeader(number, employee, table);
                            billHeader.Date = Convert.ToDateTime(date);

                            //Total
                            int total = Convert.ToInt32(parts[2]);

                            bill.Total = total;
                            bill.Header = billHeader;

                            this.Add(bill);
                        }
                    } while (line != null);

                    input.Close();
                }
                catch (Exception e)
                {
                    return ("Error loading the bills file: "
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

                foreach (Bill bill in Bills)
                {
                    output.WriteLine(bill);
                }

                output.Close();
            }
            catch (Exception e)
            {
                return ("Error saving the bills file: "
                    + e.Message);
            }
            return "";
        }
    }
}

