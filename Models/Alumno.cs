namespace Estudiantes.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public required string Apellido { get; set; }
        public required string Genero { get; set; }
        public required DateTime FechaNacimiento { get; set; }
        
    }
}
