using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class TipoSemillaDAO
    {
        private string consultaSQL;
        public DataTable consultarTipoSemilla()
        {
            consultaSQL = "SELECT * FROM Tipo_Semilla";
            return DataManager.GetInstance().ConsultaSQL(consultaSQL);
        }
    }
}
