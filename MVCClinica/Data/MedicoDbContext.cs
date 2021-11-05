using MVCClinica.Models;
using System.Data.Entity;

namespace MVCClinica.Data
{
    public class MedicoDbContext : DbContext
    {
        public MedicoDbContext() : base("KeyMedicos") { }

        public DbSet<Medico> Medicos { get; set; }
    }
}