using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalmeralGenNHibernate.CEN.Default_;
using PalmeralGenNHibernate.EN.Default_;

namespace LimpiezasPalmeralTest
{
    [TestClass]
    public class InstalacionTest
    {
        private InstalacionCEN _instTest;

        [TestInitialize]
        public void Initialize()
        {
            _instTest = new InstalacionCEN();
        }

        [TestMethod]
        public void Alta()
        {
            string expected = _instTest.Crear("10","nombretest","desctest","locatest","provtest","paistest","dirtest","cptest",
                "tlfnotest",2,"clientetest");
            Assert.AreEqual("10", expected);
        }

        [TestMethod]
        public void Obtener()
        {
            InstalacionEN expected = _instTest.ObtenerInstalacion("1");
            string actual = "Monti SA";
            Assert.AreEqual(actual, expected.Nombre);
        }

        [TestCleanup]
        public void Disconnect()
        {
            _instTest = null;
        }
    }
}
