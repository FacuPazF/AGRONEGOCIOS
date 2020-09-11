using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class ClienteDAO
    {
        private string consulta;
        public DataTable consultarClientesSinParametros()
        {
            consulta = "SELECT * FROM Cliente_Proveedor WHERE borrado = 0";
            return DBHelper.consultar(consulta);
        }
    }
}
