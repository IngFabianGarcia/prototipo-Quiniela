using prototipo_Quiniela.controlador;
using prototipo_Quiniela.modelo;
using prototipo_Quiniela.vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototipo_Quiniela
{
    internal static class IniciadorPrograma
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login VistaLogin = new Login();
            MenuPrincipal VistaMenu = new MenuPrincipal();
            AgregarEquipo VistaEquipo = new AgregarEquipo();
            AgregarPartido VistaPartido = new AgregarPartido();
            Pronostico vistaPronostico = new Pronostico();
            procesosSQL ejecutarSql = new procesosSQL();

            ControladorPrograma Controlador = new ControladorPrograma(VistaLogin,VistaMenu,VistaEquipo, VistaPartido, vistaPronostico, ejecutarSql);




            Application.Run();
        }
    }
}
