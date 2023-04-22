using UniversidadApiBackend.Models.DataModels;

namespace UniversidadApiBackend.Services
{
    public interface ICoursesService
    {
        // Obtener todos los Cursos de una categoría concreta
        IEnumerable<Chapter> GetCoursesFromACategory(string NameCategory);
        // Obtener Cursos sin temarios
        IEnumerable<Chapter> GetCoursesWithoutTopics();
        IEnumerable<Chapter> GetCoursesOfAStudent(string Student);
    }
}
