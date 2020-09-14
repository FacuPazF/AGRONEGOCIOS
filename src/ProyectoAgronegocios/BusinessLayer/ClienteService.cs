using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.DataAccessLayer;
using ProyectoAgronegocios.Entities;

namespace ProyectoAgronegocios.BusinessLayer
{
    class ClienteService
    {
        private ClienteDAO daoCliente = new ClienteDAO();

        public void registrarCliente(Cliente cliente)
        {
           daoCliente.registrarCliente(cliente);
        }
        public DataTable consultarClientesSinParametros()
        {
            return daoCliente.consultarClientesSinParametros();
        }
        public DataTable consultarClientesConCuil(string cuil)
        {
            return daoCliente.consultarClientesConCuil(cuil);
        }

        public DataTable recuperarDatosCliente(int id)
        {
            return daoCliente.recuperarDatosCliente(id);
        }
    }
}
