using ProyectoAgronegocios.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProyectoAgronegocios.BusinessLayer
{
    class ProvinciaService
    {
        private ProvinciaDAO daoProvincia = new ProvinciaDAO();

        public DataTable recuperarProvincias()
        {
            return daoProvincia.recuperarProvincias();
        }
    }
}
