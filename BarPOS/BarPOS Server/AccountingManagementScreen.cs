// Bar POS, class AccountingManagmentScreen

// Versiones: 
// V0.01 15-May-2018 Moisés: Basic skeleton
// V0.02 16-May-2018 Moisés: Event to close the form

using System.Windows.Forms;

namespace BarPOS
{
    public partial class AccountingManagmentScreen : Form
    {
        public AccountingManagementClass AccountingManagement { get; set;}

        public AccountingManagmentScreen(BillList bills)
        {
            AccountingManagement = new AccountingManagementClass(bills);
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
                lblTableNumber.Text = AccountingManagement.Index.ToString("000");
                lblTotalBills.Text = AccountingManagement.Count.ToString("000");
                Bill actualBill =
                    AccountingManagement.GetActualBill();

                actualBill.CalculateTotal();
                lblTotalAmount.Text = actualBill.Total.ToString();
                lblEmployee.Text = actualBill.Header.Employee.Name;

                for (int i = 1; i <= actualBill.Lines.Count; i++)
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

                    Label lblAmount = new Label();
                    lblAmount.BackColor = System.Drawing.Color.White;
                    lblAmount.BorderStyle = BorderStyle.FixedSingle;
                    lblAmount.Font = new System.Drawing.Font("Arial", 18F, 
                        System.Drawing.FontStyle.Regular, 
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblAmount.Location = new System.Drawing.Point(184, 0);
                    lblAmount.Name = "lblAmount";
                    lblAmount.Size = new System.Drawing.Size(152, 40);
                    lblAmount.TabIndex = 10;
                    lblAmount.Text = actualBill.GetLine(i).Amount.ToString();
                    lblAmount.TextAlign = 
                        System.Drawing.ContentAlignment.MiddleCenter;

                    Label lblTotal = new Label();
                    lblTotal.BackColor = System.Drawing.Color.White;
                    lblTotal.BorderStyle = BorderStyle.FixedSingle;
                    lblTotal.Font = 
                        new System.Drawing.Font("Arial",18F, 
                        System.Drawing.FontStyle.Regular, 
                        System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTotal.Location = new System.Drawing.Point(378, 0);
                    lblTotal.Name = "lblTotal";
                    lblTotal.Size = new System.Drawing.Size(152, 40);
                    lblTotal.TabIndex = 10;
                    lblTotal.Text = actualBill.GetLine(i).Total.ToString();
                    lblTotal.TextAlign = 
                        System.Drawing.ContentAlignment.MiddleCenter;

                    Panel LinePanel = new Panel();
                    LinePanel.BackColor = System.Drawing.Color.Black;
                    LinePanel.Controls.Add(lblProduct);
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
        }

        //Event to close the window
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
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

        private void btnAccount_Click(object sender, System.EventArgs e)
        {
            AccountingManagement.Print();
        }
    }
}
