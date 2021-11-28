using HelpDesk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Repositories
{
    interface ICategoriaRepository
    {
        Categoria SelecionarFiltrado(int id);
    }
}
