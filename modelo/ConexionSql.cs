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

            public static String user;
            public static String pass;


            public static void abrir_conexion()
            {
                conexion = new SqlConnection("Data Source=FABIAN-PC-TIO\\SQLEXPRESS; Initial Catalog = Prueba; Persist Security Info = True; User ID = " + user+"; Password = "+pass+"; TrustServerCertificate = True");

              

                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }
                else { MessageBox.Show("error"); }
            }


            public static System.Data.ConnectionState ObtenerEstadoConexion()
            {
                return conexion.State;
            }
        }
    }
}

