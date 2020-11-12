using ProyectoAgronegocios.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.BusinessLayer
{
    class TipoSemillaService
    {
        private TipoSemillaDAO daoTS = new TipoSemillaDAO();
        public DataTable consultarTipoSemilla()
        {
            return daoTS.consultarTipoSemilla();
        }
    }
}
