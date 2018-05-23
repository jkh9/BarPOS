// Bar POS, class POSScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: Added moveToTable, minor changes, 
//      added the close method, open the payScreen
// V0.03 16-May-2018 Moisés: Changes in the constructor, method move to table
// method tableup, tabledown
// V0.04 17-May-2018 César: Added the help button so that a help menu appears 
// on the screen with its different options that will be made later.

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
        }

        private void DrawCategories()
        {
            Controls.Clear();
            InitializeComponent();

            this.lblTableNumber.Text = POS.Index.ToString();
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
            Controls.Clear();
            InitializeComponent();

            this.lblTableNumber.Text = POS.Index.ToString();
            this.lblWorker.Text = POS.Employee.Code.ToString("000");

            int productIndex = 1;

            for (int column = 0; column < 7; column++)
            {
                for (int row = 0; row < 7; row++)
                {
                    Product actualProduct = POS.Products.Get(productIndex);

                    if (actualProduct.Category == category)
                    {
                        if (productIndex < POS.Products.Count - 1)
                        {
                            Button product = new Button();
                            product.FlatStyle = FlatStyle.Popup;
                            product.Location =
                                new System.Drawing.Point(0 + (row * 90), 0 + (column * 70));
                            product.Name = "lbl";
                            product.Size = new System.Drawing.Size(90, 70);
                            product.TabIndex = 57;
                            product.BackgroundImage =
                                System.Drawing.Image.FromFile(actualProduct.ImagePath);
                            product.BackgroundImageLayout = ImageLayout.Stretch;
                            product.UseVisualStyleBackColor = true;

                            pnlProducts.Controls.Add(product);
                        }
                        else if (productIndex < POS.Products.Count)
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

                            pnlProducts.Controls.Add(product);
                        }
                        else
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
                    }

                    if (productIndex == POS.Products.Count)
                    {
                        productIndex++;
                    }
                }
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
        }

        //Event to move to previous table taking care of the tables in use
        private void btnTableDown_Click(object sender, System.EventArgs e)
        {
            POS.TableDown();
            lblTableNumber.Text = POS.Index.ToString();
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
    }
}
