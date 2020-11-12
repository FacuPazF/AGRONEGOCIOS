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
    public partial class frmEstPorcVentasProv : Form
    {
        public frmEstPorcVentasProv()
        {
            InitializeComponent();
        }

        EnvioService sEnvio = new EnvioService();

        private void EstPorcVentasProv_Load(object sender, EventArgs e)
        {

            this.rpvPorcVentasProv.RefreshReport();
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
            
            rpvPorcVentasProv.LocalReport.SetParameters(new ReportParameter[]
                                                    {
                                                     new ReportParameter("FechaDesde", dtpDesde.Value.ToString("yyyy-MM-dd")),
                                                     new ReportParameter("FechaHasta", dtpHasta.Value.ToString("yyyy-MM-dd")),
                                                     
                                                    });

            DataTable tabla = new DataTable();
            tabla = sEnvio.recuperarVentasProv(fechaDesde, fechaHasta);
            rpvPorcVentasProv.LocalReport.DataSources.Clear();
            rpvPorcVentasProv.LocalReport.DataSources.Add(new ReportDataSource("EstPorcVentasXEmpleado", tabla));

            rpvPorcVentasProv.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
