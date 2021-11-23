using HelpDesk.Data;
using HelpDesk.Models;
using HelpDesk.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

namespace HelpDesk
{
    class DataService : IDataService
    {
        private readonly ApplicationDbContext context;
        public DataService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public void InicializaDB()
        {
            context.Database.Migrate();
        }

    }
}