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

        public DataTable recuperarLocalidades(int id_prov)
        {
            consulta = "SELECT * FROM Localidad WHERE id_Provincia = " + id_prov;

            return DBHelper.consultar(consulta);
        }
    }
}
