using System.ComponentModel.DataAnnotations;

namespace Parcial1_Ap1_LorHenzoTaveras.Model
{
    public class MetasFinancieras
    {
        [Key]
        public int MetaId { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string? Descripcion { get; set; }

        public decimal? Monto { get; set; }
    }
}
