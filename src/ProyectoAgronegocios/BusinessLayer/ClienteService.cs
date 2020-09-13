using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.DataAccessLayer;

namespace ProyectoAgronegocios.BusinessLayer
{
    class ClienteService
    {
        private ClienteDAO daoCliente = new ClienteDAO();
        public DataTable consultarClientesSinParametros()
        {
            return daoCliente.consultarClientesSinParametros();
        }

        public DataTable recuperarDatosCliente(int id)
        {
            return daoCliente.recuperarDatosCliente(id);
        }
    }
}
