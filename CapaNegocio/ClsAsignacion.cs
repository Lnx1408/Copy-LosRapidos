
using CapaNegocio.ConexionBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsAsignacion
    {
        protected Int16 Id_AmbulanciaAsignacion;
        protected Int16 Id_ConductorAsignacion;


        private List<Object> lst_obj;
        //ClsManejadorAmbulancia M = new ClsManejadorAmbulancia();

        public ClsAsignacion() { }
        public ClsAsignacion(Int16 Id_AmbulanciaAsignacion, Int16 Id_ConductorAsignacion)
        {
            this.Id_AmbulanciaAsignacion = Id_AmbulanciaAsignacion;
            this.Id_ConductorAsignacion = Id_ConductorAsignacion;
            
        }

        //Getter and Setter fields
        public Int16 ID_AmbulanciaAsignacion
        {
            get { return Id_AmbulanciaAsignacion; }
            set { Id_AmbulanciaAsignacion = value; }
        }

        public Int16 ID_ConductorAsignacion
        {
            get { return Id_ConductorAsignacion; }
            set { Id_ConductorAsignacion = value; }
        }

        clsBaseDatos baseDatos = new clsBaseDatos();


        public String registrar()
        {
            string msj = "";

            try
            {
             
                    SqlConnection conexion = baseDatos.abrir_conexion();

                    SqlCommand command = new SqlCommand();

                    command.Connection = conexion;

                    command.CommandText = "AsignacionInsertCommand";
                    command.CommandType = System.Data.CommandType.StoredProcedure;


                    command.Parameters.AddWithValue("@Id_AmbulanciaAsignacion", ID_AmbulanciaAsignacion); // a la variable de tip Mysql comand agregar un valor al parametro
                    command.Parameters.AddWithValue("@Id_ConductorAsignacion", ID_ConductorAsignacion); // Parametro a remplazar en la cadena de conxion o insert , con lo que venga de la capa logica



                    int t = Convert.ToInt32(command.ExecuteScalar()); // con esa linea executa el insert a la bd
                    baseDatos.cerrar_conexion(conexion);
                    msj = "Asignación registrada con éxito";
            }
            catch (Exception ex)
            {
                msj = "Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los datos ya existen";
                Console.WriteLine(ex.Message);

            }
            return msj;

        }

    }
}
