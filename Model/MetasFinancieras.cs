using System.ComponentModel.DataAnnotations;

namespace Parcial1_Ap1_LorHenzoTaveras.Model
{
    public class MetasFinancieras
    {
        [Key]
        public int MetaId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "El campo Descripcion es obligatorio")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "El campo Monto es obligatorio")]

        public decimal? Monto { get; set; }
    }
}
