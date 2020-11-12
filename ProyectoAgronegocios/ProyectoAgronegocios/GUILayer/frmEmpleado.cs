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
using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.GUILayer
{
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
        }

        //-------------------------------------------- Atributos --------------------------------------
        private EmpleadoService sEmpleado = new EmpleadoService();
        private TipoEmpleadoService sTipoEmpleado = new TipoEmpleadoService();
        private BarrioService sBarrio = new BarrioService();
        private Empleado oEmpleado = new Empleado();
        private bool nuevo;

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            this.cargarGrilla(dgvEmpleados, sEmpleado.consultarEmpleadosSinParametros());
            this.cargarCombo(cboTipoEmpleado, sTipoEmpleado.recuperarTiposEmpleado());
            this.cargarCombo(cboBarrio, sBarrio.recuperarBarrios());
            this.limpiarPanel();
            pnlEmpleado.Enabled = false;
        }

        //---------------------------------------  Botones --------------------------------------------

        private void btnCodEmpleado_Click(object sender, EventArgs e)
        {
            if (txtCodEmpleado.Text != String.Empty)
                this.cargarGrilla(dgvEmpleados, sEmpleado.consultarEmpleadoConCod(txtCodEmpleado.Text));
            else
            {
                MessageBox.Show("Ingrese Código de Empleado", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodEmpleado.Focus();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            pnlEmpleado.Enabled = true;
            dgvEmpleados.Enabled = false;
            limpiarPanel();
            txtNombre.Focus();
            habilitarBotones(false);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.nuevo = false;
            pnlEmpleado.Enabled = true;
            dgvEmpleados.Enabled = false;
            txtNombre.Focus();
            habilitarBotones(false);

            this.actualizarCampos(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el Empleado " + dgvEmpleados.CurrentRow.Cells["Nombre"].Value + " " + dgvEmpleados.CurrentRow.Cells["Apellido"].Value, "Confirmación de Eliminación",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sEmpleado.borrarEmpleado(Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value));
                MessageBox.Show("Empleado Borrado con Éxito", "Empleado Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarGrilla(dgvEmpleados, sEmpleado.consultarEmpleadosSinParametros());
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.cargarGrilla(dgvEmpleados, sEmpleado.consultarEmpleadosSinParametros());
            this.txtCodEmpleado.Clear();
            this.txtCodEmpleado.Focus();
        }



        //------------------------------------- Dentro de pnlEmpleado ---------------------------------

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            pnlEmpleado.Enabled = false;
            dgvEmpleados.Enabled = true;
            this.habilitarBotones(true);
            this.cargarGrilla(dgvEmpleados, sEmpleado.consultarEmpleadosSinParametros());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            oEmpleado.Nombre = txtNombre.Text;
            oEmpleado.Apellido = txtApellido.Text;
            oEmpleado.Email = txtEmail.Text;
            oEmpleado.Telefono = txtTelefono.Text;
            oEmpleado.Fecha_Alta = DateTime.Now;
            oEmpleado.Cod_barrio = (int)cboBarrio.SelectedValue;
            oEmpleado.Calle = txtCalle.Text;
            oEmpleado.Numero_casa = txtNroCasa.Text;
            oEmpleado.Fecha_nacimiento = dtpFechaNac.Value;
            oEmpleado.Tipo_Empleado = (int)cboBarrio.SelectedValue;
            oEmpleado.Borrado = 0;

            if (this.nuevo)
            {
                sEmpleado.registrarEmpleado(oEmpleado);
                MessageBox.Show("Empleado Creado con Éxito", "Empleado Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                oEmpleado.Cod_Empleado = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                sEmpleado.modificarEmpleado(oEmpleado);
                MessageBox.Show("Empleado Modificado con Éxito", "Empleado Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //-------------------------------------- Métodos de Soporte -----------------------------------
        private void limpiarPanel()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtCalle.Clear();
            txtNroCasa.Clear();
            dtpFechaNac.Value = DateTime.Now;
            cboTipoEmpleado.SelectedIndex = -1;
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
            btnCodEmpleado.Enabled = habilitado;
            btnActualizar.Enabled = habilitado;

        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            dgvEmpleados.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["COD"],
                                tabla.Rows[i]["Tipo Empleado"],
                                tabla.Rows[i]["Nombre"],
                                tabla.Rows[i]["Apellido"],
                                tabla.Rows[i]["Email"],
                                tabla.Rows[i]["Telefono"],
                                tabla.Rows[i]["Calle"],
                                tabla.Rows[i]["NroCasa"],
                                tabla.Rows[i]["Barrio"],
                                tabla.Rows[i]["Fecha Nacimiento"]);
            }
        }

        private void actualizarCampos(int cod)
        {
            DataTable tabla = new DataTable();
            tabla = sEmpleado.recuperarDatosEmpleado(cod);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtApellido.Text = tabla.Rows[0]["Apellido"].ToString();
            txtEmail.Text = tabla.Rows[0]["Email"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtCalle.Text = tabla.Rows[0]["Calle"].ToString();
            txtNroCasa.Text = tabla.Rows[0]["NroCasa"].ToString();
            dtpFechaNac.Value = (DateTime)tabla.Rows[0]["Fecha Nacimiento"];
            cboTipoEmpleado.SelectedValue = tabla.Rows[0]["Tipo Empleado"];
            cboBarrio.SelectedValue = tabla.Rows[0]["Barrio"];
        }
    }
}
