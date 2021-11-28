using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpDesk.Data;
using HelpDesk.Models;

namespace HelpDesk.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ApplicationDbContext context;
        public CategoriaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"

        public Categoria SelecionarFiltrado(int id)
        {
            var categoria = context.Set<Categoria>().Where(b => b.Id == id)
                .ToList();
            return categoria.FirstOrDefault();
        }
        #endregion
    }
}