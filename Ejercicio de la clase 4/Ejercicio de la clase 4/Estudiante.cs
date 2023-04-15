using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_la_clase_4
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Curso[] Cursos { get; set; } = new Curso[0];
    }
}
