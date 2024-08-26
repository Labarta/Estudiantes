using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Estudiantes.Context;
using Estudiantes.Models;

namespace Estudiantes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GradoController : ControllerBase
    {
        private readonly EstudiantesDbContext _context;

        public GradoController(EstudiantesDbContext context)
        {
            _context = context;
        }

        // GET: api/Grado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Grado>>> GetGrado()
        {
            return await _context.Grado.ToListAsync();
        }

        // GET: api/Grado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Grado>> GetGrado(int id)
        {
            var grado = await _context.Grado.FindAsync(id);

            if (grado == null)
            {
                return NotFound();
            }

            return grado;
        }

        // PUT: api/Grado/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGrado(int id, Grado grado)
        {
            if (id <= 0 || grado == null || id != grado.Id || string.IsNullOrWhiteSpace(grado.Nombre) || grado.ProfesorId == 0)
            {
                return BadRequest("Datos inválidos.");
            }

            _context.Entry(grado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GradoExists(id))
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

        // POST: api/Grado
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Grado>> PostGrado(Grado grado)
        {
            if (grado == null)
            {
                return BadRequest("Datos inválidos.");
            }
            try
            {
                _context.Grado.Add(grado);
                await _context.SaveChangesAsync();

                return CreatedAtAction("GetGrado", new { id = grado.Id }, grado);
            }
            catch(Exception ex) 
            {
                //_logger.LogError(ex, "Error al guardar el grado.");
                return StatusCode(500, "Error interno del servidor.");
            }
            
        }

        // DELETE: api/Grado/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrado(int id)
        {
            var grado = await _context.Grado.FindAsync(id);
            if (grado == null)
            {
                return NotFound(new { message = "Grado no encontrado" });
            }

            _context.Grado.Remove(grado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GradoExists(int id)
        {
            return _context.Grado.Any(e => e.Id == id);
        }
    }
}
