namespace ProyectoAgronegocios.Reportes.Forms
{
    partial class frmReporteEnviosEmpresa
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
            this.enviosEmpresaBS = new System.Windows.Forms.BindingSource(this.components);
            this.reporteEnviosEmpresa = new ProyectoAgronegocios.ReporteEnviosEmpresa();
            this.rpvEnviosEmpresa = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reporteEnviosEmpresaTableAdapter = new ProyectoAgronegocios.ReporteEnviosEmpresaTableAdapters.ReporteEnviosEmpresaTableAdapter();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.enviosEmpresaBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEnviosEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // enviosEmpresaBS
            // 
            this.enviosEmpresaBS.DataMember = "ReporteEnviosEmpresa";
            this.enviosEmpresaBS.DataSource = this.reporteEnviosEmpresa;
            // 
            // reporteEnviosEmpresa
            // 
            this.reporteEnviosEmpresa.DataSetName = "ReporteEnviosEmpresa";
            this.reporteEnviosEmpresa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvEnviosEmpresa
            // 
            reportDataSource1.Name = "ReporteEnviosEmpresa";
            reportDataSource1.Value = this.enviosEmpresaBS;
            this.rpvEnviosEmpresa.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvEnviosEmpresa.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Reportes.ReporteEnviosEmpresa.rdlc";
            this.rpvEnviosEmpresa.Location = new System.Drawing.Point(0, 0);
            this.rpvEnviosEmpresa.Name = "rpvEnviosEmpresa";
            this.rpvEnviosEmpresa.ServerReport.BearerToken = null;
            this.rpvEnviosEmpresa.Size = new System.Drawing.Size(590, 539);
            this.rpvEnviosEmpresa.TabIndex = 0;
            // 
            // reporteEnviosEmpresaTableAdapter
            // 
            this.reporteEnviosEmpresaTableAdapter.ClearBeforeFill = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(293, 627);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 40;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(185, 627);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 23);
            this.btnListar.TabIndex = 39;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(306, 583);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 38;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(26, 583);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 37;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(350, 577);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 36;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(73, 577);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 35;
            // 
            // frmReporteEnviosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 681);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvEnviosEmpresa);
            this.Name = "frmReporteEnviosEmpresa";
            this.Text = "Reporte de Cantidad de Envios por Empresa";
            this.Load += new System.EventHandler(this.frmReporteEnviosEmpresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enviosEmpresaBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEnviosEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEnviosEmpresa;
        private System.Windows.Forms.BindingSource enviosEmpresaBS;
        private ReporteEnviosEmpresa reporteEnviosEmpresa;
        private ReporteEnviosEmpresaTableAdapters.ReporteEnviosEmpresaTableAdapter reporteEnviosEmpresaTableAdapter;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
    }
}