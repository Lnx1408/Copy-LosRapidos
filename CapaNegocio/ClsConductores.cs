using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaNegocio.ConexionBD;
using System.Data.SqlClient;
using System.Windows.Forms;

/// <summary>
/// Esta clase contiene todos los métodos y parámetros necesarios para la gestión de datos de conductores
/// </summary>

namespace CapaNegocio
{
    public class ClsConductores : ClsPersona
    {

        /// <summary>
        /// Parámetros heredados y propios de la clase
        /// </summary>
        private String licencia;
        clsBaseDatos conexionBD = new clsBaseDatos(); //Con esta instancia podemos llamar a los métodos que permiten la conexión con la BD

        public ClsConductores(){}

        //Constructor, get, set
        public ClsConductores(String cedula, String nombre, String apellido, Int16 edad, String domicilio, String sexo, String licencia) : base(cedula, nombre, apellido, edad, domicilio, sexo)
        {
            this.licencia = licencia;
        }
        public string Licencia { get => licencia; set => licencia = value; }
        //Fin de constructor, get, set


        //Realiza la inserción de datos de un conductor y los almacena en la BD
        public override String registrar()
        {
            string msj = "";
            
            List<ClsConductores> lst = new List<ClsConductores>();

            try
            {
                lst.Add(new ClsConductores(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia));
                SqlConnection conexion = conexionBD.abrir_conexion();

                SqlCommand comannd = new SqlCommand
                {
                    Connection = conexion,
                    CommandText = "CONDUCTORInsertCommand",
                    CommandType = System.Data.CommandType.StoredProcedure
                };

                comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula);      //@cedula = campo vacio de referencia que se va a llenar con algún dato
                comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre);     // lst[0].Cedula = dato con el que llenaremos el campo de referencia, proviene de...
                comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);//...la lista creada en la CapaNegocio
                comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                comannd.Parameters.AddWithValue("@licencia", lst[0].Licencia);

                int t = Convert.ToInt32(comannd.ExecuteScalar()); // Ejecuta el insert
                conexionBD.cerrar_conexion(conexion);

                msj = "Insertado correctamente";

            }
            catch (Exception ex)
            {
                msj = "Error al insertar los datos, motivo: " +ex;
                return msj;
            }

            return msj;
        }


        //Mediante el parámetro cédula, busca el conductor objetivo y devuelve todos sus datos a la interfaz en cuestión
        public override List<Object> buscar(String cedula)
        {
            List<Object> lstConductor = new List<Object>();
            SqlConnection conexion = conexionBD.abrir_conexion();

            SqlCommand comando = new SqlCommand
            {
                Connection = conexion,
                CommandText = "CONDUCTORSelectByCedulaCommand",
                CommandType = System.Data.CommandType.StoredProcedure
            };

            comando.Parameters.AddWithValue("@cedula", cedula);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                var tmp = new
                {
                    id_conductor = Int16.Parse(registros["Id_Conductor"].ToString()),
                    cedula = registros["Cedula"].ToString(),
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    licencia = registros["Licencia"].ToString(),
                };

                lstConductor.Add(tmp);
            }

            conexionBD.cerrar_conexion(conexion);
            return lstConductor;
        }


        //Mediante el parámetro cédula, realiza una búsqueda y elimina el registro completo si es que lo encuentra
        public override void eliminar(String cedula)
        {
            if (buscar(cedula).Count != 0)
            {
                try
                {
                    SqlConnection conexion = conexionBD.abrir_conexion();
                    SqlCommand command = new SqlCommand
                    {
                        Connection = conexion,
                        CommandText = "CONDUCTORDeleteCommand",
                        CommandType = System.Data.CommandType.StoredProcedure
                    };

                    command.Parameters.AddWithValue("@cedula", cedula);
                    int resultado = Convert.ToInt32(command.ExecuteScalar());
                    conexionBD.cerrar_conexion(conexion);
                    MessageBox.Show("Eliminado exitosamente");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al eliminar, motivo: " + e);
                }
            }
            else
            {
                MessageBox.Show("Cédula no registrada");
            }
        }


        //Muestra a todos los conductores registrados en la BD
        public override List<Object> listar()
        {
            List<Object> lstConductor = new List<Object>();
            SqlConnection conexion = conexionBD.abrir_conexion();
            SqlCommand comannd = new SqlCommand
            {
                Connection = conexion,
                CommandText = "CONDUCTORSelectCommand",
                CommandType = System.Data.CommandType.StoredProcedure
            };
            SqlDataReader registros = comannd.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
            while (registros.Read())  // leo la informacion almacenada en registro
            {
                var tmp = new
                {
                    cedula = registros["Cedula"].ToString(),  // para asignar valores de la base a la variable cedula
                    nombre = registros["Nombre"].ToString(),
                    apellido = registros["Apellido"].ToString(),
                    edad = Int16.Parse(registros["Edad"].ToString()),
                    domicilio = registros["Domicilio"].ToString(),
                    sexo = registros["Sexo"].ToString(),
                    licencia = registros["Licencia"].ToString(),
                };

                lstConductor.Add(tmp);
            }
            conexionBD.cerrar_conexion(conexion);
            return lstConductor;
        }


        //Mediante el parámetro cédula se realiza  la búsqueda de un conductor y permite la edición de los mismos para actualizarlos
        public override int actualizar_x_cedula()
        {
            
            List<ClsConductores> lst = new List<ClsConductores>();

            try
            {
                //Pasar los parámetros hacia la capa de acceso a datos
                lst.Add(new ClsConductores(Cedula, Nombre, Apellido, Edad, Domicilio, Sexo, Licencia));
                
                    if (lst != null)
                    {
                        SqlConnection conexion = conexionBD.abrir_conexion();

                        SqlCommand comannd = new SqlCommand
                        {
                            Connection = conexion,
                            CommandText = "CONDUCTORUpdateCommand",
                            CommandType = System.Data.CommandType.StoredProcedure
                        };

                        comannd.Parameters.AddWithValue("@cedula", lst[0].Cedula);      //@cedula = campo vacio de referencia que se va a llenar con algún dato
                        comannd.Parameters.AddWithValue("@nombre", lst[0].Nombre);     // lst[0].Cedula = dato con el que llenaremos el campo de referencia, proviene de...
                        comannd.Parameters.AddWithValue("@apellido", lst[0].Apellido);//...la lista creada en la CapaNegocio
                        comannd.Parameters.AddWithValue("@edad", lst[0].Edad);
                        comannd.Parameters.AddWithValue("@domicilio", lst[0].Domicilio);
                        comannd.Parameters.AddWithValue("@sexo", lst[0].Sexo);
                        comannd.Parameters.AddWithValue("@licencia", lst[0].Licencia);

                        comannd.ExecuteNonQuery(); //Ejecuta el update

                        conexionBD.cerrar_conexion(conexion);
                        return 1;
                    }
            }
            catch (Exception e)
            {
                return 0;
                throw e;
            }

            return 2;
        }
           

            
    }//fin de clase
}//fin de namespace

