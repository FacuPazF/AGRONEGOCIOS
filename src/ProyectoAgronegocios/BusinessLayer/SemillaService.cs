using ProyectoAgronegocios.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAgronegocios.BusinessLayer
{
    class SemillaService
    {
        private SemillaDAO daoSemilla = new SemillaDAO();
        
        // ------------------- Consultas
        public DataTable consultarSemillasSinParametros()
        {
            return daoSemilla.consultarSemillasSinParametros();
        }

        public DataTable consultarSemillasConFiltros(string condiciones)
        {
            return daoSemilla.consultarSemillasConFiltros(condiciones);
        }

        public DataTable recuperarSemillasPorID(int id)
        {
            return daoSemilla.recuperarSemillasPorID(id);
        }
    }
}
