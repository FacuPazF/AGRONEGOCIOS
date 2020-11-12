using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.DataAccessLayer;

namespace ProyectoAgronegocios.BusinessLayer
{
    
    class BarrioService
    {
        private BarrioDAO daoBarrio = new BarrioDAO();

        public DataTable recuperarBarrios()
        {
            return daoBarrio.recuperarBarrios();
        }
    }
}
