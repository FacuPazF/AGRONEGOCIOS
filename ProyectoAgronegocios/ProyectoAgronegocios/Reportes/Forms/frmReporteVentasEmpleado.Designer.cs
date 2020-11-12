namespace ProyectoAgronegocios.Reportes.Forms
{
    partial class frmReporteVentasEmpleado
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rpvVentasEmpleado = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.ventasEmpleadoBS = new System.Windows.Forms.BindingSource(this.components);
            this.reporteVentasEmpleado = new ProyectoAgronegocios.ReporteVentasEmpleado();
            this.reporteVentasEmpleadoTableAdapter = new ProyectoAgronegocios.ReporteVentasEmpleadoTableAdapters.ReporteVentasEmpleadoTableAdapter();
            this.ReporteVentasEmpleadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ventasEmpleadoBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteVentasEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasEmpleadoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvVentasEmpleado
            // 
            reportDataSource2.Name = "ReporteVentasEmpleado";
            reportDataSource2.Value = this.ventasEmpleadoBS;
            this.rpvVentasEmpleado.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvVentasEmpleado.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Reportes.ReporteVentasEmpleado.rdlc";
            this.rpvVentasEmpleado.Location = new System.Drawing.Point(0, -1);
            this.rpvVentasEmpleado.Name = "rpvVentasEmpleado";
            this.rpvVentasEmpleado.ServerReport.BearerToken = null;
            this.rpvVentasEmpleado.Size = new System.Drawing.Size(572, 539);
            this.rpvVentasEmpleado.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(285, 619);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 34;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(177, 619);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 23);
            this.btnListar.TabIndex = 33;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(298, 575);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 32;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(18, 575);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 31;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(342, 569);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 30;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(65, 569);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 29;
            // 
            // ventasEmpleadoBS
            // 
            this.ventasEmpleadoBS.DataMember = "ReporteVentasEmpleado";
            this.ventasEmpleadoBS.DataSource = this.reporteVentasEmpleado;
            // 
            // reporteVentasEmpleado
            // 
            this.reporteVentasEmpleado.DataSetName = "ReporteVentasEmpleado";
            this.reporteVentasEmpleado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteVentasEmpleadoTableAdapter
            // 
            this.reporteVentasEmpleadoTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVentasEmpleadoBindingSource
            // 
            this.ReporteVentasEmpleadoBindingSource.DataMember = "ReporteVentasEmpleado";
            this.ReporteVentasEmpleadoBindingSource.DataSource = this.reporteVentasEmpleado;
            // 
            // frmReporteVentasEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 676);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvVentasEmpleado);
            this.Name = "frmReporteVentasEmpleado";
            this.Text = "Reporte de Cantidad de Ventas por Empleado";
            this.Load += new System.EventHandler(this.frmReporteVentasEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasEmpleadoBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteVentasEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentasEmpleadoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvVentasEmpleado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.BindingSource ventasEmpleadoBS;
        private ReporteVentasEmpleado reporteVentasEmpleado;
        private ReporteVentasEmpleadoTableAdapters.ReporteVentasEmpleadoTableAdapter reporteVentasEmpleadoTableAdapter;
        private System.Windows.Forms.BindingSource ReporteVentasEmpleadoBindingSource;
    }
}