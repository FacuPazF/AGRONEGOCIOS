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
    public partial class frmEstVentasEmpleados : Form
    {
        public frmEstVentasEmpleados()
        {
            InitializeComponent();
        }

        EmpleadoService sEmpleado = new EmpleadoService();

        private void frmEstVentasEmpleados_Load(object sender, EventArgs e)
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
           

            rpvVentasEmpleados.LocalReport.SetParameters(new ReportParameter[]
                                                    {
                                                     new ReportParameter("FechaDesde", dtpDesde.Value.ToString("yyyy-MM-dd")),
                                                     new ReportParameter("FechaHasta", dtpHasta.Value.ToString("yyyy-MM-dd")),
                                                     
                                                    });

            DataTable tabla = new DataTable();
            tabla = sEmpleado.recuperarVentasEmpleados(fechaDesde, fechaHasta);
            rpvVentasEmpleados.LocalReport.DataSources.Clear();
            rpvVentasEmpleados.LocalReport.DataSources.Add(new ReportDataSource("EstVentasEmpleados", tabla));

            rpvVentasEmpleados.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
