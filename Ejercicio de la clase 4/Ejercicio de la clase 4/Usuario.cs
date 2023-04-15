namespace Ejercicio_de_la_clase_4
{
    public class Usuario
    {
        public int Id { get; set; }
        public string User { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Estudiante[] Estudiantes { get; set; } = new Estudiante[0];

    }
}