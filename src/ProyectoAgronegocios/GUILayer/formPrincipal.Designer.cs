namespace ProyectoAgronegocios
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.semillasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeFacturasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEnviosPorProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeVentasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeEnviosPorEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadísticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topVentasEnCantidadPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topVentasEnPreciosPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.porcentajeDeVentasPorProvinciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeVentasPorEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cantidadDeSemillasMasVendidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.soporteToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.estadísticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSistemaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSistemaToolStripMenuItem
            // 
            this.cerrarSistemaToolStripMenuItem.Name = "cerrarSistemaToolStripMenuItem";
            this.cerrarSistemaToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cerrarSistemaToolStripMenuItem.Text = "Cerrar Sistema";
            this.cerrarSistemaToolStripMenuItem.Click += new System.EventHandler(this.cerrarSistemaToolStripMenuItem_Click);
            // 
            // soporteToolStripMenuItem
            // 
            this.soporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.transportesToolStripMenuItem,
            this.semillasToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.soporteToolStripMenuItem.Name = "soporteToolStripMenuItem";
            this.soporteToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.soporteToolStripMenuItem.Text = "Soporte";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // transportesToolStripMenuItem
            // 
            this.transportesToolStripMenuItem.Name = "transportesToolStripMenuItem";
            this.transportesToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.transportesToolStripMenuItem.Text = "Transportes ";
            this.transportesToolStripMenuItem.Click += new System.EventHandler(this.transportesToolStripMenuItem_Click);
            // 
            // semillasToolStripMenuItem
            // 
            this.semillasToolStripMenuItem.Name = "semillasToolStripMenuItem";
            this.semillasToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.semillasToolStripMenuItem.Text = "Semillas";
            this.semillasToolStripMenuItem.Click += new System.EventHandler(this.semillasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.asignarEnvioToolStripMenuItem});
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.facturarToolStripMenuItem.Text = "Facturar";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // asignarEnvioToolStripMenuItem
            // 
            this.asignarEnvioToolStripMenuItem.Name = "asignarEnvioToolStripMenuItem";
            this.asignarEnvioToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.asignarEnvioToolStripMenuItem.Text = "Asignar Envio";
            this.asignarEnvioToolStripMenuItem.Click += new System.EventHandler(this.asignarEnvioToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeFacturasPorClienteToolStripMenuItem,
            this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem,
            this.reporteDeEnviosPorProvinciaToolStripMenuItem,
            this.reporteDeVentasPorEmpleadoToolStripMenuItem,
            this.reporteDeEnviosPorEmpresaToolStripMenuItem,
            this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeFacturasPorClienteToolStripMenuItem
            // 
            this.reporteDeFacturasPorClienteToolStripMenuItem.Name = "reporteDeFacturasPorClienteToolStripMenuItem";
            this.reporteDeFacturasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.reporteDeFacturasPorClienteToolStripMenuItem.Text = "Reporte de Facturas por Cliente";
            this.reporteDeFacturasPorClienteToolStripMenuItem.Click += new System.EventHandler(this.reporteDeFacturasPorClienteToolStripMenuItem_Click);
            // 
            // cantidadDeSemillasCompradasPorClienteToolStripMenuItem
            // 
            this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem.Name = "cantidadDeSemillasCompradasPorClienteToolStripMenuItem";
            this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem.Text = "Reporte de Semillas por Cliente";
            this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeSemillasCompradasPorClienteToolStripMenuItem_Click);
            // 
            // reporteDeEnviosPorProvinciaToolStripMenuItem
            // 
            this.reporteDeEnviosPorProvinciaToolStripMenuItem.Name = "reporteDeEnviosPorProvinciaToolStripMenuItem";
            this.reporteDeEnviosPorProvinciaToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.reporteDeEnviosPorProvinciaToolStripMenuItem.Text = "Reporte de Envios por Provincia";
            this.reporteDeEnviosPorProvinciaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEnviosPorProvinciaToolStripMenuItem_Click);
            // 
            // reporteDeVentasPorEmpleadoToolStripMenuItem
            // 
            this.reporteDeVentasPorEmpleadoToolStripMenuItem.Name = "reporteDeVentasPorEmpleadoToolStripMenuItem";
            this.reporteDeVentasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.reporteDeVentasPorEmpleadoToolStripMenuItem.Text = "Reporte de Ventas por Empleado";
            this.reporteDeVentasPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.reporteDeVentasPorEmpleadoToolStripMenuItem_Click);
            // 
            // reporteDeEnviosPorEmpresaToolStripMenuItem
            // 
            this.reporteDeEnviosPorEmpresaToolStripMenuItem.Name = "reporteDeEnviosPorEmpresaToolStripMenuItem";
            this.reporteDeEnviosPorEmpresaToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.reporteDeEnviosPorEmpresaToolStripMenuItem.Text = "Reporte de Envios por Empresa";
            this.reporteDeEnviosPorEmpresaToolStripMenuItem.Click += new System.EventHandler(this.reporteDeEnviosPorEmpresaToolStripMenuItem_Click);
            // 
            // reporteDeAntigüedadDeEmpleadosToolStripMenuItem
            // 
            this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem.Name = "reporteDeAntigüedadDeEmpleadosToolStripMenuItem";
            this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem.Text = "Reporte de Antigüedad de Empleados";
            this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeAntigüedadDeEmpleadosToolStripMenuItem_Click);
            // 
            // estadísticasToolStripMenuItem
            // 
            this.estadísticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topVentasEnCantidadPorClienteToolStripMenuItem,
            this.topVentasEnPreciosPorClienteToolStripMenuItem,
            this.porcentajeDeVentasPorProvinciaToolStripMenuItem,
            this.cantidadDeVentasPorEmpleadoToolStripMenuItem,
            this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem,
            this.cantidadDeSemillasMasVendidasToolStripMenuItem});
            this.estadísticasToolStripMenuItem.Name = "estadísticasToolStripMenuItem";
            this.estadísticasToolStripMenuItem.Size = new System.Drawing.Size(79, 22);
            this.estadísticasToolStripMenuItem.Text = "Estadísticas";
            // 
            // topVentasEnCantidadPorClienteToolStripMenuItem
            // 
            this.topVentasEnCantidadPorClienteToolStripMenuItem.Name = "topVentasEnCantidadPorClienteToolStripMenuItem";
            this.topVentasEnCantidadPorClienteToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.topVentasEnCantidadPorClienteToolStripMenuItem.Text = "Top Ventas en Cantidad por Cliente";
            this.topVentasEnCantidadPorClienteToolStripMenuItem.Click += new System.EventHandler(this.topVentasEnCantidadPorClienteToolStripMenuItem_Click);
            // 
            // topVentasEnPreciosPorClienteToolStripMenuItem
            // 
            this.topVentasEnPreciosPorClienteToolStripMenuItem.Name = "topVentasEnPreciosPorClienteToolStripMenuItem";
            this.topVentasEnPreciosPorClienteToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.topVentasEnPreciosPorClienteToolStripMenuItem.Text = "Top Ventas en Precios por Cliente";
            this.topVentasEnPreciosPorClienteToolStripMenuItem.Click += new System.EventHandler(this.topVentasEnPreciosPorClienteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(271, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "AGRONEGOCIOS";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(0, 24);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(842, 38);
            this.lblBienvenida.TabIndex = 3;
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(217, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 212);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // porcentajeDeVentasPorProvinciaToolStripMenuItem
            // 
            this.porcentajeDeVentasPorProvinciaToolStripMenuItem.Name = "porcentajeDeVentasPorProvinciaToolStripMenuItem";
            this.porcentajeDeVentasPorProvinciaToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.porcentajeDeVentasPorProvinciaToolStripMenuItem.Text = "Porcentaje de Ventas por Provincia";
            this.porcentajeDeVentasPorProvinciaToolStripMenuItem.Click += new System.EventHandler(this.porcentajeDeVentasPorProvinciaToolStripMenuItem_Click);
            // 
            // cantidadDeVentasPorEmpleadoToolStripMenuItem
            // 
            this.cantidadDeVentasPorEmpleadoToolStripMenuItem.Name = "cantidadDeVentasPorEmpleadoToolStripMenuItem";
            this.cantidadDeVentasPorEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.cantidadDeVentasPorEmpleadoToolStripMenuItem.Text = "Cantidad de Ventas por Empleado";
            this.cantidadDeVentasPorEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeVentasPorEmpleadoToolStripMenuItem_Click);
            // 
            // cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem
            // 
            this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem.Name = "cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem";
            this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem.Text = "Cantidad de Envios por Empresa de Transporte";
            this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem_Click);
            // 
            // cantidadDeSemillasMasVendidasToolStripMenuItem
            // 
            this.cantidadDeSemillasMasVendidasToolStripMenuItem.Name = "cantidadDeSemillasMasVendidasToolStripMenuItem";
            this.cantidadDeSemillasMasVendidasToolStripMenuItem.Size = new System.Drawing.Size(318, 22);
            this.cantidadDeSemillasMasVendidasToolStripMenuItem.Text = "Cantidad de Semillas mas vendidas";
            this.cantidadDeSemillasMasVendidasToolStripMenuItem.Click += new System.EventHandler(this.cantidadDeSemillasMasVendidasToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoAgronegocios.Properties.Resources.campo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(842, 509);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGRONEGOCIOS";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSistemaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.ToolStripMenuItem soporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem semillasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeFacturasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeSemillasCompradasPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEnviosPorProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeVentasPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeEnviosPorEmpresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeAntigüedadDeEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadísticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topVentasEnCantidadPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topVentasEnPreciosPorClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porcentajeDeVentasPorProvinciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeVentasPorEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cantidadDeSemillasMasVendidasToolStripMenuItem;
    }
}

