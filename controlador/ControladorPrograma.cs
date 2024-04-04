using prototipo_Quiniela.modelo;
using prototipo_Quiniela.vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prototipo_Quiniela.modelo.ConexionSql;


namespace prototipo_Quiniela.controlador
{
    internal class ControladorPrograma
    {
        //se llaman todas las vistas
        Login VistaLogin;
        MenuPrincipal VistaMenu;
        AgregarEquipo VistaEquipo;
        AgregarPartido VistaPartido;
        Pronostico vistaPronostico;
        procesosSQL ejecutarSql;

        public ControladorPrograma(Login vistaLogin, MenuPrincipal vistaMenu, AgregarEquipo vistaEquipo, AgregarPartido vistaPartido, Pronostico vistaPronostico, procesosSQL ejecutarSql)
        {
            //carga las clases y vistas
            VistaLogin = vistaLogin;
            VistaMenu = vistaMenu;
            VistaEquipo = vistaEquipo;
            VistaPartido = vistaPartido;
            this.vistaPronostico = vistaPronostico;
            this.ejecutarSql = ejecutarSql;

            //activa el escucha de los botones
            //Botones Login
            vistaLogin.btnIniciarSesion.Click += clickBoton;
            //Botones Menu Principal
            vistaMenu.btnAgregarEquipo.Click += clickBoton;
            vistaMenu.btnAgregarPartido.Click += clickBoton;
            vistaMenu.btnPronostico.Click += clickBoton;
            //Botones Vista Agregar Equipo
            vistaEquipo.btnAgregarEquipo.Click += clickBoton;

            //Carga la vista inicial
            vistaMenu.Show();
            vistaLogin.ShowDialog();
        }

        private void clickBoton(object sender, EventArgs e)
        {
            if(sender == VistaLogin.btnIniciarSesion)
            {
                Miconexion.user = VistaLogin.txtUsuario.Text;
                Miconexion.pass = VistaLogin.txtContraseña.Text;
                Miconexion.abrir_conexion();
                System.Data.ConnectionState estadoConexion = Miconexion.ObtenerEstadoConexion();

                if (estadoConexion == System.Data.ConnectionState.Open)
                {
                    MessageBox.Show("login correcto");
                    VistaLogin.Close();

                }
                else
                {
                    MessageBox.Show("Contraseña o Usuario Incorrectos");
                }
            }

            if(sender == VistaMenu.btnAgregarEquipo)
            {
                VistaEquipo.Show();
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.TablaEquipos();
                VistaEquipo.dtEquipos.DataSource = dataTable;
            }
            
            if(sender == VistaEquipo.btnAgregarEquipo)
            {
                DialogResult result = MessageBox.Show("¿Quieres agregar un nuevo equipo?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    procesosSQL.agregarEquipo(VistaEquipo.txtNombreEquipo.Text);
                    modeloTablas datos = new modeloTablas();
                    DataTable dataTable = datos.TablaEquipos();
                    VistaEquipo.dtEquipos.DataSource = dataTable;
                }
                else
                {

                }
            }
        }
    }
}
