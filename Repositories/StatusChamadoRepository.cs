using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class StatusChamadoRepository : IStatusChamadoRepository
    {
        private readonly ApplicationDbContext context;
        public StatusChamadoRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"

        public StatusChamado SelecionarFiltrado(int id)
        {
            var statusChamado = context.Set<StatusChamado>().Where(b => b.Id == id)
                .ToList();
            return statusChamado.FirstOrDefault();
        }
        #endregion
    }
}
