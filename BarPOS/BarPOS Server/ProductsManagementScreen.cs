﻿// Bar POS, class ProductManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form
// V0.03 18-May-2018 Moisés: Add method, initialize method, method to move 
//    forward and backward, delete Product

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class ProductsManagmentScreen : Form
    {
        public ProductManagementClass ProductManagement { get; set; }

        public ProductsManagmentScreen(ProductsList products)
        {
            ProductManagement = new ProductManagementClass(products);

            InitializeComponent();
            Draw();
        }

        //Method to draw the actual product
        public void Draw()
        {
            if (ProductManagement.Count < 1)
            {
                lblProductCode.Text = "000";

                txtBuyPrice.Text = "";
                txtCategory.Text = "";
                txtMinimunStock.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtStock.Text = "";
            }
            else
            {
                Product actualProduct = 
                    ProductManagement.GetActualProduct();

                lblProductCode.Text = actualProduct.Code.ToString("000");
                pbImage.ImageLocation = actualProduct.ImagePath;
                txtBuyPrice.Text = actualProduct.BuyPrice + "";
                txtCategory.Text = actualProduct.Category + "";
                txtMinimunStock.Text = actualProduct.MinimunStock + "";
                txtName.Text = actualProduct.Description + "";
                txtPrice.Text = actualProduct.Price + "";
                txtStock.Text = actualProduct.Stock + "";
            }
        }

        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            this.lblProductCode.Text = (ProductManagement.Count+1).
                ToString("000");

            this.btnAdd.Visible = false;
            this.btnDelete.Visible = false;
            this.btnModify.Visible = false;
            this.btnSearch.Visible = false;

            Button validate = new Button();
            validate.Location = new Point(295, 598);
            validate.FlatAppearance.BorderSize = 0;
            validate.FlatStyle = FlatStyle.Popup;
            validate.Font = new Font("Arial", 20.25F, 
                FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            validate.Name = "btnAdd";
            validate.Size = new Size(160, 90);
            validate.TabIndex = 31;
            validate.Text = "Add";
            validate.UseVisualStyleBackColor = false;
            validate.Click += new EventHandler(validate_Click);

            validate.Text = "Confirmar";
            this.Controls.Add(validate);
        }

        private void validate_Click(object sender, EventArgs e)
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

            }
            catch (Exception)
            {
                MessageBox.Show("Error guardando el producto");
            }

            this.Controls.Clear();
            InitializeComponent();
            Draw();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            ProductManagement.MoveBackward();
            Draw();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ProductManagement.MoveForward();
            Draw();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ProductManagement.Remove();
            Draw();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\";
            getImage.Filter = "Archivos de Imagen (*.jpg)(*.jpeg)(*.png)| *.jpg;*.jpeg;*.png; | All files(*.*) | *.* ";
            if (getImage.ShowDialog() == DialogResult.OK)
            {
                this.pbImage.ImageLocation = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen");
            }
        }
    }
}