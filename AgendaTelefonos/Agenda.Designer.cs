namespace AgendaTelefonos
{
    partial class Agenda
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
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxApellido = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxCasa = new System.Windows.Forms.TextBox();
            this.tbxTrabajo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mniGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslFecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslRegistros = new System.Windows.Forms.ToolStripStatusLabel();
            this.mniNuevo = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.mnsMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AllowUserToDeleteRows = false;
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(12, 93);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.Size = new System.Drawing.Size(605, 325);
            this.dgvContactos.TabIndex = 0;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(12, 53);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 3;
            // 
            // tbxApellido
            // 
            this.tbxApellido.Location = new System.Drawing.Point(118, 53);
            this.tbxApellido.Name = "tbxApellido";
            this.tbxApellido.Size = new System.Drawing.Size(100, 20);
            this.tbxApellido.TabIndex = 4;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(224, 53);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(100, 20);
            this.tbxDireccion.TabIndex = 5;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(541, 51);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxCasa
            // 
            this.tbxCasa.Location = new System.Drawing.Point(330, 53);
            this.tbxCasa.Name = "tbxCasa";
            this.tbxCasa.Size = new System.Drawing.Size(100, 20);
            this.tbxCasa.TabIndex = 6;
            // 
            // tbxTrabajo
            // 
            this.tbxTrabajo.Location = new System.Drawing.Point(436, 53);
            this.tbxTrabajo.Name = "tbxTrabajo";
            this.tbxTrabajo.Size = new System.Drawing.Size(100, 20);
            this.tbxTrabajo.TabIndex = 7;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 34);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(115, 34);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 0;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(221, 34);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 0;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblCasa
            // 
            this.lblCasa.AutoSize = true;
            this.lblCasa.Location = new System.Drawing.Point(327, 34);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(52, 13);
            this.lblCasa.TabIndex = 0;
            this.lblCasa.Text = "Tel. Casa";
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.AutoSize = true;
            this.lblTrabajo.Location = new System.Drawing.Point(433, 34);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(64, 13);
            this.lblTrabajo.TabIndex = 0;
            this.lblTrabajo.Text = "Tel. Trabajo";
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(628, 24);
            this.mnsMenu.TabIndex = 9;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniNuevo,
            this.mniAbrir,
            this.mniGuardar,
            this.mniSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mniAbrir
            // 
            this.mniAbrir.Name = "mniAbrir";
            this.mniAbrir.Size = new System.Drawing.Size(152, 22);
            this.mniAbrir.Text = "Abrir";
            this.mniAbrir.Click += new System.EventHandler(this.mniAbrir_Click);
            // 
            // mniGuardar
            // 
            this.mniGuardar.Name = "mniGuardar";
            this.mniGuardar.Size = new System.Drawing.Size(152, 22);
            this.mniGuardar.Text = "Guardar";
            this.mniGuardar.Click += new System.EventHandler(this.mniGuardar_Click);
            // 
            // mniSalir
            // 
            this.mniSalir.Name = "mniSalir";
            this.mniSalir.Size = new System.Drawing.Size(152, 22);
            this.mniSalir.Text = "Salir";
            this.mniSalir.Click += new System.EventHandler(this.mniSalir_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAcercaDe});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // mniAcercaDe
            // 
            this.mniAcercaDe.Name = "mniAcercaDe";
            this.mniAcercaDe.Size = new System.Drawing.Size(152, 22);
            this.mniAcercaDe.Text = "Acerca de";
            this.mniAcercaDe.Click += new System.EventHandler(this.mniAcercaDe_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFecha,
            this.tslRegistros});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(628, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslFecha
            // 
            this.tslFecha.Name = "tslFecha";
            this.tslFecha.Size = new System.Drawing.Size(65, 17);
            this.tslFecha.Text = "01/01/2016";
            // 
            // tslRegistros
            // 
            this.tslRegistros.Name = "tslRegistros";
            this.tslRegistros.Size = new System.Drawing.Size(61, 17);
            this.tslRegistros.Text = "0 registros";
            // 
            // mniNuevo
            // 
            this.mniNuevo.Name = "mniNuevo";
            this.mniNuevo.Size = new System.Drawing.Size(152, 22);
            this.mniNuevo.Text = "Nuevo";
            this.mniNuevo.Click += new System.EventHandler(this.mniNuevo_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 454);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblTrabajo);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxTrabajo);
            this.Controls.Add(this.tbxCasa);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbxDireccion);
            this.Controls.Add(this.tbxApellido);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.MinimumSize = new System.Drawing.Size(644, 493);
            this.Name = "Agenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.TextBox tbxApellido;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxCasa;
        private System.Windows.Forms.TextBox tbxTrabajo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAbrir;
        private System.Windows.Forms.ToolStripMenuItem mniGuardar;
        private System.Windows.Forms.ToolStripMenuItem mniSalir;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mniAcercaDe;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslFecha;
        private System.Windows.Forms.ToolStripStatusLabel tslRegistros;
        private System.Windows.Forms.ToolStripMenuItem mniNuevo;
    }
}

