using Microsoft.VisualStudio.TestTools.UnitTesting;
using EstatisticasAPI.Models;

namespace EstasticasTest
{
    [TestClass]
    public class ModaTest
    {
        [TestMethod]
        public void TestModa()
        {
            Moda moda = new Moda();
            string valores = "4 2 2 4 2";
            double resultado = moda.CalcularModa(valores);
            double esperado = 2;
            Assert.AreEqual(esperado, resultado);
        }
    }
}