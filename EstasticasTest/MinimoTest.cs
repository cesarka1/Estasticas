using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticasAPI.Models;

namespace EstasticasTest
{
    [TestClass]
    public class MinimoTest
    {
        [TestMethod]
        public void TestMinino()
        {
            Minimo minimo = new Minimo();
            string valores = "4 5 2 7 1";
            double resultado = minimo.EcontrarMinimo(valores);
            double esperado = 1;
            Assert.AreEqual(esperado, resultado);
        }
    }
}