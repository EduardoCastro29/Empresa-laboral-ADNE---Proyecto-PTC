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
            this.lblCita = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.BackColor = System.Drawing.Color.White;
            this.lblDias.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.ForeColor = System.Drawing.Color.Teal;
            this.lblDias.Location = new System.Drawing.Point(12, 10);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(55, 25);
            this.lblDias.TabIndex = 1;
            this.lblDias.Text = "Dias";
            // 
            // lblCita
            // 
            this.lblCita.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.Location = new System.Drawing.Point(13, 61);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(100, 23);
            this.lblCita.TabIndex = 2;
            this.lblCita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCDias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCita);
            this.Controls.Add(this.lblDias);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "UCDias";
            this.Size = new System.Drawing.Size(131, 98);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblCita;
    }
}
