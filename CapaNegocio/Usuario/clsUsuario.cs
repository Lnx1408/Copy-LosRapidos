using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.ConexionBD;

namespace CapaNegocio.Usuario
{
    public class clsUsuario
    {
        String nombre;
        String apellido;
        String cedula;
        String usuario;
        String password;
        Byte[] rutaImagen;


        /* Constructor*/
        public clsUsuario()
        {

        }
        
        /* ----COMENTARIO DE PRUEBA -----*/


        /* --------------- Getters y Setters XD ------------------------- */
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public String Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        public Byte[] RutaImagen
        {
            get { return rutaImagen; }
            set { rutaImagen = value; }
        }

        clsBaseDatos baseDatos = new clsBaseDatos();


        /* ----------------------- Registro de usuario ------------------------- */
        /// <summary>
        /// Método para registrar al usuario que va a interactuar con el sistema
        /// </summary>
        /// <returns>Un objeto tipo Tuple con dos tipos de datos, una cadena de caracteres y otro booleano, para mostrar un mensaje y para verificar si el acceso fue exitoso o no</returns>
        public Tuple<String, bool> registrarUsuario()
        {
            String mensaje = "";
            bool ingreso = false;
            try
            {
                SqlConnection conexionAbierta = baseDatos.abrir_conexion();
                SqlCommand command = new SqlCommand();
                command.Connection = conexionAbierta;

                command.CommandText = "UsuarioInsertCommand";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //valores para cada parámetro dado en el query
                command.Parameters.AddWithValue("@Nombre", Nombre);
                command.Parameters.AddWithValue("@Apellido", Apellido);
                command.Parameters.AddWithValue("@Cedula", Cedula);
                command.Parameters.AddWithValue("@NombreUsuario", Usuario);
                command.Parameters.AddWithValue("@Password", Password);
                command.Parameters.AddWithValue("@Foto", RutaImagen);

                int t = Convert.ToInt32(command.ExecuteNonQuery());
                mensaje = "Usuario registrado con éxito";
                ingreso = true;
                baseDatos.cerrar_conexion(conexionAbierta);
            }
            catch (SqlException ex)
            {
                mensaje = "Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los datos ingresados ya existen";
                Console.WriteLine(ex.Message);
            }
            return Tuple.Create(mensaje, ingreso);
        }
    }




}
