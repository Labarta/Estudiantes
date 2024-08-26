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
    public class AlumnoGradoController : ControllerBase
    {
        private readonly EstudiantesDbContext _context;

        public AlumnoGradoController(EstudiantesDbContext context)
        {
            _context = context;
        }

        // GET: api/AlumnoGrado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AlumnoGrado>>> GetAlumnoGrado()
        {
            return await _context.AlumnoGrado.ToListAsync();
        }

        // GET: api/AlumnoGrado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AlumnoGrado>> GetAlumnoGrado(int id)
        {
            var alumnoGrado = await _context.AlumnoGrado.FindAsync(id);

            if (alumnoGrado == null)
            {
                return NotFound();
            }

            return alumnoGrado;
        }

        // PUT: api/AlumnoGrado/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAlumnoGrado(int id, AlumnoGrado alumnoGrado)
        {
            if (id != alumnoGrado.Id)
            {
                return BadRequest();
            }

            _context.Entry(alumnoGrado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlumnoGradoExists(id))
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

        // POST: api/AlumnoGrado
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AlumnoGrado>> PostAlumnoGrado(AlumnoGrado alumnoGrado)
        {
            _context.AlumnoGrado.Add(alumnoGrado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlumnoGrado", new { id = alumnoGrado.Id }, alumnoGrado);
        }

        // DELETE: api/AlumnoGrado/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAlumnoGrado(int id)
        {
            var alumnoGrado = await _context.AlumnoGrado.FindAsync(id);
            if (alumnoGrado == null)
            {
                return NotFound();
            }

            _context.AlumnoGrado.Remove(alumnoGrado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlumnoGradoExists(int id)
        {
            return _context.AlumnoGrado.Any(e => e.Id == id);
        }
    }
}
