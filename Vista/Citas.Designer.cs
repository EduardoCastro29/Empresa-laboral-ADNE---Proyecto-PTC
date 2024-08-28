namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    partial class CitasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitasForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlFondo = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlSombraFondo = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlForms = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnlSombraBuscar = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBuscarCita = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlEncabezadoPlanillasUC = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.lblEstadoDeLaCitaPlanilla = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblHoraPlanilla = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblFechaPlanilla = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblExpedientesPlanillas = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblPacientesPlanilla = new Bunifu.UI.WinForms.BunifuLabel();
            this.flpCitas = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFondo.SuspendLayout();
            this.pnlSombraFondo.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlSombraBuscar.SuspendLayout();
            this.pnlEncabezadoPlanillasUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlFondo.BackgroundImage")));
            this.pnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlFondo.BorderRadius = 3;
            this.pnlFondo.BorderThickness = 1;
            this.pnlFondo.Controls.Add(this.pnlSombraFondo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(15, 10);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.ShowBorders = true;
            this.pnlFondo.Size = new System.Drawing.Size(975, 668);
            this.pnlFondo.TabIndex = 4;
            // 
            // pnlSombraFondo
            // 
            this.pnlSombraFondo.BackColor = System.Drawing.Color.Transparent;
            this.pnlSombraFondo.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSombraFondo.BorderRadius = 30;
            this.pnlSombraFondo.BorderThickness = 10;
            this.pnlSombraFondo.Controls.Add(this.pnlForms);
            this.pnlSombraFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSombraFondo.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlSombraFondo.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Horizontal;
            this.pnlSombraFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlSombraFondo.Name = "pnlSombraFondo";
            this.pnlSombraFondo.Padding = new System.Windows.Forms.Padding(0, 3, 5, 7);
            this.pnlSombraFondo.PanelColor = System.Drawing.Color.Transparent;
            this.pnlSombraFondo.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlSombraFondo.ShadowColor = System.Drawing.Color.Black;
            this.pnlSombraFondo.ShadowDept = 2;
            this.pnlSombraFondo.ShadowDepth = 250;
            this.pnlSombraFondo.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnlSombraFondo.ShadowTopLeftVisible = false;
            this.pnlSombraFondo.Size = new System.Drawing.Size(975, 668);
            this.pnlSombraFondo.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Lowered;
            this.pnlSombraFondo.TabIndex = 2;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlForms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlForms.BackgroundImage")));
            this.pnlForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForms.BorderRadius = 60;
            this.pnlForms.Controls.Add(this.pnlSombraBuscar);
            this.pnlForms.Controls.Add(this.pnlEncabezadoPlanillasUC);
            this.pnlForms.Controls.Add(this.flpCitas);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.pnlForms.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.pnlForms.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlForms.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlForms.Location = new System.Drawing.Point(0, 3);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Quality = 10;
            this.pnlForms.Size = new System.Drawing.Size(970, 658);
            this.pnlForms.TabIndex = 1;
            // 
            // pnlSombraBuscar
            // 
            this.pnlSombraBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSombraBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.pnlSombraBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSombraBuscar.BackgroundImage")));
            this.pnlSombraBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSombraBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSombraBuscar.BorderRadius = 60;
            this.pnlSombraBuscar.BorderThickness = 1;
            this.pnlSombraBuscar.Controls.Add(this.txtBuscarCita);
            this.pnlSombraBuscar.Location = new System.Drawing.Point(146, 35);
            this.pnlSombraBuscar.Name = "pnlSombraBuscar";
            this.pnlSombraBuscar.Padding = new System.Windows.Forms.Padding(5, 2, 1, 6);
            this.pnlSombraBuscar.ShowBorders = true;
            this.pnlSombraBuscar.Size = new System.Drawing.Size(684, 72);
            this.pnlSombraBuscar.TabIndex = 20;
            // 
            // txtBuscarCita
            // 
            this.txtBuscarCita.AcceptsReturn = false;
            this.txtBuscarCita.AcceptsTab = false;
            this.txtBuscarCita.AnimationSpeed = 200;
            this.txtBuscarCita.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarCita.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarCita.AutoSizeHeight = true;
            this.txtBuscarCita.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarCita.BackgroundImage")));
            this.txtBuscarCita.BorderColorActive = System.Drawing.Color.Teal;
            this.txtBuscarCita.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscarCita.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.txtBuscarCita.BorderColorIdle = System.Drawing.Color.White;
            this.txtBuscarCita.BorderRadius = 60;
            this.txtBuscarCita.BorderThickness = 0;
            this.txtBuscarCita.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarCita.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarCita.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCita.DefaultFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCita.DefaultText = "";
            this.txtBuscarCita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarCita.FillColor = System.Drawing.Color.White;
            this.txtBuscarCita.HideSelection = true;
            this.txtBuscarCita.IconLeft = null;
            this.txtBuscarCita.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCita.IconPadding = 15;
            this.txtBuscarCita.IconRight = null;
            this.txtBuscarCita.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarCita.Lines = new string[0];
            this.txtBuscarCita.Location = new System.Drawing.Point(5, 2);
            this.txtBuscarCita.MaxLength = 32767;
            this.txtBuscarCita.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscarCita.Modified = false;
            this.txtBuscarCita.Multiline = false;
            this.txtBuscarCita.Name = "txtBuscarCita";
            stateProperties1.BorderColor = System.Drawing.Color.Teal;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarCita.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCita.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarCita.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarCita.OnIdleState = stateProperties4;
            this.txtBuscarCita.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscarCita.PasswordChar = '\0';
            this.txtBuscarCita.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarCita.PlaceholderText = "Buscar...";
            this.txtBuscarCita.ReadOnly = false;
            this.txtBuscarCita.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarCita.SelectedText = "";
            this.txtBuscarCita.SelectionLength = 0;
            this.txtBuscarCita.SelectionStart = 0;
            this.txtBuscarCita.ShortcutsEnabled = false;
            this.txtBuscarCita.Size = new System.Drawing.Size(678, 64);
            this.txtBuscarCita.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscarCita.TabIndex = 7;
            this.txtBuscarCita.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarCita.TextMarginBottom = 0;
            this.txtBuscarCita.TextMarginLeft = 10;
            this.txtBuscarCita.TextMarginTop = 0;
            this.txtBuscarCita.TextPlaceholder = "Buscar...";
            this.txtBuscarCita.UseSystemPasswordChar = false;
            this.txtBuscarCita.WordWrap = true;
            // 
            // pnlEncabezadoPlanillasUC
            // 
            this.pnlEncabezadoPlanillasUC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEncabezadoPlanillasUC.BackColor = System.Drawing.Color.Transparent;
            this.pnlEncabezadoPlanillasUC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEncabezadoPlanillasUC.BackgroundImage")));
            this.pnlEncabezadoPlanillasUC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEncabezadoPlanillasUC.BorderRadius = 12;
            this.pnlEncabezadoPlanillasUC.Controls.Add(this.lblEstadoDeLaCitaPlanilla);
            this.pnlEncabezadoPlanillasUC.Controls.Add(this.lblHoraPlanilla);
            this.pnlEncabezadoPlanillasUC.Controls.Add(this.lblFechaPlanilla);
            this.pnlEncabezadoPlanillasUC.Controls.Add(this.lblExpedientesPlanillas);
            this.pnlEncabezadoPlanillasUC.Controls.Add(this.lblPacientesPlanilla);
            this.pnlEncabezadoPlanillasUC.GradientBottomLeft = System.Drawing.Color.DarkCyan;
            this.pnlEncabezadoPlanillasUC.GradientBottomRight = System.Drawing.Color.DarkCyan;
            this.pnlEncabezadoPlanillasUC.GradientTopLeft = System.Drawing.Color.Teal;
            this.pnlEncabezadoPlanillasUC.GradientTopRight = System.Drawing.Color.Teal;
            this.pnlEncabezadoPlanillasUC.Location = new System.Drawing.Point(7, 141);
            this.pnlEncabezadoPlanillasUC.Name = "pnlEncabezadoPlanillasUC";
            this.pnlEncabezadoPlanillasUC.Quality = 10;
            this.pnlEncabezadoPlanillasUC.Size = new System.Drawing.Size(955, 61);
            this.pnlEncabezadoPlanillasUC.TabIndex = 19;
            // 
            // lblEstadoDeLaCitaPlanilla
            // 
            this.lblEstadoDeLaCitaPlanilla.AllowParentOverrides = false;
            this.lblEstadoDeLaCitaPlanilla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoDeLaCitaPlanilla.AutoEllipsis = false;
            this.lblEstadoDeLaCitaPlanilla.CursorType = null;
            this.lblEstadoDeLaCitaPlanilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstadoDeLaCitaPlanilla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEstadoDeLaCitaPlanilla.Location = new System.Drawing.Point(597, 22);
            this.lblEstadoDeLaCitaPlanilla.Name = "lblEstadoDeLaCitaPlanilla";
            this.lblEstadoDeLaCitaPlanilla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblEstadoDeLaCitaPlanilla.Size = new System.Drawing.Size(127, 19);
            this.lblEstadoDeLaCitaPlanilla.TabIndex = 4;
            this.lblEstadoDeLaCitaPlanilla.Text = "Estado de la cita";
            this.lblEstadoDeLaCitaPlanilla.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblEstadoDeLaCitaPlanilla.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblHoraPlanilla
            // 
            this.lblHoraPlanilla.AllowParentOverrides = false;
            this.lblHoraPlanilla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHoraPlanilla.AutoEllipsis = false;
            this.lblHoraPlanilla.CursorType = null;
            this.lblHoraPlanilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblHoraPlanilla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblHoraPlanilla.Location = new System.Drawing.Point(486, 22);
            this.lblHoraPlanilla.Name = "lblHoraPlanilla";
            this.lblHoraPlanilla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblHoraPlanilla.Size = new System.Drawing.Size(37, 19);
            this.lblHoraPlanilla.TabIndex = 3;
            this.lblHoraPlanilla.Text = "Hora";
            this.lblHoraPlanilla.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblHoraPlanilla.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblFechaPlanilla
            // 
            this.lblFechaPlanilla.AllowParentOverrides = false;
            this.lblFechaPlanilla.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFechaPlanilla.AutoEllipsis = false;
            this.lblFechaPlanilla.CursorType = null;
            this.lblFechaPlanilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaPlanilla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFechaPlanilla.Location = new System.Drawing.Point(378, 22);
            this.lblFechaPlanilla.Name = "lblFechaPlanilla";
            this.lblFechaPlanilla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblFechaPlanilla.Size = new System.Drawing.Size(49, 19);
            this.lblFechaPlanilla.TabIndex = 2;
            this.lblFechaPlanilla.Text = "Fecha";
            this.lblFechaPlanilla.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblFechaPlanilla.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblExpedientesPlanillas
            // 
            this.lblExpedientesPlanillas.AllowParentOverrides = false;
            this.lblExpedientesPlanillas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExpedientesPlanillas.AutoEllipsis = false;
            this.lblExpedientesPlanillas.CursorType = null;
            this.lblExpedientesPlanillas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblExpedientesPlanillas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblExpedientesPlanillas.Location = new System.Drawing.Point(815, 22);
            this.lblExpedientesPlanillas.Name = "lblExpedientesPlanillas";
            this.lblExpedientesPlanillas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpedientesPlanillas.Size = new System.Drawing.Size(87, 19);
            this.lblExpedientesPlanillas.TabIndex = 1;
            this.lblExpedientesPlanillas.Text = "Expediente";
            this.lblExpedientesPlanillas.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblExpedientesPlanillas.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblPacientesPlanilla
            // 
            this.lblPacientesPlanilla.AllowParentOverrides = false;
            this.lblPacientesPlanilla.AutoEllipsis = false;
            this.lblPacientesPlanilla.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPacientesPlanilla.CursorType = System.Windows.Forms.Cursors.Default;
            this.lblPacientesPlanilla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lblPacientesPlanilla.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPacientesPlanilla.Location = new System.Drawing.Point(18, 22);
            this.lblPacientesPlanilla.Name = "lblPacientesPlanilla";
            this.lblPacientesPlanilla.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPacientesPlanilla.Size = new System.Drawing.Size(68, 19);
            this.lblPacientesPlanilla.TabIndex = 0;
            this.lblPacientesPlanilla.Text = "Paciente";
            this.lblPacientesPlanilla.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblPacientesPlanilla.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // flpCitas
            // 
            this.flpCitas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpCitas.AutoScroll = true;
            this.flpCitas.BackColor = System.Drawing.Color.Transparent;
            this.flpCitas.Location = new System.Drawing.Point(7, 202);
            this.flpCitas.Name = "flpCitas";
            this.flpCitas.Size = new System.Drawing.Size(956, 429);
            this.flpCitas.TabIndex = 18;
            // 
            // CitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(995, 681);
            this.Controls.Add(this.pnlFondo);
            this.Name = "CitasForm";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 5, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.pnlFondo.ResumeLayout(false);
            this.pnlSombraFondo.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlSombraBuscar.ResumeLayout(false);
            this.pnlEncabezadoPlanillasUC.ResumeLayout(false);
            this.pnlEncabezadoPlanillasUC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel pnlFondo;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlSombraFondo;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnlForms;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnlEncabezadoPlanillasUC;
        public Bunifu.UI.WinForms.BunifuLabel lblEstadoDeLaCitaPlanilla;
        public Bunifu.UI.WinForms.BunifuLabel lblHoraPlanilla;
        public Bunifu.UI.WinForms.BunifuLabel lblFechaPlanilla;
        public Bunifu.UI.WinForms.BunifuLabel lblExpedientesPlanillas;
        public Bunifu.UI.WinForms.BunifuLabel lblPacientesPlanilla;
        public System.Windows.Forms.FlowLayoutPanel flpCitas;
        public Bunifu.UI.WinForms.BunifuPanel pnlSombraBuscar;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarCita;
    }
}