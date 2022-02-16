using CapaPresentacion.Login;
using CapaPresentacion.Usuario;
using CapaNegocio.Usuario;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace UnitTestMSTest
{
    [TestClass]
    public class UnitTest1
    {
        frmLogin frmLogin = new frmLogin();
        frmRegistrarUsuario registrarUsuario = new frmRegistrarUsuario();
        clsUsuario usuario = new clsUsuario();

        [TestMethod]
        public void TestLoginTrue()
        {
            // Los parámetros pasados están registrados en la base de datos, por lo tanto el resultado es correcto
            bool ResultadoLoguin = frmLogin.login("lino", "Qwert12345#");
            Assert.AreEqual(true, ResultadoLoguin);
        }
        [TestMethod]
        public void TestLoguinFalse()
        {
            // Los parámetros pasados no están registrados en la base de datos, por lo tanto el resultado del método "login" es falso,
            // pero como se compara un caso de usuario inexistente, entonces la prueba es exitosa 
            bool ResultadoLoguin = frmLogin.login("usuario", "12345");
            Assert.AreEqual(false, ResultadoLoguin);
        }


        [TestMethod]
        public void TestRegistroUsuario()
        {
            usuario.Nombre = "Jaime";
            usuario.Apellido = "Altozano";
            usuario.Cedula = "0945654335";
            usuario.Usuario = "JaimeA";
            usuario.Password = "Asdf123#";
            //Método usado para convertir la imagen ingresada en tipo de dato Byte
            //Agrega una imagen por defecto cuando no se pasa un archivo
            registrarUsuario.validarImagen("");
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            usuario.RutaImagen = ms.GetBuffer();

            String ResutadoRegistro = registrarUsuario.RegistrarUsuario(usuario);
            Assert.AreEqual("Usuario registrado con éxito", ResutadoRegistro);
        }

        [TestMethod]
        public void TestNoRegistrarUsuarioExistente()
        {
            usuario.Nombre = "Jaime";
            usuario.Apellido = "Altozano";
            usuario.Cedula = "0945654335";
            usuario.Usuario = "JaimeA";
            usuario.Password = "Asdf123#";
            registrarUsuario.validarImagen("");
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            usuario.RutaImagen = ms.GetBuffer();

            String ResutadoRegistro = registrarUsuario.RegistrarUsuario(usuario);

            Assert.AreEqual("Motivos de error:\n\n- No se puede acceder a la base de datos\n- Los datos ingresados ya existen", ResutadoRegistro);
        }

    }
}
