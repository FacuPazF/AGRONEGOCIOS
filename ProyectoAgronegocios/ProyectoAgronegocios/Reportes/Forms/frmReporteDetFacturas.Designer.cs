

namespace ProyectoAgronegocios.Reportes.Forms
{
    partial class frmReporteDetFacturas
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
            this.rpvDetFacturas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.lblCuil = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.detFacturasBS = new System.Windows.Forms.BindingSource(this.components);
            this.agronegociosDataSet2 = new ProyectoAgronegocios.AgronegociosDataSet2();
            this.reporteDetFacturaTableAdapter = new ProyectoAgronegocios.AgronegociosDataSet2TableAdapters.ReporteDetFacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.detFacturasBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agronegociosDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvDetFacturas
            // 
            reportDataSource1.Name = "ReporteDetFacturas";
            reportDataSource1.Value = this.detFacturasBS;
            this.rpvDetFacturas.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDetFacturas.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Reportes.ReporteDetFacturas.rdlc";
            this.rpvDetFacturas.Location = new System.Drawing.Point(1, 1);
            this.rpvDetFacturas.Name = "rpvDetFacturas";
            this.rpvDetFacturas.ServerReport.BearerToken = null;
            this.rpvDetFacturas.Size = new System.Drawing.Size(666, 528);
            this.rpvDetFacturas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(493, 586);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(105, 589);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(184, 20);
            this.txtCuil.TabIndex = 19;
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Location = new System.Drawing.Point(42, 592);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(57, 13);
            this.lblCuil.TabIndex = 18;
            this.lblCuil.Text = "Cuil o Cuit:";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(385, 586);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 23);
            this.btnListar.TabIndex = 17;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(351, 553);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 14;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(42, 553);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 13;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(395, 547);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 12;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(89, 547);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 11;
            // 
            // detFacturasBS
            // 
            this.detFacturasBS.DataMember = "ReporteDetFactura";
            this.detFacturasBS.DataSource = this.agronegociosDataSet2;
            // 
            // agronegociosDataSet2
            // 
            this.agronegociosDataSet2.DataSetName = "AgronegociosDataSet2";
            this.agronegociosDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteDetFacturaTableAdapter
            // 
            this.reporteDetFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteDetFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 635);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.lblCuil);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvDetFacturas);
            this.Name = "frmReporteDetFacturas";
            this.Text = "Reporte Detalles de Factura";
            this.Load += new System.EventHandler(this.frmReporteDetFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detFacturasBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agronegociosDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDetFacturas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label lblCuil;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.BindingSource detFacturasBS;
        private AgronegociosDataSet2 agronegociosDataSet2;
        private AgronegociosDataSet2TableAdapters.ReporteDetFacturaTableAdapter reporteDetFacturaTableAdapter;
    }
}