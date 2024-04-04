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
        AgregarUsuario VistaUsuario;
        Pronostico vistaPronostico;
        procesosSQL ejecutarSql;

        //El construcor inicializa todas las clases y las pone a escucha para poder interactuar con ellas

        public ControladorPrograma(Login vistaLogin, MenuPrincipal vistaMenu, AgregarEquipo vistaEquipo, AgregarPartido vistaPartido, Pronostico vistaPronostico, procesosSQL ejecutarSql, AgregarUsuario vistaUsuario)
        {
            //carga las clases y vistas
            VistaLogin = vistaLogin;
            VistaMenu = vistaMenu;
            VistaEquipo = vistaEquipo;
            VistaPartido = vistaPartido;
            VistaUsuario = vistaUsuario;
            
            this.vistaPronostico = vistaPronostico;
            this.ejecutarSql = ejecutarSql;

            //activa el escucha de los botones
            //Botones Login
            vistaLogin.btnIniciarSesion.Click += clickBoton;
            //Botones Menu Principal
            vistaMenu.btnAgregarEquipo.Click += clickBoton;
            vistaMenu.btnAgregarPartido.Click += clickBoton;
            vistaMenu.btnPronostico.Click += clickBoton;
            vistaMenu.btnAgregarUsuario.Click += clickBoton;
            //Botones Vista Agregar Equipo
            vistaEquipo.btnAgregarEquipo.Click += clickBoton;
            vistaPartido.btnAgregarPartido.Click += clickBoton;

            //Botones Vista Usuario
            vistaUsuario.btnAgregarUsuario.Click += clickBoton;

            //Detecta si se cierra el menu para cerrar la aplicacion
            vistaMenu.FormClosing += VistaMenu_FormClosing;

            //Carga la vista inicial
            vistaMenu.Show();
            vistaLogin.ShowDialog();

           
        }



        // Cierra la aplicación completamente cuando se cierre el formulario VistaMenu
        private void VistaMenu_FormClosing(object sender, FormClosingEventArgs e)
        { 
            Application.Exit();
        }


        private void clickBoton(object sender, EventArgs e)
        {



            //Este if realiza la accion de iniciar sesion llama al metodo Obtener Estado para ver si se completo la conexion tambien abre la conexion y si se tiene un error no se conecta a la base
            //Tambien carga la vista principal y cierra la vista de login
            if (sender == VistaLogin.btnIniciarSesion)
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
            if (sender == VistaMenu.btnAgregarEquipo)
            {
                //Permite abrir otra vez la vista si se cerro
                if (VistaEquipo == null || VistaEquipo.IsDisposed)
                {
                    VistaEquipo = new AgregarEquipo();
                }

                VistaEquipo.Show();
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.TablaEquipos();
                VistaEquipo.dtEquipos.DataSource = dataTable;
            }


            if(sender == VistaMenu.btnPronostico)
            {
                if(vistaPronostico == null|| vistaPronostico.IsDisposed)
                {
                    vistaPronostico = new Pronostico();
                }
                vistaPronostico.Show();
                modeloTablas datosLocal = new modeloTablas();
                DataTable dataTable = datosLocal.mostrarTablaLocal();
                vistaPronostico.dtLocal.DataSource = dataTable;

                modeloTablas datosVisitante = new modeloTablas();
                DataTable dataTable2 = datosVisitante.mostrarTablaVisitante();
                vistaPronostico.dtVisitante.DataSource = dataTable2;

                modeloTablas datosFecha = new modeloTablas();
                DataTable dataTable3 = datosFecha.mostrarTablaFechas();
                vistaPronostico.dtFecha.DataSource = dataTable3;

            }

            if (sender == VistaMenu.btnAgregarUsuario)
            {
                //Permite abrir otra vez la vista si se cerro
                if (VistaUsuario == null || VistaUsuario.IsDisposed)
                {
                    VistaUsuario = new AgregarUsuario();
                }
                VistaUsuario.Show();
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.CargarUsuarios();
                VistaUsuario.dtUsuarios.DataSource = dataTable;

            }

            if(sender == VistaUsuario.btnAgregarUsuario)
            {
                DialogResult result = MessageBox.Show("¿Quieres agregar un nuevo usuario?", "Confirmación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    procesosSQL.AgregarUsuario(VistaUsuario.txtUsuario.Text);
                    modeloTablas datos = new modeloTablas();
                    DataTable dataTable = datos.CargarUsuarios();
                    VistaUsuario.dtUsuarios.DataSource = dataTable;


                }
                else
                {

                }
            }

            if (sender == VistaMenu.btnAgregarPartido)
            {

                //Permite abrir otra vez la vista si se cerro
                if (VistaPartido == null || VistaPartido.IsDisposed)
                {
                    VistaPartido = new AgregarPartido();
                }

                VistaPartido.Show();
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.CargarPartidos();
                VistaPartido.dtPartidos.DataSource = dataTable;
            }

            if (sender == VistaPartido.btnAgregarPartido)
            {
                procesosSQL.AgregarPartido(VistaPartido.fechaPartido.Value, VistaPartido.txtLocal.Text, VistaPartido.txtVisitante.Text);
                modeloTablas datos = new modeloTablas();
                DataTable dataTable = datos.CargarPartidos();
                VistaPartido.dtPartidos.DataSource = dataTable;
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
