namespace Empresa_laboral_ADNE___Proyecto_PTC.Vista
{
    partial class VerCitasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerCitasForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVerCita = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnAtendidas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnlSombraBuscar = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.btnTodas = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btnPendientes = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.dgvCitasAgendadas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmsOpciones.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnlSombraBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasAgendadas)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsActualizar,
            this.cmsEliminarCita,
            this.cmsVerCita});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(151, 70);
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.ActualizarCMS;
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(150, 22);
            this.cmsActualizar.Text = "Actualizar Cita";
            // 
            // cmsEliminarCita
            // 
            this.cmsEliminarCita.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.EliminarCMS;
            this.cmsEliminarCita.Name = "cmsEliminarCita";
            this.cmsEliminarCita.Size = new System.Drawing.Size(150, 22);
            this.cmsEliminarCita.Text = "Eliminar Cita";
            // 
            // cmsVerCita
            // 
            this.cmsVerCita.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.VerCitaCMS;
            this.cmsVerCita.Name = "cmsVerCita";
            this.cmsVerCita.Size = new System.Drawing.Size(150, 22);
            this.cmsVerCita.Text = "Ver Cita";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnAtendidas);
            this.bunifuGradientPanel1.Controls.Add(this.pnlSombraBuscar);
            this.bunifuGradientPanel1.Controls.Add(this.btnTodas);
            this.bunifuGradientPanel1.Controls.Add(this.btnPendientes);
            this.bunifuGradientPanel1.Controls.Add(this.dgvCitasAgendadas);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1033, 653);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnAtendidas
            // 
            this.btnAtendidas.AllowAnimations = true;
            this.btnAtendidas.AllowMouseEffects = true;
            this.btnAtendidas.AllowToggling = false;
            this.btnAtendidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtendidas.AnimationSpeed = 200;
            this.btnAtendidas.AutoGenerateColors = false;
            this.btnAtendidas.AutoRoundBorders = false;
            this.btnAtendidas.AutoSizeLeftIcon = true;
            this.btnAtendidas.AutoSizeRightIcon = true;
            this.btnAtendidas.BackColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnAtendidas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAtendidas.BackgroundImage")));
            this.btnAtendidas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAtendidas.ButtonText = "Atendidas";
            this.btnAtendidas.ButtonTextMarginLeft = 0;
            this.btnAtendidas.ColorContrastOnClick = 45;
            this.btnAtendidas.ColorContrastOnHover = 45;
            this.btnAtendidas.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = false;
            borderEdges1.BottomRight = false;
            borderEdges1.TopLeft = false;
            borderEdges1.TopRight = false;
            this.btnAtendidas.CustomizableEdges = borderEdges1;
            this.btnAtendidas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAtendidas.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.DisabledFillColor = System.Drawing.Color.CadetBlue;
            this.btnAtendidas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAtendidas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAtendidas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtendidas.ForeColor = System.Drawing.Color.White;
            this.btnAtendidas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtendidas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAtendidas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAtendidas.IconMarginLeft = 11;
            this.btnAtendidas.IconPadding = 10;
            this.btnAtendidas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtendidas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAtendidas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAtendidas.IconSize = 25;
            this.btnAtendidas.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.IdleBorderRadius = 30;
            this.btnAtendidas.IdleBorderThickness = 1;
            this.btnAtendidas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnAtendidas.IdleIconLeftImage = null;
            this.btnAtendidas.IdleIconRightImage = null;
            this.btnAtendidas.IndicateFocus = false;
            this.btnAtendidas.Location = new System.Drawing.Point(709, 52);
            this.btnAtendidas.Name = "btnAtendidas";
            this.btnAtendidas.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.OnDisabledState.BorderRadius = 30;
            this.btnAtendidas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAtendidas.OnDisabledState.BorderThickness = 1;
            this.btnAtendidas.OnDisabledState.FillColor = System.Drawing.Color.CadetBlue;
            this.btnAtendidas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAtendidas.OnDisabledState.IconLeftImage = null;
            this.btnAtendidas.OnDisabledState.IconRightImage = null;
            this.btnAtendidas.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.onHoverState.BorderRadius = 30;
            this.btnAtendidas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAtendidas.onHoverState.BorderThickness = 1;
            this.btnAtendidas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnAtendidas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAtendidas.onHoverState.IconLeftImage = null;
            this.btnAtendidas.onHoverState.IconRightImage = null;
            this.btnAtendidas.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.OnIdleState.BorderRadius = 30;
            this.btnAtendidas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAtendidas.OnIdleState.BorderThickness = 1;
            this.btnAtendidas.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnAtendidas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAtendidas.OnIdleState.IconLeftImage = null;
            this.btnAtendidas.OnIdleState.IconRightImage = null;
            this.btnAtendidas.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAtendidas.OnPressedState.BorderRadius = 30;
            this.btnAtendidas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAtendidas.OnPressedState.BorderThickness = 1;
            this.btnAtendidas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.btnAtendidas.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAtendidas.OnPressedState.IconLeftImage = null;
            this.btnAtendidas.OnPressedState.IconRightImage = null;
            this.btnAtendidas.Size = new System.Drawing.Size(145, 50);
            this.btnAtendidas.TabIndex = 2;
            this.btnAtendidas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAtendidas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAtendidas.TextMarginLeft = 0;
            this.btnAtendidas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAtendidas.UseDefaultRadiusAndThickness = true;
            // 
            // pnlSombraBuscar
            // 
            this.pnlSombraBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSombraBuscar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.pnlSombraBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSombraBuscar.BackgroundImage")));
            this.pnlSombraBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSombraBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.pnlSombraBuscar.BorderRadius = 50;
            this.pnlSombraBuscar.BorderThickness = 1;
            this.pnlSombraBuscar.Controls.Add(this.btnBuscar);
            this.pnlSombraBuscar.Controls.Add(this.txtBuscar);
            this.pnlSombraBuscar.Location = new System.Drawing.Point(30, 44);
            this.pnlSombraBuscar.Name = "pnlSombraBuscar";
            this.pnlSombraBuscar.Padding = new System.Windows.Forms.Padding(4, 2, 1, 4);
            this.pnlSombraBuscar.ShowBorders = true;
            this.pnlSombraBuscar.Size = new System.Drawing.Size(527, 67);
            this.pnlSombraBuscar.TabIndex = 103;
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
            this.btnBuscar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(196)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.ButtonText = "";
            this.btnBuscar.ButtonTextMarginLeft = 0;
            this.btnBuscar.ColorContrastOnClick = 45;
            this.btnBuscar.ColorContrastOnHover = 45;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = false;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = false;
            borderEdges2.TopRight = true;
            this.btnBuscar.CustomizableEdges = borderEdges2;
            this.btnBuscar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBuscar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.IconLeftPadding = new System.Windows.Forms.Padding(15);
            this.btnBuscar.IconMarginLeft = 11;
            this.btnBuscar.IconPadding = 15;
            this.btnBuscar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnBuscar.IconSize = 25;
            this.btnBuscar.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.IdleBorderRadius = 50;
            this.btnBuscar.IdleBorderThickness = 1;
            this.btnBuscar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(196)))));
            this.btnBuscar.IdleIconLeftImage = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.lupa__1_;
            this.btnBuscar.IdleIconRightImage = null;
            this.btnBuscar.IndicateFocus = false;
            this.btnBuscar.Location = new System.Drawing.Point(406, 1);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnBuscar.OnDisabledState.BorderRadius = 50;
            this.btnBuscar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.OnDisabledState.BorderThickness = 1;
            this.btnBuscar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnBuscar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnBuscar.OnDisabledState.IconLeftImage = null;
            this.btnBuscar.OnDisabledState.IconRightImage = null;
            this.btnBuscar.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.onHoverState.BorderRadius = 50;
            this.btnBuscar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.onHoverState.BorderThickness = 1;
            this.btnBuscar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(224)))));
            this.btnBuscar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.onHoverState.IconLeftImage = null;
            this.btnBuscar.onHoverState.IconRightImage = null;
            this.btnBuscar.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnIdleState.BorderRadius = 50;
            this.btnBuscar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.OnIdleState.BorderThickness = 1;
            this.btnBuscar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(193)))), ((int)(((byte)(196)))));
            this.btnBuscar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnIdleState.IconLeftImage = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.lupa__1_;
            this.btnBuscar.OnIdleState.IconRightImage = null;
            this.btnBuscar.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnPressedState.BorderRadius = 50;
            this.btnBuscar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnBuscar.OnPressedState.BorderThickness = 1;
            this.btnBuscar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(168)))));
            this.btnBuscar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.OnPressedState.IconLeftImage = null;
            this.btnBuscar.OnPressedState.IconRightImage = null;
            this.btnBuscar.Size = new System.Drawing.Size(121, 62);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.AcceptsReturn = false;
            this.txtBuscar.AcceptsTab = false;
            this.txtBuscar.AnimationSpeed = 200;
            this.txtBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscar.AutoSizeHeight = true;
            this.txtBuscar.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscar.BackgroundImage")));
            this.txtBuscar.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.txtBuscar.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscar.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscar.BorderRadius = 50;
            this.txtBuscar.BorderThickness = 0;
            this.txtBuscar.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.DefaultFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.DefaultText = "";
            this.txtBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBuscar.FillColor = System.Drawing.Color.White;
            this.txtBuscar.HideSelection = true;
            this.txtBuscar.IconLeft = null;
            this.txtBuscar.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.IconPadding = 15;
            this.txtBuscar.IconRight = null;
            this.txtBuscar.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscar.Lines = new string[0];
            this.txtBuscar.Location = new System.Drawing.Point(4, 2);
            this.txtBuscar.MaxLength = 32767;
            this.txtBuscar.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscar.Modified = false;
            this.txtBuscar.Multiline = false;
            this.txtBuscar.Name = "txtBuscar";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(234)))), ((int)(((byte)(176)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscar.OnIdleState = stateProperties4;
            this.txtBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.txtBuscar.PasswordChar = '\0';
            this.txtBuscar.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscar.PlaceholderText = "Buscar...";
            this.txtBuscar.ReadOnly = false;
            this.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscar.SelectedText = "";
            this.txtBuscar.SelectionLength = 0;
            this.txtBuscar.SelectionStart = 0;
            this.txtBuscar.ShortcutsEnabled = false;
            this.txtBuscar.Size = new System.Drawing.Size(522, 61);
            this.txtBuscar.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtBuscar.TabIndex = 7;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBuscar.TextMarginBottom = 0;
            this.txtBuscar.TextMarginLeft = 10;
            this.txtBuscar.TextMarginTop = 0;
            this.txtBuscar.TextPlaceholder = "Buscar...";
            this.txtBuscar.UseSystemPasswordChar = false;
            this.txtBuscar.WordWrap = true;
            // 
            // btnTodas
            // 
            this.btnTodas.AllowAnimations = true;
            this.btnTodas.AllowMouseEffects = true;
            this.btnTodas.AllowToggling = false;
            this.btnTodas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTodas.AnimationSpeed = 200;
            this.btnTodas.AutoGenerateColors = false;
            this.btnTodas.AutoRoundBorders = false;
            this.btnTodas.AutoSizeLeftIcon = true;
            this.btnTodas.AutoSizeRightIcon = true;
            this.btnTodas.BackColor = System.Drawing.Color.Transparent;
            this.btnTodas.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnTodas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTodas.BackgroundImage")));
            this.btnTodas.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTodas.ButtonText = "Todas";
            this.btnTodas.ButtonTextMarginLeft = 0;
            this.btnTodas.ColorContrastOnClick = 45;
            this.btnTodas.ColorContrastOnHover = 45;
            this.btnTodas.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = false;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = false;
            borderEdges3.TopRight = true;
            this.btnTodas.CustomizableEdges = borderEdges3;
            this.btnTodas.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTodas.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTodas.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTodas.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTodas.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnTodas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodas.ForeColor = System.Drawing.Color.White;
            this.btnTodas.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTodas.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnTodas.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnTodas.IconMarginLeft = 11;
            this.btnTodas.IconPadding = 10;
            this.btnTodas.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTodas.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnTodas.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnTodas.IconSize = 25;
            this.btnTodas.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnTodas.IdleBorderRadius = 30;
            this.btnTodas.IdleBorderThickness = 1;
            this.btnTodas.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnTodas.IdleIconLeftImage = null;
            this.btnTodas.IdleIconRightImage = null;
            this.btnTodas.IndicateFocus = false;
            this.btnTodas.Location = new System.Drawing.Point(855, 52);
            this.btnTodas.Name = "btnTodas";
            this.btnTodas.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnTodas.OnDisabledState.BorderRadius = 30;
            this.btnTodas.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTodas.OnDisabledState.BorderThickness = 1;
            this.btnTodas.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTodas.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnTodas.OnDisabledState.IconLeftImage = null;
            this.btnTodas.OnDisabledState.IconRightImage = null;
            this.btnTodas.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTodas.onHoverState.BorderRadius = 30;
            this.btnTodas.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTodas.onHoverState.BorderThickness = 1;
            this.btnTodas.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnTodas.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnTodas.onHoverState.IconLeftImage = null;
            this.btnTodas.onHoverState.IconRightImage = null;
            this.btnTodas.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTodas.OnIdleState.BorderRadius = 30;
            this.btnTodas.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTodas.OnIdleState.BorderThickness = 1;
            this.btnTodas.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnTodas.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnTodas.OnIdleState.IconLeftImage = null;
            this.btnTodas.OnIdleState.IconRightImage = null;
            this.btnTodas.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnTodas.OnPressedState.BorderRadius = 30;
            this.btnTodas.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnTodas.OnPressedState.BorderThickness = 1;
            this.btnTodas.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.btnTodas.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnTodas.OnPressedState.IconLeftImage = null;
            this.btnTodas.OnPressedState.IconRightImage = null;
            this.btnTodas.Size = new System.Drawing.Size(145, 50);
            this.btnTodas.TabIndex = 3;
            this.btnTodas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTodas.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTodas.TextMarginLeft = 0;
            this.btnTodas.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnTodas.UseDefaultRadiusAndThickness = true;
            // 
            // btnPendientes
            // 
            this.btnPendientes.AllowAnimations = true;
            this.btnPendientes.AllowMouseEffects = true;
            this.btnPendientes.AllowToggling = false;
            this.btnPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPendientes.AnimationSpeed = 200;
            this.btnPendientes.AutoGenerateColors = false;
            this.btnPendientes.AutoRoundBorders = false;
            this.btnPendientes.AutoSizeLeftIcon = true;
            this.btnPendientes.AutoSizeRightIcon = true;
            this.btnPendientes.BackColor = System.Drawing.Color.Transparent;
            this.btnPendientes.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnPendientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPendientes.BackgroundImage")));
            this.btnPendientes.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPendientes.ButtonText = "Pendientes";
            this.btnPendientes.ButtonTextMarginLeft = 0;
            this.btnPendientes.ColorContrastOnClick = 45;
            this.btnPendientes.ColorContrastOnHover = 45;
            this.btnPendientes.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = false;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = false;
            this.btnPendientes.CustomizableEdges = borderEdges4;
            this.btnPendientes.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPendientes.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.btnPendientes.DisabledFillColor = System.Drawing.Color.CadetBlue;
            this.btnPendientes.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPendientes.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnPendientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendientes.ForeColor = System.Drawing.Color.White;
            this.btnPendientes.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendientes.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnPendientes.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnPendientes.IconMarginLeft = 11;
            this.btnPendientes.IconPadding = 10;
            this.btnPendientes.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPendientes.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnPendientes.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnPendientes.IconSize = 25;
            this.btnPendientes.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btnPendientes.IdleBorderRadius = 30;
            this.btnPendientes.IdleBorderThickness = 1;
            this.btnPendientes.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnPendientes.IdleIconLeftImage = null;
            this.btnPendientes.IdleIconRightImage = null;
            this.btnPendientes.IndicateFocus = false;
            this.btnPendientes.Location = new System.Drawing.Point(563, 52);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.OnDisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPendientes.OnDisabledState.BorderRadius = 30;
            this.btnPendientes.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPendientes.OnDisabledState.BorderThickness = 1;
            this.btnPendientes.OnDisabledState.FillColor = System.Drawing.Color.CadetBlue;
            this.btnPendientes.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnPendientes.OnDisabledState.IconLeftImage = null;
            this.btnPendientes.OnDisabledState.IconRightImage = null;
            this.btnPendientes.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPendientes.onHoverState.BorderRadius = 30;
            this.btnPendientes.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPendientes.onHoverState.BorderThickness = 1;
            this.btnPendientes.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnPendientes.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnPendientes.onHoverState.IconLeftImage = null;
            this.btnPendientes.onHoverState.IconRightImage = null;
            this.btnPendientes.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPendientes.OnIdleState.BorderRadius = 30;
            this.btnPendientes.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPendientes.OnIdleState.BorderThickness = 1;
            this.btnPendientes.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnPendientes.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnPendientes.OnIdleState.IconLeftImage = null;
            this.btnPendientes.OnIdleState.IconRightImage = null;
            this.btnPendientes.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPendientes.OnPressedState.BorderRadius = 30;
            this.btnPendientes.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnPendientes.OnPressedState.BorderThickness = 1;
            this.btnPendientes.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.btnPendientes.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPendientes.OnPressedState.IconLeftImage = null;
            this.btnPendientes.OnPressedState.IconRightImage = null;
            this.btnPendientes.Size = new System.Drawing.Size(145, 50);
            this.btnPendientes.TabIndex = 1;
            this.btnPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPendientes.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPendientes.TextMarginLeft = 0;
            this.btnPendientes.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnPendientes.UseDefaultRadiusAndThickness = true;
            // 
            // dgvCitasAgendadas
            // 
            this.dgvCitasAgendadas.AllowCustomTheming = false;
            this.dgvCitasAgendadas.AllowUserToDeleteRows = false;
            this.dgvCitasAgendadas.AllowUserToResizeColumns = false;
            this.dgvCitasAgendadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCitasAgendadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitasAgendadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitasAgendadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitasAgendadas.BackgroundColor = System.Drawing.Color.PowderBlue;
            this.dgvCitasAgendadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCitasAgendadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCitasAgendadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitasAgendadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCitasAgendadas.ColumnHeadersHeight = 40;
            this.dgvCitasAgendadas.ContextMenuStrip = this.cmsOpciones;
            this.dgvCitasAgendadas.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.dgvCitasAgendadas.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCitasAgendadas.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCitasAgendadas.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvCitasAgendadas.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCitasAgendadas.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.dgvCitasAgendadas.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvCitasAgendadas.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.dgvCitasAgendadas.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvCitasAgendadas.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCitasAgendadas.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvCitasAgendadas.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCitasAgendadas.CurrentTheme.Name = null;
            this.dgvCitasAgendadas.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.dgvCitasAgendadas.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCitasAgendadas.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCitasAgendadas.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.dgvCitasAgendadas.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitasAgendadas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCitasAgendadas.EnableHeadersVisualStyles = false;
            this.dgvCitasAgendadas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.dgvCitasAgendadas.HeaderBackColor = System.Drawing.Color.Teal;
            this.dgvCitasAgendadas.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCitasAgendadas.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCitasAgendadas.Location = new System.Drawing.Point(30, 145);
            this.dgvCitasAgendadas.Name = "dgvCitasAgendadas";
            this.dgvCitasAgendadas.ReadOnly = true;
            this.dgvCitasAgendadas.RowHeadersVisible = false;
            this.dgvCitasAgendadas.RowTemplate.Height = 40;
            this.dgvCitasAgendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitasAgendadas.Size = new System.Drawing.Size(970, 478);
            this.dgvCitasAgendadas.TabIndex = 0;
            this.dgvCitasAgendadas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // VerCitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1033, 653);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1049, 692);
            this.MinimumSize = new System.Drawing.Size(1049, 692);
            this.Name = "VerCitasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.cmsOpciones.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnlSombraBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasAgendadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsOpciones;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarCita;
        public System.Windows.Forms.ToolStripMenuItem cmsVerCita;
        public Bunifu.UI.WinForms.BunifuPanel pnlSombraBuscar;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnPendientes;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvCitasAgendadas;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnTodas;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnBuscar;
        public Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAtendidas;
    }
}