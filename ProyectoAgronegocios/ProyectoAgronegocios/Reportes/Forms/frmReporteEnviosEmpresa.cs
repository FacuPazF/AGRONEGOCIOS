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
    public partial class frmReporteEnviosEmpresa : Form
    {
        public frmReporteEnviosEmpresa()
        {
            InitializeComponent();
        }

        EnvioService sEnvio = new EnvioService();

        private void frmReporteEnviosEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporteEnviosEmpresa._ReporteEnviosEmpresa' Puede moverla o quitarla según sea necesario.
            this.reporteEnviosEmpresaTableAdapter.Fill(this.reporteEnviosEmpresa._ReporteEnviosEmpresa);

            this.rpvEnviosEmpresa.RefreshReport();
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

            enviosEmpresaBS.DataSource = sEnvio.buscarEnviosEmpresa(fechaDesde, fechaHasta);
            this.rpvEnviosEmpresa.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
