using System.ComponentModel.DataAnnotations;

namespace UniversidadApiBackend.Models.DataModels
{
    public class Curso : BaseEntity
    {
        [Required, StringLength(50)]
        public string Nombre { get; set; } = string.Empty;
        [Required, StringLength(200)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required, StringLength(500)]
        public string DescripcionLarga { get; set; } = string.Empty;
        [Required, StringLength(200)]
        public string PublicoObjetivo { get; set; } = string.Empty;
        [Required]
        public string Objetivos { get; set; } = string.Empty;
        [Required]
        public string Requisitos { get; set; } = string.Empty;
        public enum NivelCurso
        {
            Basico,
            Intermedio,
            Avanzado
        }

        [Required]
        public NivelCurso Nivel { get; set; }
    }
}
