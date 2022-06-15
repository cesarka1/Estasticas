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
            string[] valores = {"3", "10", "2", "7"};
            double resultado = mediana.CalcularMediana(valores);
            double esperado = 5;
            Assert.AreEqual(esperado, resultado);
        }
    }
}