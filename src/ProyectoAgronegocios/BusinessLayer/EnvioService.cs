using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.Entities;
using ProyectoAgronegocios.DataAccessLayer;

namespace ProyectoAgronegocios.BusinessLayer
{
    class EnvioService

    {
        EnvioDAO daoEnv = new EnvioDAO();
        public void registrarEnvio (Envio env)
        {
            daoEnv.registrarEnvio(env);
        }

    }
}
