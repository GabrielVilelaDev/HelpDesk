using HelpDesk.Models;
using System.Collections.Generic;

namespace HelpDesk.Repositories.Interfaces
{
    public interface ISetorRepository
    {
        Setor SelecionarFiltrado(int id);
        IList<Setor> Selecionar();
    }
}