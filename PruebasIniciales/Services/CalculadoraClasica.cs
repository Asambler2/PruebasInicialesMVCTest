namespace PruebasIniciales.Services
{
    public class CalculadoraClasica : ICalculadora
    {
        public double Division(int num1, int num2)
        {
            return num1 / num2;
        }

        public double Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }

        public double Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public double Suma(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
