using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class CredencialRepository : ICredencialRepository
    {
        private readonly ApplicationDbContext context;
        public CredencialRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"

        public Credencial SelecionarFiltrado(int id)
        {
            var credencial = context.Set<Credencial>().Where(b => b.Id == id)
                .ToList();
            return credencial.FirstOrDefault();
        }
        #endregion
    }
}
