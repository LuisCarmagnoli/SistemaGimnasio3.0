using SistemaGimnasio.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGimnasio
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Usuario usuario = new Usuario();
            usuario.Rol = "Socio";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (usuario.Rol == "Administrador")
                Application.Run(new VistaAdministrador());
            else
                Application.Run(new VistaSocio());
        }
    }
}
