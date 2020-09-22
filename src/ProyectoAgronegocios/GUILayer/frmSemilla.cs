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
    public partial class frmSemilla : Form
    {
        public frmSemilla()
        {
            InitializeComponent();
        }
        // ------------------------  Atributos de Soporte -------------------------
        private bool nuevo;
        private SemillaService sSemilla = new SemillaService();
        private TipoSemillaService sTipSem = new TipoSemillaService();
        private CalidadService sCalidad = new CalidadService();
        // ------------------------  Carga de Formulario --------------------------
        private void frmSemilla_Load(object sender, EventArgs e)
        {
            this.pnlSemilla.Enabled = false;
            this.habilitarBotones(true);
            this.cargarGrilla(dtgSemillas, sSemilla.consultarSemillasSinParametros());
            this.cargarCombo(cboFilterTipoSemilla,sTipSem.consultarTipoSemilla());
            this.cargarCombo(cboTipoSemilla, sTipSem.consultarTipoSemilla());
            this.cargarCombo(cboCalidad, sCalidad.consultarCalidad());
            this.cboFilterTipoSemilla.SelectedIndex = -1;
        }
        // ------------------------  Botones dentro del panel --------------------------
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (nuevo)
            {

            }
            else
            {

            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            habilitarBotones(true);
            pnlSemilla.Enabled = false;
        }

        // ------------------------  Fuera del Panel ---------------------------
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nuevo = true;
            pnlSemilla.Enabled = true;
            habilitarBotones(false);
            limpiarCampos();
            txtNombre.Focus();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            pnlSemilla.Enabled = true;
            habilitarBotones(false);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtFilterNombre.Text == "" && cboFilterTipoSemilla.SelectedIndex == -1)
                cargarGrilla(dtgSemillas, sSemilla.consultarSemillasSinParametros());
            else
            {
                String condiciones = "";
                //var filters = new Dictionary<string, object>();

                if (txtFilterNombre.Text != string.Empty)
                {
                    
                    //filters.Add("nombre", txtFilterNombre.Text);
                    condiciones += " AND s.nombre = '" + txtFilterNombre.Text + "' ";

                }
                if (cboFilterTipoSemilla.Text != string.Empty)
                {
                    
                    //filters.Add("tipoSemilla", cboFilterTipoSemilla.SelectedValue);
                    condiciones += " AND ts.id_Tipo_Semilla = " + cboFilterTipoSemilla.SelectedValue.ToString();

                }
                cargarGrilla(dtgSemillas, sSemilla.consultarSemillasConFiltros(condiciones));
            }
        }
        private void dtgSemillas_SelectionChanged(object sender, EventArgs e)
        {
            actualizarCampos((int)dtgSemillas.CurrentRow.Cells[0].Value);
        }



        // -----------------------   Métodos de Soporte --------------------------------

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtStockMin.Text = "";
            txtStock.Text = "";
            txtPrecio_X_Tonelada.Text = "";
            txtHabilitado.Text = "";
            txtDescripcion.Text = "";
            txtPrecioSugerido.Text = "";
            cboCalidad.SelectedIndex = -1;
            cboTipoSemilla.SelectedIndex = -1;
        }

        private void habilitarBotones(bool habilitado)
        {
            btnConsultar.Enabled = habilitado;
            btnNuevo.Enabled = habilitado;
            btnModificar.Enabled = habilitado;
            btnEliminar.Enabled = habilitado;
        }

        private void cargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;

        }

        private void cargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["ID"],
                                tabla.Rows[i]["Nombre"],
                                tabla.Rows[i]["Stock"],
                                tabla.Rows[i]["Precio Por Tonelada"],
                                tabla.Rows[i]["Tipo de Semilla"],
                                tabla.Rows[i]["Calidad"]);


            }
        }

        private void actualizarCampos(int id)
        {
            DataTable tabla = new DataTable();
            tabla = sSemilla.recuperarSemillasPorID(id);
            txtNombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txtStockMin.Text = tabla.Rows[0]["Stock Minimo"].ToString();
            txtStock.Text = tabla.Rows[0]["Stock"].ToString();
            txtPrecio_X_Tonelada.Text = tabla.Rows[0]["Precio Por Tonelada"].ToString();
            txtHabilitado.Text = tabla.Rows[0]["Habilitado"].ToString();
            txtDescripcion.Text = tabla.Rows[0]["Descripcion"].ToString();
            txtPrecioSugerido.Text= tabla.Rows[0]["Precio Sugerido"].ToString();
            cboTipoSemilla.SelectedValue = tabla.Rows[0]["Tipo de Semilla"];
            cboCalidad.SelectedValue = tabla.Rows[0]["Calidad"];

        }

    }
}
