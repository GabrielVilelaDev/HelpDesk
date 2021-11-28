using HelpDesk.Models;

namespace HelpDesk.Repositories.Interfaces
{
    public interface ISetorRepository
    {
        Setor SelecionarFiltrado(int id);
    }
}