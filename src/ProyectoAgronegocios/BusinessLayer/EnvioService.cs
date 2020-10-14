using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAgronegocios.Entities;
using ProyectoAgronegocios.DataAccessLayer;
using System.Data;

namespace ProyectoAgronegocios.BusinessLayer
{
    class EnvioService

    {
        EnvioDAO daoEnv = new EnvioDAO();
        public void registrarEnvio (Envio env)
        {
            daoEnv.registrarEnvio(env);
        }

        public DataTable buscarEnviosProv(DateTime fd, DateTime fh)
        {
            return daoEnv.buscarEnviosProv(fd, fh);
        }

        public DataTable buscarEnviosEmpresa(DateTime fd, DateTime fh)
        {
            return daoEnv.buscarEnviosEmpresa(fd, fh);
        }
    }
}
