
using CapaNegocio.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class ClsCliente : ClsPersona
    {
        private String imagen;
        private String codigoCliente;

        public ClsCliente() { }
        
        //metodos get /set
        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }
        public String CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        //Referencia al Manejador de la capa de acceso a datos

       
        clsBaseDatos baseDatos = new clsBaseDatos();
        /// <summary>
        /// Los datos 
        /// El objeto Cliente llena con parámetros solicitados.
        /// El método retorna una lista de objetos donde los lleva a la capa de presentación y se le mostrará al usuario el DataGridView.
        /// </summary>
        /// <returns></returns>
        public override String registrar()
        {
            string msj = "";
            try
            {
              
                    SqlConnection conexion = baseDatos.abrir_conexion();


                    SqlCommand comannd = new SqlCommand();

                    comannd.Connection = conexion;
                    comannd.CommandText = "CLIENTEInsertCommand";
                    comannd.CommandType = System.Data.CommandType.StoredProcedure;

                    comannd.Parameters.AddWithValue("@cedula", Cedula); // a la variable de tip Mysql comand agregar un valor al parametro
                    comannd.Parameters.AddWithValue("@nombre", Nombre); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    comannd.Parameters.AddWithValue("@apellido", Apellido);
                    comannd.Parameters.AddWithValue("@edad",Edad);
                    comannd.Parameters.AddWithValue("@domicilio", Domicilio);
                    comannd.Parameters.AddWithValue("@sexo", Sexo);
                    comannd.Parameters.AddWithValue("@imagen", Imagen);
                    comannd.Parameters.AddWithValue("@codigoCliente",CodigoCliente);

                int t = Convert.ToInt32(comannd.ExecuteScalar()); // con esa linea executa el insert a la bd

                    baseDatos.cerrar_conexion(conexion);
                msj = "Se han registrado los datos exitosamete (BY: Arlette-Ram)";
            }
            catch (Exception ex)
            {
                msj = "Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los Datos de la cedula ya existen";
                Console.WriteLine(ex.Message);

            }


            return msj;
        }
        /// <summary>
        /// Los datos se obtienen de la base de datos por medio de los Stored procedure.
        /// El objeto Cliente llena con parámetros solicitados.
        /// El método retorna una lista de objetos donde los lleva a la capa de presentación y se le mostrará al usuario el DataGridView.
        /// </summary>
        /// <returns></returns>
        //Lista Cliente
        public override List<Object> listar()
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = baseDatos.abrir_conexion();

            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTESelectCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader registros = comannd.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.

            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    Id_Cliente = Int16.Parse(registros["Id_Cliente"].ToString()),
                    cedula = registros["Cedula"].ToString(),  // para asignar valores de la base a la variable cedula
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };

                lstCliente.Add(tmp);
            }
            baseDatos.cerrar_conexion(conexion);
            return lstCliente;

           
        }
        /// <summary>
        /// Los datos se obtienen de la base de datos por medio de los Stored procedure.
        /// El objeto cliente llena con parámetros solicitados.
        /// El método retorna una lista de objetos donde los lleva a la capa de presentación y se le mostrará al usuario el DataGridView según la cedula ingresada.
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public override List<Object> buscar(String cedula)
        {
            List<Object> lstCliente = new List<Object>();

            SqlConnection conexion = baseDatos.abrir_conexion();

            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTESelectindividualCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;
            comannd.Parameters.AddWithValue("@cedula", cedula);

            SqlDataReader registros = comannd.ExecuteReader();
            while (registros.Read())
            {
                var tmp = new
                {
                    Id_Cliente = Int16.Parse(registros["Id_Cliente"].ToString()),
                    cedula = registros["Cedula"].ToString(),
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    imagen = registros["Imagen"].ToString(),
                    codigoCliente = registros["CodigoCliente"].ToString(),
                };
                lstCliente.Add(tmp);
            }

            baseDatos.cerrar_conexion(conexion);
            return lstCliente;

        }
        /// <summary>
        /// Los datos se elimina el registro de la base de datos por medio de los Stored procedure
        /// Se toma el registro del daraGridView del cliente en la capa de presentación.
        /// El método recibe la cedula, ya que al ser un atributo único se elimina solo un registro en caso de que el cliente exista
        /// </summary>
        /// <returns></returns>
        public override void eliminar(String cedula)
        {
            try {
    
            if (buscar(cedula) != null)
            {
                SqlConnection conexion = baseDatos.abrir_conexion();

                SqlCommand comannd = new SqlCommand();

                comannd.Connection = conexion;
                comannd.CommandText = "CLIENTEDeleteCommand";
                comannd.CommandType = System.Data.CommandType.StoredProcedure;

                comannd.Parameters.AddWithValue("@Original_Cedula", cedula);

           
            int resultado = Convert.ToInt32(comannd.ExecuteScalar());



                MessageBox.Show("Se a eliminado con exito");
                baseDatos.cerrar_conexion(conexion);
            }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        /// <summary>
        /// Los datos se obtienen de la base de datos por medio de los Stored procedure y se muestra en el formulario "frmActualizarCliente"
        /// El objeto Cliente llena con parámetros solicitados.
        /// El método retorna un valor entero que indica el número de elementos que han sido modificados.
        /// </summary>
        /// <returns></returns>
        /// 
        public override int actualizar_x_cedula()
        {


            SqlConnection conexion = baseDatos.abrir_conexion();
            SqlCommand comannd = new SqlCommand();

            comannd.Connection = conexion;
            comannd.CommandText = "CLIENTEUpdateCommand";
            comannd.CommandType = System.Data.CommandType.StoredProcedure;

            comannd.Parameters.AddWithValue("@Cedula", Cedula);
            comannd.Parameters.AddWithValue("@Nombre", Nombre);
            comannd.Parameters.AddWithValue("@Apellido", Apellido);
            comannd.Parameters.AddWithValue("@Edad", Edad);
            comannd.Parameters.AddWithValue("@Domicilio", Domicilio);
            comannd.Parameters.AddWithValue("@Sexo", Sexo);
            comannd.Parameters.AddWithValue("@Imagen", Imagen);
            comannd.Parameters.AddWithValue("@CodigoCliente", CodigoCliente);

            int resultado_operacion = Convert.ToInt32(comannd.ExecuteScalar());
            baseDatos.cerrar_conexion(conexion);

            return resultado_operacion;


        }
    
    }
}
