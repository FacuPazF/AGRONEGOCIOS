using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class CalidadDAO
    {
        private string consultaSQL;

        public DataTable consultarCalidad()
        {
            consultaSQL = "SELECT * FROM Calidad";
            return DataManager.GetInstance().ConsultaSQL(consultaSQL);
        }
    }
}
