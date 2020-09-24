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
    public partial class frmTransporte : Form
    {
        public frmTransporte()
        {
            InitializeComponent();
        }
        
        //-------------------------------------------- Atributos ---------------------------------
      
        private TransporteService sTransporte = new TransporteService();
        private BarrioService sBarrio = new BarrioService();
        private Transporte oTransporte = new Transporte();
        private bool nuevo;

        // ---------------------------------------  Carga del Formulario ----------------------------------

        private void Transporte_Load(object sender, EventArgs e)
        {
            this.cargarGrilla(dtgTransporte, sTransporte.consultarTransporteSinParametros());
            this.cargarCombo(cmbBarrio, sBarrio.recuperarBarrios());
            this.limpiarPanel();
            this.panelTransporte.Enabled = false;
        }

        //--------------------------------------- Botones ------------------------------------------------

        private void btnConsultarTranporte_Click(object sender, EventArgs e)
        {
            if (txtTransporte.Text != String.Empty)
                this.cargarGrilla(dtgTransporte, sTransporte.consultarTransporteConRazonSocial(txtTransporte.Text));
            else
            {
                MessageBox.Show("Ingrese Razon Social", "Campo vacío", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTransporte.Focus();
            }
        }



        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizarGrilla_Click(object sender, EventArgs e)
        {
            this.cargarGrilla(dtgTransporte, sTransporte.consultarTransporteSinParametros());
            this.txtTransporte.Clear();
            this.txtTransporte.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevoTransp_Click(object sender, EventArgs e)
        {
            this.nuevo = true;
            panelTransporte.Enabled = true;
            dtgTransporte.Enabled = false;
            limpiarPanel();
            txtDescripcion.Focus();
            habilitarBotones(false);
        }

        private void btnModificarTransp_Click(object sender, EventArgs e)
        {
            this.nuevo = false;
            panelTransporte.Enabled = true;
            dtgTransporte.Enabled = false;
            txtDescripcion.Focus();
            habilitarBotones(false);

            this.actualizarCampos(Convert.ToInt32(dtgTransporte.CurrentRow.Cells[0].Value));
        }

        private void btnEliminarTransp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Eliminar el Transporte " + dtgTransporte.CurrentRow.Cells["RazonSocial"].Value + " " + dtgTransporte.CurrentRow.Cells["Descripcion"].Value, "Confirmación de Eliminación",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                sTransporte.borrarTransporte(Convert.ToInt32(dtgTransporte.CurrentRow.Cells[0].Value));
                MessageBox.Show("Cliente Borrado con Éxito", "Cliente Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cargarGrilla(dtgTransporte, sTransporte.consultarTransporteSinParametros());
            }

        }
        
        // Dentro de panel Transporte ------------------------------------------------------------

        private void btnLimpiarTransp_Click(object sender, EventArgs e)
        {
            limpiarPanel();
        }

        private void btnFinalizarTransp_Click(object sender, EventArgs e)
        {
            limpiarPanel();
            panelTransporte.Enabled = false;
            dtgTransporte.Enabled = true;
            this.habilitarBotones(true);
            this.cargarGrilla(dtgTransporte, sTransporte.consultarTransporteSinParametros());
        }

        private void btnAceptarTransp_Click(object sender, EventArgs e)
        {
            oTransporte.Descripcion = txtDescripcion.Text;
            oTransporte.Razon_social = txtRazonSocial.Text;
            oTransporte.Telefono = txtTelefono.Text;
            oTransporte.Direccion = txtDireccion.Text;
            oTransporte.Id_barrio = (int)cmbBarrio.SelectedValue;
            oTransporte.Borrado = 0;

            if (this.nuevo)
            {
                if (txtRazonSocial.Text != "")
                {
                    sTransporte.registrarTransporte(oTransporte);
                    MessageBox.Show("Transporte Creado con Éxito", "Transporte Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error - Debe ingresar Razon Social", "El campo Razon Social está vacío", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRazonSocial.Focus();
                }
            }
            else
            {
                oTransporte.Id_Empresa = Convert.ToInt32(dtgTransporte.CurrentRow.Cells[0].Value);
                sTransporte.modificarTransporte(oTransporte);
                MessageBox.Show("Transporte Modificado con Éxito", "Transporte Modificado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //------------------------metodos soporte-----------------------------------------------

        private void limpiarPanel()
        {
            txtDescripcion.Clear();
            txtRazonSocial.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cmbBarrio.SelectedIndex = -1;
            
        }

        private void cargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;

        }

        private void habilitarBotones(bool habilitado)
        {
            btnNuevoTransp.Enabled = habilitado;
            btnModificarTransp.Enabled = habilitado;
            btnEliminarTransp.Enabled = habilitado;
            btnCerrar.Enabled = habilitado;
            btnConsultarTransporte.Enabled = habilitado;

        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            dtgTransporte.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["ID Empresa"],
                                tabla.Rows[i]["Descripcion"],
                                tabla.Rows[i]["Razon Social"],
                                tabla.Rows[i]["Telefono"],
                                tabla.Rows[i]["Direccion"],
                                tabla.Rows[i]["Barrio"]);


            }
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = sTransporte.recuperarDatosTransporte(id);
            txtDescripcion.Text = tabla.Rows[0]["Descripcion"].ToString();
            txtRazonSocial.Text = tabla.Rows[0]["Razon Social"].ToString();
            txtTelefono.Text = tabla.Rows[0]["Telefono"].ToString();
            txtDireccion.Text = tabla.Rows[0]["Direccion"].ToString();
            cmbBarrio.SelectedValue = tabla.Rows[0]["Barrio"];
     
        }

        private void panelTransporte_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


