namespace ProyectoAgronegocios.Reportes.Forms
{
    partial class frmReporteFacturas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.facturasBS = new System.Windows.Forms.BindingSource(this.components);
            this.agronegociosDataSet = new ProyectoAgronegocios.RepFacturas();
            this.rpvFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.cboTipoFactura = new System.Windows.Forms.ComboBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblCuil = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.facturasTableAdapter = new ProyectoAgronegocios.AgronegociosDataSetTableAdapters.FacturasTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facturasBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agronegociosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // facturasBS
            // 
            this.facturasBS.DataMember = "Facturas";
            this.facturasBS.DataSource = this.agronegociosDataSet;
            // 
            // agronegociosDataSet
            // 
            this.agronegociosDataSet.DataSetName = "AgronegociosDataSet";
            this.agronegociosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvFacturas
            // 
            reportDataSource1.Name = "Facturas";
            reportDataSource1.Value = this.facturasBS;
            this.rpvFacturas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvFacturas.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Reportes.ReporteFacturas.rdlc";
            this.rpvFacturas.Location = new System.Drawing.Point(0, 0);
            this.rpvFacturas.Name = "rpvFacturas";
            this.rpvFacturas.ServerReport.BearerToken = null;
            this.rpvFacturas.Size = new System.Drawing.Size(699, 627);
            this.rpvFacturas.TabIndex = 0;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(110, 655);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 1;
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(416, 655);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 2;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(63, 661);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 3;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(372, 661);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 4;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(63, 690);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(85, 13);
            this.lblTipoFactura.TabIndex = 5;
            this.lblTipoFactura.Text = "Tipo de Factura:";
            // 
            // cboTipoFactura
            // 
            this.cboTipoFactura.FormattingEnabled = true;
            this.cboTipoFactura.Items.AddRange(new object[] {
            "A",
            "B"});
            this.cboTipoFactura.Location = new System.Drawing.Point(154, 687);
            this.cboTipoFactura.Name = "cboTipoFactura";
            this.cboTipoFactura.Size = new System.Drawing.Size(156, 21);
            this.cboTipoFactura.TabIndex = 6;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(416, 718);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 23);
            this.btnListar.TabIndex = 7;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(63, 723);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(57, 13);
            this.lblCuil.TabIndex = 8;
            this.lblCuil.Text = "Cuil o Cuit:";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(126, 720);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(184, 20);
            this.txtCuil.TabIndex = 9;
            // 
            // facturasTableAdapter
            // 
            this.facturasTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(524, 718);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // frmReporteFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 783);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.cboTipoFactura);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvFacturas);
            this.Name = "frmReporteFacturas";
            this.Text = "Reporte Facturas";
            this.Load += new System.EventHandler(this.frmReporteFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturasBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agronegociosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvFacturas;
        private System.Windows.Forms.BindingSource facturasBS;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.ComboBox cboTipoFactura;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.TextBox txtCuil;
        private RepFacturas agronegociosDataSet;
        private AgronegociosDataSetTableAdapters.FacturasTableAdapter facturasTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
    }
}