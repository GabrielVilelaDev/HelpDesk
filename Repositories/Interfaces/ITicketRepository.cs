using HelpDesk.Models;
using System;
using System.Collections.Generic;

namespace HelpDesk.Repositories
{
    public interface ITicketRepository
    {
        void Inserir(Ticket ticket);

        IList<Ticket> Selecionar();
        Ticket SelecionarFiltrado(int id);
    }
}