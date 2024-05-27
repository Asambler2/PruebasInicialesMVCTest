using PruebasIniciales.Services;

namespace TestProject1
{
    
    [TestClass]
    public class CalculadoraClasicaTest
    {
        public CalculadoraClasica MiCalculadora = new CalculadoraClasica();
        [TestMethod]
        public void Division()
        {
            var resultado = MiCalculadora.Division(10, 5);
            Assert.IsTrue(resultado == 2);
        }
        [TestMethod]
        public void Multiplicacion()
        {
            var resultado = MiCalculadora.Multiplicacion(10, 5);
            Assert.IsNotNull(resultado);
            Assert.IsTrue(resultado > 10);
            Assert.AreEqual(resultado, 50);
        }
        [TestMethod]
        public void Resta()
        {
            var resultado = MiCalculadora.Resta(10, 5);
            Assert.AreEqual(resultado, 5); ;
        }
        [TestMethod]
        public void Suma()
        {
            var resultado = MiCalculadora.Suma(10, 5);
            Assert.AreEqual(resultado, 15);
        }
    }
}