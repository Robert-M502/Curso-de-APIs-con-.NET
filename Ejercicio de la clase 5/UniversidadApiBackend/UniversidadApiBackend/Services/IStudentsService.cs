using UniversidadApiBackend.Models.DataModels;

namespace UniversidadApiBackend.Services
{
    public interface IStudentsService
    {
        IEnumerable<Student> GetStudentWithCourses();
        // Obtener todos los alumnos que no tienen cursos asociados
        IEnumerable<Student> GetStudentWithNoCourses();
        //Obtener alumnos de un Curso concreto
        IEnumerable<Student> GetStudentsCourse(string NameCourse);
        // Obtener los Cursos de un Alumno
        IEnumerable<Student> GetStudentCourses(string NameStudent);

    }
}
