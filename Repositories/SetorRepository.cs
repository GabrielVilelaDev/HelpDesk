using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories.Interfaces
{
    public class SetorRepository : ISetorRepository
    {
        private readonly ApplicationDbContext context;
        public SetorRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"

        public Setor SelecionarFiltrado(int id)
        {
            var setor = context.Set<Setor>().Where(b => b.Id == id)
                .ToList();
            return setor.FirstOrDefault();
        }
        #endregion
    }
}
