using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login(txtUser.Text,txtPassword.Text);
        }
        private SqlConnection abrirConexionSqlServer()
        {
            SqlConnection conexion = new SqlConnection();
            try
            {
                String stringConexion = "server = localhost; database = LosRapidosSAbd; integrated security = true";
                conexion.ConnectionString = stringConexion;
                conexion.Open();
                Console.WriteLine("Se ha abierto la conexión con la base de datos de Sql Server");

            }
            catch (SqlException e)
            {
                MessageBox.Show("No se ha podido establecer conexión con la base de datos, error: " + e);
            }
            return conexion;
        }

        private SqlConnection cerrarConexionSqlServer(SqlConnection conexion)
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Se ha cerrado la conexión con la base de datos Sql Server");
            }
            catch (SqlException e)
            {
                MessageBox.Show("No se ha podido cerrar la conexión con la base de datos Sql Server, error: " + e);
            }
            return conexion;
        }

        public void login(string user, string password)
        {
            try
            {
            SqlConnection conexion = abrirConexionSqlServer();
            String cadena = ("SELECT usuario, password FROM  datos WHERE usuario = " +user+ "AND password = " +password);
            SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                if (registros.Read())
                {
                    MessageBox.Show("usuario encontrado");
                }
                else
                {
                    MessageBox.Show("usuario no encontrado");
                }
                cerrarConexionSqlServer(conexion);
                } catch (SqlException e)
            {
                MessageBox.Show(" " + e);
            }
        }
    }



}
