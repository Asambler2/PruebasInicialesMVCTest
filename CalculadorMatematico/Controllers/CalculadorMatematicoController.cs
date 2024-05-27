using CalculadorMatematico.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculadorMatematico.Controllers
{
    public class CalculadorMatematicoController : ControllerBase
    {
        ICalculo MiCalculo;
        public CalculadorMatematicoController(ICalculo miCalculo)
        {
            MiCalculo = miCalculo;
        }
        [HttpGet]
        [Route("MaximoComunDivisor/{num1:int}/{num2:int}")]
        public int MaximoComunDivisor(int num1, int num2)
        {
            return MiCalculo.MaximoComunDivisor(num1, num2);
        }
        [HttpGet]
        [Route("MinimoComunMultiplo/{num1:int}/{num2:int}")]
        public int MinimoComunMultiplo(int num1, int num2)
        {
            return MiCalculo.MinimoComunMultiplo(num1, num2);
        }

    }
}
