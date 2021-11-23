using HelpDesk.Models;
using HelpDesk.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class ListarTicketsController : Controller
    {
        private readonly ITicketRepository ticketRepository;
        public ListarTicketsController(ITicketRepository ticketRepository)
        {
            this.ticketRepository = ticketRepository;
        }

        public IActionResult Index()
        {
            var ListaTicket = ticketRepository.Selecionar();
            return View(ListaTicket);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
