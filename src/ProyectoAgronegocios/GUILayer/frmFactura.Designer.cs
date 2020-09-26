namespace ProyectoAgronegocios.GUILayer
{
    partial class frmFactura
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
            this.grpFiltros = new System.Windows.Forms.GroupBox();
            this.txtFilterCuil = new System.Windows.Forms.TextBox();
            this.lblFilterCuit = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblDatoNombre = new System.Windows.Forms.Label();
            this.lblRealNombre = new System.Windows.Forms.Label();
            this.lblDatoCuil = new System.Windows.Forms.Label();
            this.lblRealCuil = new System.Windows.Forms.Label();
            this.lblUsuarioLoguedo = new System.Windows.Forms.Label();
            this.lblTituloSemillas = new System.Windows.Forms.Label();
            this.dtgDetalles = new System.Windows.Forms.DataGridView();
            this.id_Semilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblIdSemilla = new System.Windows.Forms.Label();
            this.txtIdSemilla = new System.Windows.Forms.TextBox();
            this.lblNombreSemilla = new System.Windows.Forms.Label();
            this.txtNombreSemilla = new System.Windows.Forms.TextBox();
            this.lblTipoSemilla = new System.Windows.Forms.Label();
            this.lblCalidadSemilla = new System.Windows.Forms.Label();
            this.lblTitPrecioSugerido = new System.Windows.Forms.Label();
            this.lblPrecioSugerido = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblPrecioDetalle = new System.Windows.Forms.Label();
            this.txtPrecioDetalle = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblTotalNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltros.Controls.Add(this.txtFilterCuil);
            this.grpFiltros.Controls.Add(this.lblFilterCuit);
            this.grpFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(37, 118);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4);
            this.grpFiltros.Size = new System.Drawing.Size(674, 91);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // txtFilterCuil
            // 
            this.txtFilterCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCuil.Location = new System.Drawing.Point(348, 31);
            this.txtFilterCuil.Margin = new System.Windows.Forms.Padding(4);
            this.txtFilterCuil.Name = "txtFilterCuil";
            this.txtFilterCuil.Size = new System.Drawing.Size(284, 44);
            this.txtFilterCuil.TabIndex = 0;
            // 
            // lblFilterCuit
            // 
            this.lblFilterCuit.AutoSize = true;
            this.lblFilterCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFilterCuit.Location = new System.Drawing.Point(108, 36);
            this.lblFilterCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterCuit.Name = "lblFilterCuit";
            this.lblFilterCuit.Size = new System.Drawing.Size(193, 36);
            this.lblFilterCuit.TabIndex = 2;
            this.lblFilterCuit.Text = "CUIT o CUIL:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(718, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(252, 61);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(1145, 38);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(139, 44);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.AutoSize = true;
            this.lblDatoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoNombre.Location = new System.Drawing.Point(1163, 118);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(141, 37);
            this.lblDatoNombre.TabIndex = 4;
            this.lblDatoNombre.Text = "Nombre:";
            // 
            // lblRealNombre
            // 
            this.lblRealNombre.AutoSize = true;
            this.lblRealNombre.BackColor = System.Drawing.Color.White;
            this.lblRealNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealNombre.Location = new System.Drawing.Point(1348, 118);
            this.lblRealNombre.Name = "lblRealNombre";
            this.lblRealNombre.Size = new System.Drawing.Size(179, 37);
            this.lblRealNombre.TabIndex = 5;
            this.lblRealNombre.Text = "_________";
            // 
            // lblDatoCuil
            // 
            this.lblDatoCuil.AutoSize = true;
            this.lblDatoCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoCuil.Location = new System.Drawing.Point(1096, 189);
            this.lblDatoCuil.Name = "lblDatoCuil";
            this.lblDatoCuil.Size = new System.Drawing.Size(208, 37);
            this.lblDatoCuil.TabIndex = 6;
            this.lblDatoCuil.Text = "CUIL o CUIT:";
            // 
            // lblRealCuil
            // 
            this.lblRealCuil.AutoSize = true;
            this.lblRealCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealCuil.Location = new System.Drawing.Point(1348, 189);
            this.lblRealCuil.Name = "lblRealCuil";
            this.lblRealCuil.Size = new System.Drawing.Size(179, 37);
            this.lblRealCuil.TabIndex = 7;
            this.lblRealCuil.Text = "_________";
            // 
            // lblUsuarioLoguedo
            // 
            this.lblUsuarioLoguedo.AutoSize = true;
            this.lblUsuarioLoguedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblUsuarioLoguedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLoguedo.Location = new System.Drawing.Point(60, 31);
            this.lblUsuarioLoguedo.Name = "lblUsuarioLoguedo";
            this.lblUsuarioLoguedo.Size = new System.Drawing.Size(203, 44);
            this.lblUsuarioLoguedo.TabIndex = 9;
            this.lblUsuarioLoguedo.Text = "Empleado:";
            // 
            // lblTituloSemillas
            // 
            this.lblTituloSemillas.AutoSize = true;
            this.lblTituloSemillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSemillas.Location = new System.Drawing.Point(54, 261);
            this.lblTituloSemillas.Name = "lblTituloSemillas";
            this.lblTituloSemillas.Size = new System.Drawing.Size(166, 44);
            this.lblTituloSemillas.TabIndex = 10;
            this.lblTituloSemillas.Text = "Semillas";
            // 
            // dtgDetalles
            // 
            this.dtgDetalles.AllowUserToAddRows = false;
            this.dtgDetalles.AllowUserToDeleteRows = false;
            this.dtgDetalles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_Semilla,
            this.nombre,
            this.precioVenta,
            this.cantidad,
            this.subTotal});
            this.dtgDetalles.Location = new System.Drawing.Point(132, 520);
            this.dtgDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.dtgDetalles.Name = "dtgDetalles";
            this.dtgDetalles.ReadOnly = true;
            this.dtgDetalles.RowHeadersWidth = 82;
            this.dtgDetalles.RowTemplate.Height = 33;
            this.dtgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalles.Size = new System.Drawing.Size(1356, 551);
            this.dtgDetalles.TabIndex = 11;
            // 
            // id_Semilla
            // 
            this.id_Semilla.HeaderText = "ID de Semilla";
            this.id_Semilla.MinimumWidth = 10;
            this.id_Semilla.Name = "id_Semilla";
            this.id_Semilla.ReadOnly = true;
            this.id_Semilla.Width = 120;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 10;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 120;
            // 
            // precioVenta
            // 
            this.precioVenta.HeaderText = "Precio de Venta";
            this.precioVenta.MinimumWidth = 10;
            this.precioVenta.Name = "precioVenta";
            this.precioVenta.ReadOnly = true;
            this.precioVenta.Width = 120;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MinimumWidth = 10;
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 120;
            // 
            // subTotal
            // 
            this.subTotal.HeaderText = "Subtotal";
            this.subTotal.MinimumWidth = 10;
            this.subTotal.Name = "subTotal";
            this.subTotal.ReadOnly = true;
            this.subTotal.Width = 120;
            // 
            // lblIdSemilla
            // 
            this.lblIdSemilla.AutoSize = true;
            this.lblIdSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSemilla.Location = new System.Drawing.Point(87, 338);
            this.lblIdSemilla.Name = "lblIdSemilla";
            this.lblIdSemilla.Size = new System.Drawing.Size(50, 31);
            this.lblIdSemilla.TabIndex = 12;
            this.lblIdSemilla.Text = "ID:";
            // 
            // txtIdSemilla
            // 
            this.txtIdSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSemilla.Location = new System.Drawing.Point(151, 335);
            this.txtIdSemilla.Name = "txtIdSemilla";
            this.txtIdSemilla.Size = new System.Drawing.Size(112, 38);
            this.txtIdSemilla.TabIndex = 13;
            this.txtIdSemilla.TextChanged += new System.EventHandler(this.txtIdSemilla_TextChanged);
            // 
            // lblNombreSemilla
            // 
            this.lblNombreSemilla.AutoSize = true;
            this.lblNombreSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSemilla.Location = new System.Drawing.Point(281, 338);
            this.lblNombreSemilla.Name = "lblNombreSemilla";
            this.lblNombreSemilla.Size = new System.Drawing.Size(118, 31);
            this.lblNombreSemilla.TabIndex = 14;
            this.lblNombreSemilla.Text = "Nombre:";
            // 
            // txtNombreSemilla
            // 
            this.txtNombreSemilla.Enabled = false;
            this.txtNombreSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSemilla.Location = new System.Drawing.Point(405, 338);
            this.txtNombreSemilla.Name = "txtNombreSemilla";
            this.txtNombreSemilla.Size = new System.Drawing.Size(180, 38);
            this.txtNombreSemilla.TabIndex = 15;
            // 
            // lblTipoSemilla
            // 
            this.lblTipoSemilla.AutoSize = true;
            this.lblTipoSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSemilla.Location = new System.Drawing.Point(281, 450);
            this.lblTipoSemilla.Name = "lblTipoSemilla";
            this.lblTipoSemilla.Size = new System.Drawing.Size(170, 31);
            this.lblTipoSemilla.TabIndex = 16;
            this.lblTipoSemilla.Text = "Tipo Semilla:";
            // 
            // lblCalidadSemilla
            // 
            this.lblCalidadSemilla.AutoSize = true;
            this.lblCalidadSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidadSemilla.Location = new System.Drawing.Point(281, 394);
            this.lblCalidadSemilla.Name = "lblCalidadSemilla";
            this.lblCalidadSemilla.Size = new System.Drawing.Size(114, 31);
            this.lblCalidadSemilla.TabIndex = 17;
            this.lblCalidadSemilla.Text = "Calidad:";
            // 
            // lblTitPrecioSugerido
            // 
            this.lblTitPrecioSugerido.AutoSize = true;
            this.lblTitPrecioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitPrecioSugerido.Location = new System.Drawing.Point(606, 341);
            this.lblTitPrecioSugerido.Name = "lblTitPrecioSugerido";
            this.lblTitPrecioSugerido.Size = new System.Drawing.Size(214, 31);
            this.lblTitPrecioSugerido.TabIndex = 18;
            this.lblTitPrecioSugerido.Text = "Precio Sugerido:";
            // 
            // lblPrecioSugerido
            // 
            this.lblPrecioSugerido.AutoSize = true;
            this.lblPrecioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSugerido.Location = new System.Drawing.Point(844, 341);
            this.lblPrecioSugerido.Name = "lblPrecioSugerido";
            this.lblPrecioSugerido.Size = new System.Drawing.Size(209, 31);
            this.lblPrecioSugerido.TabIndex = 19;
            this.lblPrecioSugerido.Text = "_____________";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(689, 397);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(131, 31);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(850, 394);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(180, 38);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDetalle.Location = new System.Drawing.Point(642, 450);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(178, 31);
            this.lblPrecioDetalle.TabIndex = 17;
            this.lblPrecioDetalle.Text = "Total Semilla:";
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Enabled = false;
            this.txtPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDetalle.Location = new System.Drawing.Point(850, 443);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.Size = new System.Drawing.Size(180, 38);
            this.txtPrecioDetalle.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1077, 420);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 61);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(1292, 1294);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(196, 63);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(132, 1294);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(196, 63);
            this.btnFacturar.TabIndex = 21;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1163, 1101);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(169, 37);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total: AR$";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(1196, 420);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 61);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "-";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.Location = new System.Drawing.Point(1348, 1101);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(35, 37);
            this.lblTotalNum.TabIndex = 25;
            this.lblTotalNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 1164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 31);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo de Factura:";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboTipoFactura.Location = new System.Drawing.Point(385, 1164);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(199, 39);
            this.cboTipoFactura.TabIndex = 27;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(385, 1101);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(199, 38);
            this.dtpFechaFactura.TabIndex = 28;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.Location = new System.Drawing.Point(240, 1107);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(98, 31);
            this.lblFechaFactura.TabIndex = 29;
            this.lblFechaFactura.Text = "Fecha:";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1636, 1401);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.dtpFechaFactura);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalNum);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblPrecioSugerido);
            this.Controls.Add(this.lblTitPrecioSugerido);
            this.Controls.Add(this.lblPrecioDetalle);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCalidadSemilla);
            this.Controls.Add(this.txtPrecioDetalle);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblTipoSemilla);
            this.Controls.Add(this.txtNombreSemilla);
            this.Controls.Add(this.lblNombreSemilla);
            this.Controls.Add(this.txtIdSemilla);
            this.Controls.Add(this.lblIdSemilla);
            this.Controls.Add(this.dtgDetalles);
            this.Controls.Add(this.lblTituloSemillas);
            this.Controls.Add(this.lblUsuarioLoguedo);
            this.Controls.Add(this.lblRealCuil);
            this.Controls.Add(this.lblDatoCuil);
            this.Controls.Add(this.lblRealNombre);
            this.Controls.Add(this.lblDatoNombre);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grpFiltros);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFiltros;
        private System.Windows.Forms.TextBox txtFilterCuil;
        private System.Windows.Forms.Label lblFilterCuit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblDatoNombre;
        private System.Windows.Forms.Label lblRealNombre;
        private System.Windows.Forms.Label lblDatoCuil;
        private System.Windows.Forms.Label lblRealCuil;
        private System.Windows.Forms.Label lblUsuarioLoguedo;
        private System.Windows.Forms.Label lblTituloSemillas;
        private System.Windows.Forms.DataGridView dtgDetalles;
        private System.Windows.Forms.Label lblIdSemilla;
        private System.Windows.Forms.TextBox txtIdSemilla;
        private System.Windows.Forms.Label lblNombreSemilla;
        private System.Windows.Forms.TextBox txtNombreSemilla;
        private System.Windows.Forms.Label lblTipoSemilla;
        private System.Windows.Forms.Label lblCalidadSemilla;
        private System.Windows.Forms.Label lblTitPrecioSugerido;
        private System.Windows.Forms.Label lblPrecioSugerido;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblPrecioDetalle;
        private System.Windows.Forms.TextBox txtPrecioDetalle;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblTotalNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_Semilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.Label lblFechaFactura;
    }
}