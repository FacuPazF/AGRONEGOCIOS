using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;
using ProyectoAgronegocios.Estadisticas.Forms;
using ProyectoAgronegocios.GUILayer;
using ProyectoAgronegocios.Reportes.Forms;
using System;
using System.Windows.Forms;

namespace ProyectoAgronegocios
{
    public partial class formPrincipal : Form
    {
        
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void cerrarSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formPrincipal_Load(object sender, EventArgs e)
        {
            frmLogin formLogin = new frmLogin();
            formLogin.ShowDialog();
            
            if (formLogin.IsClosed)
            {
                Close();
                return;
            }

            lblBienvenida.Text = "¡Bienvenido, " + formLogin.User.Usuario + "!";
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente formCliente = new frmCliente();
            formCliente.ShowDialog();
        }

        private void transportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransporte formTransporte = new frmTransporte();
            formTransporte.ShowDialog();
        }

        private void semillasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSemilla formSemilla = new frmSemilla();
            formSemilla.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleado formEmpleado = new frmEmpleado();
            formEmpleado.ShowDialog();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactura formFactura = new frmFactura();
            formFactura.ShowDialog();
        }

        private void asignarEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnvio formEnvio = new frmEnvio();
            formEnvio.ShowDialog();
        }

        private void reporteDeFacturasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteFacturas frmRF = new frmReporteFacturas();
            frmRF.ShowDialog();
        }

        private void cantidadDeSemillasCompradasPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteDetFacturas frmRDF = new frmReporteDetFacturas();
            frmRDF.ShowDialog();
        }

        private void reporteDeEnviosPorProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEnviosProv frmREP = new frmReporteEnviosProv();
            frmREP.ShowDialog();
        }

        private void reporteDeVentasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentasEmpleado frmRVE = new frmReporteVentasEmpleado();
            frmRVE.ShowDialog();
        }

        private void reporteDeEnviosPorEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteEnviosEmpresa frmREE = new frmReporteEnviosEmpresa();
            frmREE.ShowDialog();
        }

        private void reporteDeAntigüedadDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteAntigEmpleados frmRAE = new frmReporteAntigEmpleados();
            frmRAE.ShowDialog();
        }

        private void topVentasEnCantidadPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstClientesVentas frmECV = new frmEstClientesVentas();
            frmECV.ShowDialog();
        }

        private void topVentasEnPreciosPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstClientesVentasP frmECVP = new frmEstClientesVentasP();
            frmECVP.ShowDialog();
        }

        private void porcentajeDeVentasPorProvinciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstPorcVentasProv frmEPVP = new frmEstPorcVentasProv();
            frmEPVP.ShowDialog();
        }

        private void cantidadDeVentasPorEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstVentasEmpleados frmEVE = new frmEstVentasEmpleados();
            frmEVE.ShowDialog();
        }

        private void cantidadDeEnviosPorEmpresaDeTransporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstEnviosEmp frmEE = new frmEstEnviosEmp();
            frmEE.ShowDialog();
        }

        private void cantidadDeSemillasMasVendidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstVentasSemillas frmEVS = new frmEstVentasSemillas();
            frmEVS.ShowDialog();
        }
    }
}
