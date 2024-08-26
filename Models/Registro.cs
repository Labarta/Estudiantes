namespace Estudiantes.Models
{
    public class Registro
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Matricula { get; set; }
        public string? Curso { get; set; }
        public string? Materia { get; set; }
        public string? Profesor { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Horario { get; set; }
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
