using Estudiantes.Context;
using Estudiantes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace Estudiantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class obtenerGradoController : ControllerBase
    {
        private readonly EstudiantesDbContext _context;

        public obtenerGradoController(EstudiantesDbContext context)
        {
            _context = context;
        }

        [HttpGet("ObtenerGrado")]
        public async Task<IActionResult> ObtenerGrado()
        {
            var grados = await _context.Set<obtenerGrado>()
                .FromSqlRaw("EXEC obtenerGrado")
                .ToListAsync();

            return Ok(grados);
        }
    }
}
