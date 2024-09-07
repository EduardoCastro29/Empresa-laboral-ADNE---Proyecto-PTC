namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    partial class ControlPacientePlanillaUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPacientePlanillaUC));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pnlFondoUC = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblPacienteId = new System.Windows.Forms.Label();
            this.lblExpedienteId = new System.Windows.Forms.Label();
            this.lblCitaId = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnDescargar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.lblDUI = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblNombrePaciente = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlSeparador = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlFondoUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondoUC
            // 
            this.pnlFondoUC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFondoUC.BackColor = System.Drawing.Color.Transparent;
            this.pnlFondoUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFondoUC.BackgroundImage")));
            this.pnlFondoUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondoUC.BorderRadius = 10;
            this.pnlFondoUC.Controls.Add(this.pnlSeparador);
            this.pnlFondoUC.Controls.Add(this.lblPacienteId);
            this.pnlFondoUC.Controls.Add(this.lblExpedienteId);
            this.pnlFondoUC.Controls.Add(this.lblCitaId);
            this.pnlFondoUC.Controls.Add(this.btnDescargar);
            this.pnlFondoUC.Controls.Add(this.lblDUI);
            this.pnlFondoUC.Controls.Add(this.lblNombrePaciente);
            this.pnlFondoUC.GradientBottomLeft = System.Drawing.Color.WhiteSmoke;
            this.pnlFondoUC.GradientBottomRight = System.Drawing.Color.WhiteSmoke;
            this.pnlFondoUC.GradientTopLeft = System.Drawing.Color.White;
            this.pnlFondoUC.GradientTopRight = System.Drawing.Color.White;
            this.pnlFondoUC.Location = new System.Drawing.Point(0, 0);
            this.pnlFondoUC.Margin = new System.Windows.Forms.Padding(1);
            this.pnlFondoUC.Name = "pnlFondoUC";
            this.pnlFondoUC.Quality = 10;
            this.pnlFondoUC.Size = new System.Drawing.Size(955, 51);
            this.pnlFondoUC.TabIndex = 22;
            // 
            // lblPacienteId
            // 
            this.lblPacienteId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPacienteId.AutoSize = true;
            this.lblPacienteId.Location = new System.Drawing.Point(314, 32);
            this.lblPacienteId.Name = "lblPacienteId";
            this.lblPacienteId.Size = new System.Drawing.Size(0, 13);
            this.lblPacienteId.TabIndex = 25;
            this.lblPacienteId.Visible = false;
            // 
            // lblExpedienteId
            // 
            this.lblExpedienteId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpedienteId.AutoSize = true;
            this.lblExpedienteId.Location = new System.Drawing.Point(479, 6);
            this.lblExpedienteId.Name = "lblExpedienteId";
            this.lblExpedienteId.Size = new System.Drawing.Size(0, 13);
            this.lblExpedienteId.TabIndex = 24;
            this.lblExpedienteId.Visible = false;
            // 
            // lblCitaId
            // 
            this.lblCitaId.AllowParentOverrides = false;
            this.lblCitaId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCitaId.AutoEllipsis = false;
            this.lblCitaId.CursorType = null;
            this.lblCitaId.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblCitaId.Location = new System.Drawing.Point(3, 6);
            this.lblCitaId.Name = "lblCitaId";
            this.lblCitaId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCitaId.Size = new System.Drawing.Size(0, 0);
            this.lblCitaId.TabIndex = 22;
            this.lblCitaId.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCitaId.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblCitaId.Visible = false;
            // 
            // btnDescargar
            // 
            this.btnDescargar.AllowAnimations = true;
            this.btnDescargar.AllowMouseEffects = true;
            this.btnDescargar.AllowToggling = false;
            this.btnDescargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDescargar.AnimationSpeed = 200;
            this.btnDescargar.AutoGenerateColors = false;
            this.btnDescargar.AutoRoundBorders = false;
            this.btnDescargar.AutoSizeLeftIcon = true;
            this.btnDescargar.AutoSizeRightIcon = true;
            this.btnDescargar.BackColor = System.Drawing.Color.Transparent;
            this.btnDescargar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.btnDescargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDescargar.BackgroundImage")));
            this.btnDescargar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDescargar.ButtonText = "Descargar";
            this.btnDescargar.ButtonTextMarginLeft = 0;
            this.btnDescargar.ColorContrastOnClick = 45;
            this.btnDescargar.ColorContrastOnHover = 45;
            this.btnDescargar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnDescargar.CustomizableEdges = borderEdges1;
            this.btnDescargar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDescargar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDescargar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDescargar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDescargar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnDescargar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescargar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescargar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDescargar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnDescargar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnDescargar.IconMarginLeft = 11;
            this.btnDescargar.IconPadding = 10;
            this.btnDescargar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDescargar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnDescargar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnDescargar.IconSize = 25;
            this.btnDescargar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnDescargar.IdleBorderRadius = 12;
            this.btnDescargar.IdleBorderThickness = 1;
            this.btnDescargar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.btnDescargar.IdleIconLeftImage = null;
            this.btnDescargar.IdleIconRightImage = null;
            this.btnDescargar.IndicateFocus = false;
            this.btnDescargar.Location = new System.Drawing.Point(750, 6);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDescargar.OnDisabledState.BorderRadius = 12;
            this.btnDescargar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDescargar.OnDisabledState.BorderThickness = 1;
            this.btnDescargar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDescargar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnDescargar.OnDisabledState.IconLeftImage = null;
            this.btnDescargar.OnDisabledState.IconRightImage = null;
            this.btnDescargar.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDescargar.onHoverState.BorderRadius = 12;
            this.btnDescargar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDescargar.onHoverState.BorderThickness = 1;
            this.btnDescargar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnDescargar.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescargar.onHoverState.IconLeftImage = null;
            this.btnDescargar.onHoverState.IconRightImage = null;
            this.btnDescargar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDescargar.OnIdleState.BorderRadius = 12;
            this.btnDescargar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDescargar.OnIdleState.BorderThickness = 1;
            this.btnDescargar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(204)))), ((int)(((byte)(192)))));
            this.btnDescargar.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDescargar.OnIdleState.IconLeftImage = null;
            this.btnDescargar.OnIdleState.IconRightImage = null;
            this.btnDescargar.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDescargar.OnPressedState.BorderRadius = 12;
            this.btnDescargar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnDescargar.OnPressedState.BorderThickness = 1;
            this.btnDescargar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(174)))), ((int)(((byte)(170)))));
            this.btnDescargar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnDescargar.OnPressedState.IconLeftImage = null;
            this.btnDescargar.OnPressedState.IconRightImage = null;
            this.btnDescargar.Size = new System.Drawing.Size(194, 39);
            this.btnDescargar.TabIndex = 20;
            this.btnDescargar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDescargar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDescargar.TextMarginLeft = 0;
            this.btnDescargar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnDescargar.UseDefaultRadiusAndThickness = true;
            // 
            // lblDUI
            // 
            this.lblDUI.AllowParentOverrides = false;
            this.lblDUI.AutoEllipsis = false;
            this.lblDUI.CursorType = null;
            this.lblDUI.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblDUI.Location = new System.Drawing.Point(24, 16);
            this.lblDUI.Name = "lblDUI";
            this.lblDUI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDUI.Size = new System.Drawing.Size(85, 20);
            this.lblDUI.TabIndex = 2;
            this.lblDUI.Text = "012345678-9";
            this.lblDUI.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDUI.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblNombrePaciente
            // 
            this.lblNombrePaciente.AllowParentOverrides = false;
            this.lblNombrePaciente.AutoEllipsis = false;
            this.lblNombrePaciente.CursorType = null;
            this.lblNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNombrePaciente.Location = new System.Drawing.Point(144, 16);
            this.lblNombrePaciente.Name = "lblNombrePaciente";
            this.lblNombrePaciente.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNombrePaciente.Size = new System.Drawing.Size(78, 20);
            this.lblNombrePaciente.TabIndex = 0;
            this.lblNombrePaciente.Text = "Paciente...";
            this.lblNombrePaciente.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblNombrePaciente.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackgroundColor = System.Drawing.Color.Gray;
            this.pnlSeparador.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSeparador.BackgroundImage")));
            this.pnlSeparador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSeparador.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSeparador.BorderRadius = 3;
            this.pnlSeparador.BorderThickness = 1;
            this.pnlSeparador.Location = new System.Drawing.Point(127, 10);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.ShowBorders = true;
            this.pnlSeparador.Size = new System.Drawing.Size(4, 35);
            this.pnlSeparador.TabIndex = 26;
            // 
            // ControlPacientePlanillaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.pnlFondoUC);
            this.Name = "ControlPacientePlanillaUC";
            this.Size = new System.Drawing.Size(955, 51);
            this.pnlFondoUC.ResumeLayout(false);
            this.pnlFondoUC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuGradientPanel pnlFondoUC;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnDescargar;
        public Bunifu.UI.WinForms.BunifuLabel lblNombrePaciente;
        public Bunifu.UI.WinForms.BunifuLabel lblCitaId;
        public System.Windows.Forms.Label lblPacienteId;
        public System.Windows.Forms.Label lblExpedienteId;
        public Bunifu.UI.WinForms.BunifuLabel lblDUI;
        private Bunifu.UI.WinForms.BunifuPanel pnlSeparador;
    }
}
