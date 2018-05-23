namespace BarPOS
{
    partial class LogInScreen
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
            this.btnLogIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Arial", 21.75F);
            this.btnLogIn.Location = new System.Drawing.Point(40, 143);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(165, 63);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Code";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Arial", 21.75F);
            this.txtCode.Location = new System.Drawing.Point(40, 81);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(165, 41);
            this.txtCode.TabIndex = 2;
            // 
            // LogInScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 218);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogIn);
            this.Name = "LogInScreen";
            this.Text = "LogInScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
    }
}