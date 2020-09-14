using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class LocalidadDAO
    {
        private string consulta;
        public DataTable recuperarLocalidades()
        {
            consulta = "SELECT * FROM Localidad";

            return DBHelper.consultar(consulta);
        }
    }
}
