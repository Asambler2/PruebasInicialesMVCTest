using CalculadorMatematico.Services;

namespace CalculoTest
{
    [TestClass]
    public class TestCalculo
    {
        Calculo MiCalculo = new Calculo();
        [TestMethod]
        public void TestMaximoComunDivisor()
        {
            var resultado = MiCalculo.MaximoComunDivisor(24, 36);
            Assert.AreEqual(resultado, 12);
        }
        [TestMethod]
        public void TestMinimoComunMultiplo()
        {
            var resultado = MiCalculo.MinimoComunMultiplo(8, 6);
            Assert.AreEqual(resultado, 24);
        }
    }
}