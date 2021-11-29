using HelpDesk.Data;
using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class StatusChamadoRepository : BaseRepository<StatusChamado>, IStatusChamadoRepository
    {
        public StatusChamadoRepository(ApplicationDbContext context) : base(context)
        {
        }

        #region "Métodos CRUD"
        public IList<StatusChamado> Selecionar()
        {
            var lista = dbSet
            .ToList();
            return lista;
        }
        public StatusChamado SelecionarFiltrado(int id)
        {
            var statusChamado = dbSet.Where(b => b.Id == id)
                .ToList();
            return statusChamado.FirstOrDefault();
        }
        #endregion
    }
}
