using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class CredencialRepository : BaseRepository<Credencial>, ICredencialRepository
    {
        public CredencialRepository(ApplicationDbContext context) : base(context)
        {
        }

        #region "Métodos CRUD"
        public IList<Credencial> Selecionar()
        {
            var lista = dbSet
            .ToList();
            return lista;
        }
        public Credencial SelecionarFiltrado(int id)
        {
            var credencial = dbSet.Where(b => b.Id == id)
                .ToList();
            return credencial.FirstOrDefault();
        }
        #endregion
    }
}
