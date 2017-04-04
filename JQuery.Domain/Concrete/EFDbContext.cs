using JQuery.Domain.Entities;
using System.Data.Entity;

namespace JQuery.Domain.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<Empresa>Empresas { get; set; }
    }
}
