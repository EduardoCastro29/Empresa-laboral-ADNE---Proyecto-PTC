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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarCita = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVerCita = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFondo = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlSombraFondo = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlForms = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.pnlSombraBuscar = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBuscar = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvCitasAgendadas = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.btnSalir = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cmsOpciones.SuspendLayout();
            this.pnlFondo.SuspendLayout();
            this.pnlSombraFondo.SuspendLayout();
            this.pnlForms.SuspendLayout();
            this.pnlSombraBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasAgendadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
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
            this.pnlForms.Controls.Add(this.btnSalir);
            this.pnlForms.Controls.Add(this.pnlSombraBuscar);
            this.pnlForms.Controls.Add(this.dgvCitasAgendadas);
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
            this.pnlSombraBuscar.Controls.Add(this.txtBuscar);
            this.pnlSombraBuscar.Location = new System.Drawing.Point(153, 57);
            this.pnlSombraBuscar.Name = "pnlSombraBuscar";
            this.pnlSombraBuscar.Padding = new System.Windows.Forms.Padding(5, 2, 1, 6);
            this.pnlSombraBuscar.ShowBorders = true;
            this.pnlSombraBuscar.Size = new System.Drawing.Size(687, 74);
            this.pnlSombraBuscar.TabIndex = 102;
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
            this.txtBuscar.BorderColorIdle = System.Drawing.Color.White;
            this.txtBuscar.BorderRadius = 60;
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
            this.txtBuscar.Location = new System.Drawing.Point(5, 2);
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
            stateProperties4.BorderColor = System.Drawing.Color.White;
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
            this.txtBuscar.Size = new System.Drawing.Size(681, 66);
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
            // dgvCitasAgendadas
            // 
            this.dgvCitasAgendadas.AllowCustomTheming = false;
            this.dgvCitasAgendadas.AllowUserToAddRows = false;
            this.dgvCitasAgendadas.AllowUserToResizeColumns = false;
            this.dgvCitasAgendadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCitasAgendadas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCitasAgendadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCitasAgendadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitasAgendadas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
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
            this.dgvCitasAgendadas.Location = new System.Drawing.Point(28, 165);
            this.dgvCitasAgendadas.Name = "dgvCitasAgendadas";
            this.dgvCitasAgendadas.ReadOnly = true;
            this.dgvCitasAgendadas.RowHeadersVisible = false;
            this.dgvCitasAgendadas.RowTemplate.Height = 40;
            this.dgvCitasAgendadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCitasAgendadas.Size = new System.Drawing.Size(931, 497);
            this.dgvCitasAgendadas.TabIndex = 100;
            this.dgvCitasAgendadas.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // btnSalir
            // 
            this.btnSalir.AllowFocused = false;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.AutoSizeHeight = true;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Cerrar_Login;
            this.btnSalir.IsCircle = true;
            this.btnSalir.Location = new System.Drawing.Point(934, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(27, 27);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 103;
            this.btnSalir.TabStop = false;
            this.btnSalir.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // VerCitasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(1011, 720);
            this.Controls.Add(this.pnlFondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerCitasForm";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 5, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Citas";
            this.cmsOpciones.ResumeLayout(false);
            this.pnlFondo.ResumeLayout(false);
            this.pnlSombraFondo.ResumeLayout(false);
            this.pnlForms.ResumeLayout(false);
            this.pnlSombraBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitasAgendadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsOpciones;
        public System.Windows.Forms.ToolStripMenuItem cmsActualizar;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarCita;
        public System.Windows.Forms.ToolStripMenuItem cmsVerCita;
        public Bunifu.UI.WinForms.BunifuPanel pnlFondo;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlSombraFondo;
        public Bunifu.UI.WinForms.BunifuGradientPanel pnlForms;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvCitasAgendadas;
        public Bunifu.UI.WinForms.BunifuPanel pnlSombraBuscar;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscar;
        public Bunifu.UI.WinForms.BunifuPictureBox btnSalir;
    }
}