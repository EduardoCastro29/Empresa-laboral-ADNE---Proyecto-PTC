﻿namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.pnlFondo = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlSombraFondo = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlForms = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.txtBuscarPaciente = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnVerPacientesSinProfesional = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.flpVerPacientes = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnlFondo.SuspendLayout();
            this.pnlSombraFondo.SuspendLayout();
            this.pnlForms.SuspendLayout();
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
            this.pnlFondo.Size = new System.Drawing.Size(991, 718);
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
            this.pnlSombraFondo.Size = new System.Drawing.Size(991, 718);
            this.pnlSombraFondo.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Lowered;
            this.pnlSombraFondo.TabIndex = 2;
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.Transparent;
            this.pnlForms.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlForms.BackgroundImage")));
            this.pnlForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlForms.BorderRadius = 60;
            this.pnlForms.Controls.Add(this.btnBuscar);
            this.pnlForms.Controls.Add(this.txtBuscarPaciente);
            this.pnlForms.Controls.Add(this.btnVerPacientesSinProfesional);
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
            this.pnlForms.Size = new System.Drawing.Size(986, 708);
            this.pnlForms.TabIndex = 1;
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
            this.txtBuscarPaciente.BorderColorIdle = System.Drawing.Color.LightGray;
            this.txtBuscarPaciente.BorderRadius = 60;
            this.txtBuscarPaciente.BorderThickness = 1;
            this.txtBuscarPaciente.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.DefaultFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.DefaultText = "";
            this.txtBuscarPaciente.FillColor = System.Drawing.Color.White;
            this.txtBuscarPaciente.HideSelection = true;
            this.txtBuscarPaciente.IconLeft = null;
            this.txtBuscarPaciente.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.IconPadding = 15;
            this.txtBuscarPaciente.IconRight = null;
            this.txtBuscarPaciente.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.Lines = new string[0];
            this.txtBuscarPaciente.Location = new System.Drawing.Point(149, 34);
            this.txtBuscarPaciente.MaxLength = 130;
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
            stateProperties4.BorderColor = System.Drawing.Color.LightGray;
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
            this.txtBuscarPaciente.TabIndex = 0;
            this.txtBuscarPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarPaciente.TextMarginBottom = 0;
            this.txtBuscarPaciente.TextMarginLeft = 10;
            this.txtBuscarPaciente.TextMarginTop = 0;
            this.txtBuscarPaciente.TextPlaceholder = "Buscar...";
            this.txtBuscarPaciente.UseSystemPasswordChar = false;
            this.txtBuscarPaciente.WordWrap = true;
            // 
            // btnVerPacientesSinProfesional
            // 
            this.btnVerPacientesSinProfesional.AllowAnimations = true;
            this.btnVerPacientesSinProfesional.AllowMouseEffects = true;
            this.btnVerPacientesSinProfesional.AllowToggling = false;
            this.btnVerPacientesSinProfesional.AnimationSpeed = 200;
            this.btnVerPacientesSinProfesional.AutoGenerateColors = false;
            this.btnVerPacientesSinProfesional.AutoRoundBorders = false;
            this.btnVerPacientesSinProfesional.AutoSizeLeftIcon = true;
            this.btnVerPacientesSinProfesional.AutoSizeRightIcon = true;
            this.btnVerPacientesSinProfesional.BackColor = System.Drawing.Color.Transparent;
            this.btnVerPacientesSinProfesional.BackColor1 = System.Drawing.Color.LightSeaGreen;
            this.btnVerPacientesSinProfesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVerPacientesSinProfesional.BackgroundImage")));
            this.btnVerPacientesSinProfesional.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnVerPacientesSinProfesional.ButtonText = "Pacientes sin profesional";
            this.btnVerPacientesSinProfesional.ButtonTextMarginLeft = 0;
            this.btnVerPacientesSinProfesional.ColorContrastOnClick = 45;
            this.btnVerPacientesSinProfesional.ColorContrastOnHover = 45;
            this.btnVerPacientesSinProfesional.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnVerPacientesSinProfesional.CustomizableEdges = borderEdges2;
            this.btnVerPacientesSinProfesional.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVerPacientesSinProfesional.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVerPacientesSinProfesional.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVerPacientesSinProfesional.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVerPacientesSinProfesional.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnVerPacientesSinProfesional.Font = new System.Drawing.Font("Century Gothic", 13.5F, System.Drawing.FontStyle.Bold);
            this.btnVerPacientesSinProfesional.ForeColor = System.Drawing.Color.White;
            this.btnVerPacientesSinProfesional.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerPacientesSinProfesional.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPacientesSinProfesional.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnVerPacientesSinProfesional.IconMarginLeft = 11;
            this.btnVerPacientesSinProfesional.IconPadding = 10;
            this.btnVerPacientesSinProfesional.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerPacientesSinProfesional.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerPacientesSinProfesional.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnVerPacientesSinProfesional.IconSize = 25;
            this.btnVerPacientesSinProfesional.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnVerPacientesSinProfesional.IdleBorderRadius = 15;
            this.btnVerPacientesSinProfesional.IdleBorderThickness = 1;
            this.btnVerPacientesSinProfesional.IdleFillColor = System.Drawing.Color.LightSeaGreen;
            this.btnVerPacientesSinProfesional.IdleIconLeftImage = null;
            this.btnVerPacientesSinProfesional.IdleIconRightImage = null;
            this.btnVerPacientesSinProfesional.IndicateFocus = false;
            this.btnVerPacientesSinProfesional.Location = new System.Drawing.Point(672, 638);
            this.btnVerPacientesSinProfesional.Name = "btnVerPacientesSinProfesional";
            this.btnVerPacientesSinProfesional.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnVerPacientesSinProfesional.OnDisabledState.BorderRadius = 15;
            this.btnVerPacientesSinProfesional.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnVerPacientesSinProfesional.OnDisabledState.BorderThickness = 1;
            this.btnVerPacientesSinProfesional.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnVerPacientesSinProfesional.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnVerPacientesSinProfesional.OnDisabledState.IconLeftImage = null;
            this.btnVerPacientesSinProfesional.OnDisabledState.IconRightImage = null;
            this.btnVerPacientesSinProfesional.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVerPacientesSinProfesional.onHoverState.BorderRadius = 15;
            this.btnVerPacientesSinProfesional.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnVerPacientesSinProfesional.onHoverState.BorderThickness = 1;
            this.btnVerPacientesSinProfesional.onHoverState.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnVerPacientesSinProfesional.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnVerPacientesSinProfesional.onHoverState.IconLeftImage = null;
            this.btnVerPacientesSinProfesional.onHoverState.IconRightImage = null;
            this.btnVerPacientesSinProfesional.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnVerPacientesSinProfesional.OnIdleState.BorderRadius = 15;
            this.btnVerPacientesSinProfesional.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnVerPacientesSinProfesional.OnIdleState.BorderThickness = 1;
            this.btnVerPacientesSinProfesional.OnIdleState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnVerPacientesSinProfesional.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnVerPacientesSinProfesional.OnIdleState.IconLeftImage = null;
            this.btnVerPacientesSinProfesional.OnIdleState.IconRightImage = null;
            this.btnVerPacientesSinProfesional.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(158)))));
            this.btnVerPacientesSinProfesional.OnPressedState.BorderRadius = 15;
            this.btnVerPacientesSinProfesional.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnVerPacientesSinProfesional.OnPressedState.BorderThickness = 1;
            this.btnVerPacientesSinProfesional.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(166)))), ((int)(((byte)(158)))));
            this.btnVerPacientesSinProfesional.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnVerPacientesSinProfesional.OnPressedState.IconLeftImage = null;
            this.btnVerPacientesSinProfesional.OnPressedState.IconRightImage = null;
            this.btnVerPacientesSinProfesional.Size = new System.Drawing.Size(290, 53);
            this.btnVerPacientesSinProfesional.TabIndex = 27;
            this.btnVerPacientesSinProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVerPacientesSinProfesional.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnVerPacientesSinProfesional.TextMarginLeft = 0;
            this.btnVerPacientesSinProfesional.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnVerPacientesSinProfesional.UseDefaultRadiusAndThickness = true;
            // 
            // flpVerPacientes
            // 
            this.flpVerPacientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpVerPacientes.AutoScroll = true;
            this.flpVerPacientes.Location = new System.Drawing.Point(25, 121);
            this.flpVerPacientes.Name = "flpVerPacientes";
            this.flpVerPacientes.Size = new System.Drawing.Size(937, 511);
            this.flpVerPacientes.TabIndex = 2;
            this.flpVerPacientes.TabStop = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AllowAnimations = true;
            this.btnBuscar.AllowMouseEffects = true;
            this.btnBuscar.AllowToggling = false;
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.AnimationSpeed = 200;
            this.btnBuscar.AutoGenerateColors = false;
            this.btnBuscar.AutoRoundBorders = false;
            this.btnBuscar.AutoSizeLeftIcon = true;
            this.btnBuscar.AutoSizeRightIcon = true;
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.BackColor1 = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.ButtonText = "";
            this.btnBuscar.ButtonTextMarginLeft = 0;
            this.btnBuscar.ColorContrastOnClick = 45;
            this.btnBuscar.ColorContrastOnHover = 45;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = true;
            this.btnBuscar.CustomizableEdges = borderEdges1;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnBuscar.IconMarginLeft = 11;
            this.btnBuscar.IconPadding = 15;
            this.btnBuscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnBuscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.IdleBorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.IdleBorderRadius = 60;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.IdleIconLeftImage = null;
            this.btnBuscar.IdleIconRightImage = null;
            this.btnBuscar.IndicateFocus = false;
            this.btnBuscar.Location = new System.Drawing.Point(706, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.OnDisabledState.BorderRadius = 60;
            this.btnBuscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.OnDisabledState.BorderThickness = 1;
            this.btnBuscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.OnDisabledState.IconLeftImage = null;
            this.btnBuscar.OnDisabledState.IconRightImage = null;
            this.btnBuscar.onHoverState.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.onHoverState.BorderRadius = 60;
            this.btnBuscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.onHoverState.BorderThickness = 1;
            this.btnBuscar.onHoverState.FillColor = System.Drawing.Color.MediumTurquoise;
            this.btnBuscar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.onHoverState.IconLeftImage = null;
            this.btnBuscar.onHoverState.IconRightImage = null;
            this.btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.OnIdleState.BorderRadius = 60;
            this.btnBuscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.OnIdleState.BorderThickness = 1;
            this.btnBuscar.OnIdleState.FillColor = System.Drawing.Color.DarkTurquoise;
            this.btnBuscar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnIdleState.IconLeftImage = null;
            this.btnBuscar.OnIdleState.IconRightImage = null;
            this.btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.OnPressedState.BorderRadius = 60;
            this.btnBuscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.OnPressedState.BorderThickness = 1;
            this.btnBuscar.OnPressedState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnBuscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnPressedState.IconLeftImage = null;
            this.btnBuscar.OnPressedState.IconRightImage = null;
            this.btnBuscar.Size = new System.Drawing.Size(130, 62);
            this.btnBuscar.TabIndex = 103;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
            // 
            // VerPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1011, 731);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1027, 770);
            this.MinimumSize = new System.Drawing.Size(1027, 770);
            this.Name = "VerPacientesForm";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 5, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pacientes";
            this.pnlFondo.ResumeLayout(false);
            this.pnlSombraFondo.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Bunifu.UI.WinForms.BunifuPanel pnlFondo;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlSombraFondo;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnlForms;
        public System.Windows.Forms.FlowLayoutPanel flpVerPacientes;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarPaciente;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnVerPacientesSinProfesional;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnBuscar;
    }
}