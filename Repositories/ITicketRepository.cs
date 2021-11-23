using HelpDesk.Models;
using System;
using System.Collections.Generic;

namespace HelpDesk.Repositories
{
    public interface ITicketRepository
    {
        void Inserir(string assunto, Categoria categoria, DateTime dataAbertura, Usuario usuario, Prioridade prioridade, StatusChamado status, Usuario responsavel);

        IList<Ticket> Selecionar();
    }
}