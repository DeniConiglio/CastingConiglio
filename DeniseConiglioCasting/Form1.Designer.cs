namespace DeniseConiglioCasting
{
    partial class Form1
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
            this.btbIngresar = new System.Windows.Forms.Button();
            this.ibiLongitud = new System.Windows.Forms.Label();
            this.txtLongitud = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btbIngresar
            // 
            this.btbIngresar.Location = new System.Drawing.Point(461, 180);
            this.btbIngresar.Name = "btbIngresar";
            this.btbIngresar.Size = new System.Drawing.Size(89, 31);
            this.btbIngresar.TabIndex = 0;
            this.btbIngresar.Text = "Ingresar";
            this.btbIngresar.UseVisualStyleBackColor = true;
            this.btbIngresar.Click += new System.EventHandler(this.btbIngresar_Click);
            // 
            // ibiLongitud
            // 
            this.ibiLongitud.AutoSize = true;
            this.ibiLongitud.Location = new System.Drawing.Point(118, 188);
            this.ibiLongitud.Name = "ibiLongitud";
            this.ibiLongitud.Size = new System.Drawing.Size(106, 16);
            this.ibiLongitud.TabIndex = 1;
            this.ibiLongitud.Text = "Ingrese Longitud";
            // 
            // txtLongitud
            // 
            this.txtLongitud.Location = new System.Drawing.Point(255, 185);
            this.txtLongitud.Name = "txtLongitud";
            this.txtLongitud.Size = new System.Drawing.Size(100, 22);
            this.txtLongitud.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLongitud);
            this.Controls.Add(this.ibiLongitud);
            this.Controls.Add(this.btbIngresar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbIngresar;
        private System.Windows.Forms.Label ibiLongitud;
        private System.Windows.Forms.TextBox txtLongitud;
    }
}

