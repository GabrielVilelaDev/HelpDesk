using HelpDesk.Data;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext context;
        public UsuarioRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"

        public Usuario SelecionarFiltrado(int id)
        {
            var usuario = context.Set<Usuario>().Where(b => b.Id == id)
                .Include(b => b.credencial)
                .Include(b => b.setor)
                .ToList();
            return usuario.FirstOrDefault();
        }
        #endregion
    }
}
