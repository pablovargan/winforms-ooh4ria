using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralTest
{
    [TestClass]
    public class ProductoTest
    {
        private ProductoCEN productoTest;

        [TestInitialize]
        public void TestMethod1()
        {
            productoTest = new ProductoCEN();
        }

        [TestMethod]
        public void Pro_Registrar()
        {
            string expected = productoTest.Crear("102", "Lejia", "limpiador automatico", 10, "tufoto.com");
            productoTest.Eliminar("102");
            Assert.AreEqual("102", expected);
        }

        [TestMethod]
        public void Pro_RegistarError()
        {
            try
            {
                productoTest.Crear("10", "Lejia", "limpiador automatico", 10, "tufoto.com");
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in ProductoCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        public void Pro_Consultar()
        {
            ProductoEN expected = productoTest.ObtenerProducto("10");
            string actual = "limpiador automatico";
            Assert.AreEqual(actual, expected.Descripcion);
        }

        [TestMethod]
        public void Pro_ConsultarError()
        {
            try
            {
                productoTest.ObtenerProducto(null);
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in ProductoCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestCleanup]
        public void Disconnect()
        {
            productoTest = null;
        }
    }
}
