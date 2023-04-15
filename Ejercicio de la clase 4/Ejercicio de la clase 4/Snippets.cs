using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_la_clase_4
{
    public class Snippets
    {
        static public void Linq() {
            var usuarios = new[] {
                new Usuario() {
                    Id = 1,
                    User = "@Robert",
                    Email = "robert@gmail.com",
                    Password = "robert",
                    Estudiantes = new[] {
                        new Estudiante {
                            Id = 1,
                            Name = "Roberto Morales",
                            Age = 23,
                            Cursos = new[] { 
                                new Curso { 
                                    Id = 1,
                                    Name = "Programación",
                                    Lavel = "Intermedio"
                                },
                                new Curso {
                                    Id = 2,
                                    Name = "Redes de Computadoras",
                                    Lavel = "Avanzado"
                                }
                            }
                        },
                        new Estudiante {
                            Id = 2,
                            Name = "Alexander Morales",
                            Age = 23,
                            Cursos = new[] {
                                new Curso {
                                    Id = 3,
                                    Name = "Diseño Gráfico",
                                    Lavel = "Basico"
                                },
                                new Curso {
                                    Id = 4,
                                    Name = "Inglés",
                                    Lavel = "Avanzado"
                                }
                            }
                        }
                    }
                }
            };

            var categorias = new[] {
                new Categoria {
                    Id = 1,
                    Name = "Programación",
                    Cursos =  new[] { 
                        new Curso { 
                            Id = 1, 
                            Name = "HTML5y CSS3", 
                            Lavel="Avanzado" 
                        } 
                    }
                }
            };

            // Buscar usuarios por email
            string emailBuscado = "robert@gmail.com";
            var UsuarioEncontrado = usuarios.AsEnumerable().FirstOrDefault(u => u.Email == emailBuscado);

            // Buscar alumnos mayores de edad
            var estudiantesMayoresDeEdad = usuarios.SelectMany(u => u.Estudiantes).Where(e => e.Age >= 18);

            // Buscar alumnos que tengan al menos un curso
            var estudiantesConCursos = usuarios.SelectMany(u => u.Estudiantes).Where(e => e.Cursos.Length > 0);

            // Buscar cursos de un nivel determinado que al menos tengan un alumno inscrito
            var cursosConEstudiantes = usuarios.SelectMany(u => u.Estudiantes.SelectMany(e => e.Cursos.Select(c => new { Curso = c, Estudiante = e })));
            var cursosNivelIntermedioConEstudiantes = cursosConEstudiantes.Where(c => c.Curso.Lavel == "Intermedio");

            // Buscar cursos de un nivel determinado que sean de una categoría determinada
            var categoriaBuscada = "Programación";
            var nivelBuscado = "Avanzado";
            var cursosEncontrados = categorias.Where(c => c.Name == categoriaBuscada).SelectMany(c => c.Cursos.Where(curso => curso.Lavel == nivelBuscado));

            // Buscar cursos sin alumnos
            var cursosSinEstudiantes = usuarios.SelectMany(u => u.Estudiantes)
                                    .SelectMany(e => e.Cursos)
                                    .Where(c => !usuarios.SelectMany(u => u.Estudiantes)
                                                        .SelectMany(e => e.Cursos)
                                                        .Any(cc => cc.Id == c.Id))
                                    .Distinct();

        }
    }
}
