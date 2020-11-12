using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.DataAccessLayer;
using System.Data;

namespace ProyectoAgronegocios.BusinessLayer
{
    class TipoEmpleadoService
    {
        private TipoEmpleadoDAO daoTipoEmpleado = new TipoEmpleadoDAO();

        public DataTable recuperarTiposEmpleado()
        {
            return daoTipoEmpleado.recuperarTiposEmpleado();
        }
    }
}
