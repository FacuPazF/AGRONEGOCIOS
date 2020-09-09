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
            formLogin formLogin = new formLogin();
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
    }
}
