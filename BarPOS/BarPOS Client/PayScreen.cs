﻿// Bar POS, class PayScreen

// Versiones: 
// V0.01 14-May-2018 Moisés: Basic skeleton;
// V0.02 15-May-2018 Moisés: close event added and minor changes

using System;
using System.Drawing;
using System.Windows.Forms;

namespace BarPOS
{
    public partial class PayScreen : Form
    {
        public PayClass Pay { get; set; }
        public bool Paid { get; set; }

        public PayScreen(ProductToSellList products, BillList bills,
            User actualUser, int table, double total, Languajes languaje)
        {
            Pay = new PayClass(products, bills, actualUser, table, total);

            InitializeComponent();
            drawTexts(languaje);
            Draw();
            drawTexts(languaje);
        }

        private void Draw()
        {
            lblTotal.Text = Pay.Total.ToString("0.##");
            lblChange.Text = 0.ToString();
            lblGiven.Text = 0.ToString();
        }

        private void drawTexts(Languajes languaje)
        {
            switch (languaje)
            {
                case Languajes.Castellano:
                    lblGivenText.Text = "Recibido";
                    lblMoneyBackText.Text = "Devolver";
                    btnPay.Text = "Cobrar";
                    break;
                case Languajes.English:
                    lblGivenText.Text = "Given";
                    lblMoneyBackText.Text = "Money Back";
                    btnPay.Text = "Pay";
                    break;
            }
        }

        //Event to close the actual windows
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, System.EventArgs e)
        {
            double change = Convert.ToDouble(lblChange.Text);
            if (change >= 0)
            {
                Pay.ActualBill.MoneyGiven = Convert.ToDouble(lblGiven.Text);
                Pay.ActualBill.Change = Convert.ToDouble(lblChange.Text);
                printPreviewDialog.Document = printDocument;
                printPreviewDialog.ShowDialog();
                Pay.Bills.Add(Pay.ActualBill);
                Paid = true;
            }
        }

        private void printDocument_PrintPage(object sender,
            System.Drawing.Printing.PrintPageEventArgs e)
        {
            string[] lines = Pay.ActualBill.ToPrintable();
            for (int i = 0; i < lines.Length; i++)
            {
                e.Graphics.DrawString(lines[i], new
                    Font("Times new Roman", 40, FontStyle.Regular),
                    Brushes.Black, new PointF(0, (0 + (i * 50))));
            }
        }

        private void drawChangeText()
        {
            lblChange.Text = Pay.CalculateMoneyToReturn(lblTotal.Text,
                lblGiven.Text);

            if (Convert.ToDouble(lblChange.Text) < 0)
            {
                lblChange.ForeColor = Color.Firebrick;
            }
            else
            {
                lblChange.ForeColor = Color.ForestGreen;
            }
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(((Button)sender).Name.Substring(3));

            double actualPrice = Convert.ToDouble(lblGiven.Text);
            if (actualPrice == 0 && !lblGiven.Text.Contains(","))
            {
                lblGiven.Text = number.ToString("0");
            }
            else if (lblGiven.Text.Contains(",") && lblGiven.Text.Substring(
                lblGiven.Text.IndexOf(',')).Length > 2)
            {

            }
            else
            {
                lblGiven.Text = lblGiven.Text + number.ToString("0.##");
            }

            drawChangeText();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblGiven.Text.Length == 1)
            {
                lblGiven.Text = "0";
            }
            else
            {
                lblGiven.Text = lblGiven.Text.Substring(0,
                    lblGiven.Text.Length - 1);
            }
            drawChangeText();
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!lblGiven.Text.Contains(","))
            {
                lblGiven.Text = lblGiven.Text + ",";
            }
            drawChangeText();
        }
    }
}
