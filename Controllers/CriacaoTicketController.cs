using HelpDesk.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Controllers
{
    public class CriacaoTicketController : Controller
    {
        // POST: NovoTicketController/CriarTicket
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CriarTicket(Ticket? ticket)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View();
        }
    }
}
