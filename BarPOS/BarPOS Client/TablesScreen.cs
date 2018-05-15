// Bar POS, class TableScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Added POSScreen, drawTable, deleted posScreenList,
//    tableClick added

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
        UsersList user;

        public TableScreen()
        {
            tables = new TableList();
            products = new ProductsList();
            bills = new BillList();
            user = new UsersList();
            DrawTables();
            InitializeComponent();
        }

        //This method will draw the buttons we use for the tables
        public void DrawTables()
        {
            for (int i = 0; i < tables.Tables.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(((int)(((byte)(255)))), 
                    ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Font = new Font("Arial", 36F, FontStyle.Regular, 
                    GraphicsUnit.Point, ((byte)(0)));
                btn.Location = new Point(tables.Tables[i].X, 
                    tables.Tables[i].Y);
                btn.Name = "table"+(i+1);
                btn.Size = new Size(88, 88);
                btn.TabIndex = 2;
                btn.Text = (i+1).ToString();
                btn.UseVisualStyleBackColor = false;
                btn.Click += new System.EventHandler(this.table_Click);

                this.Controls.Add(btn);
            }
        }

        //This event will open the POSScreen when we click on a table
        private void table_Click(object sender, System.EventArgs e)
        {
            int tableNumber = Convert.ToInt32(((Button)sender).Text);
            
            POSScreen actual = new POSScreen(products,
                tables.Tables[tableNumber-1].Products, bills);
            actual.StartPosition = FormStartPosition.CenterScreen;
            actual.Show();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            ConfigurationScreen configurationScreen = new 
                ConfigurationScreen(products,bills);
            configurationScreen.StartPosition = FormStartPosition.CenterScreen;
            configurationScreen.Show();
        }
    }
}
