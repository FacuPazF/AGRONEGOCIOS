namespace ProyectoAgronegocios.Reportes.Forms
{
    partial class frmReporteAntigEmpleados
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
            this.antigEmpleadosBS = new System.Windows.Forms.BindingSource(this.components);
            this.reporteAntigEmpleados1 = new ProyectoAgronegocios.ReporteAntigEmpleados1();
            this.rpvAntigEmpleados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.reporteAntigEmpleadosTableAdapter = new ProyectoAgronegocios.ReporteAntigEmpleados1TableAdapters.ReporteAntigEmpleadosTableAdapter();
            this.ReporteAntigEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.antigEmpleadosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAntigEmpleados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAntigEmpleadosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // antigEmpleadosBS
            // 
            this.antigEmpleadosBS.DataMember = "ReporteAntigEmpleados";
            this.antigEmpleadosBS.DataSource = this.reporteAntigEmpleados1;
            // 
            // reporteAntigEmpleados1
            // 
            this.reporteAntigEmpleados1.DataSetName = "ReporteAntigEmpleados1";
            this.reporteAntigEmpleados1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpvAntigEmpleados
            // 
            reportDataSource1.Name = "ReporteAntigEmpleados1";
            reportDataSource1.Value = this.antigEmpleadosBS;
            this.rpvAntigEmpleados.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvAntigEmpleados.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Reportes.ReporteAntigEmpleados.rdlc";
            this.rpvAntigEmpleados.Location = new System.Drawing.Point(0, 0);
            this.rpvAntigEmpleados.Name = "rpvAntigEmpleados";
            this.rpvAntigEmpleados.ServerReport.BearerToken = null;
            this.rpvAntigEmpleados.Size = new System.Drawing.Size(807, 538);
            this.rpvAntigEmpleados.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(603, 581);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 40;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(495, 581);
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
            this.lblHasta.Location = new System.Drawing.Point(110, 605);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 38;
            this.lblHasta.Text = "Hasta:";
            this.lblHasta.Click += new System.EventHandler(this.lblHasta_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(110, 569);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 37;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.Click += new System.EventHandler(this.lblDesde_Click);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(157, 599);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 36;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(157, 563);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 35;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // reporteAntigEmpleadosTableAdapter
            // 
            this.reporteAntigEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAntigEmpleadosBindingSource
            // 
            this.ReporteAntigEmpleadosBindingSource.DataMember = "ReporteAntigEmpleados";
            this.ReporteAntigEmpleadosBindingSource.DataSource = this.reporteAntigEmpleados1;
            // 
            // frmReporteAntigEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 647);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvAntigEmpleados);
            this.Name = "frmReporteAntigEmpleados";
            this.Text = "Reporte de Antigüedad de Empleados";
            this.Load += new System.EventHandler(this.ReporteAntigEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antigEmpleadosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteAntigEmpleados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteAntigEmpleadosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvAntigEmpleados;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.BindingSource antigEmpleadosBS;
        private ReporteAntigEmpleados1 reporteAntigEmpleados1;
        private ReporteAntigEmpleados1TableAdapters.ReporteAntigEmpleadosTableAdapter reporteAntigEmpleadosTableAdapter;
        private System.Windows.Forms.BindingSource ReporteAntigEmpleadosBindingSource;
    }
}