// Bar POS, class POSScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Added moveToTable, minor changes, 
//      added the close method, open the payScreen
// V0.03 16-May-2018 Moisés: Changes in the constructor, method move to table
//      method tableup, tabledown
// V0.04 17-May-2018 César: Added the help button so that a help menu appears 
//      on the screen with its different options that will be made later.
// V0.05 23-May-2018 Moisés: Added the Draw method for the categories
//      and products
// V0.06 24-May-2018 Moisés: Started the Draw method for the tableProducts
//      and click methods 
// V0.07 25-May-2018 Moisés: Changes in order to show the product table 

using System;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class POSScreen : Form
    {
        public POSSClass POS { get; set; }
        PayScreen PayScreen;

        public POSScreen(ProductsList products, TableList tables,
            BillList bills, int index, User employee)
        {
            POS = new POSSClass(products, tables, bills, index,employee);
            InitializeComponent();

            DrawCategories();
            DrawTableProducts();
        }

        private void DrawCategories()
        {
            pnlProducts.Controls.Clear();

            this.lblWorker.Text = POS.Employee.Code.ToString("000");

            int categoryIndex = 0;

            string[] categories = POS.Products.GetCategories();

            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 7; row++)
                {
                    if (categoryIndex < categories.Length)
                    {
                        Button category = new Button();
                        category.FlatStyle = FlatStyle.Popup;
                        category.Location =
                            new System.Drawing.Point(0 + (row * 90),
                            0 + (column * 70));
                        category.Name = "lbl";
                        category.Size = new System.Drawing.Size(90, 70);
                        category.TabIndex = 57;
                        category.BackgroundImageLayout = ImageLayout.Stretch;
                        category.UseVisualStyleBackColor = true;
                        category.Text = categories[categoryIndex];
                        category.Font = new System.Drawing.Font("Arial", 13);
                        category.Click += 
                            new System.EventHandler(category_Click);

                        pnlProducts.Controls.Add(category);

                        categoryIndex++;
                    }
                    else
                    {
                        Button category = new Button();
                        category.FlatStyle = FlatStyle.Popup;
                        category.Location =
                            new System.Drawing.Point(0 + (row * 90),
                            0 + (column * 70));
                        category.Name = "lbl";
                        category.Size = new System.Drawing.Size(90, 70);

                        pnlProducts.Controls.Add(category);
                    }
                }
            }
        }

        private void DrawProducts(string category)
        {
            pnlProducts.Controls.Clear();

            this.lblWorker.Text = POS.Employee.Code.ToString("000");

            int productIndex = 1;

            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 7; row++)
                {
                    Product actualProduct;

                    do
                    {
                        if (productIndex <= POS.Products.Count)
                        {
                            actualProduct = POS.Products.Get(productIndex);
                        }
                        else
                        {
                            actualProduct = POS.Products.Get(1);
                        }

                        if (actualProduct.Category == category &&
                            productIndex <= POS.Products.Count)
                        {
                            Button product = new Button();
                            product.FlatStyle = FlatStyle.Popup;
                            product.Location =
                                new System.Drawing.Point(0 + (row * 90), 0 + (column * 70));
                            product.Name = "lbl "+ productIndex;
                            product.Size = new System.Drawing.Size(90, 70);
                            product.TabIndex = 57;
                            product.BackgroundImage =
                                System.Drawing.Image.FromFile(actualProduct.ImagePath);
                            product.BackgroundImageLayout = ImageLayout.Stretch;
                            product.UseVisualStyleBackColor = true;
                            product.Click +=
                            new System.EventHandler(product_Click);

                            pnlProducts.Controls.Add(product);
                        }
                        

                        if (productIndex == POS.Products.Count + 1)
                        {
                            Button product = new Button();
                            product.FlatStyle = FlatStyle.Popup;
                            product.Location =
                                new System.Drawing.Point(0 + (row * 90), 0 + (column * 70));
                            product.Name = "lbl";
                            product.Size = new System.Drawing.Size(90, 70);
                            product.TabIndex = 57;
                            product.Text = "BACK";
                            product.BackgroundImageLayout = ImageLayout.Stretch;
                            product.UseVisualStyleBackColor = true;
                            product.Click +=
                            new System.EventHandler(back_Click);

                            pnlProducts.Controls.Add(product);
                        }
                        else if (productIndex > POS.Products.Count + 1)
                        {
                            Button white = new Button();
                            white.FlatStyle = FlatStyle.Popup;
                            white.Location =
                                new System.Drawing.Point(0 + (row * 90),
                                0 + (column * 70));
                            white.Name = "lbl";
                            white.Size = new System.Drawing.Size(90, 70);
                            pnlProducts.Controls.Add(white);
                        }

                        if (productIndex <= POS.Products.Count + 1)
                        {
                            productIndex++;
                        }

                    } while (actualProduct.Category != category && 
                    productIndex <= POS.Products.Count + 1);
                }
            }
        }

        private void DrawTableProducts()
        {
            pnlTableProducts.Controls.Clear();
            this.lblWorker.Text = POS.Employee.Code.ToString("000");

            this.lblTableNumber.Text = POS.Index.ToString();

            TableProductsList products = POS.GetTableProducts();

            for (int i = 1; i <= products.Count; i++)
            {
                ProductToSell actualProduct = products.Get(i);
                // 
                // btnSubstract
                // 
                Button btnSubstract = new Button();
                btnSubstract.BackColor = System.Drawing.Color.White;
                btnSubstract.FlatAppearance.BorderColor = 
                    System.Drawing.Color.Black;
                btnSubstract.FlatStyle = 
                    FlatStyle.Popup;
                btnSubstract.Font = 
                    new System.Drawing.Font("Microsoft Sans Serif", 
                    15.75F, System.Drawing.FontStyle.Regular, 
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnSubstract.Location = new System.Drawing.Point(56, 110);
                btnSubstract.Name = "btnSubstract "+i;
                btnSubstract.Size = new System.Drawing.Size(33, 33);
                btnSubstract.TabIndex = 80;
                btnSubstract.Text = "-";
                btnSubstract.UseVisualStyleBackColor = false;
                btnSubstract.Click +=
                            new System.EventHandler(btnSubstract_Click);
                // 
                // btnAdd
                // 
                Button btnAdd = new Button();
                btnAdd.BackColor = System.Drawing.Color.White;
                btnAdd.FlatAppearance.BorderColor = 
                    System.Drawing.Color.Black;
                btnAdd.FlatStyle = FlatStyle.Popup;
                btnAdd.Font = 
                    new System.Drawing.Font("Microsoft Sans Serif", 
                    15.75F, System.Drawing.FontStyle.Regular, 
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnAdd.Location = new System.Drawing.Point(56, 78);
                btnAdd.Name = "btnAdd "+i;
                btnAdd.Size = new System.Drawing.Size(33, 33);
                btnAdd.TabIndex = 81;
                btnAdd.Text = "+";
                btnAdd.UseVisualStyleBackColor = false;
                btnAdd.Click +=
                            new System.EventHandler(btnAdd_Click);
                // 
                // lblAmount
                // 
                Label lblAmount = new Label();
                lblAmount.BackColor = System.Drawing.Color.White;
                lblAmount.BorderStyle = BorderStyle.FixedSingle;
                lblAmount.Font = 
                    new System.Drawing.Font("Arial", 
                    27.75F, System.Drawing.FontStyle.Regular,
                    System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                lblAmount.Location = new System.Drawing.Point(-9, 78);
                lblAmount.Name = "label15";
                lblAmount.Size = new System.Drawing.Size(68, 65);
                lblAmount.TabIndex = 82;
                lblAmount.Text = actualProduct.Amount.ToString();
                lblAmount.TextAlign = 
                    System.Drawing.ContentAlignment.MiddleRight;
                // 
                // pbImage
                // 
                PictureBox pbImage = new PictureBox();
                pbImage.BackColor = System.Drawing.Color.White;
                pbImage.BorderStyle = BorderStyle.Fixed3D;
                pbImage.Location = new System.Drawing.Point(-2, -2);
                pbImage.Name = "pbImage";
                pbImage.Size = new System.Drawing.Size(90, 80);
                pbImage.TabIndex = 79;
                pbImage.TabStop = false;
                pbImage.Image = System.Drawing.Image.FromFile(
                    actualProduct.ActualProduct.ImagePath);
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                // 
                //Panel container
                // 
                Panel tableProduct = new Panel();
                tableProduct.BorderStyle = BorderStyle.Fixed3D;
                tableProduct.Controls.Add(btnAdd);
                tableProduct.Controls.Add(btnSubstract);
                tableProduct.Controls.Add(lblAmount);
                tableProduct.Controls.Add(pbImage);
                tableProduct.Location =
                    new System.Drawing.Point(0 + ((i-1) * 90), 0);
                tableProduct.Name = "pnl " + i;
                tableProduct.Size = new System.Drawing.Size(90, 145);
                tableProduct.TabIndex = 85;

                pnlTableProducts.Controls.Add(tableProduct);
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        //Event to open the payScreen
        private void btnPay_Click(object sender, System.EventArgs e)
        {
            PayScreen = new PayScreen(POS.ProductsToSell, POS.Bills);
            PayScreen.StartPosition = FormStartPosition.CenterScreen;
            PayScreen.Show();
        }

        //Event to move to next table taking care of the tables in use
        private void btnTableUp_Click(object sender, System.EventArgs e)
        {
            POS.TableUp();
            lblTableNumber.Text = POS.Index.ToString();
            DrawTableProducts();
        }

        //Event to move to previous table taking care of the tables in use
        private void btnTableDown_Click(object sender, System.EventArgs e)
        {
            POS.TableDown();
            lblTableNumber.Text = POS.Index.ToString();
            DrawTableProducts();
        }

        //Event to show 
        private void btnHelp_Click(object sender, System.EventArgs e)
        {
            picHelp.BringToFront();
            picHelp.Visible = true;
            btnExitHelp.BringToFront();
            btnExitHelp.Visible = true;
        }

        private void btnExitHelp_Click(object sender, System.EventArgs e)
        {
            picHelp.Visible = false;
            btnExitHelp.Visible = false;
        }

        private void lblWorker_MouseDown(object sender, MouseEventArgs e)
        {
            lblUserName.Visible = true;
            lblUserName.Text = POS.Employee.Name;
        }

        private void lblWorker_MouseUp(object sender, MouseEventArgs e)
        {
            lblUserName.Visible = false;
        }

        private void category_Click(object sender, System.EventArgs e)
        {
            DrawProducts(((Button)sender).Text);
        }

        private void back_Click(object sender, System.EventArgs e)
        {
            DrawCategories();
        }

        private void product_Click(object sender, System.EventArgs e)
        {
            int index = Convert.ToInt32(
                ((Button)sender).Name.Split()[1]);

            ProductToSell product = new ProductToSell();
            product.ActualProduct = POS.Products.Get(index);
            product.Amount = 1;

            POS.MoveToTable(product);
            DrawTableProducts();
        }

        private void btnSubstract_Click(object sender, System.EventArgs e)
        {
            int index = Convert.ToInt32(
                ((Button)sender).Name.Split()[1]);

            ProductToSell product = new ProductToSell();
            product.ActualProduct = POS.Products.Get(index);

            POS.SubstractProduct(product);
            DrawTableProducts();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            int index = Convert.ToInt32(
                ((Button)sender).Name.Split()[1]);

            ProductToSell product = new ProductToSell();
            product.ActualProduct = POS.Products.Get(index);

            POS.AddProduct(product);
            DrawTableProducts();
        }
    }
}
