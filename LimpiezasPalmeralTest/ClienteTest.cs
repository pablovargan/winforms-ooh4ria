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
        private string DNI = "99999999Z";

        [TestInitialize]
        public void TestMethod1()
        {
            clienteTest = new ClienteCEN();
            if (clienteTest.ObtenerCliente(DNI) != null)
                clienteTest.Eliminar(DNI);

        }

        [TestMethod]
        public void Cli_Registrar()
        {
            string expected = clienteTest.Crear(DNI, "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
            clienteTest.Eliminar(DNI);
            Assert.AreEqual(DNI, expected);
        }

        [TestMethod]
        public void Cli_RegistarError()
        {
            try
            {
                clienteTest.Crear(DNI, "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
                string expected = clienteTest.Crear(DNI, "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
                clienteTest.Eliminar(DNI);
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
            clienteTest.Crear(DNI, "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
            ClienteEN expected = clienteTest.ObtenerCliente(DNI);
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


        [TestMethod]
        public void Cli_Editar()
        {
            clienteTest.Crear(DNI, "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
            clienteTest.Editar(DNI, "ClienteEditado", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
            ClienteEN expected = clienteTest.ObtenerCliente(DNI);
            string actual = "ClienteEditado";
            Assert.AreEqual(actual, expected.Nombre);
        }

        [TestMethod]
        public void Cli_EditarError()
        {
            try
            {
                clienteTest.Editar("No existe", "Cliente", "Descripcion", "email@email.com", "Alicante", "Alicante", "España", "Calle", "03339", "665855458");
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
