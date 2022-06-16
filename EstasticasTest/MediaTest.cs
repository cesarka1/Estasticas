using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticasAPI.Models;

namespace EstasticasTest
{
    [TestClass]
    public class MediaTest
    {
        [TestMethod]
        public void TestMedia()
        {
            Media media = new Media();
            string valores = "1 2 3 4 5 6 7 8 9";
            double resultado = media.CalcularMedia(valores);
            double esperado = 5;
            Assert.AreEqual(esperado, resultado);
        }
    }
}