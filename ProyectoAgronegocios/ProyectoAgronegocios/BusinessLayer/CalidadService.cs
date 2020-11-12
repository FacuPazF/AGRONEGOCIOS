using ProyectoAgronegocios.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.BusinessLayer
{
    class CalidadService
    {
        private CalidadDAO daoCalidad = new CalidadDAO();
        public DataTable consultarCalidad()
        {
            return daoCalidad.consultarCalidad();
        }
    }
}
