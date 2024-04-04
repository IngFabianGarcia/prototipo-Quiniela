﻿using System;
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
    internal class procesosSQL
    {
        //agrega un equipo a la base de datos
        public static void agregarEquipo(string nombreEquipo)
        {
            try
            {
                Miconexion.abrir_conexion();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                // Nombre del procedimiento almacenado
                cmd.CommandText = "AgregarEquipo"; 
                cmd.Connection = Miconexion.conexion;

                //Son los parametros que necesita para funcionar
                cmd.Parameters.Add(new SqlParameter("@NombreEquipo", nombreEquipo));

                //Ejecuta el comando SQL
                cmd.ExecuteNonQuery();
                MessageBox.Show("Equipo agregado exitosamente");
                Miconexion.conexion.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Algo salió mal: " + ex.Message);
            }
        }
    }
}