using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoAgronegocios.DataAccessLayer;

namespace ProyectoAgronegocios.BusinessLayer
{
    class FormaPagoService
    {
        private FormaPagoDAO daoFP = new FormaPagoDAO();
        public DataTable recuperarFormasPago()
        {
            return daoFP.recuperarFormasPago();
        }
    }
}
