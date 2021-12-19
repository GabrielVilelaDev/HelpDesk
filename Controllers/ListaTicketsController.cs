using HelpDesk.Models;
using HelpDesk.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PagedList;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class ListaTicketsController : Controller
    {
        private readonly ITicketRepository ticketRepository;
        public ListaTicketsController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public IActionResult MeusTickets(int? pagina)
        {
            int tamanhoPagina = 15;
            int numeroPagina = pagina ?? 1;
            var ListaTicket = ticketRepository.Selecionar().OrderByDescending(b => b.Id);
            return View(ListaTicket.ToPagedList(numeroPagina, tamanhoPagina));
        }

        public IActionResult VisualizarTicket(int id)
        {
            return View(ticketRepository.SelecionarFiltrado(id));
        }
        public IActionResult DirecionaChamado(int id)
        {
            return RedirectToAction("AlteraResponsavel", "CriacaoTicket", new { id = id });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
