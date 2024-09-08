namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    partial class AdministradorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVerEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFondo = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlSombraFondo = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlForms = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnlSombraBuscar = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBuscarEmpleado = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pnlSombreBoton = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.btnAñadirProfesional = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.dgvAdministrarProfesional = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmsOpciones.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            this.pnlSombraFondo.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlSombraBuscar.SuspendLayout();
            this.pnlSombreBoton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrarProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsActualizar,
            this.cmsEliminarProfesional,
            this.cmsVerEspecialidades});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(189, 70);
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.ActualizarCMS;
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(188, 22);
            this.cmsActualizar.Text = "Actualizar Profesional";
            // 
            // cmsEliminarProfesional
            // 
            this.cmsEliminarProfesional.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.EliminarCMS;
            this.cmsEliminarProfesional.Name = "cmsEliminarProfesional";
            this.cmsEliminarProfesional.Size = new System.Drawing.Size(188, 22);
            this.cmsEliminarProfesional.Text = "Eliminar Profesional";
            // 
            // cmsVerEspecialidades
            // 
            this.cmsVerEspecialidades.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Ver_Especialidades;
            this.cmsVerEspecialidades.Name = "cmsVerEspecialidades";
            this.cmsVerEspecialidades.Size = new System.Drawing.Size(188, 22);
            this.cmsVerEspecialidades.Text = "Ver Especialidades";
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
            this.pnlForms.Controls.Add(this.pnlSombreBoton);
            this.pnlForms.Controls.Add(this.dgvAdministrarProfesional);
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.pnlForms.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.pnlForms.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlForms.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.pnlForms.Location = new System.Drawing.Point(0, 3);
            this.pnlForms.Margin = new System.Windows.Forms.Padding(0);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Quality = 10;
            this.pnlForms.Size = new System.Drawing.Size(986, 697);
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
            this.pnlSombraBuscar.Controls.Add(this.txtBuscarEmpleado);
            this.pnlSombraBuscar.Location = new System.Drawing.Point(124, 58);
            this.pnlSombraBuscar.Name = "pnlSombraBuscar";
            this.pnlSombraBuscar.Padding = new System.Windows.Forms.Padding(5, 2, 1, 6);
            this.pnlSombraBuscar.ShowBorders = true;
            this.pnlSombraBuscar.Size = new System.Drawing.Size(551, 73);
            this.pnlSombraBuscar.TabIndex = 102;
            // 
            // txtBuscarEmpleado
            // 
            this.txtBuscarEmpleado.AcceptsReturn = false;
            this.txtBuscarEmpleado.AcceptsTab = false;
            this.txtBuscarEmpleado.AnimationSpeed = 200;
            this.txtBuscarEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarEmpleado.AutoSizeHeight = true;
            this.txtBuscarEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarEmpleado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarEmpleado.BackgroundImage")));
            this.txtBuscarEmpleado.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.txtBuscarEmpleado.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscarEmpleado.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.txtBuscarEmpleado.BorderColorIdle = System.Drawing.Color.White;
            this.txtBuscarEmpleado.BorderRadius = 60;
            this.txtBuscarEmpleado.BorderThickness = 0;
            this.txtBuscarEmpleado.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarEmpleado.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEmpleado.DefaultFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarEmpleado.DefaultText = "";
            this.txtBuscarEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscarEmpleado.FillColor = System.Drawing.Color.White;
            this.txtBuscarEmpleado.HideSelection = true;
            this.txtBuscarEmpleado.IconLeft = null;
            this.txtBuscarEmpleado.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEmpleado.IconPadding = 15;
            this.txtBuscarEmpleado.IconRight = null;
            this.txtBuscarEmpleado.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarEmpleado.Lines = new string[0];
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(5, 2);
            this.txtBuscarEmpleado.MaxLength = 32767;
            this.txtBuscarEmpleado.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscarEmpleado.Modified = false;
            this.txtBuscarEmpleado.Multiline = false;
            this.txtBuscarEmpleado.Name = "txtBuscarEmpleado";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarEmpleado.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarEmpleado.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarEmpleado.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarEmpleado.OnIdleState = stateProperties4;
            this.txtBuscarEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscarEmpleado.PasswordChar = '\0';
            this.txtBuscarEmpleado.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarEmpleado.PlaceholderText = "Buscar...";
            this.txtBuscarEmpleado.ReadOnly = false;
            this.txtBuscarEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarEmpleado.SelectedText = "";
            this.txtBuscarEmpleado.SelectionLength = 0;
            this.txtBuscarEmpleado.SelectionStart = 0;
            this.txtBuscarEmpleado.ShortcutsEnabled = false;
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(545, 65);
            this.txtBuscarEmpleado.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscarEmpleado.TabIndex = 7;
            this.txtBuscarEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscarEmpleado.TextMarginBottom = 0;
            this.txtBuscarEmpleado.TextMarginLeft = 10;
            this.txtBuscarEmpleado.TextMarginTop = 0;
            this.txtBuscarEmpleado.TextPlaceholder = "Buscar...";
            this.txtBuscarEmpleado.UseSystemPasswordChar = false;
            this.txtBuscarEmpleado.WordWrap = true;
            // 
            // pnlSombreBoton
            // 
            this.pnlSombreBoton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSombreBoton.BackColor = System.Drawing.Color.Transparent;
            this.pnlSombreBoton.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSombreBoton.BorderRadius = 15;
            this.pnlSombreBoton.BorderThickness = 1;
            this.pnlSombreBoton.Controls.Add(this.btnAñadirProfesional);
            this.pnlSombreBoton.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlSombreBoton.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlSombreBoton.Location = new System.Drawing.Point(697, 61);
            this.pnlSombreBoton.Name = "pnlSombreBoton";
            this.pnlSombreBoton.Padding = new System.Windows.Forms.Padding(0, 0, 3, 4);
            this.pnlSombreBoton.PanelColor = System.Drawing.Color.Transparent;
            this.pnlSombreBoton.PanelColor2 = System.Drawing.Color.Transparent;
            this.pnlSombreBoton.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSombreBoton.ShadowDept = 2;
            this.pnlSombreBoton.ShadowDepth = 10;
            this.pnlSombreBoton.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnlSombreBoton.ShadowTopLeftVisible = false;
            this.pnlSombreBoton.Size = new System.Drawing.Size(185, 65);
            this.pnlSombreBoton.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlSombreBoton.TabIndex = 101;
            // 
            // btnAñadirProfesional
            // 
            this.btnAñadirProfesional.AllowAnimations = true;
            this.btnAñadirProfesional.AllowMouseEffects = true;
            this.btnAñadirProfesional.AllowToggling = false;
            this.btnAñadirProfesional.AnimationSpeed = 200;
            this.btnAñadirProfesional.AutoGenerateColors = false;
            this.btnAñadirProfesional.AutoRoundBorders = false;
            this.btnAñadirProfesional.AutoSizeLeftIcon = true;
            this.btnAñadirProfesional.AutoSizeRightIcon = true;
            this.btnAñadirProfesional.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(172)))), ((int)(((byte)(158)))));
            this.btnAñadirProfesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadirProfesional.BackgroundImage")));
            this.btnAñadirProfesional.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.ButtonText = "Añadir";
            this.btnAñadirProfesional.ButtonTextMarginLeft = 0;
            this.btnAñadirProfesional.ColorContrastOnClick = 45;
            this.btnAñadirProfesional.ColorContrastOnHover = 45;
            this.btnAñadirProfesional.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnAñadirProfesional.CustomizableEdges = borderEdges1;
            this.btnAñadirProfesional.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAñadirProfesional.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAñadirProfesional.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAñadirProfesional.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAñadirProfesional.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAñadirProfesional.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAñadirProfesional.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirProfesional.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAñadirProfesional.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAñadirProfesional.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAñadirProfesional.IconMarginLeft = 11;
            this.btnAñadirProfesional.IconPadding = 10;
            this.btnAñadirProfesional.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAñadirProfesional.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAñadirProfesional.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAñadirProfesional.IconSize = 25;
            this.btnAñadirProfesional.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.IdleBorderRadius = 25;
            this.btnAñadirProfesional.IdleBorderThickness = 1;
            this.btnAñadirProfesional.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(172)))), ((int)(((byte)(158)))));
            this.btnAñadirProfesional.IdleIconLeftImage = null;
            this.btnAñadirProfesional.IdleIconRightImage = null;
            this.btnAñadirProfesional.IndicateFocus = false;
            this.btnAñadirProfesional.Location = new System.Drawing.Point(0, 0);
            this.btnAñadirProfesional.Name = "btnAñadirProfesional";
            this.btnAñadirProfesional.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAñadirProfesional.OnDisabledState.BorderRadius = 25;
            this.btnAñadirProfesional.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnDisabledState.BorderThickness = 1;
            this.btnAñadirProfesional.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAñadirProfesional.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAñadirProfesional.OnDisabledState.IconLeftImage = null;
            this.btnAñadirProfesional.OnDisabledState.IconRightImage = null;
            this.btnAñadirProfesional.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.onHoverState.BorderRadius = 25;
            this.btnAñadirProfesional.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.onHoverState.BorderThickness = 1;
            this.btnAñadirProfesional.onHoverState.FillColor = System.Drawing.Color.LightSeaGreen;
            this.btnAñadirProfesional.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.onHoverState.IconLeftImage = null;
            this.btnAñadirProfesional.onHoverState.IconRightImage = null;
            this.btnAñadirProfesional.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.OnIdleState.BorderRadius = 25;
            this.btnAñadirProfesional.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnIdleState.BorderThickness = 1;
            this.btnAñadirProfesional.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(172)))), ((int)(((byte)(158)))));
            this.btnAñadirProfesional.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.OnIdleState.IconLeftImage = null;
            this.btnAñadirProfesional.OnIdleState.IconRightImage = null;
            this.btnAñadirProfesional.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.OnPressedState.BorderRadius = 25;
            this.btnAñadirProfesional.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnPressedState.BorderThickness = 1;
            this.btnAñadirProfesional.OnPressedState.FillColor = System.Drawing.Color.Teal;
            this.btnAñadirProfesional.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.OnPressedState.IconLeftImage = null;
            this.btnAñadirProfesional.OnPressedState.IconRightImage = null;
            this.btnAñadirProfesional.Size = new System.Drawing.Size(182, 61);
            this.btnAñadirProfesional.TabIndex = 3;
            this.btnAñadirProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAñadirProfesional.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAñadirProfesional.TextMarginLeft = 0;
            this.btnAñadirProfesional.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAñadirProfesional.UseDefaultRadiusAndThickness = true;
            // 
            // dgvAdministrarProfesional
            // 
            this.dgvAdministrarProfesional.AllowCustomTheming = false;
            this.dgvAdministrarProfesional.AllowUserToAddRows = false;
            this.dgvAdministrarProfesional.AllowUserToResizeColumns = false;
            this.dgvAdministrarProfesional.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAdministrarProfesional.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdministrarProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdministrarProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdministrarProfesional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvAdministrarProfesional.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAdministrarProfesional.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAdministrarProfesional.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdministrarProfesional.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAdministrarProfesional.ColumnHeadersHeight = 40;
            this.dgvAdministrarProfesional.ContextMenuStrip = this.cmsOpciones;
            this.dgvAdministrarProfesional.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvAdministrarProfesional.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAdministrarProfesional.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAdministrarProfesional.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvAdministrarProfesional.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAdministrarProfesional.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgvAdministrarProfesional.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvAdministrarProfesional.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvAdministrarProfesional.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvAdministrarProfesional.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAdministrarProfesional.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvAdministrarProfesional.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAdministrarProfesional.CurrentTheme.Name = null;
            this.dgvAdministrarProfesional.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvAdministrarProfesional.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvAdministrarProfesional.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvAdministrarProfesional.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvAdministrarProfesional.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAdministrarProfesional.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAdministrarProfesional.EnableHeadersVisualStyles = false;
            this.dgvAdministrarProfesional.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvAdministrarProfesional.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgvAdministrarProfesional.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvAdministrarProfesional.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAdministrarProfesional.Location = new System.Drawing.Point(21, 169);
            this.dgvAdministrarProfesional.Name = "dgvAdministrarProfesional";
            this.dgvAdministrarProfesional.ReadOnly = true;
            this.dgvAdministrarProfesional.RowHeadersVisible = false;
            this.dgvAdministrarProfesional.RowTemplate.Height = 40;
            this.dgvAdministrarProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministrarProfesional.Size = new System.Drawing.Size(946, 500);
            this.dgvAdministrarProfesional.TabIndex = 100;
            this.dgvAdministrarProfesional.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1011, 720);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(1027, 759);
            this.MinimumSize = new System.Drawing.Size(1027, 759);
            this.Name = "AdministradorForm";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 5, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.cmsOpciones.ResumeLayout(false);
            this.pnlFondo.ResumeLayout(false);
            this.pnlSombraFondo.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlSombraBuscar.ResumeLayout(false);
            this.pnlSombreBoton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrarProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsOpciones;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarProfesional;
        public Bunifu.UI.WinForms.BunifuPanel pnlFondo;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlSombraFondo;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnlForms;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAñadirProfesional;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvAdministrarProfesional;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlSombreBoton;
        public Bunifu.UI.WinForms.BunifuPanel pnlSombraBuscar;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarEmpleado;
        public System.Windows.Forms.ToolStripMenuItem cmsVerEspecialidades;
    }
}