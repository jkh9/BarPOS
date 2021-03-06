﻿namespace BarPOS
{
    partial class AccountingManagmentScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountingManagmentScreen));
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.lblTotalBills = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalPriceText = new System.Windows.Forms.Label();
            this.lblEmployeeText = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.pnlBillLine = new System.Windows.Forms.Panel();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.lblMoneyGivenText = new System.Windows.Forms.Label();
            this.lblMoneyGiven = new System.Windows.Forms.Label();
            this.lblChangeText = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.pnlTopBar.SuspendLayout();
            this.pnlBillLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTopBar.Controls.Add(this.btnForward);
            this.pnlTopBar.Controls.Add(this.btnBackward);
            this.pnlTopBar.Controls.Add(this.lblTotalBills);
            this.pnlTopBar.Controls.Add(this.lblTableNumber);
            this.pnlTopBar.Controls.Add(this.btnDay);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Controls.Add(this.lblBill);
            this.pnlTopBar.Controls.Add(this.label2);
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(700, 50);
            this.pnlTopBar.TabIndex = 6;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.White;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnForward.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.Location = new System.Drawing.Point(595, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(40, 40);
            this.btnForward.TabIndex = 26;
            this.btnForward.Text = "→";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.White;
            this.btnBackward.FlatAppearance.BorderSize = 0;
            this.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackward.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.Location = new System.Drawing.Point(552, 4);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(40, 40);
            this.btnBackward.TabIndex = 27;
            this.btnBackward.Text = "←";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // lblTotalBills
            // 
            this.lblTotalBills.AutoSize = true;
            this.lblTotalBills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTotalBills.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalBills.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalBills.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBills.Location = new System.Drawing.Point(445, 2);
            this.lblTotalBills.Name = "lblTotalBills";
            this.lblTotalBills.Size = new System.Drawing.Size(83, 44);
            this.lblTotalBills.TabIndex = 21;
            this.lblTotalBills.Text = "001";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblTableNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTableNumber.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTableNumber.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.Location = new System.Drawing.Point(335, 1);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(83, 44);
            this.lblTableNumber.TabIndex = 21;
            this.lblTableNumber.Text = "001";
            // 
            // btnDay
            // 
            this.btnDay.BackColor = System.Drawing.Color.Transparent;
            this.btnDay.FlatAppearance.BorderSize = 0;
            this.btnDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDay.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.Location = new System.Drawing.Point(3, 5);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(171, 40);
            this.btnDay.TabIndex = 23;
            this.btnDay.UseVisualStyleBackColor = false;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(650, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblBill
            // 
            this.lblBill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBill.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(176, 3);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(153, 42);
            this.lblBill.TabIndex = 22;
            this.lblBill.Text = "Factura nº";
            this.lblBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, -4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 55);
            this.label2.TabIndex = 25;
            this.label2.Text = "/";
            // 
            // lblTotalPriceText
            // 
            this.lblTotalPriceText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceText.Location = new System.Drawing.Point(236, 484);
            this.lblTotalPriceText.Name = "lblTotalPriceText";
            this.lblTotalPriceText.Size = new System.Drawing.Size(179, 40);
            this.lblTotalPriceText.TabIndex = 10;
            this.lblTotalPriceText.Text = "Total Price:";
            this.lblTotalPriceText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployeeText
            // 
            this.lblEmployeeText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeText.Location = new System.Drawing.Point(63, 98);
            this.lblEmployeeText.Name = "lblEmployeeText";
            this.lblEmployeeText.Size = new System.Drawing.Size(166, 40);
            this.lblEmployeeText.TabIndex = 10;
            this.lblEmployeeText.Text = "Employee:";
            this.lblEmployeeText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlBill
            // 
            this.pnlBill.AutoScroll = true;
            this.pnlBill.Location = new System.Drawing.Point(64, 181);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(547, 300);
            this.pnlBill.TabIndex = 11;
            // 
            // pnlBillLine
            // 
            this.pnlBillLine.BackColor = System.Drawing.Color.Black;
            this.pnlBillLine.Controls.Add(this.lblSubtotal);
            this.pnlBillLine.Controls.Add(this.lblUnits);
            this.pnlBillLine.Controls.Add(this.lblPrice);
            this.pnlBillLine.Controls.Add(this.lblProduct);
            this.pnlBillLine.Location = new System.Drawing.Point(64, 141);
            this.pnlBillLine.Name = "pnlBillLine";
            this.pnlBillLine.Size = new System.Drawing.Size(530, 40);
            this.pnlBillLine.TabIndex = 0;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BackColor = System.Drawing.Color.White;
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(410, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(120, 40);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnits
            // 
            this.lblUnits.BackColor = System.Drawing.Color.White;
            this.lblUnits.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnits.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(308, 0);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(83, 40);
            this.lblUnits.TabIndex = 10;
            this.lblUnits.Text = "Units";
            this.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(172, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(117, 40);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.White;
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(0, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(152, 40);
            this.lblProduct.TabIndex = 10;
            this.lblProduct.Text = "Product";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(13, 598);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(130, 90);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gold;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(556, 598);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 90);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(407, 488);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(30, 32);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(220, 101);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(0, 32);
            this.lblEmployee.TabIndex = 10;
            this.lblEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(579, 539);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 40);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.Silver;
            this.btnBackToMainMenu.FlatAppearance.BorderSize = 0;
            this.btnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMainMenu.Location = new System.Drawing.Point(0, 49);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(163, 46);
            this.btnBackToMainMenu.TabIndex = 28;
            this.btnBackToMainMenu.Text = "Back to main";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(0, 0);
            this.mc.Name = "mc";
            this.mc.TabIndex = 0;
            this.mc.TodayDate = new System.DateTime(2018, 5, 23, 0, 0, 0, 0);
            this.mc.TrailingForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.mc.Visible = false;
            this.mc.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.mc_DateSelected);
            // 
            // lblMoneyGivenText
            // 
            this.lblMoneyGivenText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyGivenText.Location = new System.Drawing.Point(213, 524);
            this.lblMoneyGivenText.Name = "lblMoneyGivenText";
            this.lblMoneyGivenText.Size = new System.Drawing.Size(202, 40);
            this.lblMoneyGivenText.TabIndex = 10;
            this.lblMoneyGivenText.Text = "Money Given:";
            this.lblMoneyGivenText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMoneyGiven
            // 
            this.lblMoneyGiven.AutoSize = true;
            this.lblMoneyGiven.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoneyGiven.Location = new System.Drawing.Point(407, 528);
            this.lblMoneyGiven.Name = "lblMoneyGiven";
            this.lblMoneyGiven.Size = new System.Drawing.Size(30, 32);
            this.lblMoneyGiven.TabIndex = 10;
            this.lblMoneyGiven.Text = "0";
            this.lblMoneyGiven.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChangeText
            // 
            this.lblChangeText.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangeText.Location = new System.Drawing.Point(284, 560);
            this.lblChangeText.Name = "lblChangeText";
            this.lblChangeText.Size = new System.Drawing.Size(131, 40);
            this.lblChangeText.TabIndex = 10;
            this.lblChangeText.Text = "Change:";
            this.lblChangeText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.Location = new System.Drawing.Point(407, 564);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(30, 32);
            this.lblChange.TabIndex = 10;
            this.lblChange.Text = "0";
            this.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountingManagmentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.pnlBillLine);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.lblEmployeeText);
            this.Controls.Add(this.lblChange);
            this.Controls.Add(this.lblMoneyGiven);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblChangeText);
            this.Controls.Add(this.lblMoneyGivenText);
            this.Controls.Add(this.lblTotalPriceText);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountingManagmentScreen";
            this.Text = "AccoutingManagmentScreen";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlBillLine.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Label lblTotalBills;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalPriceText;
        private System.Windows.Forms.Label lblEmployeeText;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Panel pnlBillLine;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.Label lblMoneyGivenText;
        private System.Windows.Forms.Label lblMoneyGiven;
        private System.Windows.Forms.Label lblChangeText;
        private System.Windows.Forms.Label lblChange;
    }
}