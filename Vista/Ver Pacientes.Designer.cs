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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnSalir = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txtBuscarPaciente = new Bunifu.UI.WinForms.BunifuTextBox();
            this.flpVerPacientes = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnSalir);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuPanel1);
            this.bunifuGradientPanel1.Controls.Add(this.flpVerPacientes);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(225)))), ((int)(((byte)(226)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(227)))), ((int)(((byte)(226)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1011, 720);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.AllowFocused = false;
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.AutoSizeHeight = true;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Cerrar_Login;
            this.btnSalir.IsCircle = true;
            this.btnSalir.Location = new System.Drawing.Point(979, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(20, 20);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 14;
            this.btnSalir.TabStop = false;
            this.btnSalir.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 60;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.txtBuscarPaciente);
            this.bunifuPanel1.Location = new System.Drawing.Point(96, 54);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(801, 73);
            this.bunifuPanel1.TabIndex = 13;
            // 
            // txtBuscarPaciente
            // 
            this.txtBuscarPaciente.AcceptsReturn = false;
            this.txtBuscarPaciente.AcceptsTab = false;
            this.txtBuscarPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBuscarPaciente.AnimationSpeed = 200;
            this.txtBuscarPaciente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtBuscarPaciente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtBuscarPaciente.AutoSizeHeight = true;
            this.txtBuscarPaciente.BackColor = System.Drawing.Color.Transparent;
            this.txtBuscarPaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtBuscarPaciente.BackgroundImage")));
            this.txtBuscarPaciente.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtBuscarPaciente.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtBuscarPaciente.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtBuscarPaciente.BorderColorIdle = System.Drawing.Color.White;
            this.txtBuscarPaciente.BorderRadius = 60;
            this.txtBuscarPaciente.BorderThickness = 0;
            this.txtBuscarPaciente.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.txtBuscarPaciente.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtBuscarPaciente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.DefaultFont = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarPaciente.DefaultText = "";
            this.txtBuscarPaciente.FillColor = System.Drawing.Color.White;
            this.txtBuscarPaciente.HideSelection = true;
            this.txtBuscarPaciente.IconLeft = null;
            this.txtBuscarPaciente.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.IconPadding = 15;
            this.txtBuscarPaciente.IconRight = null;
            this.txtBuscarPaciente.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBuscarPaciente.Lines = new string[0];
            this.txtBuscarPaciente.Location = new System.Drawing.Point(0, 2);
            this.txtBuscarPaciente.MaxLength = 32767;
            this.txtBuscarPaciente.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtBuscarPaciente.Modified = false;
            this.txtBuscarPaciente.Multiline = false;
            this.txtBuscarPaciente.Name = "txtBuscarPaciente";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtBuscarPaciente.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtBuscarPaciente.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
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
            this.txtBuscarPaciente.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBuscarPaciente.PlaceholderText = "Buscar...";
            this.txtBuscarPaciente.ReadOnly = false;
            this.txtBuscarPaciente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBuscarPaciente.SelectedText = "";
            this.txtBuscarPaciente.SelectionLength = 0;
            this.txtBuscarPaciente.SelectionStart = 0;
            this.txtBuscarPaciente.ShortcutsEnabled = true;
            this.txtBuscarPaciente.Size = new System.Drawing.Size(801, 64);
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
            // flpVerPacientes
            // 
            this.flpVerPacientes.AutoScroll = true;
            this.flpVerPacientes.Location = new System.Drawing.Point(36, 164);
            this.flpVerPacientes.Name = "flpVerPacientes";
            this.flpVerPacientes.Size = new System.Drawing.Size(914, 500);
            this.flpVerPacientes.TabIndex = 1;
            // 
            // VerPacientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 720);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerPacientesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Pacientes";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarPaciente;
        public System.Windows.Forms.FlowLayoutPanel flpVerPacientes;
        public Bunifu.UI.WinForms.BunifuPictureBox btnSalir;
    }
}