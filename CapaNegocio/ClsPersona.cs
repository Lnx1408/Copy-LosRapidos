using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class ClsPersona
    {
        protected String cedula;
        protected String nombre;
        protected String apellido;
        protected Int16 edad;
        protected String domicilio;
        protected String sexo;
        private List<Object> lst_obj;

        public ClsPersona() { }

       public ClsPersona(String cedula, String nombre, String apellido, Int16 edad, String domicilio, String sexo)
        {
           this.cedula = cedula;
           this.nombre = nombre;
           this.apellido = apellido;
           this.edad = edad;
           this.domicilio = domicilio;
           this.sexo = sexo;

        }
        //metodos get /set
        public String Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

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
        public Int16 Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public String Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public String Sexo
        {

            get { return sexo; }
            set { sexo = value; }
        }

        //Métodos que pueden ser modificados por las clases hijos
        public virtual String registrar() { return ""; }
        public virtual List<Object> listar() { return lst_obj; }

        public virtual List<Object> buscar(String cedula) { return lst_obj; }
        public virtual void eliminar(String cedula) { }
        
        
        public virtual int actualizar_x_cedula()
        { return 0; }


    }
}
