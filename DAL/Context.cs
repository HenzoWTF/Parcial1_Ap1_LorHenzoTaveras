using Microsoft.EntityFrameworkCore;
using Parcial1_Ap1_LorHenzoTaveras.Model;

namespace Parcial1_Ap1_LorHenzoTaveras.DAL
{

    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<MetasFinancieras> Metas { get; set; }
    }
}
