using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;
using ProyectoAgronegocios.GUILayer;
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
    }
}
