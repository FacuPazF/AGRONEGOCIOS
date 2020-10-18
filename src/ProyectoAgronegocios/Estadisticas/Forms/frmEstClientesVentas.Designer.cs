namespace ProyectoAgronegocios.Estadisticas.Forms
{
    partial class frmEstClientesVentas
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
            this.rpvClientesVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnGrafico = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.ventasClientesBS = new System.Windows.Forms.BindingSource(this.components);
            this.estClientesVentas1 = new ProyectoAgronegocios.EstClientesVentas();
            this.estClientesVentasTableAdapter = new ProyectoAgronegocios.EstClientesVentasTableAdapters.EstClientesVentasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ventasClientesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estClientesVentas1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvClientesVentas
            // 
            this.rpvClientesVentas.LocalReport.ReportEmbeddedResource = "ProyectoAgronegocios.Estadisticas.EstClientesVentas.rdlc";
            this.rpvClientesVentas.Location = new System.Drawing.Point(-1, -1);
            this.rpvClientesVentas.Name = "rpvClientesVentas";
            this.rpvClientesVentas.ServerReport.BearerToken = null;
            this.rpvClientesVentas.Size = new System.Drawing.Size(770, 575);
            this.rpvClientesVentas.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(578, 628);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 23);
            this.btnCerrar.TabIndex = 46;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGrafico
            // 
            this.btnGrafico.Location = new System.Drawing.Point(470, 628);
            this.btnGrafico.Name = "btnGrafico";
            this.btnGrafico.Size = new System.Drawing.Size(102, 23);
            this.btnGrafico.TabIndex = 45;
            this.btnGrafico.Text = "Gráfico";
            this.btnGrafico.UseVisualStyleBackColor = true;
            this.btnGrafico.Click += new System.EventHandler(this.btnGrafico_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(85, 652);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 44;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(85, 616);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 43;
            this.lblDesde.Text = "Desde:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(132, 646);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 42;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(132, 610);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 41;
            // 
            // ventasClientesBS
            // 
            this.ventasClientesBS.DataMember = "EstClientesVentas";
            this.ventasClientesBS.DataSource = this.estClientesVentas1;
            // 
            // estClientesVentas1
            // 
            this.estClientesVentas1.DataSetName = "EstClientesVentas";
            this.estClientesVentas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estClientesVentasTableAdapter
            // 
            this.estClientesVentasTableAdapter.ClearBeforeFill = true;
            // 
            // frmEstClientesVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 710);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnGrafico);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.rpvClientesVentas);
            this.Name = "frmEstClientesVentas";
            this.Text = "EstClientesVentas";
            this.Load += new System.EventHandler(this.EstClientesVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ventasClientesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estClientesVentas1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvClientesVentas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGrafico;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.BindingSource ventasClientesBS;
        private ProyectoAgronegocios.EstClientesVentas estClientesVentas1;
        private EstClientesVentasTableAdapters.EstClientesVentasTableAdapter estClientesVentasTableAdapter;
    }
}