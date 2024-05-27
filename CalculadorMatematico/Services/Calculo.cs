namespace CalculadorMatematico.Services
{
    public class Calculo : ICalculo
    {
        public int MaximoComunDivisor(int num1, int num2)
        {
            for(int divisor = num1 -1; divisor > 1; divisor--)
            {
                if (num1 % divisor == 0 && num2 % divisor == 0) return divisor;
            }
            return 1;
        }

        public int MinimoComunMultiplo(int num1, int num2)
        {
            for (int multiplo = num1 + 1; multiplo > num1; multiplo++)
            {
                if(multiplo % num1 == 0 && multiplo % num2 == 0)return multiplo;
            }
            return 0;
        }
    }
}
