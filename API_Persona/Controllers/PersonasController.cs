using API_Persona.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Persona.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        [HttpGet(Name = "get")]
        public IEnumerable<Persona> Get()
        {
            List<Persona> ventas = new List<Persona>();
            for (int i = 1; i < 11; i++)
            {
                ventas.Add(new Persona { IdPersona = i, Nombre = "Juan " + i, Apellido="Cucho " + i });
            }
            return ventas;
        }

        [HttpGet(Name = "getDemo")]
        public IEnumerable<Persona> getDemo()
        {
            List<Persona> ventas = new List<Persona>();
            for (int i = 1; i < 11; i++)
            {
                ventas.Add(new Persona { IdPersona = i*2, Nombre = "Juan " + i * 2, Apellido = "Cucho " + i * 2 });
            }
            return ventas;
        }

        [HttpGet(Name = "getPrueba")]
        public IEnumerable<Persona> getPrueba()
        {
            List<Persona> ventas = new List<Persona>();
            for (int i = 1; i < 11; i++)
            {
                ventas.Add(new Persona { IdPersona = i*3, Nombre = "Juan " + i * 3, Apellido = "Cucho " + i * 3 });
            }
            return ventas;
        }
    }
}
