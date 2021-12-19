using HelpDesk.Data;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class TicketRepository : BaseRepository<Ticket>, ITicketRepository
    {
        public TicketRepository(ApplicationDbContext context) : base(context)
        {
        }

        #region "Métodos CRUD"
        public void Inserir(Ticket ticket)
        {
            dbSet.Add(ticket);
            context.SaveChanges();
        }
        public void AtualizarResponsavel(Ticket ticket, Usuario usuario)
        {
            ticket.responsavel = usuario;
            dbSet.Update(ticket);
            context.SaveChanges();
        }
        public IList<Ticket> Selecionar()
        {
            var lista = dbSet
                .Include(b => b.categoria)
                .Include(b => b.criador)
                .Include(b => b.criador.credencial)
                .Include(b => b.responsavel)
                .Include(b => b.responsavel.credencial)
                .Include(b => b.status)
                .Include(b => b.prioridade)
                .ToList();
            return lista;
        }
        public Ticket SelecionarFiltrado(int id)
        {
            var ticket = dbSet.Where(b => b.Id == id)
                .Include(b => b.categoria)
                .Include(b => b.criador)
                .Include(b => b.criador.credencial)
                .Include(b => b.responsavel)
                .Include(b => b.responsavel.credencial)
                .Include(b => b.status)
                .Include(b => b.prioridade)
                .ToList();
            return ticket.FirstOrDefault();
        }
        #endregion
    }
}
