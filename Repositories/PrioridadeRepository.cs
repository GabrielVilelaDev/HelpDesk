using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class PrioridadeRepository : BaseRepository<Prioridade>, IPrioridadeRepository
    {
        public PrioridadeRepository(ApplicationDbContext context) : base(context)
        {
        }

        #region "Métodos CRUD"
        public IList<Prioridade> Selecionar()
        {
            var lista = dbSet
            .ToList();
            return lista;
        }
        public Prioridade SelecionarFiltrado(int id)
        {
            var prioridade = dbSet.Where(b => b.Id == id)
                .ToList();
            return prioridade.FirstOrDefault();
        }
        #endregion
    }
}
