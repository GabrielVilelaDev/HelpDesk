using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class PrioridadeRepository : IPrioridadeRepository
    {
        private readonly ApplicationDbContext context;
        public PrioridadeRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"

        public Prioridade SelecionarFiltrado(int id)
        {
            var prioridade = context.Set<Prioridade>().Where(b => b.Id == id)
                .ToList();
            return prioridade.FirstOrDefault();
        }
        #endregion
    }
}
