using UniversidadApiBackend.Models.DataModels;

namespace UniversidadApiBackend.Services
{
    public interface IChaptersService
    {
        // Obtener temario de un curso concreto
        IEnumerable<Chapter> GetTheTopicsOfACourse(string NemaCourse);
    }
}
