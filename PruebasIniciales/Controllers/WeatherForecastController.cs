using Microsoft.AspNetCore.Mvc;
using PruebasIniciales.Services;

namespace PruebasIniciales.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        
        private readonly ICalculadora   MiCalculadora;
        public WeatherForecastController(ICalculadora miCalculadora)
        {
            MiCalculadora = miCalculadora;
        }

        [HttpGet]
        [Route("getSuma/{num1:int}/{num2:int}")]
        public double GetSuma(int num1, int num2)
        {
           return MiCalculadora.Suma(num1, num2);
        }
        [HttpGet]
        [Route("getResta/{num1:int}/{num2:int}")]
        public double GetResta(int num1, int num2)
        {
            return MiCalculadora.Resta(num1, num2);
        }
        [HttpGet]
        [Route("getMultiplicacion/{num1:int}/{num2:int}")]
        public double GetMultiplicacion(int num1, int num2)
        {
            return MiCalculadora.Multiplicacion(num1, num2);
        }
        [HttpGet]
        [Route("getDivision/{num1:int}/{num2:int}")]
        public double GetDivision(int num1, int num2)
        {
            return MiCalculadora.Division(num1, num2);  
        }
    }
}
