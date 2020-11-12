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

namespace ProyectoAgronegocios.Reportes.Forms
{
    public partial class frmReporteVentasEmpleado : Form
    {
        public frmReporteVentasEmpleado()
        {
            InitializeComponent();
        }
        FacturaService sFactura = new FacturaService();
        private void frmReporteVentasEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporteVentasEmpleado._ReporteVentasEmpleado' Puede moverla o quitarla según sea necesario.
            this.reporteVentasEmpleadoTableAdapter.Fill(this.reporteVentasEmpleado._ReporteVentasEmpleado);

            this.rpvVentasEmpleado.RefreshReport();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha DESDE no puede ser mayor a la fecha HASTA!");
                dtpDesde.Focus();
                return;
            }


            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;

            ventasEmpleadoBS.DataSource = sFactura.buscarVentasEmpleado(fechaDesde, fechaHasta);
            this.rpvVentasEmpleado.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
