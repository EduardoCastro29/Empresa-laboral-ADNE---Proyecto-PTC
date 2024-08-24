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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnSalir = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.dgvAdministrarProfesional = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAñadirProfesional = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrarProfesional)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnSalir);
            this.bunifuGradientPanel1.Controls.Add(this.dgvAdministrarProfesional);
            this.bunifuGradientPanel1.Controls.Add(this.btnAñadirProfesional);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuTextBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(226)))), ((int)(((byte)(227)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(991, 700);
            this.bunifuGradientPanel1.TabIndex = 99;
            // 
            // btnSalir
            // 
            this.btnSalir.AllowFocused = false;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.AutoSizeHeight = true;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Cerrar_Login;
            this.btnSalir.IsCircle = true;
            this.btnSalir.Location = new System.Drawing.Point(959, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TabStop = false;
            this.btnSalir.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.dgvAdministrarProfesional.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.dgvAdministrarProfesional.Location = new System.Drawing.Point(27, 158);
            this.dgvAdministrarProfesional.Name = "dgvAdministrarProfesional";
            this.dgvAdministrarProfesional.ReadOnly = true;
            this.dgvAdministrarProfesional.RowHeadersVisible = false;
            this.dgvAdministrarProfesional.RowTemplate.Height = 40;
            this.dgvAdministrarProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministrarProfesional.Size = new System.Drawing.Size(931, 499);
            this.dgvAdministrarProfesional.TabIndex = 99;
            this.dgvAdministrarProfesional.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsActualizar,
            this.cmsEliminarProfesional});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(189, 48);
            // 
            // cmsActualizar
            // 
            this.cmsActualizar.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.ActualizarCMS;
            this.cmsActualizar.Name = "cmsActualizar";
            this.cmsActualizar.Size = new System.Drawing.Size(188, 22);
            this.cmsActualizar.Text = "Actualizar profesional";
            // 
            // cmsEliminarProfesional
            // 
            this.cmsEliminarProfesional.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.EliminarCMS;
            this.cmsEliminarProfesional.Name = "cmsEliminarProfesional";
            this.cmsEliminarProfesional.Size = new System.Drawing.Size(188, 22);
            this.cmsEliminarProfesional.Text = "Eliminar profesional";
            // 
            // btnAñadirProfesional
            // 
            this.btnAñadirProfesional.AllowAnimations = true;
            this.btnAñadirProfesional.AllowMouseEffects = true;
            this.btnAñadirProfesional.AllowToggling = false;
            this.btnAñadirProfesional.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAñadirProfesional.AnimationSpeed = 200;
            this.btnAñadirProfesional.AutoGenerateColors = false;
            this.btnAñadirProfesional.AutoRoundBorders = false;
            this.btnAñadirProfesional.AutoSizeLeftIcon = true;
            this.btnAñadirProfesional.AutoSizeRightIcon = true;
            this.btnAñadirProfesional.BackColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
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
            this.btnAñadirProfesional.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnAñadirProfesional.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnAñadirProfesional.IdleBorderRadius = 12;
            this.btnAñadirProfesional.IdleBorderThickness = 1;
            this.btnAñadirProfesional.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAñadirProfesional.IdleIconLeftImage = null;
            this.btnAñadirProfesional.IdleIconRightImage = null;
            this.btnAñadirProfesional.IndicateFocus = false;
            this.btnAñadirProfesional.Location = new System.Drawing.Point(749, 54);
            this.btnAñadirProfesional.Name = "btnAñadirProfesional";
            this.btnAñadirProfesional.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAñadirProfesional.OnDisabledState.BorderRadius = 12;
            this.btnAñadirProfesional.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnDisabledState.BorderThickness = 1;
            this.btnAñadirProfesional.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAñadirProfesional.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAñadirProfesional.OnDisabledState.IconLeftImage = null;
            this.btnAñadirProfesional.OnDisabledState.IconRightImage = null;
            this.btnAñadirProfesional.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.onHoverState.BorderRadius = 12;
            this.btnAñadirProfesional.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.onHoverState.BorderThickness = 1;
            this.btnAñadirProfesional.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAñadirProfesional.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.onHoverState.IconLeftImage = null;
            this.btnAñadirProfesional.onHoverState.IconRightImage = null;
            this.btnAñadirProfesional.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.OnIdleState.BorderRadius = 12;
            this.btnAñadirProfesional.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnIdleState.BorderThickness = 1;
            this.btnAñadirProfesional.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAñadirProfesional.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.OnIdleState.IconLeftImage = null;
            this.btnAñadirProfesional.OnIdleState.IconRightImage = null;
            this.btnAñadirProfesional.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.OnPressedState.BorderRadius = 12;
            this.btnAñadirProfesional.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnPressedState.BorderThickness = 1;
            this.btnAñadirProfesional.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(2)))), ((int)(((byte)(161)))), ((int)(((byte)(104)))));
            this.btnAñadirProfesional.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.OnPressedState.IconLeftImage = null;
            this.btnAñadirProfesional.OnPressedState.IconRightImage = null;
            this.btnAñadirProfesional.Size = new System.Drawing.Size(209, 67);
            this.btnAñadirProfesional.TabIndex = 2;
            this.btnAñadirProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAñadirProfesional.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAñadirProfesional.TextMarginLeft = 0;
            this.btnAñadirProfesional.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAñadirProfesional.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.White;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.Teal;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.LightSeaGreen;
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.BorderRadius = 20;
            this.bunifuTextBox1.BorderThickness = 2;
            this.bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Lupa;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 22;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(27, 54);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.Teal;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.LightSeaGreen;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.DarkGray;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.bunifuTextBox1.PlaceholderText = "Buscar...";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(694, 67);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Material;
            this.bunifuTextBox1.TabIndex = 1;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 15;
            this.bunifuTextBox1.TextMarginTop = 1;
            this.bunifuTextBox1.TextPlaceholder = "Buscar...";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 700);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministradorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrarProfesional)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvAdministrarProfesional;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAñadirProfesional;
        public Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        public Bunifu.UI.WinForms.BunifuPictureBox btnSalir;
        public System.Windows.Forms.ContextMenuStrip cmsOpciones;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarProfesional;
    }
}