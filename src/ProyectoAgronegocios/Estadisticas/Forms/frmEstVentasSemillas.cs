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
using Microsoft.Reporting.WinForms;

namespace ProyectoAgronegocios.Estadisticas.Forms
{
    public partial class frmEstVentasSemillas : Form
    {
        public frmEstVentasSemillas()
        {
            InitializeComponent();
        }

        SemillaService sSemilla = new SemillaService();

        private void frmEstVentasSemillas_Load(object sender, EventArgs e)
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
            rpvVentasSemillas.LocalReport.SetParameters(
                                                            new ReportParameter[]
                                                            {
                                                            new ReportParameter("FechaDesde", fechaDesde.ToString("yyyy-MM-dd")),
                                                            new ReportParameter("FechaHasta", fechaHasta.ToString("yyyy-MM-dd"))
                                                            }
                                                            );
            
            
            DataTable tabla = sSemilla.recuperarVentasSemilla(fechaDesde, fechaHasta);

            rpvVentasSemillas.LocalReport.DataSources.Clear();
            rpvVentasSemillas.LocalReport.DataSources.Add(new ReportDataSource("EstVentSemillas", tabla));
            this.rpvVentasSemillas.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
