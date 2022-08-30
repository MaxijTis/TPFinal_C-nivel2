namespace Presentacion
{
    partial class frmBienvenido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBienvenido));
            this.btnStock = new System.Windows.Forms.Button();
            this.sspEstado = new System.Windows.Forms.StatusStrip();
            this.sslblReady = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsControlStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsCerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsStock = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAcerca = new System.Windows.Forms.ToolStripMenuItem();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblhGit = new System.Windows.Forms.LinkLabel();
            this.sspEstado.SuspendLayout();
            this.msMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            this.btnStock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStock.AutoSize = true;
            this.btnStock.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStock.FlatAppearance.BorderSize = 2;
            this.btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStock.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStock.Image = ((System.Drawing.Image)(resources.GetObject("btnStock.Image")));
            this.btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStock.Location = new System.Drawing.Point(12, 79);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(165, 55);
            this.btnStock.TabIndex = 2;
            this.btnStock.Text = "Control de Stock";
            this.btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // sspEstado
            // 
            this.sspEstado.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sspEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslblReady});
            this.sspEstado.Location = new System.Drawing.Point(0, 401);
            this.sspEstado.Name = "sspEstado";
            this.sspEstado.Size = new System.Drawing.Size(582, 22);
            this.sspEstado.TabIndex = 0;
            // 
            // sslblReady
            // 
            this.sslblReady.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sslblReady.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.sslblReady.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sslblReady.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sslblReady.ImageTransparentColor = System.Drawing.Color.Gray;
            this.sslblReady.Name = "sslblReady";
            this.sslblReady.Size = new System.Drawing.Size(39, 17);
            this.sslblReady.Text = "Ready";
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.SystemColors.Menu;
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tsOpciones,
            this.aboutToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(582, 24);
            this.msMenu.TabIndex = 4;
            this.msMenu.TabStop = true;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsControlStock,
            this.tsCerrar});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // tsControlStock
            // 
            this.tsControlStock.Name = "tsControlStock";
            this.tsControlStock.ShortcutKeyDisplayString = "";
            this.tsControlStock.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsControlStock.Size = new System.Drawing.Size(181, 22);
            this.tsControlStock.Text = "Control de Stock";
            this.tsControlStock.Click += new System.EventHandler(this.controlDeStockToolStripMenuItem_Click);
            // 
            // tsCerrar
            // 
            this.tsCerrar.Image = ((System.Drawing.Image)(resources.GetObject("tsCerrar.Image")));
            this.tsCerrar.Name = "tsCerrar";
            this.tsCerrar.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.tsCerrar.Size = new System.Drawing.Size(181, 22);
            this.tsCerrar.Text = "Cerrar";
            this.tsCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsCerrar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsCerrar.Click += new System.EventHandler(this.tsCerrar_Click);
            // 
            // tsOpciones
            // 
            this.tsOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tsStock});
            this.tsOpciones.Name = "tsOpciones";
            this.tsOpciones.Size = new System.Drawing.Size(69, 20);
            this.tsOpciones.Text = "&Opciones";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Enabled = false;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.productosToolStripMenuItem.Text = "Articulos";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Enabled = false;
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // tsStock
            // 
            this.tsStock.Name = "tsStock";
            this.tsStock.Size = new System.Drawing.Size(121, 22);
            this.tsStock.Text = "Stock";
            this.tsStock.Click += new System.EventHandler(this.tsStock_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAcerca});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.aboutToolStripMenuItem.Text = "Acer&ca de... ";
            // 
            // tsAcerca
            // 
            this.tsAcerca.Name = "tsAcerca";
            this.tsAcerca.Size = new System.Drawing.Size(209, 22);
            this.tsAcerca.Text = "Acerca de este Proyecto...";
            this.tsAcerca.Click += new System.EventHandler(this.tsAcerca_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitulo.BackColor = System.Drawing.Color.SlateGray;
            this.txtTitulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTitulo.Font = new System.Drawing.Font("Arial Black", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(279, 48);
            this.txtTitulo.Multiline = true;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.ShortcutsEnabled = false;
            this.txtTitulo.Size = new System.Drawing.Size(266, 143);
            this.txtTitulo.TabIndex = 0;
            this.txtTitulo.TabStop = false;
            this.txtTitulo.Text = "\r\nGestión del Deposito Central";
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblhGit
            // 
            this.lblhGit.AutoSize = true;
            this.lblhGit.Location = new System.Drawing.Point(9, 379);
            this.lblhGit.Name = "lblhGit";
            this.lblhGit.Size = new System.Drawing.Size(100, 13);
            this.lblhGit.TabIndex = 3;
            this.lblhGit.TabStop = true;
            this.lblhGit.Text = "Github del Proyecto";
            // 
            // frmBienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(582, 423);
            this.Controls.Add(this.lblhGit);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.sspEstado);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.btnStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.MaximizeBox = false;
            this.Name = "frmBienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido";
            this.sspEstado.ResumeLayout(false);
            this.sspEstado.PerformLayout();
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.StatusStrip sspEstado;
        private System.Windows.Forms.ToolStripStatusLabel sslblReady;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsOpciones;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsControlStock;
        private System.Windows.Forms.ToolStripMenuItem tsCerrar;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsStock;
        private System.Windows.Forms.ToolStripMenuItem tsAcerca;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.LinkLabel lblhGit;
    }
}

