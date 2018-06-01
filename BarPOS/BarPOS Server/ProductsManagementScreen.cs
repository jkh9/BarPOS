// Bar POS, class ProductManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form
// V0.03 18-May-2018 Moisés: Add method, initialize method, method to move 
//    forward and backward, delete Product

using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class ProductsManagmentScreen : Form
    {
        private ProductManagementClass ProductManagement;
        private SearchScreen searchScreen;
        Languajes languaje;

        public ProductsManagmentScreen(ProductsList products, Languajes languaje)
        {
            ProductManagement = new ProductManagementClass(products);
            searchScreen = new SearchScreen(languaje);
            InitializeComponent();
            Draw();
            this.languaje = languaje;
            drawTexts();
        }

        private void drawTexts()
        {
            switch (languaje)
            {
                case Languajes.Castellano:
                    btnBackToMainMenu.Text = "Volver al menu";
                    lblDescription.Text = "Descripción:";
                    lblPrice.Text = "Precio:";
                    lblStock.Text = "Stock:";
                    lblMinimunStock.Text = "Stock mínimo:";
                    lblCategory.Text = "Categoría:";
                    lblBuyPrice.Text = "Precio compra:";
                    lblCode.Text = "Codigo:";
                    btnBack.Text = "Volver";
                    btnModify.Text = "Modificar";
                    btnDelete.Text = "Borrar";
                    btnAdd.Text = "Añadir";
                    btnValidate.Text = "Añadir";
                    btnSearch.Text = "Buscar";
                    lblProduct.Text = "Producto";
                    break;
                case Languajes.English:
                    btnBackToMainMenu.Text = "Back to main";
                    lblDescription.Text = "Description:";
                    lblPrice.Text = "Price:";
                    lblStock.Text = "Stock:";
                    lblMinimunStock.Text = "Minimun Stock:";
                    lblCategory.Text = "Category:";
                    lblBuyPrice.Text = "Buy Price:";
                    lblCode.Text = "Code:";
                    btnBack.Text = "Back";
                    btnModify.Text = "Modify";
                    btnDelete.Text = "Delete";
                    btnAdd.Text = "Add";
                    btnValidate.Text = "Add";
                    btnSearch.Text = "Search";
                    lblProduct.Text = "Product";
                    break;
            }
        }

        //Method to draw the actual product
        public void Draw()
        {
            if (ProductManagement.Count < 1)
            {
                Controls.Clear();
                InitializeComponent();
                lblIndex.Text = "0/0";
            }
            else
            {
                Product actualProduct =
                ProductManagement.GetActualProduct();

                lblIndex.Text =
                    ProductManagement.Index + "/" + ProductManagement.Count;

                txtCode.Text = actualProduct.Code.ToString("000");
                pbImage.ImageLocation = actualProduct.ImagePath;
                txtBuyPrice.Text = actualProduct.BuyPrice + "";
                txtCategory.Text = actualProduct.Category + "";
                txtMinimunStock.Text = actualProduct.MinimunStock + "";
                txtName.Text = actualProduct.Description + "";
                txtPrice.Text = actualProduct.Price + "";
                txtStock.Text = actualProduct.Stock + "";
            }
            drawTexts();
        }

        public void Save()
        {
            string errorCode = ProductManagement.Save();
            if (errorCode != "")
            {
                MessageBox.Show(errorCode);
            }
        }
        
        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            if (ProductManagement.Count == 0)
            {
                this.txtCode.Text = "001";
            }
            else
            {
                this.txtCode.Text = (ProductManagement.Count + 1).
                ToString("000");
            }

            lblIndex.Text =
                    (ProductManagement.Index + 1) + "/" + ProductManagement.Count;

            this.btnForward.Visible = false;
            this.btnBackward.Visible = false;
            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnModify.Visible = false;
            this.btnSearch.Visible = false;
            this.btnValidate.Visible = true;
        }

        private void add()
        {
            try
            {
                Product newProduct = new Product();
                newProduct.ImagePath = pbImage.ImageLocation;
                newProduct.BuyPrice = Convert.ToDouble(txtBuyPrice.Text);
                newProduct.Category = txtCategory.Text;
                newProduct.Code = Convert.ToInt32((
                    ProductManagement.Count + 1).ToString("000"));
                newProduct.Description = txtName.Text;
                newProduct.MinimunStock =
                    Convert.ToInt32(txtMinimunStock.Text);
                newProduct.Price = Convert.ToDouble(txtPrice.Text);
                newProduct.Stock = Convert.ToInt32(txtStock.Text);

                ProductManagement.Add(newProduct);
                Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el producto");
            }

            this.Controls.Clear();
            InitializeComponent();
            Draw();
        }

        private void validate_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (ProductManagement.Count > 1)
            {
                modify();
            }
            ProductManagement.MoveBackward();
            Draw();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (ProductManagement.Count > 1)
            {
                modify();
            }
            ProductManagement.MoveForward();
            Draw();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductManagement.Remove();
            Save();
            Draw();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = Application.StartupPath + @"\imgs\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.png)| " +
                "*.jpg;*.jpeg;*.png; | All files(*.*) | *.* ";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                string fileName = getImage.FileName.Substring(
                                        getImage.FileName.LastIndexOf('\\'));

                string sourceFile = getImage.FileName;
                string destFile =
                    Application.StartupPath + @"\imgs\" + fileName;

                if (!File.Exists(destFile))
                {
                    File.Copy(sourceFile, destFile, true);
                }

                this.pbImage.ImageLocation = Application.StartupPath
                    + "\\imgs\\" + fileName;
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchScreen.StartPosition = FormStartPosition.CenterParent;
            searchScreen.ShowDialog();
            if (ProductManagement.Search(searchScreen.TextToSearch))
            {
                Draw();
                pnlTopBar.BackColor = Color.Gold;
                this.btnBack.Visible = true;
            }
            else
            {
                MessageBox.Show("No results found");
            }
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            this.btnBack.Visible = false;
            ProductManagement.DrawFounds = false;
            pnlTopBar.BackColor = Color.Gainsboro;

            //restarting the found attribute
            for (int i = 1; i <= ProductManagement.Count; i++)
            {
                ProductManagement.Products.Get(i).Found = false;
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            modify();
        }

        private void modify()
        {
            try
            {
                Product newProduct = new Product();
                newProduct.ImagePath = pbImage.ImageLocation;
                newProduct.BuyPrice = Convert.ToDouble(txtBuyPrice.Text);
                newProduct.Category = txtCategory.Text;
                newProduct.Code = Convert.ToInt32(txtCode.Text);
                newProduct.Description = txtName.Text;
                newProduct.MinimunStock =
                    Convert.ToInt32(txtMinimunStock.Text);
                newProduct.Price = Convert.ToDouble(txtPrice.Text);
                newProduct.Stock = Convert.ToInt32(txtStock.Text);

                ProductManagement.Modify(newProduct);
                Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el producto");
            }

            this.Controls.Clear();
            InitializeComponent();
            Draw();
        }

        private void any_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (btnModify.Visible)
                {
                    modify();
                }
                else
                {
                    add();
                }
            }
        }
    }
}
