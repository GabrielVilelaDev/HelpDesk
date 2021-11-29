using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories.Interfaces
{
    public class SetorRepository : BaseRepository<Setor>, ISetorRepository
    {
        public SetorRepository(ApplicationDbContext context) : base(context)
        {
        }

        #region "Métodos CRUD"
        public IList<Setor> Selecionar()
        {
            var lista = dbSet
            .ToList();
            return lista;
        }
        public Setor SelecionarFiltrado(int id)
        {
            var setor = dbSet.Where(b => b.Id == id)
                .ToList();
            return setor.FirstOrDefault();
        }
        #endregion
    }
}
