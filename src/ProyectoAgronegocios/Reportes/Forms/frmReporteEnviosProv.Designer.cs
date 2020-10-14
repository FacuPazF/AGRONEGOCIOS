namespace ProyectoAgronegocios.Reportes.Forms
{
    partial class frmReporteEnviosProv
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
            this.rpvEnviosProv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.enviosProvBS = new System.Windows.Forms.BindingSource(this.components);
            this.reporteEnviosProv = new ProyectoAgronegocios.ReporteEnviosProv();
            this.reporteEnviosProvTableAdapter = new ProyectoAgronegocios.ReporteEnviosProvTableAdapters.ReporteEnviosProvTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.enviosProvBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEnviosProv)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvEnviosProv
            // 
            reportDataSource2.Name = "ReporteEnviosProv";
            reportDataSource2.Value = this.enviosProvBS;
            this.rpvEnviosProv.LocalReport.DataSources.Add(reportDataSource2);
            this.rpvEnviosProv.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Reportes.ReporteEnviosProv.rdlc";
            this.rpvEnviosProv.Location = new System.Drawing.Point(0, 0);
            this.rpvEnviosProv.Name = "rpvEnviosProv";
            this.rpvEnviosProv.ServerReport.BearerToken = null;
            this.rpvEnviosProv.Size = new System.Drawing.Size(547, 518);
            this.rpvEnviosProv.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(277, 596);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 28;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(169, 596);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(102, 23);
            this.btnListar.TabIndex = 25;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(290, 552);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 24;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(10, 552);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 23;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(334, 546);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 22;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(57, 546);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 21;
            // 
            // enviosProvBS
            // 
            this.enviosProvBS.DataMember = "ReporteEnviosProv";
            this.enviosProvBS.DataSource = this.reporteEnviosProv;
            // 
            // reporteEnviosProv
            // 
            this.reporteEnviosProv.DataSetName = "ReporteEnviosProv";
            this.reporteEnviosProv.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reporteEnviosProvTableAdapter
            // 
            this.reporteEnviosProvTableAdapter.ClearBeforeFill = true;
            // 
            // frmReporteEnviosProv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 643);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvEnviosProv);
            this.Name = "frmReporteEnviosProv";
            this.Text = "Reporte Envios Por Provincia";
            this.Load += new System.EventHandler(this.frmReporteEnviosProv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enviosProvBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteEnviosProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvEnviosProv;
        private System.Windows.Forms.BindingSource enviosProvBS;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private ReporteEnviosProv reporteEnviosProv;
        private ReporteEnviosProvTableAdapters.ReporteEnviosProvTableAdapter reporteEnviosProvTableAdapter;
    }
}