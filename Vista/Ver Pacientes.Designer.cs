namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    partial class VerPacientesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerPacientesForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlFondo = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlSombraFondo = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlForms = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.flpVerPacientes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAbrirDocumentos = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnlSombraBuscar = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBuscarPaciente = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlFondo.SuspendLayout();
            this.pnlSombraFondo.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlSombraBuscar.SuspendLayout();
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
            this.pnlFondo.Size = new System.Drawing.Size(991, 707);
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
            this.pnlSombraFondo.Size = new System.Drawing.Size(991, 707);
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
            this.pnlForms.Controls.Add(this.btnAbrirDocumentos);
            this.pnlForms.Controls.Add(this.flpVerPacientes);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlForms.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlForms.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlForms.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.pnlForms.Location = new System.Drawing.Point(0, 3);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Quality = 10;
            this.pnlForms.Size = new System.Drawing.Size(986, 697);
            this.pnlForms.TabIndex = 1;
            // 
            // flpVerPacientes
            // 
            this.flpVerPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpVerPacientes.AutoScroll = true;
            this.flpVerPacientes.Location = new System.Drawing.Point(25, 169);
            this.flpVerPacientes.Name = "flpVerPacientes";
            this.flpVerPacientes.Size = new System.Drawing.Size(937, 500);
            this.flpVerPacientes.TabIndex = 23;
            // 
            // btnAbrirDocumentos
            // 
            this.btnAbrirDocumentos.AllowAnimations = true;
            this.btnAbrirDocumentos.AllowMouseEffects = true;
            this.btnAbrirDocumentos.AllowToggling = false;
            this.btnAbrirDocumentos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAbrirDocumentos.AnimationSpeed = 200;
            this.btnAbrirDocumentos.AutoGenerateColors = false;
            this.btnAbrirDocumentos.AutoRoundBorders = false;
            this.btnAbrirDocumentos.AutoSizeLeftIcon = true;
            this.btnAbrirDocumentos.AutoSizeRightIcon = true;
            this.btnAbrirDocumentos.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrirDocumentos.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAbrirDocumentos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAbrirDocumentos.BackgroundImage")));
            this.btnAbrirDocumentos.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAbrirDocumentos.ButtonText = "Documentos de Pacientes";
            this.btnAbrirDocumentos.ButtonTextMarginLeft = 0;
            this.btnAbrirDocumentos.ColorContrastOnClick = 45;
            this.btnAbrirDocumentos.ColorContrastOnHover = 45;
            this.btnAbrirDocumentos.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAbrirDocumentos.CustomizableEdges = borderEdges1;
            this.btnAbrirDocumentos.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAbrirDocumentos.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAbrirDocumentos.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAbrirDocumentos.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAbrirDocumentos.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAbrirDocumentos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirDocumentos.ForeColor = System.Drawing.Color.White;
            this.btnAbrirDocumentos.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbrirDocumentos.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAbrirDocumentos.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAbrirDocumentos.IconMarginLeft = 11;
            this.btnAbrirDocumentos.IconPadding = 10;
            this.btnAbrirDocumentos.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbrirDocumentos.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAbrirDocumentos.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAbrirDocumentos.IconSize = 25;
            this.btnAbrirDocumentos.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAbrirDocumentos.IdleBorderRadius = 12;
            this.btnAbrirDocumentos.IdleBorderThickness = 1;
            this.btnAbrirDocumentos.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAbrirDocumentos.IdleIconLeftImage = null;
            this.btnAbrirDocumentos.IdleIconRightImage = null;
            this.btnAbrirDocumentos.IndicateFocus = false;
            this.btnAbrirDocumentos.Location = new System.Drawing.Point(389, 17);
            this.btnAbrirDocumentos.Name = "btnAbrirDocumentos";
            this.btnAbrirDocumentos.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAbrirDocumentos.OnDisabledState.BorderRadius = 12;
            this.btnAbrirDocumentos.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAbrirDocumentos.OnDisabledState.BorderThickness = 1;
            this.btnAbrirDocumentos.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAbrirDocumentos.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAbrirDocumentos.OnDisabledState.IconLeftImage = null;
            this.btnAbrirDocumentos.OnDisabledState.IconRightImage = null;
            this.btnAbrirDocumentos.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAbrirDocumentos.onHoverState.BorderRadius = 12;
            this.btnAbrirDocumentos.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAbrirDocumentos.onHoverState.BorderThickness = 1;
            this.btnAbrirDocumentos.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAbrirDocumentos.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAbrirDocumentos.onHoverState.IconLeftImage = null;
            this.btnAbrirDocumentos.onHoverState.IconRightImage = null;
            this.btnAbrirDocumentos.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAbrirDocumentos.OnIdleState.BorderRadius = 12;
            this.btnAbrirDocumentos.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAbrirDocumentos.OnIdleState.BorderThickness = 1;
            this.btnAbrirDocumentos.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAbrirDocumentos.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAbrirDocumentos.OnIdleState.IconLeftImage = null;
            this.btnAbrirDocumentos.OnIdleState.IconRightImage = null;
            this.btnAbrirDocumentos.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAbrirDocumentos.OnPressedState.BorderRadius = 12;
            this.btnAbrirDocumentos.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAbrirDocumentos.OnPressedState.BorderThickness = 1;
            this.btnAbrirDocumentos.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAbrirDocumentos.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAbrirDocumentos.OnPressedState.IconLeftImage = null;
            this.btnAbrirDocumentos.OnPressedState.IconRightImage = null;
            this.btnAbrirDocumentos.Size = new System.Drawing.Size(216, 39);
            this.btnAbrirDocumentos.TabIndex = 25;
            this.btnAbrirDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbrirDocumentos.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAbrirDocumentos.TextMarginLeft = 0;
            this.btnAbrirDocumentos.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAbrirDocumentos.UseDefaultRadiusAndThickness = true;
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
            this.pnlSombraBuscar.Controls.Add(this.txtBuscarPaciente);
            this.pnlSombraBuscar.Location = new System.Drawing.Point(155, 67);
            this.pnlSombraBuscar.Name = "pnlSombraBuscar";
            this.pnlSombraBuscar.Padding = new System.Windows.Forms.Padding(5, 2, 1, 6);
            this.pnlSombraBuscar.ShowBorders = true;
            this.pnlSombraBuscar.Size = new System.Drawing.Size(684, 72);
            this.pnlSombraBuscar.TabIndex = 26;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.AcceptsReturn = false;
            this.txtBuscarPaciente.AcceptsTab = false;
            this.txtBuscarPaciente.AnimationSpeed = 200;
            this.txtBuscarPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarPaciente.AutoSizeHeight = true;
            this.txtBuscarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarPaciente.BackgroundImage")));
            this.txtBuscarPaciente.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.txtBuscarPaciente.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscarPaciente.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.txtBuscarPaciente.BorderColorIdle = System.Drawing.Color.White;
            this.txtBuscarPaciente.BorderRadius = 60;
            this.txtBuscarPaciente.BorderThickness = 0;
            this.txtBuscarPaciente.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.DefaultFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.DefaultText = "";
            this.txtBuscarPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarPaciente.FillColor = System.Drawing.Color.White;
            this.txtBuscarPaciente.HideSelection = true;
            this.txtBuscarPaciente.IconLeft = null;
            this.txtBuscarPaciente.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.IconPadding = 15;
            this.txtBuscarPaciente.IconRight = null;
            this.txtBuscarPaciente.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.Lines = new string[0];
            this.txtBuscarPaciente.Location = new System.Drawing.Point(5, 2);
            this.txtBuscarPaciente.MaxLength = 32767;
            this.txtBuscarPaciente.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscarPaciente.Modified = false;
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarPaciente.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarPaciente.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarPaciente.OnIdleState = stateProperties4;
            this.txtBuscarPaciente.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscarPaciente.PasswordChar = '\0';
            this.txtBuscarPaciente.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.PlaceholderText = "Buscar...";
            this.txtBuscarPaciente.ReadOnly = false;
            this.txtBuscarPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarPaciente.SelectedText = "";
            this.txtBuscarPaciente.SelectionLength = 0;
            this.txtBuscarPaciente.SelectionStart = 0;
            this.txtBuscarPaciente.ShortcutsEnabled = false;
            this.txtBuscarPaciente.Size = new System.Drawing.Size(678, 64);
            this.txtBuscarPaciente.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscarPaciente.TabIndex = 7;
            this.txtBuscarPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarPaciente.TextMarginBottom = 0;
            this.txtBuscarPaciente.TextMarginLeft = 10;
            this.txtBuscarPaciente.TextMarginTop = 0;
            this.txtBuscarPaciente.TextPlaceholder = "Buscar...";
            this.txtBuscarPaciente.UseSystemPasswordChar = false;
            this.txtBuscarPaciente.WordWrap = true;
            // 
            // VerPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1011, 720);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPacientesForm";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 5, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pacientes";
            this.pnlFondo.ResumeLayout(false);
            this.pnlSombraFondo.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlSombraBuscar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel pnlFondo;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlSombraFondo;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnlForms;
        public System.Windows.Forms.FlowLayoutPanel flpVerPacientes;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAbrirDocumentos;
        public Bunifu.UI.WinForms.BunifuPanel pnlSombraBuscar;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarPaciente;
    }
}