// Bar POS, class TableScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton
// V0.02 15-May-2018 Moisés: Added POSScreen, drawTable, deleted posScreenList,
//    tableClick added
// V0.03 16-May-2018 Moisés: Minor changes, method checklogin
// V0.04 21-May-2018 Moisés: LoadTables method

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class TableScreen : Form
    {
        public TablesClass Tables { get; set; }
        POSScreen actual;
        bool edit;
        Languajes languaje;

        public TableScreen(ProductsList products, BillList bills,
            User employee, Languajes languaje)
        {
            Tables = new TablesClass(products, bills, employee);
            LoadTables();
            DrawTables();
            edit = false;
            this.languaje = languaje;
            drawTexts();
        }

        private void drawTexts()
        {
            switch (languaje)
            {
                case Languajes.Castellano:
                    btnConfiguration.Text = "Configuracion";
                    if (edit)
                    {
                        btnEdit.Text = "Activar edición";
                    }
                    else
                    {
                        btnEdit.Text = "Apagar edición";
                    }
                    break;
                case Languajes.English:
                    btnConfiguration.Text = "Configuration";
                    if (edit)
                    {
                        btnEdit.Text = "EditModeON";
                    }
                    else
                    {
                        btnEdit.Text = "EditModeOff";
                    }
                    break;
            }
        }

        public void LoadTables()
        {
            string errorMessage = Tables.Tables.Load();
            if (errorMessage != "")
            {
                MessageBox.Show(errorMessage);
            }
        }

        //This method will draw the buttons we use for the tables
        public void DrawTables()
        {
            Controls.Clear();
            for (int i = 1; i <= Tables.Count; i++)
            {
                Button btn = new Button();
                btn.BackColor = Color.FromArgb(((int)(((byte)(255)))), 
                    ((int)(((byte)(192)))), ((int)(((byte)(128)))));
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatStyle = FlatStyle.Popup;
                btn.Font = new Font("Arial", 36F, FontStyle.Regular, 
                    GraphicsUnit.Point, ((byte)(0)));
                btn.Location = new Point(Tables.GetTable(i).X, 
                    Tables.GetTable(i).Y);
                btn.Name = "table"+(i);
                btn.Size = new Size(88, 88);
                btn.TabIndex = 2;
                btn.Text = (i).ToString();
                btn.UseVisualStyleBackColor = false;
                btn.Click += new EventHandler(this.table_Click);
                btn.MouseDown += new MouseEventHandler(this.table_MouseDown);
                btn.MouseUp += new MouseEventHandler(this.table_MouseUp);

                this.Controls.Add(btn);
            }
            InitializeComponent();
        }

        //Event for open the POSScreen when we click on a table
        private void table_Click(object sender, System.EventArgs e)
        {
            if (!edit)
            {
                int tableNumber = Convert.ToInt32(((Button)sender).Text);

                actual = new POSScreen(Tables.Products,
                    Tables.Tables, Tables.Bills, tableNumber, Tables.Employee,
                    languaje);
                actual.StartPosition = FormStartPosition.CenterScreen;
                actual.ShowDialog();
                Tables.RefreshTablesInUse();
            }
        }

        //Event for open the configurationScreen
        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                edit = true;
                btnEdit.BackColor = Color.Red;
            }
            else
            {
                edit = false;
                btnEdit.BackColor = SystemColors.Control;
            }
            drawTexts();
        }

        
        public int X, Y;
        public bool Movimiento;

        private void table_MouseDown(object sender, MouseEventArgs e)
        {
            if (edit)
            {
                X = e.X;
                Y = e.Y;
                if (e.Button == MouseButtons.Left)
                {
                    Movimiento = true;
                }
            }
        }

        private void table_MouseUp(object sender, MouseEventArgs e)
        {
            if (edit)
            {
                int tableNumber = Convert.ToInt32(((Button)sender).Text);

                if (Movimiento)
                {
                    Table actual = Tables.Tables.Get(tableNumber);

                    Tables.Tables.ChangePosition(e.X + actual.X - X,
                        e.Y + actual.Y - Y, tableNumber);
                    DrawTables();
                }
                Movimiento = false;
            }
        }
        
    }
}
