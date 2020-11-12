using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ProyectoAgronegocios.BusinessLayer;

namespace ProyectoAgronegocios.Estadisticas.Forms
{
    public partial class frmEstClientesVentasP : Form
    {
        public frmEstClientesVentasP()
        {
            InitializeComponent();
        }

        ClienteService sCliente = new ClienteService();

        private void frmEstClientesVentasP_Load(object sender, EventArgs e)
        {

       
        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha DESDE no puede ser mayor a la fecha HASTA!");
                dtpDesde.Focus();
                return;
            }

            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;
            double prom = sCliente.promedioVentasP(fechaDesde, fechaHasta);

            rpvClientesVentasP.LocalReport.SetParameters(new ReportParameter[]
                                                    {
                                                     new ReportParameter("FechaDesde", dtpDesde.Value.ToString("yyyy-MM-dd")),
                                                     new ReportParameter("FechaHasta", dtpHasta.Value.ToString("yyyy-MM-dd")),
                                                     new ReportParameter("Promedio", Math.Round(prom, 2).ToString())
                                                    });

            DataTable tabla = new DataTable();
            tabla = sCliente.recuperarCantidadVentasPrecio(fechaDesde, fechaHasta);
            rpvClientesVentasP.LocalReport.DataSources.Clear();
            rpvClientesVentasP.LocalReport.DataSources.Add(new ReportDataSource("EstClientesVentasP", tabla));

            rpvClientesVentasP.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
