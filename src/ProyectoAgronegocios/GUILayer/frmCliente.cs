using ProyectoAgronegocios.BusinessLayer;
using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;
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
        private ProvinciaService sProvincia = new ProvinciaService();
        private LocalidadService sLocalidad = new LocalidadService();
        private ClienteService sCliente = new ClienteService();
        private BarrioService sBarrio = new BarrioService();
        private Cliente oCliente = new Cliente();
        private bool nuevo;

        // ---------------------------------------  Carga del Formulario ----------------------------------
        private void frmCliente_Load(object sender, EventArgs e)
        {
            
            this.cargarGrilla(dtgCliente, sCliente.consultarClientesSinParametros());
            this.cargarCombo(cboBarrio, sBarrio.recuperarBarrios());
            this.cargarCombo(cboCiudad, sLocalidad.recuperarLocalidades());
            this.cargarCombo(cboProvincia, sProvincia.recuperarProvincias());
            this.limpiarPanel();
        }



        //--------------------------------------- Botones ----------------------
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text != String.Empty)
                this.cargarGrilla(dtgCliente, sCliente.consultarClientesConCuil(txtCliente.Text));
            else
            {
                MessageBox.Show("Ingrese CUIL o CUIT", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCliente.Focus();
            }
                

        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarGrilla(dtgCliente, sCliente.consultarClientesSinParametros());
            this.txtCliente.Clear();
            this.txtCliente.Focus();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            pnlCliente.Enabled = true;
            dtgCliente.Enabled = false;
            limpiarPanel();
            txtNombre.Focus();
            habilitarBotones(false);
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.nuevo = false;
            pnlCliente.Enabled = true;
            dtgCliente.Enabled = false;
            txtNombre.Focus();
            habilitarBotones(false);
            
            this.actualizarCampos(Convert.ToInt32(dtgCliente.CurrentRow.Cells[0].Value));
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el Cliente " + dtgCliente.CurrentRow.Cells["Nombre"].Value + " " + dtgCliente.CurrentRow.Cells["Apellido"].Value, "Confirmación de Eliminación",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sCliente.borrarCliente(Convert.ToInt32(dtgCliente.CurrentRow.Cells[0].Value));
                MessageBox.Show("Cliente Borrado con Éxito", "Cliente Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarGrilla(dtgCliente, sCliente.consultarClientesSinParametros());
            }
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
            this.habilitarBotones(true);
            this.cargarGrilla(dtgCliente, sCliente.consultarClientesSinParametros());
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // --- Valida Nombre
            if(txtNombre.Text == "")
            {
                MessageBox.Show("Nombre de Cliente faltante", "Nombre inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }
            // --- Valida Apellido
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Apellido de Cliente faltante", "Apellido inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
                return;
            }
            // --- Valida Cuil o Cuit
            long cuil;
            if (!(long.TryParse(txtCuil.Text, out cuil)) || txtCuil.Text == "" || txtCuil.Text.Length != 11)
            {
                MessageBox.Show("Ingrese Cuil o Cuit válido (Solo números y de 11 caracteres)", "Cuil o Cuit erróneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCuil.Focus();
                return;
            }
            // --- Valida Razon Social
            if (txtRazonSocial.Text == "")
            {
                MessageBox.Show("Ingrese Razón Social", "Razon Social Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRazonSocial.Focus();
                return;
            }
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Ingrese Email", "Email inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            long telefono;
            if (!(long.TryParse(txtTelefono.Text, out telefono)) || txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese un Número de Telefono Válido (Solo numeros)", "Telefono Erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Ingrese Ubicación", "Ubicación faltante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProvincia.Focus();
                return;
            }
            oCliente.Nombre = txtNombre.Text;
            oCliente.Apellido = txtApellido.Text;
            oCliente.Cuil_cuit = txtCuil.Text;
            oCliente.Razon_Social = txtRazonSocial.Text;
            oCliente.Email = txtEmail.Text;
            oCliente.Telefono = txtTelefono.Text;
            oCliente.Cod_Barrio = (int)cboBarrio.SelectedValue;
            oCliente.Id_Tipo = 1;
            oCliente.Borrado = 0;

            if (this.nuevo)
            {
                if(txtCuil.Text != "")
                {
                    sCliente.registrarCliente(oCliente);
                    MessageBox.Show("Cliente Creado con Éxito", "Cliente Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Debe ingresar CUIL", "El campo CUIL o CUIT está vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCuil.Focus();
                }
            }
            else
            {
                oCliente.Id_Cliente_Proveedor = Convert.ToInt32(dtgCliente.CurrentRow.Cells[0].Value);
                sCliente.modificarCliente(oCliente);
                MessageBox.Show("Cliente Modificado con Éxito", "Cliente Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
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

        private void cargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            
        }

        private void habilitarBotones(bool habilitado)
        {
            btnNuevo.Enabled = habilitado;
            btnModificar.Enabled = habilitado;
            btnEliminar.Enabled = habilitado;
            btnCerrar.Enabled = habilitado;
            btnConsultar.Enabled = habilitado;

        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            dtgCliente.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["ID"],
                                tabla.Rows[i]["Cuil o Cuit"],
                                tabla.Rows[i]["Nombre"],
                                tabla.Rows[i]["Apellido"],
                                tabla.Rows[i]["Razon Social"],
                                tabla.Rows[i]["Tipo de Cliente"],
                                tabla.Rows[i]["Email"],
                                tabla.Rows[i]["Telefono"],
                                tabla.Rows[i]["Barrio"]);


            }
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = sCliente.recuperarDatosCliente(id);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtCuil.Text = tabla.Rows[0]["Cuil o Cuit"].ToString();

            txtRazonSocial.Text = tabla.Rows[0]["Razon Social"].ToString();
            txtEmail.Text = tabla.Rows[0]["Email"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            cboBarrio.SelectedValue = tabla.Rows[0]["Barrio"];
            cboProvincia.SelectedValue = tabla.Rows[0]["Provincia"];
            cboCiudad.SelectedValue = tabla.Rows[0]["Ciudad"];
        }

    }
}
