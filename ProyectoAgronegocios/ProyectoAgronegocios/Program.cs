using System;
using System.Windows.Forms;
using ProyectoAgronegocios.GUILayer;
using ProyectoAgronegocios.Reportes.Forms;
using ProyectoAgronegocios.Estadisticas.Forms;
namespace ProyectoAgronegocios
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new formPrincipal());

        }
    }
}
