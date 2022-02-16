using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.ConexionBD
{
    class clsBaseDatos
    {
        private SqlConnection conexion;

        /// <summary>
        /// Permite establecer una conexión con la base de datos local
        /// </summary>
        /// <returns>Una variable de tipo de dato SqlConnection con el estado de la conexión.</returns>
        public SqlConnection abrir_conexion()
        {
            try
            {
                string ConnectionString = "server = localhost; database = LosRapidosSAbd; integrated security = true  ";

                conexion = new SqlConnection(ConnectionString);
                conexion.Open();

                Console.WriteLine("Se abrio la conexion desde la capa de acceso a datos");

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return conexion;
        }

        /// <summary>
        /// Método para cerrar la conexión a la base de datos.
        /// </summary>
        /// <param name="conexion">Estado de la conexión de la base de datos.</param>
        public void cerrar_conexion(SqlConnection conexion)
        {
            conexion.Close();
            Console.WriteLine("Se cerro la conexion desde la capa de acceso a datos");
        }

    }
}
