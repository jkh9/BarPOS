// Bar POS, class AccountingManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form
// V0.03 22-May-2018 Moisés: DrawFounds property added
//    changes in the draw method for drawing the bills founds when search
//    print method implemented

using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class AccountingManagmentScreen : Form
    {
        private AccountingManagementClass AccountingManagement;
        private bool DrawFounds;

        public AccountingManagmentScreen(BillList bills)
        {
            AccountingManagement = new AccountingManagementClass(bills);
            DrawFounds = false;
            InitializeComponent();
            Draw();
        }

        //Method to draw the actual product
        public void Draw()
        {
            if (AccountingManagement.Count < 1)
            {
                Controls.Clear();
                InitializeComponent();
            }
            else
            {
                this.pnlBill.Controls.Clear();

                Bill actualBill =
                        AccountingManagement.GetActualBill();

                if (DrawFounds && actualBill.Found || !DrawFounds)
                {
                    lblTableNumber.Text = 
                        AccountingManagement.Index.ToString("000");
                    lblTotalBills.Text = 
                        AccountingManagement.Count.ToString("000");

                    actualBill.CalculateTotal();
                    lblTotalPrice.Text = actualBill.Total.ToString()+"€";
                    lblEmployee.Text = actualBill.Header.Employee.Name;

                    for (int i = 1; i <= actualBill.LinesCount; i++)
                    {
                        Label lblProduct = new Label();
                        lblProduct.BackColor = System.Drawing.Color.White;
                        lblProduct.BorderStyle = BorderStyle.FixedSingle;
                        lblProduct.Font = new System.Drawing.Font("Arial", 18F,
                            System.Drawing.FontStyle.Regular,
                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblProduct.Location = new System.Drawing.Point(0, 0);
                        lblProduct.Name = "lblProduct";
                        lblProduct.Size = new System.Drawing.Size(152, 40);
                        lblProduct.TabIndex = 10;
                        lblProduct.Text = actualBill.GetLine(i).
                            LineProduct.Description;
                        lblProduct.TextAlign =
                            System.Drawing.ContentAlignment.MiddleCenter;

                        Label lblPrice = new Label();
                        lblPrice.BackColor = System.Drawing.Color.White;
                        lblPrice.BorderStyle = BorderStyle.FixedSingle;
                        lblPrice.Font = new System.Drawing.Font("Arial", 18F,
                            System.Drawing.FontStyle.Regular,
                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblPrice.Location = new System.Drawing.Point(172, 0);
                        lblPrice.Name = "lblPrice";
                        lblPrice.Size = new System.Drawing.Size(117, 40);
                        lblPrice.TabIndex = 10;
                        lblPrice.Text = actualBill.GetLine(i).
                            LineProduct.Price.ToString();
                        lblPrice.TextAlign =
                            System.Drawing.ContentAlignment.MiddleCenter;

                        Label lblAmount = new Label();
                        lblAmount.BackColor = System.Drawing.Color.White;
                        lblAmount.BorderStyle = BorderStyle.FixedSingle;
                        lblAmount.Font = new System.Drawing.Font("Arial", 18F,
                            System.Drawing.FontStyle.Regular,
                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblAmount.Location = new System.Drawing.Point(308, 0);
                        lblAmount.Name = "lblAmount";
                        lblAmount.Size = new System.Drawing.Size(83, 40);
                        lblAmount.TabIndex = 10;
                        lblAmount.Text = actualBill.GetLine(i).
                            Amount.ToString();
                        lblAmount.TextAlign =
                            System.Drawing.ContentAlignment.MiddleCenter;

                        Label lblTotal = new Label();
                        lblTotal.BackColor = System.Drawing.Color.White;
                        lblTotal.BorderStyle = BorderStyle.FixedSingle;
                        lblTotal.Font =
                            new System.Drawing.Font("Arial", 18F,
                            System.Drawing.FontStyle.Regular,
                            System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        lblTotal.Location = new System.Drawing.Point(410, 0);
                        lblTotal.Name = "lblTotal";
                        lblTotal.Size = new System.Drawing.Size(120, 40);
                        lblTotal.TabIndex = 10;
                        lblTotal.Text = actualBill.GetLine(i).Total.ToString();
                        lblTotal.TextAlign =
                            System.Drawing.ContentAlignment.MiddleCenter;

                        Panel LinePanel = new Panel();
                        LinePanel.BackColor = System.Drawing.Color.Black;
                        LinePanel.Controls.Add(lblProduct);
                        LinePanel.Controls.Add(lblPrice);
                        LinePanel.Controls.Add(lblAmount);
                        LinePanel.Controls.Add(lblTotal);
                        LinePanel.Location =
                            new System.Drawing.Point(0, 0 + (i * 40) - 40);
                        LinePanel.Name = "pnlLine";
                        LinePanel.Size = new System.Drawing.Size(530, 40);
                        LinePanel.TabIndex = 11;

                        pnlBill.Controls.Add(LinePanel);
                    }
                }
                else
                {
                    AccountingManagement.MoveForward();
                    Draw();
                }
            }
        }

        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnForward_Click(object sender, System.EventArgs e)
        {
            AccountingManagement.MoveForward();
            Draw();
        }

        private void btnBackward_Click(object sender, System.EventArgs e)
        {
            AccountingManagement.MoveBackward();
            Draw();
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }

        private void printDocument_PrintPage(object sender, 
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            string[] lines = AccountingManagement.GetActualBill().
                ToPrintable();
            for (int i = 0; i < lines.Length; i++)
            {
                e.Graphics.DrawString(lines[i], new 
                    Font("Times new Roman", 40, FontStyle.Regular), 
                    Brushes.Black, new PointF(0, (0 + (i * 50))));
            }
        }

        private void btnSearch_Click(object sender, System.EventArgs e)
        {
            SearchScreen searchScreen = new SearchScreen();
            searchScreen.StartPosition = FormStartPosition.CenterParent;
            searchScreen.ShowDialog();
            if (AccountingManagement.Search(searchScreen.TextToSearch))
            {
                DrawFounds = true;
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
            DrawFounds = false;
            pnlTopBar.BackColor = Color.Gainsboro;

            //restarting the found attribute
            for (int i = 1; i <= AccountingManagement.Count; i++)
            {
                AccountingManagement.Bills.Get(i).Found = false;
            }
        }

        private void btnBackToMainMenu_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
