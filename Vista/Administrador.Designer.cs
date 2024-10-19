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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmsOpciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsVerProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsRestablecerProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsEliminarProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsVerEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.NotificacionAdmin = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.Notificacion1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.btnAñadirProfesional = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.pnlSombraBuscar = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnBuscar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.txtBuscarEmpleado = new Bunifu.UI.WinForms.BunifuTextBox();
            this.dgvAdministrarProfesional = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cmsDeshabilitarProfesional = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsOpciones.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnlSombraBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrarProfesional)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsVerProfesional,
            this.cmsRestablecerProfesional,
            this.cmsEliminarProfesional,
            this.cmsDeshabilitarProfesional,
            this.cmsVerEspecialidades});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.Size = new System.Drawing.Size(197, 114);
            // 
            // cmsVerProfesional
            // 
            this.cmsVerProfesional.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Ver_Profesional_P;
            this.cmsVerProfesional.Name = "cmsVerProfesional";
            this.cmsVerProfesional.Size = new System.Drawing.Size(196, 22);
            this.cmsVerProfesional.Text = "Ver Profesional";
            // 
            // cmsRestablecerProfesional
            // 
            this.cmsRestablecerProfesional.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.ActualizarCMS;
            this.cmsRestablecerProfesional.Name = "cmsRestablecerProfesional";
            this.cmsRestablecerProfesional.Size = new System.Drawing.Size(196, 22);
            this.cmsRestablecerProfesional.Text = "Restablecer Profesional";
            // 
            // cmsEliminarProfesional
            // 
            this.cmsEliminarProfesional.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.EliminarCMS;
            this.cmsEliminarProfesional.Name = "cmsEliminarProfesional";
            this.cmsEliminarProfesional.Size = new System.Drawing.Size(196, 22);
            this.cmsEliminarProfesional.Text = "Eliminar Profesional";
            // 
            // cmsVerEspecialidades
            // 
            this.cmsVerEspecialidades.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.Ver_Especialidades;
            this.cmsVerEspecialidades.Name = "cmsVerEspecialidades";
            this.cmsVerEspecialidades.Size = new System.Drawing.Size(196, 22);
            this.cmsVerEspecialidades.Text = "Ver Especialidades";
            // 
            // NotificacionAdmin
            // 
            this.NotificacionAdmin.AllowDragging = false;
            this.NotificacionAdmin.AllowMultipleViews = true;
            this.NotificacionAdmin.ClickToClose = true;
            this.NotificacionAdmin.DoubleClickToClose = true;
            this.NotificacionAdmin.DurationAfterIdle = 3000;
            this.NotificacionAdmin.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.ErrorOptions.ActionBorderRadius = 1;
            this.NotificacionAdmin.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NotificacionAdmin.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.NotificacionAdmin.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.NotificacionAdmin.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.NotificacionAdmin.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NotificacionAdmin.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.NotificacionAdmin.ErrorOptions.IconLeftMargin = 12;
            this.NotificacionAdmin.FadeCloseIcon = false;
            this.NotificacionAdmin.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.NotificacionAdmin.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.InformationOptions.ActionBorderRadius = 1;
            this.NotificacionAdmin.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NotificacionAdmin.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.InformationOptions.BackColor = System.Drawing.Color.White;
            this.NotificacionAdmin.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.NotificacionAdmin.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NotificacionAdmin.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.NotificacionAdmin.InformationOptions.IconLeftMargin = 12;
            this.NotificacionAdmin.Margin = 10;
            this.NotificacionAdmin.MaximumSize = new System.Drawing.Size(0, 0);
            this.NotificacionAdmin.MaximumViews = 1;
            this.NotificacionAdmin.MessageRightMargin = 15;
            this.NotificacionAdmin.MessageTopMargin = 0;
            this.NotificacionAdmin.MinimumSize = new System.Drawing.Size(0, 0);
            this.NotificacionAdmin.ShowBorders = false;
            this.NotificacionAdmin.ShowCloseIcon = false;
            this.NotificacionAdmin.ShowIcon = true;
            this.NotificacionAdmin.ShowShadows = true;
            this.NotificacionAdmin.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.SuccessOptions.ActionBorderRadius = 1;
            this.NotificacionAdmin.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NotificacionAdmin.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.NotificacionAdmin.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.NotificacionAdmin.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.NotificacionAdmin.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NotificacionAdmin.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.NotificacionAdmin.SuccessOptions.IconLeftMargin = 12;
            this.NotificacionAdmin.ViewsMargin = 7;
            this.NotificacionAdmin.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotificacionAdmin.WarningOptions.ActionBorderRadius = 1;
            this.NotificacionAdmin.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.NotificacionAdmin.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.WarningOptions.BackColor = System.Drawing.Color.White;
            this.NotificacionAdmin.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.NotificacionAdmin.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.NotificacionAdmin.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.NotificacionAdmin.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.NotificacionAdmin.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.NotificacionAdmin.WarningOptions.IconLeftMargin = 12;
            this.NotificacionAdmin.ZoomCloseIcon = true;
            // 
            // Notificacion1
            // 
            this.Notificacion1.AllowDragging = false;
            this.Notificacion1.AllowMultipleViews = true;
            this.Notificacion1.ClickToClose = true;
            this.Notificacion1.DoubleClickToClose = true;
            this.Notificacion1.DurationAfterIdle = 3000;
            this.Notificacion1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.ErrorOptions.ActionBorderRadius = 1;
            this.Notificacion1.ErrorOptions.ActionFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificacion1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notificacion1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Notificacion1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Notificacion1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Notificacion1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notificacion1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Notificacion1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon4")));
            this.Notificacion1.ErrorOptions.IconLeftMargin = 12;
            this.Notificacion1.FadeCloseIcon = false;
            this.Notificacion1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Notificacion1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.InformationOptions.ActionBorderRadius = 1;
            this.Notificacion1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notificacion1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notificacion1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Notificacion1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Notificacion1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Notificacion1.InformationOptions.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notificacion1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Notificacion1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon5")));
            this.Notificacion1.InformationOptions.IconLeftMargin = 12;
            this.Notificacion1.Margin = 10;
            this.Notificacion1.MaximumSize = new System.Drawing.Size(0, 0);
            this.Notificacion1.MaximumViews = 1;
            this.Notificacion1.MessageRightMargin = 15;
            this.Notificacion1.MessageTopMargin = 0;
            this.Notificacion1.MinimumSize = new System.Drawing.Size(0, 0);
            this.Notificacion1.ShowBorders = false;
            this.Notificacion1.ShowCloseIcon = false;
            this.Notificacion1.ShowIcon = true;
            this.Notificacion1.ShowShadows = true;
            this.Notificacion1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.SuccessOptions.ActionBorderRadius = 1;
            this.Notificacion1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notificacion1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notificacion1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Notificacion1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Notificacion1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Notificacion1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notificacion1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Notificacion1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon6")));
            this.Notificacion1.SuccessOptions.IconLeftMargin = 12;
            this.Notificacion1.ViewsMargin = 7;
            this.Notificacion1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notificacion1.WarningOptions.ActionBorderRadius = 1;
            this.Notificacion1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notificacion1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notificacion1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Notificacion1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Notificacion1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Notificacion1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notificacion1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Notificacion1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon7")));
            this.Notificacion1.WarningOptions.IconLeftMargin = 12;
            this.Notificacion1.ZoomCloseIcon = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.btnAñadirProfesional);
            this.bunifuGradientPanel1.Controls.Add(this.pnlSombraBuscar);
            this.bunifuGradientPanel1.Controls.Add(this.dgvAdministrarProfesional);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Teal;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(992, 653);
            this.bunifuGradientPanel1.TabIndex = 2;
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
            this.btnAñadirProfesional.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnAñadirProfesional.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadirProfesional.BackgroundImage")));
            this.btnAñadirProfesional.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.ButtonText = "Añadir";
            this.btnAñadirProfesional.ButtonTextMarginLeft = 0;
            this.btnAñadirProfesional.ColorContrastOnClick = 45;
            this.btnAñadirProfesional.ColorContrastOnHover = 45;
            this.btnAñadirProfesional.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnAñadirProfesional.IdleBorderRadius = 30;
            this.btnAñadirProfesional.IdleBorderThickness = 1;
            this.btnAñadirProfesional.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnAñadirProfesional.IdleIconLeftImage = null;
            this.btnAñadirProfesional.IdleIconRightImage = null;
            this.btnAñadirProfesional.IndicateFocus = false;
            this.btnAñadirProfesional.Location = new System.Drawing.Point(753, 51);
            this.btnAñadirProfesional.Name = "btnAñadirProfesional";
            this.btnAñadirProfesional.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAñadirProfesional.OnDisabledState.BorderRadius = 30;
            this.btnAñadirProfesional.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnDisabledState.BorderThickness = 1;
            this.btnAñadirProfesional.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAñadirProfesional.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAñadirProfesional.OnDisabledState.IconLeftImage = null;
            this.btnAñadirProfesional.OnDisabledState.IconRightImage = null;
            this.btnAñadirProfesional.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.onHoverState.BorderRadius = 30;
            this.btnAñadirProfesional.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.onHoverState.BorderThickness = 1;
            this.btnAñadirProfesional.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(186)))), ((int)(((byte)(171)))));
            this.btnAñadirProfesional.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.onHoverState.IconLeftImage = null;
            this.btnAñadirProfesional.onHoverState.IconRightImage = null;
            this.btnAñadirProfesional.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.OnIdleState.BorderRadius = 30;
            this.btnAñadirProfesional.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnIdleState.BorderThickness = 1;
            this.btnAñadirProfesional.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(158)))), ((int)(((byte)(146)))));
            this.btnAñadirProfesional.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.OnIdleState.IconLeftImage = null;
            this.btnAñadirProfesional.OnIdleState.IconRightImage = null;
            this.btnAñadirProfesional.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadirProfesional.OnPressedState.BorderRadius = 30;
            this.btnAñadirProfesional.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnAñadirProfesional.OnPressedState.BorderThickness = 1;
            this.btnAñadirProfesional.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(130)))), ((int)(((byte)(120)))));
            this.btnAñadirProfesional.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAñadirProfesional.OnPressedState.IconLeftImage = null;
            this.btnAñadirProfesional.OnPressedState.IconRightImage = null;
            this.btnAñadirProfesional.Size = new System.Drawing.Size(197, 52);
            this.btnAñadirProfesional.TabIndex = 104;
            this.btnAñadirProfesional.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAñadirProfesional.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAñadirProfesional.TextMarginLeft = 0;
            this.btnAñadirProfesional.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnAñadirProfesional.UseDefaultRadiusAndThickness = true;
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
            this.pnlSombraBuscar.Controls.Add(this.txtBuscarEmpleado);
            this.pnlSombraBuscar.Location = new System.Drawing.Point(40, 44);
            this.pnlSombraBuscar.Name = "pnlSombraBuscar";
            this.pnlSombraBuscar.Padding = new System.Windows.Forms.Padding(4, 2, 1, 4);
            this.pnlSombraBuscar.ShowBorders = true;
            this.pnlSombraBuscar.Size = new System.Drawing.Size(654, 67);
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
            this.btnBuscar.Location = new System.Drawing.Point(533, 2);
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
            this.btnBuscar.Size = new System.Drawing.Size(121, 61);
            this.btnBuscar.TabIndex = 104;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBuscar.TextMarginLeft = 0;
            this.btnBuscar.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnBuscar.UseDefaultRadiusAndThickness = true;
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
            this.txtBuscarEmpleado.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtBuscarEmpleado.BorderRadius = 50;
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
            this.txtBuscarEmpleado.Location = new System.Drawing.Point(4, 2);
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
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
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
            this.txtBuscarEmpleado.Size = new System.Drawing.Size(649, 61);
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
            // dgvAdministrarProfesional
            // 
            this.dgvAdministrarProfesional.AllowCustomTheming = false;
            this.dgvAdministrarProfesional.AllowUserToAddRows = false;
            this.dgvAdministrarProfesional.AllowUserToDeleteRows = false;
            this.dgvAdministrarProfesional.AllowUserToResizeColumns = false;
            this.dgvAdministrarProfesional.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvAdministrarProfesional.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdministrarProfesional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAdministrarProfesional.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdministrarProfesional.BackgroundColor = System.Drawing.Color.PowderBlue;
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
            this.dgvAdministrarProfesional.Location = new System.Drawing.Point(40, 149);
            this.dgvAdministrarProfesional.Name = "dgvAdministrarProfesional";
            this.dgvAdministrarProfesional.ReadOnly = true;
            this.dgvAdministrarProfesional.RowHeadersVisible = false;
            this.dgvAdministrarProfesional.RowTemplate.Height = 40;
            this.dgvAdministrarProfesional.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAdministrarProfesional.Size = new System.Drawing.Size(910, 468);
            this.dgvAdministrarProfesional.TabIndex = 0;
            this.dgvAdministrarProfesional.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            // 
            // cmsDeshabilitarProfesional
            // 
            this.cmsDeshabilitarProfesional.Image = global::Empresa_laboral_ADNE___Proyecto_PTC.Properties.Resources.EliminarCMS;
            this.cmsDeshabilitarProfesional.Name = "cmsDeshabilitarProfesional";
            this.cmsDeshabilitarProfesional.Size = new System.Drawing.Size(196, 22);
            this.cmsDeshabilitarProfesional.Text = "Inhabilitar Profesional";
            // 
            // AdministradorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(143)))), ((int)(((byte)(156)))));
            this.ClientSize = new System.Drawing.Size(992, 653);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1008, 692);
            this.MinimumSize = new System.Drawing.Size(1008, 692);
            this.Name = "AdministradorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.cmsOpciones.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnlSombraBuscar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdministrarProfesional)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ContextMenuStrip cmsOpciones;
        public System.Windows.Forms.ToolStripMenuItem cmsRestablecerProfesional;
        public System.Windows.Forms.ToolStripMenuItem cmsEliminarProfesional;
        public System.Windows.Forms.ToolStripMenuItem cmsVerEspecialidades;
        public Bunifu.UI.WinForms.BunifuSnackbar NotificacionAdmin;
        public System.Windows.Forms.ToolStripMenuItem cmsVerProfesional;
        public Bunifu.UI.WinForms.BunifuSnackbar Notificacion1;
        public Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        public Bunifu.UI.WinForms.BunifuPanel pnlSombraBuscar;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnBuscar;
        public Bunifu.UI.WinForms.BunifuTextBox txtBuscarEmpleado;
        public Bunifu.UI.WinForms.BunifuDataGridView dgvAdministrarProfesional;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnAñadirProfesional;
        public System.Windows.Forms.ToolStripMenuItem cmsDeshabilitarProfesional;
    }
}