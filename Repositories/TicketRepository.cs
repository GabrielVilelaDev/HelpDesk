using HelpDesk.Data;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    public class TicketRepository : ITicketRepository
    {
        private readonly ApplicationDbContext context;
        public TicketRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        #region "Métodos CRUD"
        public void Inserir(string assunto, string descricao, Categoria categoria, DateTime dataAbertura, Usuario usuario, Prioridade prioridade, StatusChamado status, Usuario responsavel)
        {
            Ticket ticket = new Ticket(assunto, descricao, categoria, dataAbertura, usuario, prioridade, status, responsavel);
            context.Set<Ticket>().Add(ticket);
            context.SaveChanges();
        }

        public IList<Ticket> Selecionar()
        {
            var lista = context.Set<Ticket>()
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
            var ticket = context.Set<Ticket>().Where(b => b.Id == id)
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
