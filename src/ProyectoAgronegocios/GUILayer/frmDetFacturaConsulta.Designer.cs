namespace ProyectoAgronegocios.GUILayer
{
    partial class frmDetFacturaConsulta
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
            this.lblNroFactura = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblFechaFactura = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.dtgDetalles = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.nombreSemilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNroFactura
            // 
            this.lblNroFactura.AutoSize = true;
            this.lblNroFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroFactura.Location = new System.Drawing.Point(243, 34);
            this.lblNroFactura.Name = "lblNroFactura";
            this.lblNroFactura.Size = new System.Drawing.Size(119, 20);
            this.lblNroFactura.TabIndex = 0;
            this.lblNroFactura.Text = "Nro de Factura:";
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoFactura.Location = new System.Drawing.Point(46, 34);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(124, 20);
            this.lblTipoFactura.TabIndex = 1;
            this.lblTipoFactura.Text = "Tipo de Factura:";
            // 
            // lblFechaFactura
            // 
            this.lblFechaFactura.AutoSize = true;
            this.lblFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFactura.Location = new System.Drawing.Point(46, 69);
            this.lblFechaFactura.Name = "lblFechaFactura";
            this.lblFechaFactura.Size = new System.Drawing.Size(140, 20);
            this.lblFechaFactura.TabIndex = 2;
            this.lblFechaFactura.Text = "Fecha de Emisión:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(46, 104);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(183, 20);
            this.lblEmpleado.TabIndex = 3;
            this.lblEmpleado.Text = "Empleado Responsable:";
            // 
            // dtgDetalles
            // 
            this.dtgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreSemilla,
            this.precio,
            this.cantidad,
            this.subtotal});
            this.dtgDetalles.Location = new System.Drawing.Point(50, 166);
            this.dtgDetalles.Name = "dtgDetalles";
            this.dtgDetalles.Size = new System.Drawing.Size(456, 360);
            this.dtgDetalles.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(338, 550);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(61, 20);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total: $";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(407, 588);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nombreSemilla
            // 
            this.nombreSemilla.HeaderText = "Nombre de Semilla";
            this.nombreSemilla.Name = "nombreSemilla";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio x Tonelada";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // frmDetFacturaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 635);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dtgDetalles);
            this.Controls.Add(this.lblEmpleado);
            this.Controls.Add(this.lblFechaFactura);
            this.Controls.Add(this.lblTipoFactura);
            this.Controls.Add(this.lblNroFactura);
            this.Name = "frmDetFacturaConsulta";
            this.Text = "Detalle de Factura";
            this.Load += new System.EventHandler(this.frmDetFacturaConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNroFactura;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblFechaFactura;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.DataGridView dtgDetalles;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreSemilla;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}