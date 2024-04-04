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
        //se llaman todas las clases que utilizara el constructor
        Login VistaLogin;
        MenuPrincipal VistaMenu;
        AgregarEquipo VistaEquipo;
        AgregarPartido VistaPartido;
        Pronostico vistaPronostico;
        procesosSQL ejecutarSql;

        //El construcor inicializa todas las clases y las pone a escucha para poder interactuar con ellas

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
            //Este if realiza la accion de iniciar sesion llama al metodo Obtener Estado para ver si se completo la conexion tambien abre la conexion y si se tiene un error no se conecta a la base
            //Tambien carga la vista principal y cierra la vista de login
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

            //Este if realiza la accion de abrir la vista de equipos y tambien carga el metodo de tabla equipos que carga el data grid para que muestre datos
            if(sender == VistaMenu.btnAgregarEquipo)
            {
                VistaEquipo.Show();
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.TablaEquipos();
                VistaEquipo.dtEquipos.DataSource = dataTable;
            }

            //Este if agrega un dato de equipo a la base de datos por medio del metodo agregar equipo tambien actualiza la tabla con los datos nuevos
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
