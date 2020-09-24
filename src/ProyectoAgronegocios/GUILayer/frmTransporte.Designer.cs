namespace ProyectoAgronegocios.GUILayer
{
    partial class frmTransporte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransporte = new System.Windows.Forms.TextBox();
            this.btnConsultarTransporte = new System.Windows.Forms.Button();
            this.dtgTransporte = new System.Windows.Forms.DataGridView();
            this.IdEmpresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevoTransp = new System.Windows.Forms.Button();
            this.btnModificarTransp = new System.Windows.Forms.Button();
            this.btnEliminarTransp = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panelTransporte = new System.Windows.Forms.Panel();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinalizarTransp = new System.Windows.Forms.Button();
            this.btnLimpiarTransp = new System.Windows.Forms.Button();
            this.btnAceptarTransp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnActualizarGrilla = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransporte)).BeginInit();
            this.panelTransporte.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empresa de Transporte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Razon Social:";
            // 
            // txtTransporte
            // 
            this.txtTransporte.Location = new System.Drawing.Point(154, 86);
            this.txtTransporte.Name = "txtTransporte";
            this.txtTransporte.Size = new System.Drawing.Size(144, 20);
            this.txtTransporte.TabIndex = 2;
            this.txtTransporte.TextChanged += new System.EventHandler(this.txtTransporte_TextChanged);
            // 
            // btnConsultarTransporte
            // 
            this.btnConsultarTransporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnConsultarTransporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarTransporte.ForeColor = System.Drawing.Color.White;
            this.btnConsultarTransporte.Location = new System.Drawing.Point(316, 82);
            this.btnConsultarTransporte.Name = "btnConsultarTransporte";
            this.btnConsultarTransporte.Size = new System.Drawing.Size(82, 26);
            this.btnConsultarTransporte.TabIndex = 3;
            this.btnConsultarTransporte.Text = "Consultar";
            this.btnConsultarTransporte.UseVisualStyleBackColor = false;
            this.btnConsultarTransporte.Click += new System.EventHandler(this.btnConsultarTranporte_Click);
            // 
            // dtgTransporte
            // 
            this.dtgTransporte.AllowUserToAddRows = false;
            this.dtgTransporte.AllowUserToDeleteRows = false;
            this.dtgTransporte.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dtgTransporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTransporte.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmpresa,
            this.Descripcion,
            this.RazonSocial,
            this.Telefono,
            this.Direccion,
            this.Barrio});
            this.dtgTransporte.Location = new System.Drawing.Point(13, 127);
            this.dtgTransporte.Name = "dtgTransporte";
            this.dtgTransporte.ReadOnly = true;
            this.dtgTransporte.Size = new System.Drawing.Size(596, 326);
            this.dtgTransporte.TabIndex = 4;
            // 
            // IdEmpresa
            // 
            this.IdEmpresa.HeaderText = "Id ";
            this.IdEmpresa.Name = "IdEmpresa";
            this.IdEmpresa.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.HeaderText = "Razon Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            this.Barrio.ReadOnly = true;
            // 
            // btnNuevoTransp
            // 
            this.btnNuevoTransp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNuevoTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoTransp.ForeColor = System.Drawing.Color.White;
            this.btnNuevoTransp.Location = new System.Drawing.Point(15, 497);
            this.btnNuevoTransp.Name = "btnNuevoTransp";
            this.btnNuevoTransp.Size = new System.Drawing.Size(106, 33);
            this.btnNuevoTransp.TabIndex = 5;
            this.btnNuevoTransp.Text = "Nuevo";
            this.btnNuevoTransp.UseVisualStyleBackColor = false;
            this.btnNuevoTransp.Click += new System.EventHandler(this.btnNuevoTransp_Click);
            // 
            // btnModificarTransp
            // 
            this.btnModificarTransp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnModificarTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTransp.ForeColor = System.Drawing.Color.White;
            this.btnModificarTransp.Location = new System.Drawing.Point(127, 497);
            this.btnModificarTransp.Name = "btnModificarTransp";
            this.btnModificarTransp.Size = new System.Drawing.Size(100, 33);
            this.btnModificarTransp.TabIndex = 5;
            this.btnModificarTransp.Text = "Modificar";
            this.btnModificarTransp.UseVisualStyleBackColor = false;
            this.btnModificarTransp.Click += new System.EventHandler(this.btnModificarTransp_Click);
            // 
            // btnEliminarTransp
            // 
            this.btnEliminarTransp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEliminarTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTransp.ForeColor = System.Drawing.Color.White;
            this.btnEliminarTransp.Location = new System.Drawing.Point(244, 497);
            this.btnEliminarTransp.Name = "btnEliminarTransp";
            this.btnEliminarTransp.Size = new System.Drawing.Size(97, 33);
            this.btnEliminarTransp.TabIndex = 5;
            this.btnEliminarTransp.Text = "Eliminar";
            this.btnEliminarTransp.UseVisualStyleBackColor = false;
            this.btnEliminarTransp.Click += new System.EventHandler(this.btnEliminarTransp_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(943, 497);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(84, 33);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelTransporte
            // 
            this.panelTransporte.BackColor = System.Drawing.Color.Transparent;
            this.panelTransporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTransporte.Controls.Add(this.cmbBarrio);
            this.panelTransporte.Controls.Add(this.label3);
            this.panelTransporte.Controls.Add(this.btnFinalizarTransp);
            this.panelTransporte.Controls.Add(this.btnLimpiarTransp);
            this.panelTransporte.Controls.Add(this.btnAceptarTransp);
            this.panelTransporte.Controls.Add(this.label7);
            this.panelTransporte.Controls.Add(this.label6);
            this.panelTransporte.Controls.Add(this.label5);
            this.panelTransporte.Controls.Add(this.label4);
            this.panelTransporte.Controls.Add(this.label2);
            this.panelTransporte.Controls.Add(this.txtDescripcion);
            this.panelTransporte.Controls.Add(this.txtTelefono);
            this.panelTransporte.Controls.Add(this.txtDireccion);
            this.panelTransporte.Controls.Add(this.txtRazonSocial);
            this.panelTransporte.Location = new System.Drawing.Point(627, 70);
            this.panelTransporte.Name = "panelTransporte";
            this.panelTransporte.Size = new System.Drawing.Size(400, 383);
            this.panelTransporte.TabIndex = 6;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(146, 245);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(146, 21);
            this.cmbBarrio.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(68, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Empresa de Transporte";
            // 
            // btnFinalizarTransp
            // 
            this.btnFinalizarTransp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFinalizarTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarTransp.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarTransp.Location = new System.Drawing.Point(242, 331);
            this.btnFinalizarTransp.Name = "btnFinalizarTransp";
            this.btnFinalizarTransp.Size = new System.Drawing.Size(84, 37);
            this.btnFinalizarTransp.TabIndex = 5;
            this.btnFinalizarTransp.Text = "Finalizar";
            this.btnFinalizarTransp.UseVisualStyleBackColor = false;
            this.btnFinalizarTransp.Click += new System.EventHandler(this.btnFinalizarTransp_Click);
            // 
            // btnLimpiarTransp
            // 
            this.btnLimpiarTransp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLimpiarTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarTransp.ForeColor = System.Drawing.Color.White;
            this.btnLimpiarTransp.Location = new System.Drawing.Point(134, 331);
            this.btnLimpiarTransp.Name = "btnLimpiarTransp";
            this.btnLimpiarTransp.Size = new System.Drawing.Size(84, 37);
            this.btnLimpiarTransp.TabIndex = 5;
            this.btnLimpiarTransp.Text = "Limpiar";
            this.btnLimpiarTransp.UseVisualStyleBackColor = false;
            this.btnLimpiarTransp.Click += new System.EventHandler(this.btnLimpiarTransp_Click);
            // 
            // btnAceptarTransp
            // 
            this.btnAceptarTransp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAceptarTransp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptarTransp.ForeColor = System.Drawing.Color.White;
            this.btnAceptarTransp.Location = new System.Drawing.Point(31, 331);
            this.btnAceptarTransp.Name = "btnAceptarTransp";
            this.btnAceptarTransp.Size = new System.Drawing.Size(84, 37);
            this.btnAceptarTransp.TabIndex = 5;
            this.btnAceptarTransp.Text = "Aceptar";
            this.btnAceptarTransp.UseVisualStyleBackColor = false;
            this.btnAceptarTransp.Click += new System.EventHandler(this.btnAceptarTransp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Barrio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Direccion:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(146, 77);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(146, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(146, 161);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(146, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(146, 203);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(146, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(146, 121);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(146, 20);
            this.txtRazonSocial.TabIndex = 2;
            // 
            // btnActualizarGrilla
            // 
            this.btnActualizarGrilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnActualizarGrilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarGrilla.ForeColor = System.Drawing.Color.White;
            this.btnActualizarGrilla.Location = new System.Drawing.Point(525, 459);
            this.btnActualizarGrilla.Name = "btnActualizarGrilla";
            this.btnActualizarGrilla.Size = new System.Drawing.Size(84, 28);
            this.btnActualizarGrilla.TabIndex = 5;
            this.btnActualizarGrilla.Text = "Actualizar";
            this.btnActualizarGrilla.UseVisualStyleBackColor = false;
            this.btnActualizarGrilla.Click += new System.EventHandler(this.btnActualizarGrilla_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Buscar Transporte:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(169, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ingrese Razon Social ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // frmTransporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAgronegocios.Properties.Resources.ago18s0104_camion_semillas_campo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1039, 553);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panelTransporte);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizarGrilla);
            this.Controls.Add(this.btnEliminarTransp);
            this.Controls.Add(this.btnModificarTransp);
            this.Controls.Add(this.btnNuevoTransp);
            this.Controls.Add(this.dtgTransporte);
            this.Controls.Add(this.btnConsultarTransporte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTransporte);
            this.Controls.Add(this.label1);
            this.Name = "frmTransporte";
            this.Text = "Transporte";
            this.Load += new System.EventHandler(this.Transporte_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgTransporte)).EndInit();
            this.panelTransporte.ResumeLayout(false);
            this.panelTransporte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransporte;
        private System.Windows.Forms.Button btnConsultarTransporte;
        private System.Windows.Forms.DataGridView dtgTransporte;
        private System.Windows.Forms.Button btnNuevoTransp;
        private System.Windows.Forms.Button btnModificarTransp;
        private System.Windows.Forms.Button btnEliminarTransp;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panelTransporte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinalizarTransp;
        private System.Windows.Forms.Button btnLimpiarTransp;
        private System.Windows.Forms.Button btnAceptarTransp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizarGrilla;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
    }
}