using HelpDesk.Data;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(ApplicationDbContext context) : base(context)
        {
        }

        #region "Métodos CRUD"
        public IList<Usuario> Selecionar()
        {
            var lista = dbSet
            .Include(b => b.setor)
            .Include(b => b.credencial)
            .ToList();
            return lista;
        }
        public Usuario SelecionarFiltrado(int id)
        {
            var usuario = dbSet.Where(b => b.Id == id)
                .Include(b => b.credencial)
                .Include(b => b.setor)
                .ToList();
            return usuario.FirstOrDefault();
        }
        #endregion
    }
}
