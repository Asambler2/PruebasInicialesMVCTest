using Concatenador.Servicies;
using Microsoft.AspNetCore.Mvc;

namespace Concatenador.Controllers
{
    public class ConcatenadorController : ControllerBase
    {
        private readonly IConcatenador   MiConcatenador;
        public ConcatenadorController(IConcatenador MiConcatenador)
        {
            this.MiConcatenador = MiConcatenador;
        }

        [HttpGet]
        [Route("ConcatenarCadena/{cadena1}/{cadena2}")]
        public string ConcatenarCadena(string cadena1, string cadena2)
        {
           return MiConcatenador.ConcaternaCadena(cadena1, cadena2);
        }
        [HttpGet]
        [Route("Cuenta/{cadena1}/{cadena2}")]
        public int Cuenta(string cadena1, string cadena2)
        {
            return MiConcatenador.Cuenta(cadena1, cadena2);
        }
    }
}
