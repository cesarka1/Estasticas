using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticasAPI.Models;

namespace EstasticasTest
{
    [TestClass]
    public class MedianaTest
    {
        [TestMethod]
        public void TestMediana()
        {
            Mediana mediana = new Mediana();
            string valores = "4 5 2 7 1";
            double resultado = mediana.CalcularMediana(valores);
            double esperado = 4;
            Assert.AreEqual(esperado, resultado);
        }
    }
}