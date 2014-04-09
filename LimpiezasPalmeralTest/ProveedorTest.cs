using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralTest
{
    [TestClass]
    public class ProveedorTest
    {
        private ProveedorCEN _provTest;

        [TestInitialize]
        public void Initialize()
        {
            _provTest = new ProveedorCEN();
        }

        [TestMethod]
        public void Prov_DarAlta()
        {
            string expected = _provTest.Crear("201", 
                "Proveedor 1", "123456789", "Calle", "Aspe", "Alicante", "09080", "email@gmail.com", "España", "oooo que chulo");
            _provTest.Eliminar("201");
            Assert.AreEqual("201", expected);
        }

        [TestMethod]
        public void Prov_DarAltaError()
        {
            try
            {
                _provTest.Crear("1",
                    "Proveedor 1", "123456789", "Calle", "Aspe", "Alicante", "09080", "email@gmail.com", "España", "oooo que chulo");
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in ProveedorCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        public void Prov_Consultar()
        {
            ProveedorEN expected = _provTest.ObtenerProveedor("1");
            string actual = "email@gmail.com";
            Assert.AreEqual(actual, expected.Email);
        }

        [TestMethod]
        public void Prov_ConsultarError()
        {
            try
            {
                _provTest.ObtenerProveedor(null);
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in ProveedorCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestCleanup]
        public void Disconnect()
        {
            _provTest = null;
        }
    }
}
