namespace ProyectoAgronegocios.GUILayer
{
    partial class frmSemilla
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
            this.lblSemillasTitulo = new System.Windows.Forms.Label();
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.txtFilterNombre = new System.Windows.Forms.TextBox();
            this.lblFilterNombre = new System.Windows.Forms.Label();
            this.lblFilterTipoSemilla = new System.Windows.Forms.Label();
            this.cboFilterTipoSemilla = new System.Windows.Forms.ComboBox();
            this.dtgSemillas = new System.Windows.Forms.DataGridView();
            this.id_Semilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_X_Tonelada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoSemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.pnlSemilla = new System.Windows.Forms.Panel();
            this.cboCalidad = new System.Windows.Forms.ComboBox();
            this.cboTipoSemilla = new System.Windows.Forms.ComboBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtHabilitado = new System.Windows.Forms.TextBox();
            this.txtPrecioSugerido = new System.Windows.Forms.TextBox();
            this.txtPrecio_X_Tonelada = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblHabilitado = new System.Windows.Forms.Label();
            this.lblCalidad = new System.Windows.Forms.Label();
            this.lblPrecioSugerido = new System.Windows.Forms.Label();
            this.lblTipoSemilla = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio_X_Tonelada = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockMin = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPanelSemilla = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemillas)).BeginInit();
            this.pnlSemilla.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSemillasTitulo
            // 
            this.lblSemillasTitulo.AutoSize = true;
            this.lblSemillasTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSemillasTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lblSemillasTitulo.Location = new System.Drawing.Point(218, 20);
            this.lblSemillasTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSemillasTitulo.Name = "lblSemillasTitulo";
            this.lblSemillasTitulo.Size = new System.Drawing.Size(137, 37);
            this.lblSemillasTitulo.TabIndex = 0;
            this.lblSemillasTitulo.Text = "Semillas";
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltros.Controls.Add(this.txtFilterNombre);
            this.grpFiltros.Controls.Add(this.lblFilterNombre);
            this.grpFiltros.Controls.Add(this.lblFilterTipoSemilla);
            this.grpFiltros.Controls.Add(this.cboFilterTipoSemilla);
            this.grpFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(39, 56);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(2);
            this.grpFiltros.Size = new System.Drawing.Size(337, 88);
            this.grpFiltros.TabIndex = 0;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // txtFilterNombre
            // 
            this.txtFilterNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterNombre.Location = new System.Drawing.Point(174, 16);
            this.txtFilterNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtFilterNombre.Name = "txtFilterNombre";
            this.txtFilterNombre.Size = new System.Drawing.Size(144, 26);
            this.txtFilterNombre.TabIndex = 0;
            // 
            // lblFilterNombre
            // 
            this.lblFilterNombre.AutoSize = true;
            this.lblFilterNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFilterNombre.Location = new System.Drawing.Point(88, 19);
            this.lblFilterNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterNombre.Name = "lblFilterNombre";
            this.lblFilterNombre.Size = new System.Drawing.Size(66, 18);
            this.lblFilterNombre.TabIndex = 2;
            this.lblFilterNombre.Text = "Nombre:";
            // 
            // lblFilterTipoSemilla
            // 
            this.lblFilterTipoSemilla.AutoSize = true;
            this.lblFilterTipoSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFilterTipoSemilla.Location = new System.Drawing.Point(37, 51);
            this.lblFilterTipoSemilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilterTipoSemilla.Name = "lblFilterTipoSemilla";
            this.lblFilterTipoSemilla.Size = new System.Drawing.Size(113, 18);
            this.lblFilterTipoSemilla.TabIndex = 3;
            this.lblFilterTipoSemilla.Text = "Tipo de Semilla:";
            // 
            // cboFilterTipoSemilla
            // 
            this.cboFilterTipoSemilla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTipoSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFilterTipoSemilla.FormattingEnabled = true;
            this.cboFilterTipoSemilla.Location = new System.Drawing.Point(174, 52);
            this.cboFilterTipoSemilla.Margin = new System.Windows.Forms.Padding(2);
            this.cboFilterTipoSemilla.Name = "cboFilterTipoSemilla";
            this.cboFilterTipoSemilla.Size = new System.Drawing.Size(144, 28);
            this.cboFilterTipoSemilla.TabIndex = 1;
            // 
            // dtgSemillas
            // 
            this.dtgSemillas.AllowUserToAddRows = false;
            this.dtgSemillas.AllowUserToDeleteRows = false;
            this.dtgSemillas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgSemillas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSemillas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Semilla,
            this.nombre,
            this.stock,
            this.precio_X_Tonelada,
            this.tipoSemilla,
            this.calidad});
            this.dtgSemillas.Location = new System.Drawing.Point(26, 154);
            this.dtgSemillas.Margin = new System.Windows.Forms.Padding(2);
            this.dtgSemillas.Name = "dtgSemillas";
            this.dtgSemillas.ReadOnly = true;
            this.dtgSemillas.RowHeadersWidth = 82;
            this.dtgSemillas.RowTemplate.Height = 33;
            this.dtgSemillas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgSemillas.Size = new System.Drawing.Size(642, 416);
            this.dtgSemillas.TabIndex = 2;
            this.dtgSemillas.SelectionChanged += new System.EventHandler(this.dtgSemillas_SelectionChanged);
            // 
            // id_Semilla
            // 
            this.id_Semilla.HeaderText = "ID de Semilla";
            this.id_Semilla.MinimumWidth = 10;
            this.id_Semilla.Name = "id_Semilla";
            this.id_Semilla.ReadOnly = true;
            this.id_Semilla.Width = 200;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 10;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 200;
            // 
            // stock
            // 
            this.stock.HeaderText = "Stock";
            this.stock.MinimumWidth = 10;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Width = 200;
            // 
            // precio_X_Tonelada
            // 
            this.precio_X_Tonelada.HeaderText = "Precio Por Tonelada";
            this.precio_X_Tonelada.MinimumWidth = 10;
            this.precio_X_Tonelada.Name = "precio_X_Tonelada";
            this.precio_X_Tonelada.ReadOnly = true;
            this.precio_X_Tonelada.Width = 200;
            // 
            // tipoSemilla
            // 
            this.tipoSemilla.HeaderText = "Tipo de Semilla";
            this.tipoSemilla.MinimumWidth = 10;
            this.tipoSemilla.Name = "tipoSemilla";
            this.tipoSemilla.ReadOnly = true;
            this.tipoSemilla.Width = 200;
            // 
            // calidad
            // 
            this.calidad.HeaderText = "Calidad";
            this.calidad.MinimumWidth = 10;
            this.calidad.Name = "calidad";
            this.calidad.ReadOnly = true;
            this.calidad.Width = 200;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(26, 597);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 37);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(172, 597);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 37);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.Location = new System.Drawing.Point(318, 597);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1001, 597);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(120, 37);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(394, 96);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(111, 31);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // pnlSemilla
            // 
            this.pnlSemilla.BackColor = System.Drawing.Color.Transparent;
            this.pnlSemilla.Controls.Add(this.cboCalidad);
            this.pnlSemilla.Controls.Add(this.cboTipoSemilla);
            this.pnlSemilla.Controls.Add(this.btnFinalizar);
            this.pnlSemilla.Controls.Add(this.btnLimpiar);
            this.pnlSemilla.Controls.Add(this.btnAceptar);
            this.pnlSemilla.Controls.Add(this.txtDescripcion);
            this.pnlSemilla.Controls.Add(this.txtHabilitado);
            this.pnlSemilla.Controls.Add(this.txtPrecioSugerido);
            this.pnlSemilla.Controls.Add(this.txtPrecio_X_Tonelada);
            this.pnlSemilla.Controls.Add(this.txtStock);
            this.pnlSemilla.Controls.Add(this.txtStockMin);
            this.pnlSemilla.Controls.Add(this.txtNombre);
            this.pnlSemilla.Controls.Add(this.lblHabilitado);
            this.pnlSemilla.Controls.Add(this.lblCalidad);
            this.pnlSemilla.Controls.Add(this.lblPrecioSugerido);
            this.pnlSemilla.Controls.Add(this.lblTipoSemilla);
            this.pnlSemilla.Controls.Add(this.lblDescripcion);
            this.pnlSemilla.Controls.Add(this.lblPrecio_X_Tonelada);
            this.pnlSemilla.Controls.Add(this.lblStock);
            this.pnlSemilla.Controls.Add(this.lblStockMin);
            this.pnlSemilla.Controls.Add(this.lblNombre);
            this.pnlSemilla.Controls.Add(this.lblPanelSemilla);
            this.pnlSemilla.Location = new System.Drawing.Point(696, 39);
            this.pnlSemilla.Margin = new System.Windows.Forms.Padding(2);
            this.pnlSemilla.Name = "pnlSemilla";
            this.pnlSemilla.Size = new System.Drawing.Size(425, 532);
            this.pnlSemilla.TabIndex = 7;
            // 
            // cboCalidad
            // 
            this.cboCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCalidad.FormattingEnabled = true;
            this.cboCalidad.Location = new System.Drawing.Point(201, 418);
            this.cboCalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cboCalidad.Name = "cboCalidad";
            this.cboCalidad.Size = new System.Drawing.Size(158, 28);
            this.cboCalidad.TabIndex = 8;
            // 
            // cboTipoSemilla
            // 
            this.cboTipoSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoSemilla.FormattingEnabled = true;
            this.cboTipoSemilla.Location = new System.Drawing.Point(201, 380);
            this.cboTipoSemilla.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoSemilla.Name = "cboTipoSemilla";
            this.cboTipoSemilla.Size = new System.Drawing.Size(158, 28);
            this.cboTipoSemilla.TabIndex = 7;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(301, 491);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(110, 36);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(155, 491);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(9, 491);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(110, 36);
            this.btnAceptar.TabIndex = 9;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(201, 248);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 72);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtHabilitado
            // 
            this.txtHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHabilitado.Location = new System.Drawing.Point(201, 214);
            this.txtHabilitado.Margin = new System.Windows.Forms.Padding(2);
            this.txtHabilitado.MaxLength = 2;
            this.txtHabilitado.Name = "txtHabilitado";
            this.txtHabilitado.Size = new System.Drawing.Size(48, 26);
            this.txtHabilitado.TabIndex = 4;
            // 
            // txtPrecioSugerido
            // 
            this.txtPrecioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioSugerido.Location = new System.Drawing.Point(201, 343);
            this.txtPrecioSugerido.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioSugerido.Name = "txtPrecioSugerido";
            this.txtPrecioSugerido.Size = new System.Drawing.Size(88, 26);
            this.txtPrecioSugerido.TabIndex = 6;
            // 
            // txtPrecio_X_Tonelada
            // 
            this.txtPrecio_X_Tonelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio_X_Tonelada.Location = new System.Drawing.Point(201, 181);
            this.txtPrecio_X_Tonelada.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio_X_Tonelada.Name = "txtPrecio_X_Tonelada";
            this.txtPrecio_X_Tonelada.Size = new System.Drawing.Size(88, 26);
            this.txtPrecio_X_Tonelada.TabIndex = 3;
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(201, 148);
            this.txtStock.Margin = new System.Windows.Forms.Padding(2);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(88, 26);
            this.txtStock.TabIndex = 2;
            // 
            // txtStockMin
            // 
            this.txtStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMin.Location = new System.Drawing.Point(201, 114);
            this.txtStockMin.Margin = new System.Windows.Forms.Padding(2);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(88, 26);
            this.txtStockMin.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(201, 81);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // lblHabilitado
            // 
            this.lblHabilitado.AutoSize = true;
            this.lblHabilitado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblHabilitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHabilitado.ForeColor = System.Drawing.Color.White;
            this.lblHabilitado.Location = new System.Drawing.Point(86, 214);
            this.lblHabilitado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHabilitado.Name = "lblHabilitado";
            this.lblHabilitado.Size = new System.Drawing.Size(88, 20);
            this.lblHabilitado.TabIndex = 17;
            this.lblHabilitado.Text = "Habilitado: ";
            // 
            // lblCalidad
            // 
            this.lblCalidad.AutoSize = true;
            this.lblCalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidad.ForeColor = System.Drawing.Color.White;
            this.lblCalidad.Location = new System.Drawing.Point(108, 418);
            this.lblCalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalidad.Name = "lblCalidad";
            this.lblCalidad.Size = new System.Drawing.Size(66, 20);
            this.lblCalidad.TabIndex = 21;
            this.lblCalidad.Text = "Calidad:";
            // 
            // lblPrecioSugerido
            // 
            this.lblPrecioSugerido.AutoSize = true;
            this.lblPrecioSugerido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrecioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSugerido.ForeColor = System.Drawing.Color.White;
            this.lblPrecioSugerido.Location = new System.Drawing.Point(48, 343);
            this.lblPrecioSugerido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioSugerido.Name = "lblPrecioSugerido";
            this.lblPrecioSugerido.Size = new System.Drawing.Size(125, 20);
            this.lblPrecioSugerido.TabIndex = 19;
            this.lblPrecioSugerido.Text = "Precio Sugerido:";
            // 
            // lblTipoSemilla
            // 
            this.lblTipoSemilla.AutoSize = true;
            this.lblTipoSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTipoSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSemilla.ForeColor = System.Drawing.Color.White;
            this.lblTipoSemilla.Location = new System.Drawing.Point(52, 380);
            this.lblTipoSemilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoSemilla.Name = "lblTipoSemilla";
            this.lblTipoSemilla.Size = new System.Drawing.Size(120, 20);
            this.lblTipoSemilla.TabIndex = 20;
            this.lblTipoSemilla.Text = "Tipo de Semilla:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.White;
            this.lblDescripcion.Location = new System.Drawing.Point(78, 248);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 18;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio_X_Tonelada
            // 
            this.lblPrecio_X_Tonelada.AutoSize = true;
            this.lblPrecio_X_Tonelada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrecio_X_Tonelada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio_X_Tonelada.ForeColor = System.Drawing.Color.White;
            this.lblPrecio_X_Tonelada.Location = new System.Drawing.Point(16, 181);
            this.lblPrecio_X_Tonelada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio_X_Tonelada.Name = "lblPrecio_X_Tonelada";
            this.lblPrecio_X_Tonelada.Size = new System.Drawing.Size(155, 20);
            this.lblPrecio_X_Tonelada.TabIndex = 16;
            this.lblPrecio_X_Tonelada.Text = "Precio Por Tonelada:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.White;
            this.lblStock.Location = new System.Drawing.Point(122, 148);
            this.lblStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(54, 20);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Stock:";
            // 
            // lblStockMin
            // 
            this.lblStockMin.AutoSize = true;
            this.lblStockMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMin.ForeColor = System.Drawing.Color.White;
            this.lblStockMin.Location = new System.Drawing.Point(66, 114);
            this.lblStockMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStockMin.Name = "lblStockMin";
            this.lblStockMin.Size = new System.Drawing.Size(108, 20);
            this.lblStockMin.TabIndex = 14;
            this.lblStockMin.Text = "Stock Mínimo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(104, 81);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 13;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblPanelSemilla
            // 
            this.lblPanelSemilla.AutoSize = true;
            this.lblPanelSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanelSemilla.Location = new System.Drawing.Point(121, 11);
            this.lblPanelSemilla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPanelSemilla.Name = "lblPanelSemilla";
            this.lblPanelSemilla.Size = new System.Drawing.Size(201, 26);
            this.lblPanelSemilla.TabIndex = 12;
            this.lblPanelSemilla.Text = "Datos de la Semilla";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(558, 574);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 27);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // frmSemilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::ProyectoAgronegocios.Properties.Resources.semilla;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1157, 660);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.pnlSemilla);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dtgSemillas);
            this.Controls.Add(this.grpFiltros);
            this.Controls.Add(this.lblSemillasTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSemilla";
            this.Text = "Semillas";
            this.Load += new System.EventHandler(this.frmSemilla_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSemillas)).EndInit();
            this.pnlSemilla.ResumeLayout(false);
            this.pnlSemilla.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSemillasTitulo;
        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.TextBox txtFilterNombre;
        private System.Windows.Forms.Label lblFilterNombre;
        private System.Windows.Forms.Label lblFilterTipoSemilla;
        private System.Windows.Forms.ComboBox cboFilterTipoSemilla;
        private System.Windows.Forms.DataGridView dtgSemillas;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel pnlSemilla;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblHabilitado;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio_X_Tonelada;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockMin;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPanelSemilla;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.TextBox txtPrecio_X_Tonelada;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtHabilitado;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cboCalidad;
        private System.Windows.Forms.ComboBox cboTipoSemilla;
        private System.Windows.Forms.Label lblCalidad;
        private System.Windows.Forms.Label lblTipoSemilla;
        private System.Windows.Forms.TextBox txtPrecioSugerido;
        private System.Windows.Forms.Label lblPrecioSugerido;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Semilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_X_Tonelada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoSemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn calidad;
        private System.Windows.Forms.Button btnActualizar;
    }
}