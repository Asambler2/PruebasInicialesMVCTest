using Concatenador.Servicies;

namespace TestConcatenador
{
    [TestClass]
    public class ConcatenadorTest
    {
        ConcatenadorClase MiConcatenador = new ConcatenadorClase();
        [TestMethod]
        public void TestConcatenarCadena()
        {
            var resultado = MiConcatenador.ConcaternaCadena("Patata", "Brava");
            Assert.AreEqual(resultado, "PatataBrava");
        }
        [TestMethod]
        public void TestCuenta()
        {
            var resultado = MiConcatenador.Cuenta("Patata", "Brava");
            Assert.AreEqual(resultado, 1);
        }
    }
}