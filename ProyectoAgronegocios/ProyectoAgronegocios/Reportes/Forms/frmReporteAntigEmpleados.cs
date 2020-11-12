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
    public partial class frmReporteAntigEmpleados : Form
    {
        public frmReporteAntigEmpleados()
        {
            InitializeComponent();
        }

        EmpleadoService sEmpleado = new EmpleadoService();
        private void ReporteAntigEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'reporteAntigEmpleados1.ReporteAntigEmpleados' Puede moverla o quitarla según sea necesario.
            this.reporteAntigEmpleadosTableAdapter.Fill(this.reporteAntigEmpleados1.ReporteAntigEmpleados);
            // TODO: esta línea de código carga datos en la tabla 'reporteAntigEmpleados1.ReporteAntigEmpleados' Puede moverla o quitarla según sea necesario.
            this.reporteAntigEmpleadosTableAdapter.Fill(this.reporteAntigEmpleados1.ReporteAntigEmpleados);

            this.rpvAntigEmpleados.RefreshReport();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

            antigEmpleadosBS.DataSource = sEmpleado.buscarAntiguedades(fechaDesde, fechaHasta);
            this.rpvAntigEmpleados.RefreshReport();
        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
