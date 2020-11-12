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
    public partial class frmEstClientesVentas : Form
    {
        public frmEstClientesVentas()
        {
            InitializeComponent();
        }

        ClienteService sCliente = new ClienteService();

        private void EstClientesVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'estClientesVentas1._EstClientesVentas' Puede moverla o quitarla según sea necesario.
            this.estClientesVentasTableAdapter.Fill(this.estClientesVentas1._EstClientesVentas);

            this.rpvClientesVentas.RefreshReport();
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
            //double prom = sCliente.promedioVentasC(fechaDesde, fechaHasta);

            rpvClientesVentas.LocalReport.SetParameters(new ReportParameter[]
                                                    {
                                                     new ReportParameter("FechaDesde", dtpDesde.Value.ToString("yyyy-MM-dd")),
                                                     new ReportParameter("FechaHasta", dtpHasta.Value.ToString("yyyy-MM-dd"))
                                                     //new ReportParameter("Promedio", Math.Round(prom, 2).ToString())
                                                    });

            DataTable tabla = new DataTable();
            tabla = sCliente.recuperarCantidadVentas(fechaDesde, fechaHasta);
            rpvClientesVentas.LocalReport.DataSources.Clear();
            rpvClientesVentas.LocalReport.DataSources.Add(new ReportDataSource("EstClientesVentas", tabla));

            rpvClientesVentas.RefreshReport();


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
