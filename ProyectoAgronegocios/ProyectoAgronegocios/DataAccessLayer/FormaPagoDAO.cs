using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.DataAccessLayer
{
    class FormaPagoDAO
    {
        public DataTable recuperarFormasPago()
        {
            string consultaSQL = "select * from Formas_Pagos";
            return DataManager.GetInstance().ConsultaSQL(consultaSQL);
        }
    }
}
