using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class BarrioDAO
    {
        private string consulta;
        public DataTable recuperarBarrios()
        {
            consulta = "SELECT * FROM Barrios";
                               
            return DBHelper.consultar(consulta);
        }
    }
}
