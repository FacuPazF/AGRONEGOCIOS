using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class ProvinciaDAO
    {
        private string consulta;
        public DataTable recuperarProvincias()
        {
            consulta = "SELECT * FROM Provincia";

            return DBHelper.consultar(consulta);
        }
    }
}
