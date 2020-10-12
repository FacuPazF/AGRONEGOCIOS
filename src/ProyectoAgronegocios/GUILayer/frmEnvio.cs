using ProyectoAgronegocios.Entities;
using ProyectoAgronegocios.Support.Gestores;
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
    public partial class frmEnvio : Form
    {
        // ---------------- Atributos
        GestorEnvios gesEnvios = new GestorEnvios();
        public frmEnvio()
        {
            InitializeComponent();
        }
        private void frmEnvio_Load(object sender, EventArgs e)
        {
            recargarFormulario(DialogResult.Yes);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            double cuil_cliente;
            if (!double.TryParse(txtFilterCuil.Text,out cuil_cliente))
            {
                MessageBox.Show("Solo se aceptan números");
                txtFilterCuil.Focus();
                return;
            }
            if (cuil_cliente < 0 )
            {
                MessageBox.Show("Ingrese un número válido de CUIT o CUIL (sin comas ni signos)");
                txtFilterCuil.Focus();
                return;
            }
            if ((cuil_cliente % Math.Truncate(cuil_cliente)) != 0)
            {
                MessageBox.Show("Ingrese un número válido de CUIT o CUIL (sin comas ni signos)");
                txtFilterCuil.Focus();
                return;
            }

            // Buscar al Cliente
            gesEnvios.buscarClienteSeleccionado(txtFilterCuil.Text);
            
            if (gesEnvios.ClienteSeleccionado != null)
            {
                lblRealNomApe.Text = gesEnvios.ClienteSeleccionado.Nombre + " " + gesEnvios.ClienteSeleccionado.Apellido;
                lblRealCuil.Text = gesEnvios.ClienteSeleccionado.Cuil_cuit;
                lblRealRazonSocial.Text = gesEnvios.ClienteSeleccionado.Razon_Social;
                grbDatosEnvio.Enabled = true;
                btnRegistrarEnvio.Enabled = true;
            }
            else
            {
                MessageBox.Show("Cliente no encontrado");
                return;
            }

            //Búsqueda de Facturas
            //buscarFacturas();
        }
        private void btnRegistrarEnvio_Click(object sender, EventArgs e)
        {
            if (dtpFechaEnvio.Value < DateTime.Today)
            {
                MessageBox.Show("Ingrese fecha mayor a " + DateTime.Today.ToString("F"), "Error - Fecha no válida", MessageBoxButtons.OK,MessageBoxIcon.Error);
                dtpFechaEnvio.Focus();
                return;
            }
            if (txtDireccionEnvio.Text == "")
            {
                MessageBox.Show("Ingrese una dirección de envío", "Error - Dirección de envío no ingresada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccionEnvio.Focus();
                return;
            }
            if (cboProvincia.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Provincia ", "Error - Provincia no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProvincia.Focus();
                return;
            }
            if (cboLocalidad.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Localidad ", "Error - Localidad no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboLocalidad.Focus();
                return;
            }
            if (cboBarrio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un Barrio ", "Error - Barrio no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProvincia.Focus();
                return;
            }
            if (cboEmpresaTransporte.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una Empresa de Transporte ", "Error - Empresa de Transporte no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboProvincia.Focus();
                return;
            }
            //if (dtgFacturas.CurrentRow.Index > dtgFacturas.Rows.Count || dtgFacturas.CurrentRow.Index < 0)
            //{
            //    MessageBox.Show("Seleccione una Factura", "Error - Factura no seleccionada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            if (gesEnvios.ClienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un Cliente ", "Error - Cliente no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFilterCuil.Focus();
                return;
            }
                
            
            gesEnvios.registrarEnvio();
        }






        // ---------------------- Métodos de Soporte
        //private void buscarFacturas()
        //{
        //    if (gesEnvios.ClienteSeleccionado == null)
        //    {
        //        return;
        //    }
        //    DataTable facturas = gesEnvios.buscarFacturasCliente(gesEnvios.ClienteSeleccionado);
        //    if (facturas.Rows.Count != 0)
        //    {
        //        for (int i = 0; i < facturas.Rows.Count; i++)
        //        {
        //            dtgFacturas.Rows.Add(
        //                facturas.Rows[i]["Tipo de Factura"],
        //                facturas.Rows[i]["Numero de Factura"],
        //                facturas.Rows[i]["Fecha de Emision"],
        //                facturas.Rows[i]["Monto Total"],
        //                facturas.Rows[i]["Empleado"]);
        //        }

        //    }
        //    else
        //    {
        //        DialogResult msjSinFacturas = MessageBox.Show("Este cliente no tiene Facturas. ¿Desea registrar una nueva Factura?",
        //                                                      "Cliente sin Facturas",
        //                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
        //        if (msjSinFacturas == DialogResult.Yes)
        //        {
        //            frmFactura factura = new frmFactura();
        //            factura.ShowDialog();
        //        }

        //    }
        //}
        private void cargarCombo(ComboBox combo, DataTable tabla)
        {

            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedValue = -1;

        }
        private void recargarFormulario(DialogResult msj)
        {
            if (msj == DialogResult.Yes)
            {
                cargarCombo(cboProvincia, gesEnvios.buscarProvincias());
                cargarCombo(cboEmpresaTransporte, gesEnvios.buscarEmpresasTransporte());
                cboBarrio.SelectedIndex = -1;
                cboLocalidad.SelectedIndex = -1;
                cboBarrio.DataSource = null;
                cboLocalidad.DataSource = null;
                txtDireccionEnvio.Text = "";
                dtpFechaEnvio.Value = DateTime.Today;
                cboEmpresaTransporte.SelectedIndex = -1;
                dtgFacturas.Rows.Clear();
                grbDatosEnvio.Enabled = false;
                lblRealNomApe.Text = "_________";
                lblRealCuil.Text = "_________";
                lblRealRazonSocial.Text = "_________";
                gesEnvios.ClienteSeleccionado = null;
                txtFilterCuil.Text = "";
                txtFilterCuil.Focus();
                btnRegistrarEnvio.Enabled = false;
                
            }
            
        }
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboProvincia.SelectedIndex != -1)
            //    cargarCombo(cboLocalidad, gesEnvios.buscarLocalidad(Convert.ToInt32(cboProvincia.SelectedValue)));
        }
        private void cboLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboLocalidad.SelectedIndex != -1)
            //    cargarCombo(cboBarrio, gesEnvios.buscarBarrios(Convert.ToInt32(cboLocalidad.SelectedValue)));
        }

        // --- Botones No críticos
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            //buscarFacturas();
        }
        private void btnCancelarEnvio_Click(object sender, EventArgs e)
        {
            DialogResult msjCancelarEnvio = MessageBox.Show("¿Desea limpiar todos los campos seleccionados y cargar un nuevo envío?", "Cancelar Envío",
                                                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            recargarFormulario(msjCancelarEnvio);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
