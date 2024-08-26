namespace Estudiantes.Models
{
    public class Grado
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public int ProfesorId { get; set; }

    }
}
