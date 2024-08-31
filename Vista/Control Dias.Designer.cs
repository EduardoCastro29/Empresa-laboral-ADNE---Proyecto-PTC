namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    partial class UCDias
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.BackColor = System.Drawing.Color.Transparent;
            this.lblDias.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.Color.Teal;
            this.lblDias.Location = new System.Drawing.Point(12, 10);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(55, 25);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias";
            // 
            // UCDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDias);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCDias";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(133, 85);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDias;
    }
}
