
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
    public class ClsAmbulancia
    {
        protected String modelo;
        protected String tipoAmbulancia;  //Asistenciales, no asistenciales.
        protected String placa;
        protected String matricula;
    

        private List<Object> lst_obj;
        //ClsManejadorAmbulancia M = new ClsManejadorAmbulancia();

        public ClsAmbulancia() { }
        public ClsAmbulancia(String modelo, String tipoAmbulancia,String placa, String matricula)
        {
            this.modelo = modelo;
            this.tipoAmbulancia = tipoAmbulancia;
            this.placa = placa;
            this.matricula = matricula;
  
         
        }

        //Getter and Setter fields
        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public String TipoAmbulancia
        {
            get { return tipoAmbulancia; }
            set { tipoAmbulancia = value; }
        }

        public String Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public String Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }


        clsBaseDatos baseDatos = new clsBaseDatos();

        /// <summary>
        /// Los datos se obtienen de la capa de precentación por medio de los getters & setters de Ambulancia
        /// El objeto Amblulancia tiene parámetros: Modelo, TipoAmbulancia, Placa, Matricula
        /// El método retorna una cadena de caracteres donde lleva un mensaje a la capa de presentación y se le mostrará al usuario el resultado de la operación
        /// </summary>
        /// <returns></returns>
        public String registrar()
        {
            string msj = "";

            try
            {
           
                    SqlConnection conexion = baseDatos.abrir_conexion();


                    SqlCommand command = new SqlCommand();

                    command.Connection = conexion;

                    command.CommandText = "ambInsertCommand";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@modelo", Modelo); // a la variable de tip Mysql comand agregar un valor al parametro
                    command.Parameters.AddWithValue("@tipoAmbulancia",TipoAmbulancia); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica
                    command.Parameters.AddWithValue("@placa", Placa);
                    command.Parameters.AddWithValue("@matricula", Matricula);


                    int t = Convert.ToInt32(command.ExecuteScalar()); // con esa linea executa el insert a la bd
                    baseDatos.cerrar_conexion(conexion);
                   msj = "Ambulancia registrada con éxito";
                
            }
            catch (Exception ex)
            {

                msj = "Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los datos de la placa o matricula ya existen";
                Console.WriteLine(ex.Message);

            }

            return msj;
        }

        /// <summary>
        /// Los datos se obtienen de la base de datos por medio de los Stored procedure
        /// El objeto Amblulancia llena con parámetros: Id_ambulanci Modelo, TipoAmbulancia, Placa, Matricula
        /// El método retorna una lista de objetos donde los lleva a la capa de presentación y se le mostrará al usuario el DataGridView
        /// </summary>
        /// <returns></returns>

        public List<Object> listar()
        {
            List<Object> lstAmbulancia = new List<Object>();

            try
            {
                SqlConnection conexion = baseDatos.abrir_conexion();

                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "ambSelectCommand";
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader registros = command.ExecuteReader(); // lo usamos porque requerimos que la base nos devuelva algo todo esa info llega a la variable registros.
                while (registros.Read())  // leo la informacion almacenada en registro
                {
                    var tmp = new
                    {
                        Id_Ambulancia = Int16.Parse(registros["Id_Ambulancia"].ToString()),
                        modelo = registros["modelo"].ToString(),  // para asignar valores de la base a la variable cedula
                        tipoAmbulancia = registros["tipoAmbulancia"].ToString(),
                        placa = registros["placa"].ToString(),
                        matricula = registros["matricula"].ToString(),

                    };
                    lstAmbulancia.Add(tmp);
                }
                baseDatos.cerrar_conexion(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lstAmbulancia;
        }


        /// <summary>
        /// Los datos se obtienen de la base de datos por medio de los Stored procedure
        /// El objeto Amblulancia llena con parámetros: Id_ambulanci Modelo, TipoAmbulancia, Placa, Matricula
        /// El método retorna una lista de objetos donde los lleva a la capa de presentación y se le mostrará al usuario el DataGridView según la placa ingresada
        /// </summary>
        /// <returns></returns>
        /// 
        public List<Object> buscar(String placa)
        {
            List<Object> lstAmbulancia = new List<Object>();

            try
            {
                SqlConnection conexion = baseDatos.abrir_conexion();
                SqlCommand command = new SqlCommand();
                command.Connection = conexion;
                command.CommandText = "ambSelectindividualCommand";
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@placa", placa);

                SqlDataReader registros = command.ExecuteReader();
                while (registros.Read())
                {
                    var tmp = new
                    {
                        Id_Ambulancia = Int16.Parse(registros["Id_Ambulancia"].ToString()),
                        modelo = registros["modelo"].ToString(),
                        tipoAmbulancia = registros["tipoAmbulancia"].ToString(),
                        placa = registros["placa"].ToString(),
                        matricula = registros["matricula"].ToString(),
                    };
                    lstAmbulancia.Add(tmp);
                }
                baseDatos.cerrar_conexion(conexion);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lstAmbulancia;
        }

        /// <summary>
        /// Los datos se elimina el registro de la base de datos por medio de los Stored procedure
        /// Se toma el registro del daraGridView de la ambulancia en la capa de presentación.
        /// El método recibe una placa, ya que al ser un atributo único se elimina solo un registro en caso de que la cédula exista
        /// </summary>
        /// <returns></returns>

        public void eliminar(String placa)
        {
            try {
                if (buscar(placa) != null)
                {
                    SqlConnection conexion = baseDatos.abrir_conexion();
                    SqlCommand command = new SqlCommand();
                    command.Connection = conexion;
                    command.CommandText = "AmbDeleteCommand";
                    command.CommandType = System.Data.CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Original_placa", placa);
                    int resultado = Convert.ToInt32(command.ExecuteScalar());

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
        /// Los datos se obtienen de la base de datos por medio de los Stored procedure y se muestra en el formulario "frmActualizarAmbulancia"
        /// El objeto Amblulancia llena con parámetros: Id_ambulanci Modelo, TipoAmbulancia, Placa, Matricula.
        /// El método retorna un valor entero que indica el número de elementos que han sido modificados.
        /// </summary>
        /// <returns></returns>
        /// 
        public int actualizar_x_placa()
        {


            SqlConnection conexion = baseDatos.abrir_conexion();
            SqlCommand command = new SqlCommand();

            command.Connection = conexion;
            command.CommandText = "ambUpdateCommand";
            command.CommandType = System.Data.CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@modelo", Modelo);
            command.Parameters.AddWithValue("@tipoAmbulancia", TipoAmbulancia);
            command.Parameters.AddWithValue("@placa", Placa);
            command.Parameters.AddWithValue("@matricula", Matricula);

            int resultado_operacion = Convert.ToInt32(command.ExecuteScalar());
            baseDatos.cerrar_conexion(conexion);


            return resultado_operacion;
        }
    }

}

