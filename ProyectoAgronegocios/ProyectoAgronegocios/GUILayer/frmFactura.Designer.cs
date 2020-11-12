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
            this.cboFormaPago1 = new System.Windows.Forms.ComboBox();
            this.lblFormaPago1 = new System.Windows.Forms.Label();
            this.btnAgregarFP1 = new System.Windows.Forms.Button();
            this.dtgFormasPago = new System.Windows.Forms.DataGridView();
            this.id_FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreFP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dias_plazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbFormasPago = new System.Windows.Forms.GroupBox();
            this.nudDias1 = new System.Windows.Forms.NumericUpDown();
            this.btnQuitarFP = new System.Windows.Forms.Button();
            this.lblMontoFP = new System.Windows.Forms.Label();
            this.txtMontoFP1 = new System.Windows.Forms.TextBox();
            this.totBotonEliminarFP = new System.Windows.Forms.ToolTip(this.components);
            this.grpFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormasPago)).BeginInit();
            this.grbFormasPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFiltros
            // 
            this.grpFiltros.BackColor = System.Drawing.Color.Transparent;
            this.grpFiltros.Controls.Add(this.txtFilterCuil);
            this.grpFiltros.Controls.Add(this.lblFilterCuit);
            this.grpFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFiltros.Location = new System.Drawing.Point(36, 117);
            this.grpFiltros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltros.Name = "grpFiltros";
            this.grpFiltros.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpFiltros.Size = new System.Drawing.Size(674, 90);
            this.grpFiltros.TabIndex = 1;
            this.grpFiltros.TabStop = false;
            this.grpFiltros.Text = "Filtros";
            // 
            // txtFilterCuil
            // 
            this.txtFilterCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterCuil.Location = new System.Drawing.Point(348, 31);
            this.txtFilterCuil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFilterCuil.Name = "txtFilterCuil";
            this.txtFilterCuil.Size = new System.Drawing.Size(284, 44);
            this.txtFilterCuil.TabIndex = 0;
            // 
            // lblFilterCuit
            // 
            this.lblFilterCuit.AutoSize = true;
            this.lblFilterCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilterCuit.Location = new System.Drawing.Point(108, 37);
            this.lblFilterCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFilterCuit.Name = "lblFilterCuit";
            this.lblFilterCuit.Size = new System.Drawing.Size(208, 37);
            this.lblFilterCuit.TabIndex = 2;
            this.lblFilterCuit.Text = "CUIT o CUIL:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(718, 140);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(252, 62);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Black;
            this.lblCliente.Location = new System.Drawing.Point(1176, 31);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(139, 44);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // lblDatoNombre
            // 
            this.lblDatoNombre.AutoSize = true;
            this.lblDatoNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDatoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoNombre.ForeColor = System.Drawing.Color.White;
            this.lblDatoNombre.Location = new System.Drawing.Point(1164, 117);
            this.lblDatoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatoNombre.Name = "lblDatoNombre";
            this.lblDatoNombre.Size = new System.Drawing.Size(151, 39);
            this.lblDatoNombre.TabIndex = 4;
            this.lblDatoNombre.Text = "Nombre:";
            // 
            // lblRealNombre
            // 
            this.lblRealNombre.AutoSize = true;
            this.lblRealNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRealNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealNombre.ForeColor = System.Drawing.Color.White;
            this.lblRealNombre.Location = new System.Drawing.Point(1348, 117);
            this.lblRealNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealNombre.Name = "lblRealNombre";
            this.lblRealNombre.Size = new System.Drawing.Size(188, 39);
            this.lblRealNombre.TabIndex = 5;
            this.lblRealNombre.Text = "_________";
            // 
            // lblDatoCuil
            // 
            this.lblDatoCuil.AutoSize = true;
            this.lblDatoCuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDatoCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatoCuil.ForeColor = System.Drawing.Color.White;
            this.lblDatoCuil.Location = new System.Drawing.Point(1096, 188);
            this.lblDatoCuil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatoCuil.Name = "lblDatoCuil";
            this.lblDatoCuil.Size = new System.Drawing.Size(222, 39);
            this.lblDatoCuil.TabIndex = 6;
            this.lblDatoCuil.Text = "CUIL o CUIT:";
            // 
            // lblRealCuil
            // 
            this.lblRealCuil.AutoSize = true;
            this.lblRealCuil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblRealCuil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRealCuil.ForeColor = System.Drawing.Color.White;
            this.lblRealCuil.Location = new System.Drawing.Point(1348, 188);
            this.lblRealCuil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRealCuil.Name = "lblRealCuil";
            this.lblRealCuil.Size = new System.Drawing.Size(188, 39);
            this.lblRealCuil.TabIndex = 7;
            this.lblRealCuil.Text = "_________";
            // 
            // lblUsuarioLoguedo
            // 
            this.lblUsuarioLoguedo.AutoSize = true;
            this.lblUsuarioLoguedo.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarioLoguedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLoguedo.ForeColor = System.Drawing.Color.Black;
            this.lblUsuarioLoguedo.Location = new System.Drawing.Point(60, 31);
            this.lblUsuarioLoguedo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioLoguedo.Name = "lblUsuarioLoguedo";
            this.lblUsuarioLoguedo.Size = new System.Drawing.Size(203, 44);
            this.lblUsuarioLoguedo.TabIndex = 9;
            this.lblUsuarioLoguedo.Text = "Empleado:";
            // 
            // lblTituloSemillas
            // 
            this.lblTituloSemillas.AutoSize = true;
            this.lblTituloSemillas.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloSemillas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloSemillas.Location = new System.Drawing.Point(36, 217);
            this.lblTituloSemillas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.dtgDetalles.Location = new System.Drawing.Point(36, 465);
            this.dtgDetalles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgDetalles.Name = "dtgDetalles";
            this.dtgDetalles.ReadOnly = true;
            this.dtgDetalles.RowHeadersWidth = 82;
            this.dtgDetalles.RowTemplate.Height = 33;
            this.dtgDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDetalles.Size = new System.Drawing.Size(1588, 552);
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
            this.lblIdSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblIdSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdSemilla.ForeColor = System.Drawing.Color.White;
            this.lblIdSemilla.Location = new System.Drawing.Point(36, 281);
            this.lblIdSemilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdSemilla.Name = "lblIdSemilla";
            this.lblIdSemilla.Size = new System.Drawing.Size(57, 37);
            this.lblIdSemilla.TabIndex = 12;
            this.lblIdSemilla.Text = "ID:";
            // 
            // txtIdSemilla
            // 
            this.txtIdSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdSemilla.Location = new System.Drawing.Point(116, 277);
            this.txtIdSemilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdSemilla.Name = "txtIdSemilla";
            this.txtIdSemilla.Size = new System.Drawing.Size(112, 44);
            this.txtIdSemilla.TabIndex = 13;
            this.txtIdSemilla.TextChanged += new System.EventHandler(this.txtIdSemilla_TextChanged);
            // 
            // lblNombreSemilla
            // 
            this.lblNombreSemilla.AutoSize = true;
            this.lblNombreSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNombreSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreSemilla.ForeColor = System.Drawing.Color.White;
            this.lblNombreSemilla.Location = new System.Drawing.Point(248, 277);
            this.lblNombreSemilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreSemilla.Name = "lblNombreSemilla";
            this.lblNombreSemilla.Size = new System.Drawing.Size(141, 37);
            this.lblNombreSemilla.TabIndex = 14;
            this.lblNombreSemilla.Text = "Nombre:";
            // 
            // txtNombreSemilla
            // 
            this.txtNombreSemilla.Enabled = false;
            this.txtNombreSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreSemilla.Location = new System.Drawing.Point(408, 277);
            this.txtNombreSemilla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreSemilla.Name = "txtNombreSemilla";
            this.txtNombreSemilla.Size = new System.Drawing.Size(180, 44);
            this.txtNombreSemilla.TabIndex = 15;
            // 
            // lblTipoSemilla
            // 
            this.lblTipoSemilla.AutoSize = true;
            this.lblTipoSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTipoSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoSemilla.ForeColor = System.Drawing.Color.White;
            this.lblTipoSemilla.Location = new System.Drawing.Point(180, 385);
            this.lblTipoSemilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoSemilla.Name = "lblTipoSemilla";
            this.lblTipoSemilla.Size = new System.Drawing.Size(202, 37);
            this.lblTipoSemilla.TabIndex = 16;
            this.lblTipoSemilla.Text = "Tipo Semilla:";
            // 
            // lblCalidadSemilla
            // 
            this.lblCalidadSemilla.AutoSize = true;
            this.lblCalidadSemilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCalidadSemilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalidadSemilla.ForeColor = System.Drawing.Color.White;
            this.lblCalidadSemilla.Location = new System.Drawing.Point(248, 331);
            this.lblCalidadSemilla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalidadSemilla.Name = "lblCalidadSemilla";
            this.lblCalidadSemilla.Size = new System.Drawing.Size(135, 37);
            this.lblCalidadSemilla.TabIndex = 17;
            this.lblCalidadSemilla.Text = "Calidad:";
            // 
            // lblTitPrecioSugerido
            // 
            this.lblTitPrecioSugerido.AutoSize = true;
            this.lblTitPrecioSugerido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTitPrecioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitPrecioSugerido.ForeColor = System.Drawing.Color.White;
            this.lblTitPrecioSugerido.Location = new System.Drawing.Point(610, 281);
            this.lblTitPrecioSugerido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitPrecioSugerido.Name = "lblTitPrecioSugerido";
            this.lblTitPrecioSugerido.Size = new System.Drawing.Size(253, 37);
            this.lblTitPrecioSugerido.TabIndex = 18;
            this.lblTitPrecioSugerido.Text = "Precio Sugerido:";
            // 
            // lblPrecioSugerido
            // 
            this.lblPrecioSugerido.AutoSize = true;
            this.lblPrecioSugerido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrecioSugerido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioSugerido.ForeColor = System.Drawing.Color.White;
            this.lblPrecioSugerido.Location = new System.Drawing.Point(896, 277);
            this.lblPrecioSugerido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioSugerido.Name = "lblPrecioSugerido";
            this.lblPrecioSugerido.Size = new System.Drawing.Size(251, 37);
            this.lblPrecioSugerido.TabIndex = 19;
            this.lblPrecioSugerido.Text = "_____________";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.White;
            this.lblCantidad.Location = new System.Drawing.Point(708, 331);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(155, 37);
            this.lblCantidad.TabIndex = 17;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(898, 323);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(180, 44);
            this.txtCantidad.TabIndex = 15;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // lblPrecioDetalle
            // 
            this.lblPrecioDetalle.AutoSize = true;
            this.lblPrecioDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDetalle.ForeColor = System.Drawing.Color.White;
            this.lblPrecioDetalle.Location = new System.Drawing.Point(652, 385);
            this.lblPrecioDetalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioDetalle.Name = "lblPrecioDetalle";
            this.lblPrecioDetalle.Size = new System.Drawing.Size(211, 37);
            this.lblPrecioDetalle.TabIndex = 17;
            this.lblPrecioDetalle.Text = "Total Semilla:";
            // 
            // txtPrecioDetalle
            // 
            this.txtPrecioDetalle.Enabled = false;
            this.txtPrecioDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioDetalle.Location = new System.Drawing.Point(898, 385);
            this.txtPrecioDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrecioDetalle.Name = "txtPrecioDetalle";
            this.txtPrecioDetalle.Size = new System.Drawing.Size(180, 44);
            this.txtPrecioDetalle.TabIndex = 15;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(1152, 373);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 62);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "+";
            this.btnAgregar.UseVisualStyleBackColor = false;
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
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(1368, 1462);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(196, 63);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFacturar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(1152, 1462);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(196, 63);
            this.btnFacturar.TabIndex = 21;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(1226, 1069);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(169, 37);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "Total: AR$";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(1260, 373);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 62);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "-";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblTotalNum
            // 
            this.lblTotalNum.AutoSize = true;
            this.lblTotalNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblTotalNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalNum.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotalNum.Location = new System.Drawing.Point(1428, 1069);
            this.lblTotalNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalNum.Name = "lblTotalNum";
            this.lblTotalNum.Size = new System.Drawing.Size(35, 37);
            this.lblTotalNum.TabIndex = 25;
            this.lblTotalNum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1144, 1183);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 37);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tipo de Factura:";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboTipoFactura.Location = new System.Drawing.Point(1424, 1183);
            this.cboTipoFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(200, 45);
            this.cboTipoFactura.TabIndex = 27;
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFactura.Location = new System.Drawing.Point(1424, 1117);
            this.dtpFechaFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(200, 44);
            this.dtpFechaFactura.TabIndex = 28;
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.ForeColor = System.Drawing.Color.White;
            this.lblFechaFactura.Location = new System.Drawing.Point(1280, 1127);
            this.lblFechaFactura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(115, 37);
            this.lblFechaFactura.TabIndex = 29;
            this.lblFechaFactura.Text = "Fecha:";
            // 
            // cboFormaPago1
            // 
            this.cboFormaPago1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormaPago1.FormattingEnabled = true;
            this.cboFormaPago1.Location = new System.Drawing.Point(296, 79);
            this.cboFormaPago1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboFormaPago1.Name = "cboFormaPago1";
            this.cboFormaPago1.Size = new System.Drawing.Size(200, 45);
            this.cboFormaPago1.TabIndex = 30;
            this.cboFormaPago1.SelectedIndexChanged += new System.EventHandler(this.cboFormaPago1_SelectedIndexChanged);
            // 
            // lblFormaPago1
            // 
            this.lblFormaPago1.AutoSize = true;
            this.lblFormaPago1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFormaPago1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormaPago1.ForeColor = System.Drawing.Color.White;
            this.lblFormaPago1.Location = new System.Drawing.Point(24, 79);
            this.lblFormaPago1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormaPago1.Name = "lblFormaPago1";
            this.lblFormaPago1.Size = new System.Drawing.Size(248, 37);
            this.lblFormaPago1.TabIndex = 26;
            this.lblFormaPago1.Text = "Forma de Pago:";
            // 
            // btnAgregarFP1
            // 
            this.btnAgregarFP1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAgregarFP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarFP1.ForeColor = System.Drawing.Color.White;
            this.btnAgregarFP1.Location = new System.Drawing.Point(876, 81);
            this.btnAgregarFP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarFP1.Name = "btnAgregarFP1";
            this.btnAgregarFP1.Size = new System.Drawing.Size(140, 52);
            this.btnAgregarFP1.TabIndex = 31;
            this.btnAgregarFP1.Text = "+";
            this.btnAgregarFP1.UseVisualStyleBackColor = false;
            this.btnAgregarFP1.Click += new System.EventHandler(this.btnAgregarFP1_Click);
            // 
            // dtgFormasPago
            // 
            this.dtgFormasPago.AllowUserToAddRows = false;
            this.dtgFormasPago.AllowUserToDeleteRows = false;
            this.dtgFormasPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFormasPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_FormaPago,
            this.nombreFP,
            this.monto,
            this.dias_plazo});
            this.dtgFormasPago.Location = new System.Drawing.Point(32, 142);
            this.dtgFormasPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgFormasPago.Name = "dtgFormasPago";
            this.dtgFormasPago.ReadOnly = true;
            this.dtgFormasPago.RowHeadersWidth = 50;
            this.dtgFormasPago.RowTemplate.Height = 33;
            this.dtgFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFormasPago.Size = new System.Drawing.Size(816, 315);
            this.dtgFormasPago.TabIndex = 33;
            // 
            // id_FormaPago
            // 
            this.id_FormaPago.HeaderText = "ID";
            this.id_FormaPago.MinimumWidth = 10;
            this.id_FormaPago.Name = "id_FormaPago";
            this.id_FormaPago.ReadOnly = true;
            this.id_FormaPago.Width = 70;
            // 
            // nombreFP
            // 
            this.nombreFP.HeaderText = "Nombre";
            this.nombreFP.MinimumWidth = 10;
            this.nombreFP.Name = "nombreFP";
            this.nombreFP.ReadOnly = true;
            this.nombreFP.Width = 200;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 10;
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 200;
            // 
            // dias_plazo
            // 
            this.dias_plazo.HeaderText = "Dias de Plazo";
            this.dias_plazo.MinimumWidth = 10;
            this.dias_plazo.Name = "dias_plazo";
            this.dias_plazo.ReadOnly = true;
            this.dias_plazo.Width = 200;
            // 
            // grbFormasPago
            // 
            this.grbFormasPago.BackColor = System.Drawing.Color.Transparent;
            this.grbFormasPago.Controls.Add(this.nudDias1);
            this.grbFormasPago.Controls.Add(this.btnQuitarFP);
            this.grbFormasPago.Controls.Add(this.lblMontoFP);
            this.grbFormasPago.Controls.Add(this.txtMontoFP1);
            this.grbFormasPago.Controls.Add(this.cboFormaPago1);
            this.grbFormasPago.Controls.Add(this.dtgFormasPago);
            this.grbFormasPago.Controls.Add(this.btnAgregarFP1);
            this.grbFormasPago.Controls.Add(this.lblFormaPago1);
            this.grbFormasPago.Enabled = false;
            this.grbFormasPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbFormasPago.Location = new System.Drawing.Point(68, 1040);
            this.grbFormasPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFormasPago.Name = "grbFormasPago";
            this.grbFormasPago.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbFormasPago.Size = new System.Drawing.Size(1040, 485);
            this.grbFormasPago.TabIndex = 34;
            this.grbFormasPago.TabStop = false;
            this.grbFormasPago.Text = "Formas de Pago";
            // 
            // nudDias1
            // 
            this.nudDias1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDias1.Location = new System.Drawing.Point(728, 79);
            this.nudDias1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDias1.Name = "nudDias1";
            this.nudDias1.Size = new System.Drawing.Size(120, 44);
            this.nudDias1.TabIndex = 37;
            // 
            // btnQuitarFP
            // 
            this.btnQuitarFP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnQuitarFP.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitarFP.ForeColor = System.Drawing.Color.White;
            this.btnQuitarFP.Location = new System.Drawing.Point(876, 206);
            this.btnQuitarFP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitarFP.Name = "btnQuitarFP";
            this.btnQuitarFP.Size = new System.Drawing.Size(140, 52);
            this.btnQuitarFP.TabIndex = 36;
            this.btnQuitarFP.Text = "X";
            this.totBotonEliminarFP.SetToolTip(this.btnQuitarFP, "Elimina todas las formas de pago\r\n");
            this.btnQuitarFP.UseVisualStyleBackColor = false;
            this.btnQuitarFP.Click += new System.EventHandler(this.btnQuitarFP_Click);
            // 
            // lblMontoFP
            // 
            this.lblMontoFP.AutoSize = true;
            this.lblMontoFP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoFP.Location = new System.Drawing.Point(560, 35);
            this.lblMontoFP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontoFP.Name = "lblMontoFP";
            this.lblMontoFP.Size = new System.Drawing.Size(89, 31);
            this.lblMontoFP.TabIndex = 35;
            this.lblMontoFP.Text = "Monto";
            // 
            // txtMontoFP1
            // 
            this.txtMontoFP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoFP1.Location = new System.Drawing.Point(516, 81);
            this.txtMontoFP1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMontoFP1.Name = "txtMontoFP1";
            this.txtMontoFP1.Size = new System.Drawing.Size(188, 44);
            this.txtMontoFP1.TabIndex = 34;
            // 
            // totBotonEliminarFP
            // 
            this.totBotonEliminarFP.ToolTipTitle = "Eliminar formas de Pago";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProyectoAgronegocios.Properties.Resources.factura;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1660, 1554);
            this.Controls.Add(this.grbFormasPago);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturar";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.grpFiltros.ResumeLayout(false);
            this.grpFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFormasPago)).EndInit();
            this.grbFormasPago.ResumeLayout(false);
            this.grbFormasPago.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDias1)).EndInit();
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
        private System.Windows.Forms.ComboBox cboFormaPago1;
        private System.Windows.Forms.Label lblFormaPago1;
        private System.Windows.Forms.Button btnAgregarFP1;
        private System.Windows.Forms.DataGridView dtgFormasPago;
        private System.Windows.Forms.GroupBox grbFormasPago;
        private System.Windows.Forms.Button btnQuitarFP;
        private System.Windows.Forms.Label lblMontoFP;
        private System.Windows.Forms.TextBox txtMontoFP1;
        private System.Windows.Forms.NumericUpDown nudDias1;
        private System.Windows.Forms.ToolTip totBotonEliminarFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreFP;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dias_plazo;
    }
}