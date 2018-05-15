namespace BarPOS
{
    partial class TableScreen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.picTables = new System.Windows.Forms.PictureBox();
            this.btnConfiguration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTables)).BeginInit();
            this.SuspendLayout();
            // 
            // picTables
            // 
            this.picTables.BackColor = System.Drawing.Color.Transparent;
            this.picTables.Image = global::BarPOS.Properties.Resources.TableImage;
            this.picTables.InitialImage = null;
            this.picTables.Location = new System.Drawing.Point(0, 0);
            this.picTables.Name = "picTables";
            this.picTables.Size = new System.Drawing.Size(1024, 768);
            this.picTables.TabIndex = 0;
            this.picTables.TabStop = false;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfiguration.FlatAppearance.BorderSize = 0;
            this.btnConfiguration.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfiguration.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfiguration.Location = new System.Drawing.Point(914, 698);
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Size = new System.Drawing.Size(110, 70);
            this.btnConfiguration.TabIndex = 1;
            this.btnConfiguration.Text = "Configuration";
            this.btnConfiguration.UseVisualStyleBackColor = false;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // TableScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.btnConfiguration);
            this.Controls.Add(this.picTables);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TableScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picTables;
        private System.Windows.Forms.Button btnConfiguration;
    }
}

