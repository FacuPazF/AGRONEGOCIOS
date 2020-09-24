using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class TipoEmpleadoDAO
    {
        private string consulta;
        public DataTable recuperarTiposEmpleado()
        {
            consulta = "SELECT * FROM Tipo_Empleados";

            return DBHelper.consultar(consulta);
        }
    }
}
