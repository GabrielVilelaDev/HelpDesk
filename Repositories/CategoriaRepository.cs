using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpDesk.Data;
using HelpDesk.Models;

namespace HelpDesk.Repositories
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        public CategoriaRepository(ApplicationDbContext context) : base(context)
        {
        }


        #region "Métodos CRUD"
        public IList<Categoria> Selecionar()
        {
            var lista = dbSet
            .ToList();
            return lista;
        }
        public Categoria SelecionarFiltrado(int id)
        {
            var categoria = dbSet.Where(b => b.Id == id)
                .ToList();
            return categoria.FirstOrDefault();
        }
        #endregion
    }
}