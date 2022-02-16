using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using CapaPresentacion;
using CapaPresentacion.Login;
using CapaNegocio;
using CapaNegocio.Usuario;
using CapaPresentacion.Usuario;

namespace UnitTestMSTest
{
    /// <summary>
    /// Aquí se hará la prueba de búsqueda de un Conductor que no existe
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        frmLogin logearse = new frmLogin();
        ClsConductores chofer = new ClsConductores();
        bool resultado;

        [TestMethod]
        public void loguearse()
        {
            resultado = logearse.login("s", "1"); //Coloca aquí el usuario y contraseña que tengas guardado en tu máquina
            Assert.AreEqual(true, resultado);
        }


        [TestMethod]
        public void buscarConductor() 
        {
            List<Object> lista = new List<object>();
            lista = chofer.buscar("0944381632"); //Colocar aquí la cédula que se desea buscar
            Assert.AreEqual(1, lista.Count);
        }

    }
}
