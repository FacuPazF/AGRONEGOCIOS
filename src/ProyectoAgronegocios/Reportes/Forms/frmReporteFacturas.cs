using ProyectoAgronegocios.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.Reportes.Forms
{
    public partial class frmReporteFacturas : Form

    {
        private ClienteService sCliente = new ClienteService();
        private FacturaService sFactura = new FacturaService();
        private string consulta = "";
        public frmReporteFacturas()
        {
            InitializeComponent();
        }

        private void frmReporteFacturas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agronegociosDataSet.Facturas' Puede moverla o quitarla según sea necesario.
            this.facturasTableAdapter.Fill(this.agronegociosDataSet.Facturas);

            this.rpvFacturas.RefreshReport();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            double cuil_cliente;
            if (!double.TryParse(txtCuil.Text, out cuil_cliente))
            {
                MessageBox.Show("Solo se aceptan números");
                txtCuil.Focus();
                return;
            }
            if (cuil_cliente < 0)
            {
                MessageBox.Show("Ingrese un número válido de CUIT o CUIL (sin comas ni signos)");
                txtCuil.Focus();
                return;
            }
            if ((cuil_cliente % Math.Truncate(cuil_cliente)) != 0)
            {
                MessageBox.Show("Ingrese un número válido de CUIT o CUIL (sin comas ni signos)");
                txtCuil.Focus();
                return;
            }
            if (cboTipoFactura.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de factura!");
                cboTipoFactura.Focus();
                return;
            }
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha DESDE no puede ser mayor a la fecha HASTA!");
                dtpDesde.Focus();
                return;
            }
            if ((sCliente.consultarClientesConCuil(txtCuil.Text)).Rows.Count == 0)
            {
                MessageBox.Show("Cliente no encontrado");
                txtCuil.Focus();
                return;
            }

            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;
            string tipoFactura = cboTipoFactura.Text;
            int idCliente = (int)(sCliente.consultarClientesConCuil(txtCuil.Text)).Rows[0]["ID"];

            facturasBS.DataSource = sFactura.buscarFacturasConParametros(fechaDesde, fechaHasta, tipoFactura, idCliente);
            this.rpvFacturas.RefreshReport();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
