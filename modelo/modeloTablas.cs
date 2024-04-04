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
        public DataTable TablaEquipos()
        {
            DataTable tablaEquipos = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "VerEquipos";
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(tablaEquipos);
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return tablaEquipos;
        }

        public DataTable TablaPartidos(string numCuenta)
        {
            DataTable TablaPartidos = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarDeposito";
                cmd.Parameters.AddWithValue("idCuenta", numCuenta);
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(TablaPartidos);

                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return TablaPartidos;
        }

        public DataTable TablaPronosticos(string numCuenta)
        {
            DataTable TablaPronosticos = new DataTable();
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "BuscarDeposito";
                cmd.Parameters.AddWithValue("idCuenta", numCuenta);
                cmd.Connection = Miconexion.conexion;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(TablaPronosticos);

                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }

            return TablaPronosticos;
        }

    }
}
