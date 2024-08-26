using Estudiantes.Context;
using Estudiantes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Estudiantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistroController : ControllerBase
    {
        private readonly EstudiantesDbContext _context;

        public RegistroController(EstudiantesDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Registro>>> GetRegistros()
        {
            return await _context.Registros.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Registro>> PostRegistro(Registro registro)
        {
            if (_context.Registros.Any(r => r.Matricula == registro.Matricula))
            {
                return BadRequest("Matrícula ya existe.");
            }

            if (_context.Registros.Any(r => r.Materia == registro.Materia && r.Fecha == registro.Fecha && r.Profesor == registro.Profesor))
            {
                return BadRequest("La combinación de materia, fecha y profesor ya existe.");
            }

            _context.Registros.Add(registro);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetRegistros), new { id = registro.Id }, registro);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutRegistro(int id, Registro registro)
        {
            if (id != registro.Id)
            {
                return BadRequest();
            }

            _context.Entry(registro).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Registros.Any(r => r.Id == id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRegistro(int id)
        {
            var registro = await _context.Registros.FindAsync(id);
            if (registro == null)
            {
                return NotFound();
            }

            _context.Registros.Remove(registro);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
