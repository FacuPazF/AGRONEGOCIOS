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

namespace ProyectoAgronegocios.GUILayer
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        //-------------------------------------------- Atributos ---------------------------------

        private ClienteService sCliente = new ClienteService();

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        // ---------------------------------------  Carga del Formulario
        private void frmCliente_Load(object sender, EventArgs e)
        {
             
            dtgCliente.DataSource = sCliente.consultarClientesSinParametros();
        }



        //--------------------------------------- Botones ----------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            pnlCliente.Enabled = true;
            dtgCliente.Enabled = false;
            limpiarPanel();
            txtNombre.Focus();
            habilitarBotones(false);
            
        }


        // -- Dentro de pnlCliente
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            pnlCliente.Enabled = false;
            dtgCliente.Enabled = true;
        }
        //-------------------------------------- Métodos de Soporte -------------------------------------
        private void limpiarPanel()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCuil.Clear();
            txtRazonSocial.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            cboProvincia.SelectedIndex = -1;
            cboCiudad.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;
        }

        private void habilitarBotones(bool habilitado)
        {
            btnNuevo.Enabled = habilitado;
            btnModificar.Enabled = habilitado;
            btnEliminar.Enabled = habilitado;
            btnCerrar.Enabled = habilitado;

        }

        
    }
}
