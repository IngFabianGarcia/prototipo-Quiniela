using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prototipo_Quiniela.modelo
{
    internal class ConexionSql
    {
        public static class Miconexion
        {
            public static SqlConnection conexion;

            //Estas variables son cambiadas por el login al ser incorrectas no se hace la conexion
            public static String user;
            public static String pass;


            public static void abrir_conexion()
            {
                //Este es el nombre de conexion para conectar a la base de datos
                conexion = new SqlConnection("Data Source=FABIAN-PC-TIO\\SQLEXPRESS; Initial Catalog = Prueba; Persist Security Info = True; User ID = " + user+"; Password = "+pass+"; TrustServerCertificate = True");

              
                //Este if cambia el estado de conexion cerrada a abierta
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
                else { MessageBox.Show("error"); }
            }


            //Con este metodo se obtiene el estado de la conexion
            public static System.Data.ConnectionState ObtenerEstadoConexion()
            {
                return conexion.State;
            }
        }
    }
}

