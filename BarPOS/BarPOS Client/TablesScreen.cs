// Bar POS, class TableScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Added POSScreen, drawTable, deleted posScreenList,
//    tableClick added
// V0.03 16-May-2018 Moisés: Minor changes, method checklogin

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class TableScreen : Form
    {
        Image image;
        TableList tables;
        ProductsList products;
        BillList bills;
        UsersList users;

        public TableScreen(ProductsList products, BillList bills,
            UsersList users)
        {
            tables = new TableList();
            this.products = products;
            this.bills = bills;
            this.users = users;
            DrawTables();
            InitializeComponent();
        }

        //This method will draw the buttons we use for the tables
        public void DrawTables()
        {
            for (int i = 1; i <= tables.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(((int)(((byte)(255)))), 
                    ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Font = new Font("Arial", 36F, FontStyle.Regular, 
                    GraphicsUnit.Point, ((byte)(0)));
                btn.Location = new Point(tables.Get(i).X, 
                    tables.Get(i).Y);
                btn.Name = "table"+(i);
                btn.Size = new Size(88, 88);
                btn.TabIndex = 2;
                btn.Text = (i).ToString();
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(this.table_Click);

                this.Controls.Add(btn);
            }
        }

        //Event for open the POSScreen when we click on a table
        private void table_Click(object sender, System.EventArgs e)
        {
            int tableNumber = Convert.ToInt32(((Button)sender).Text);
            
            POSScreen actual = new POSScreen(products,
                tables, bills, tableNumber);
            actual.StartPosition = FormStartPosition.CenterScreen;
            actual.Show();
        }

        //Event for open the configurationScreen
        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
