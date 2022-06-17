using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticasAPI.Models;

namespace EstasticasTest
{
    [TestClass]
    public class MaximoTest
    {
        [TestMethod]
        public void TestMaximo()
        {
            Maximo maximo = new Maximo();
            string valores = "4 5 2 7 1";
            double resultado = maximo.EcontrarMaximo(valores);
            double esperado = 7;
            Assert.AreEqual(esperado, resultado);
        }
    }
}