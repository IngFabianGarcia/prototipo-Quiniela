using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static prototipo_Quiniela.modelo.ConexionSql;
using System.Windows.Forms;

namespace prototipo_Quiniela.modelo
{
    internal class modeloTablas
    {

        //Este metodo devuelve una tabla utilizable para el data grid
        public DataTable TablaEquipos()
        {
            DataTable tablaEquipos = new DataTable();
            //El try toma el siguiente codigo y agarra el error y lo muestra
            try
            {
                //Se abre la conexion con el metodo
                Miconexion.abrir_conexion();

                //se crea un nuevo comando de sql
                SqlCommand cmd = new SqlCommand();

                //Se indica que el comando es para procesos almacenados previamente programados en la base de datos
                cmd.CommandType = CommandType.StoredProcedure;

                // Se pone el nombre del procedimiento
                cmd.CommandText = "VerEquipos";

                //Se hace la conexion
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Llena el data grid vacio cojn los datos de la base de datos
                adapter.Fill(tablaEquipos);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            //Devuelve la tabla ya modificada

            return tablaEquipos;
        }
    }
}
