using HelpDesk.Models;
using HelpDesk.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using HelpDesk.Repositories.Interfaces;

namespace HelpDesk.Controllers
{
    public class CriacaoTicketController : Controller
    {
        //atributos das classes de repositório cujo objeto é instânciado na injeção de dependência
        private readonly ITicketRepository ticketRepository;
        private readonly IUsuarioRepository usuarioRepository;
        private readonly ICategoriaRepository categoriaRepository;
        private readonly ISetorRepository setorRepository;
        private readonly IStatusChamadoRepository statusChamadoRepository;
        private readonly IPrioridadeRepository prioridadeRepository;
        private readonly ICredencialRepository credencialRepository;

        public CriacaoTicketController(
            ITicketRepository ticketRepository,
            IUsuarioRepository usuarioRepository,
            ICategoriaRepository categoriaRepository,
            ISetorRepository setorRepository,
            IStatusChamadoRepository statusChamadoRepository,
            IPrioridadeRepository prioridadeRepository,
            ICredencialRepository credencialRepository)
        {
            this.ticketRepository = ticketRepository;
            this.usuarioRepository = usuarioRepository;
            this.categoriaRepository = categoriaRepository;
            this.setorRepository = setorRepository;
            this.statusChamadoRepository = statusChamadoRepository;
            this.prioridadeRepository = prioridadeRepository;
            this.credencialRepository = credencialRepository;
        }

        public IActionResult AberturaDeTicket()
        {
            //passa para a view uma instância de ticket com o objetivo de ser utilizado no formulário
            return View(new Ticket());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AberturaDeTicket(Ticket ticket)//recebe um formulário do tipo ticket em um POST
        {
            //Seta os atributos implícitos
            ticket.categoria = categoriaRepository.SelecionarFiltrado(1);
            ticket.dataAbertura = DateTime.Today;
            ticket.criador = usuarioRepository.SelecionarFiltrado(1);
            ticket.prioridade = prioridadeRepository.SelecionarFiltrado(1);
            ticket.status = statusChamadoRepository.SelecionarFiltrado(1);
            ticket.responsavel = usuarioRepository.SelecionarFiltrado(1);
            ticket.categoria = categoriaRepository.SelecionarFiltrado(1);
            ticketRepository.Inserir(ticket);
            return RedirectToAction("VisualizarTicket", "ListaTickets", new { id = ticket.Id });
        }
    }
}
