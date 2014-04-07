using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralTest
{
    [TestClass]
    public class TrabajadorTest
    {
        private TrabajadorCEN _traTest;

        [TestInitialize]
        public void Initialize()
        {
            _traTest = new TrabajadorCEN();
        }

        [TestMethod]
        public void Tra_DarAlta()
        {
            string expected = _traTest.Crear("15424150M", "trabajador", "martinez", "calle test", "964821023",
                "03400", "España", "Villena", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
            _traTest.Eliminar("15424150M");
            Assert.AreEqual("15424150M", expected);
        }

        [TestMethod]
        public void Tra_DarAltaError()
        {
            try
            {
                 _traTest.Crear("11111111A", "trabajador", "martinez", "calle test", "964821023",
                "03400", "España", "Villena", "Alicante", PalmeralGenNHibernate.Enumerated.Default_.TipoEmpleoEnum.Empleado);
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in TrabajadorCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestMethod]
        public void Tra_Consultar()
        {
            TrabajadorEN expected = _traTest.ObtenerTrabajador("11111111A");
            string actual = "Trabajador 1";
            Assert.AreEqual(actual, expected.Nombre);
        }

        [TestMethod]
        public void Tra_ConsultarError()
        {
            try
            {
                _traTest.ObtenerTrabajador(null);
                Assert.Fail("Excepcion no lanzada");
            }
            catch (PalmeralGenNHibernate.Exceptions.DataLayerException ex)
            {
                string expected = "Error in TrabajadorCAD.";
                Assert.AreEqual(ex.Message, expected);
            }
        }

        [TestCleanup]
        public void Disconnect()
        {
            _traTest = null;
        }
    }
}
