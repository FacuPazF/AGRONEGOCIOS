using ProyectoAgronegocios.BusinessLayer;
using ProyectoAgronegocios.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAgronegocios.Support.Gestores
{
    class GestorEnvios
    {
        private Cliente clienteSeleccionado;
        private ProvinciaService sProvincia = new ProvinciaService();
        private BarrioService sBarrio = new BarrioService();
        private LocalidadService sLocalidad = new LocalidadService();
        private TransporteService sTransporte = new TransporteService();
        

        // ----- Métodos get y set
        public Cliente ClienteSeleccionado { get => clienteSeleccionado; set => clienteSeleccionado = value; }
        internal ProvinciaService SProvincia { get => sProvincia; set => sProvincia = value; }
        internal BarrioService SBarrio { get => sBarrio; set => sBarrio = value; }
        internal LocalidadService SLocalidad { get => sLocalidad; set => sLocalidad = value; }
        internal TransporteService STransporte { get => sTransporte; set => sTransporte = value; }



        // ------ Métodos Críticos
        public Cliente buscarClienteSeleccionado(string cuit_cuil)
        {
            // Esto es código de prueba
            if (cuit_cuil == "20")
            {
                ClienteSeleccionado = new Cliente();
                ClienteSeleccionado.Nombre = "Pedro";
                ClienteSeleccionado.Apellido = "Perez";
                ClienteSeleccionado.Cuil_cuit = "20";
                ClienteSeleccionado.Razon_Social = "Una Empresa";
            }
            else
            {
                ClienteSeleccionado = null;
            }
            return ClienteSeleccionado;
        }
        public void registrarEnvio()
        {
            MessageBox.Show("Envío registrado");
        }
        public DataTable buscarFacturasCliente(Cliente unCliente)
        {
            return new DataTable();
        }


        // ----- Métodos de soporte

        public DataTable buscarProvincias()
        {
            return SProvincia.recuperarProvincias();
        }
        public DataTable buscarEmpresasTransporte()
        {
            return STransporte.consultarTransporteSinParametros();
        }
        public DataTable buscarLocalidad(int idProvincia)
        {
            //recuperarLocalidades(idProvincia)
            return SLocalidad.recuperarLocalidades();
        }
        public DataTable buscarBarrios(int idLocalidad)
        {
            return SBarrio.recuperarBarrios();
        }
        
    }
}
