using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_LorHenzoTaveras.Model;

namespace Parcial1_Ap1_LorHenzoTaveras.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<MetasFinancieras> MetasFinancieras { get; set; }
    }
}
