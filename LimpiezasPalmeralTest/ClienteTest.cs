using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralTest
{
    [TestClass]
    public class ClienteTest
    {
        private ClienteCEN clienteTest;

        [TestInitialize]
        public void TestMethod1()
        {
            clienteTest = new ClienteCEN();
        }

        [TestMethod]
        public void Cli_Registrar()
        {
            string expected = clienteTest.Crear("99999999Z", "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
            clienteTest.Eliminar("99999999Z");
            Assert.AreEqual("99999999Z", expected);
        }

        [TestMethod]
        public void Cli_RegistarError()
        {
            try
            {
                clienteTest.Crear("99999999Z", "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
                string expected = clienteTest.Crear("99999999Z", "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
                clienteTest.Eliminar("99999999Z");
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in ClienteCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        public void Cli_Consultar()
        {
            ClienteEN expected = clienteTest.ObtenerCliente("99999999Z");
            string actual = "Cliente";
            Assert.AreEqual(actual, expected.Nombre);
        }

        [TestMethod]
        public void Cli_ConsultarError()
        {
            try
            {
                ClienteEN expected = clienteTest.ObtenerCliente(null);
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in ClienteCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestCleanup]
        public void Disconnect()
        {

            clienteTest = null;
        }
    }
}
