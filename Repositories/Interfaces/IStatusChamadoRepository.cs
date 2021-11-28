using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    interface IStatusChamadoRepository
    {
        StatusChamado SelecionarFiltrado(int id);
    }
}
