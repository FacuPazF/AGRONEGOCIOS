using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.DataAccessLayer;

namespace ProyectoAgronegocios.BusinessLayer
{
    class LocalidadService
    {
        private LocalidadDAO daoLocalidad = new LocalidadDAO();

        public DataTable recuperarLocalidades()
        {
            return daoLocalidad.recuperarLocalidades();
        }
    }
}
