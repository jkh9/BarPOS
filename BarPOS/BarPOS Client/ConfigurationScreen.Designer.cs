using System;

namespace BarPOS
{
    partial class ConfigurationScreen
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
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExitHelp = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.picHelp = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(367, 543);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(200, 150);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Tables";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnExitHelp);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnBox);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.picHelp);
            this.panel1.Location = new System.Drawing.Point(35, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 700);
            this.panel1.TabIndex = 8;
            // 
            // btnExitHelp
            // 
            this.btnExitHelp.BackColor = System.Drawing.Color.Red;
            this.btnExitHelp.FlatAppearance.BorderSize = 0;
            this.btnExitHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitHelp.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitHelp.Location = new System.Drawing.Point(869, 49);
            this.btnExitHelp.Name = "btnExitHelp";
            this.btnExitHelp.Size = new System.Drawing.Size(40, 40);
            this.btnExitHelp.TabIndex = 88;
            this.btnExitHelp.Text = "X";
            this.btnExitHelp.UseVisualStyleBackColor = false;
            this.btnExitHelp.Visible = false;
            this.btnExitHelp.Click += new System.EventHandler(this.btnExitHelp_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(853, 497);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(79, 40);
            this.btnHelp.TabIndex = 21;
            this.btnHelp.Text = "HELP";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(252, 309);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(403, 55);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login Required!!!!";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(368, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 150);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrint.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(572, 543);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(360, 150);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print Daily Accounts";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnBox
            // 
            this.btnBox.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnBox.FlatAppearance.BorderSize = 0;
            this.btnBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBox.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox.Location = new System.Drawing.Point(3, 543);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(360, 150);
            this.btnBox.TabIndex = 7;
            this.btnBox.Text = "Open box";
            this.btnBox.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(572, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(360, 150);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(3, 3);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(360, 150);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // picHelp
            // 
            this.picHelp.BackColor = System.Drawing.Color.Transparent;
            this.picHelp.Image = global::BarPOS.Properties.Resources.picHelp;
            this.picHelp.Location = new System.Drawing.Point(32, 49);
            this.picHelp.Name = "picHelp";
            this.picHelp.Size = new System.Drawing.Size(877, 606);
            this.picHelp.TabIndex = 87;
            this.picHelp.TabStop = false;
            this.picHelp.Visible = false;
            // 
            // ConfigurationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BarPOS.Properties.Resources.TableImage;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigurationScreen";
            this.Text = "ConfigurationScreen";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHelp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.PictureBox picHelp;
        private System.Windows.Forms.Button btnExitHelp;
    }
}