// Bar POS, class ProductManagmentScreen

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
        public int Index { get; set; }
        public ProductsList Products { get; set; }

        public ProductsManagmentScreen(ProductsList products)
        {
            Products = products;
            Index = 1;

            InitializeComponent();
            Draw();
        }

        //Method to draw the actual product
        public void Draw()
        {
            if (Products.Count < 1)
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
                lblProductCode.Text = Products.Get(Index).Code.ToString("000");

                txtBuyPrice.Text = Products.Get(Index).BuyPrice + "";
                txtCategory.Text = Products.Get(Index).Category + "";
                txtMinimunStock.Text = Products.Get(Index).MinimunStock + "";
                txtName.Text = Products.Get(Index).Description + "";
                txtPrice.Text = Products.Get(Index).Price + "";
                txtStock.Text = Products.Get(Index).Stock + "";
            }
        }

        public void Modify()
        {
            //TO DO
        }

        public void Search()
        {
            //TO DO
        }

        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtPrice.Text = "";
            this.txtStock.Text = "";
            this.txtMinimunStock.Text = "";
            this.txtCategory.Text = "";
            this.txtBuyPrice.Text = "";
            this.lblProductCode.Text = (Products.Count+1).ToString("000");

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
                newProduct.BuyPrice = Convert.ToDouble(txtBuyPrice.Text);
                newProduct.Category = txtCategory.Text;
                newProduct.Code = Convert.ToInt32((Products.Count + 1).ToString("000"));
                newProduct.Description = txtName.Text;
                newProduct.MinimunStock = Convert.ToInt32(txtMinimunStock.Text);
                newProduct.Price = Convert.ToDouble(txtPrice.Text);
                newProduct.Stock = Convert.ToInt32(txtStock.Text);

                Products.Add(newProduct);

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
            if (Index > 1)
            {
                Index--;
                Draw();
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (Index < Products.Count)
            {
                Index++;
                Draw();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Products.Remove(Index);
            if (Index > 1)
            {
                Index--;
            }
            Draw();
        }
    }
}
