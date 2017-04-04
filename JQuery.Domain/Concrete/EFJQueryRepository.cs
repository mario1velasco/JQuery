using JQuery.Domain.Abstract;
using JQuery.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JQuery.Domain.Concrete
{
    public class EFJQueryRepository:IJQueryRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Empresa> Empresas { get { return context.Empresas; } }
    }
}
