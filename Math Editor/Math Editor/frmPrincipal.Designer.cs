namespace MathEditor
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtFormula = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuGuardarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarComoHTMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAutom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.barrasDeHerramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estándarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolFile = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolModif = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuActualizar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 48);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.webBrowser1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtFormula);
            this.splitContainer1.Size = new System.Drawing.Size(1184, 689);
            this.splitContainer1.SplitterDistance = 397;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(1180, 393);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.TabStop = false;
            this.webBrowser1.Url = new System.Uri("file:///C:/Users/Jota/Documents/TEC/Administraci%C3%B3n%20de%20Proyectos/Admi%203" +
                    ".0/Prototipo%20De%20Seguridad/WindowsFormsApplication2/WindowsFormsApplication2/" +
                    "Temp.html", System.UriKind.Absolute);
            // 
            // txtFormula
            // 
            this.txtFormula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFormula.Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFormula.Location = new System.Drawing.Point(10, 10);
            this.txtFormula.Multiline = true;
            this.txtFormula.Name = "txtFormula";
            this.txtFormula.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFormula.Size = new System.Drawing.Size(1162, 265);
            this.txtFormula.TabIndex = 0;
            this.txtFormula.TextChanged += new System.EventHandler(this.txtFormula_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile,
            this.toolPath,
            this.toolModif});
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.ediciónToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.mnuPrincipal.Size = new System.Drawing.Size(1184, 24);
            this.mnuPrincipal.TabIndex = 2;
            this.mnuPrincipal.Text = "Menú Principal";
            this.mnuPrincipal.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNuevo,
            this.mnuAbrir,
            this.toolStripSeparator1,
            this.mnuGuardar,
            this.mnuGuardarComo,
            this.exportarComoHTMLToolStripMenuItem,
            this.toolStripSeparator2,
            this.mnuSalir});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "&Archivo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // mnuGuardarComo
            // 
            this.mnuGuardarComo.Name = "mnuGuardarComo";
            this.mnuGuardarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.G)));
            this.mnuGuardarComo.Size = new System.Drawing.Size(247, 22);
            this.mnuGuardarComo.Text = "G&uardar como...";
            this.mnuGuardarComo.Click += new System.EventHandler(this.mnuGuardarComo_Click);
            // 
            // exportarComoHTMLToolStripMenuItem
            // 
            this.exportarComoHTMLToolStripMenuItem.Name = "exportarComoHTMLToolStripMenuItem";
            this.exportarComoHTMLToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.exportarComoHTMLToolStripMenuItem.Text = "&Exportar como HTML...";
            this.exportarComoHTMLToolStripMenuItem.Click += new System.EventHandler(this.exportarComoHTMLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuSalir.Size = new System.Drawing.Size(247, 22);
            this.mnuSalir.Text = "&Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDeshacer,
            this.mnuRehacer,
            this.toolStripSeparator3,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "&Edición";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(201, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuActualizar,
            this.mnuAutom,
            this.toolStripSeparator4,
            this.barrasDeHerramientasToolStripMenuItem,
            this.barraDeEstadoToolStripMenuItem,
            this.toolStripSeparator5,
            this.mnuFullscreen});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.verToolStripMenuItem.Text = "&Ver";
            // 
            // mnuAutom
            // 
            this.mnuAutom.Checked = true;
            this.mnuAutom.CheckOnClick = true;
            this.mnuAutom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuAutom.Name = "mnuAutom";
            this.mnuAutom.Size = new System.Drawing.Size(262, 22);
            this.mnuAutom.Text = "Actualizar automáticamente &la vista";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(259, 6);
            // 
            // barrasDeHerramientasToolStripMenuItem
            // 
            this.barrasDeHerramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estándarToolStripMenuItem});
            this.barrasDeHerramientasToolStripMenuItem.Name = "barrasDeHerramientasToolStripMenuItem";
            this.barrasDeHerramientasToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.barrasDeHerramientasToolStripMenuItem.Text = "&Barras de herramientas";
            // 
            // estándarToolStripMenuItem
            // 
            this.estándarToolStripMenuItem.Checked = true;
            this.estándarToolStripMenuItem.CheckOnClick = true;
            this.estándarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.estándarToolStripMenuItem.Name = "estándarToolStripMenuItem";
            this.estándarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.estándarToolStripMenuItem.Text = "&Estándar";
            this.estándarToolStripMenuItem.Click += new System.EventHandler(this.estándarToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(259, 6);
            // 
            // toolFile
            // 
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(0, 17);
            this.toolFile.Visible = false;
            // 
            // toolPath
            // 
            this.toolPath.Name = "toolPath";
            this.toolPath.Size = new System.Drawing.Size(0, 17);
            this.toolPath.Visible = false;
            // 
            // toolModif
            // 
            this.toolModif.Name = "toolModif";
            this.toolModif.Size = new System.Drawing.Size(31, 17);
            this.toolModif.Text = "false";
            this.toolModif.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1184, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuNuevo
            // 
            this.mnuNuevo.Image = global::MathEditor.Properties.Resources.Document_1;
            this.mnuNuevo.Name = "mnuNuevo";
            this.mnuNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNuevo.Size = new System.Drawing.Size(247, 22);
            this.mnuNuevo.Text = "&Nuevo";
            // 
            // mnuAbrir
            // 
            this.mnuAbrir.Image = global::MathEditor.Properties.Resources.open_file_icon;
            this.mnuAbrir.Name = "mnuAbrir";
            this.mnuAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuAbrir.Size = new System.Drawing.Size(247, 22);
            this.mnuAbrir.Text = "&Abrir";
            this.mnuAbrir.Click += new System.EventHandler(this.mnuAbrir_Click);
            // 
            // mnuGuardar
            // 
            this.mnuGuardar.Image = global::MathEditor.Properties.Resources.Save_icon;
            this.mnuGuardar.Name = "mnuGuardar";
            this.mnuGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.mnuGuardar.Size = new System.Drawing.Size(247, 22);
            this.mnuGuardar.Text = "&Guardar";
            this.mnuGuardar.Click += new System.EventHandler(this.mnuGuardar_Click);
            // 
            // mnuDeshacer
            // 
            this.mnuDeshacer.Enabled = false;
            this.mnuDeshacer.Image = global::MathEditor.Properties.Resources.Actions_blue_arrow_undo_icon;
            this.mnuDeshacer.Name = "mnuDeshacer";
            this.mnuDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mnuDeshacer.Size = new System.Drawing.Size(204, 22);
            this.mnuDeshacer.Text = "&Deshacer";
            // 
            // mnuRehacer
            // 
            this.mnuRehacer.Enabled = false;
            this.mnuRehacer.Image = global::MathEditor.Properties.Resources.Actions_blue_arrow_redo_icon;
            this.mnuRehacer.Name = "mnuRehacer";
            this.mnuRehacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mnuRehacer.Size = new System.Drawing.Size(204, 22);
            this.mnuRehacer.Text = "&Rehacer";
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Enabled = false;
            this.cortarToolStripMenuItem.Image = global::MathEditor.Properties.Resources.Edit_Cut_icon__1_;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.cortarToolStripMenuItem.Text = "&Cortar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Enabled = false;
            this.copiarToolStripMenuItem.Image = global::MathEditor.Properties.Resources.copy_icon__1_;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.copiarToolStripMenuItem.Text = "Cop&iar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Enabled = false;
            this.pegarToolStripMenuItem.Image = global::MathEditor.Properties.Resources.paste_icon;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pegarToolStripMenuItem.Text = "Pe&gar";
            // 
            // mnuActualizar
            // 
            this.mnuActualizar.Image = global::MathEditor.Properties.Resources.refresh_icon;
            this.mnuActualizar.Name = "mnuActualizar";
            this.mnuActualizar.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.mnuActualizar.Size = new System.Drawing.Size(262, 22);
            this.mnuActualizar.Text = "Actuali&zar";
            this.mnuActualizar.Click += new System.EventHandler(this.mnuActualizar_Click);
            // 
            // mnuFullscreen
            // 
            this.mnuFullscreen.Image = global::MathEditor.Properties.Resources.Fullscreen_icon;
            this.mnuFullscreen.Name = "mnuFullscreen";
            this.mnuFullscreen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.mnuFullscreen.Size = new System.Drawing.Size(262, 22);
            this.mnuFullscreen.Text = "P&antalla Completa";
            this.mnuFullscreen.Click += new System.EventHandler(this.mnuFullscreen_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de &Math Editor";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // barraDeEstadoToolStripMenuItem
            // 
            this.barraDeEstadoToolStripMenuItem.Checked = true;
            this.barraDeEstadoToolStripMenuItem.CheckOnClick = true;
            this.barraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeEstadoToolStripMenuItem.Name = "barraDeEstadoToolStripMenuItem";
            this.barraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(262, 22);
            this.barraDeEstadoToolStripMenuItem.Text = "Barra &de estado";
            this.barraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.barraDeEstadoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 762);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mnuPrincipal);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sin título - Math Editor";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrincipal_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuNuevo;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuAbrir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardar;
        private System.Windows.Forms.ToolStripMenuItem mnuGuardarComo;
        private System.Windows.Forms.ToolStripMenuItem mnuDeshacer;
        private System.Windows.Forms.ToolStripMenuItem mnuRehacer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.TextBox txtFormula;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuActualizar;
        private System.Windows.Forms.ToolStripMenuItem mnuAutom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mnuFullscreen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ToolStripMenuItem barrasDeHerramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estándarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarComoHTMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolFile;
        private System.Windows.Forms.ToolStripStatusLabel toolPath;
        private System.Windows.Forms.ToolStripStatusLabel toolModif;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeEstadoToolStripMenuItem;
    }
}

