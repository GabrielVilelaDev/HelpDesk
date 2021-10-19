using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpDesk.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            //Relacionando entidades 1xN de Ticket
            modelBuilder.Entity<Ticket>().HasKey(t => t.Id);
            modelBuilder.Entity<Ticket>().HasOne(t => t.categoria);
            modelBuilder.Entity<Ticket>().HasOne(t => t.prioridade);
            modelBuilder.Entity<Ticket>().HasOne(t => t.responsavel);
            modelBuilder.Entity<Ticket>().HasOne(t => t.criador);
            modelBuilder.Entity<Ticket>().HasOne(t => t.status);
            //Relacionando entidades 1xN de Usuario
            modelBuilder.Entity<Usuario>().HasKey(t => t.Id);
            modelBuilder.Entity<Usuario>().HasOne(t => t.setor);
            modelBuilder.Entity<Usuario>().HasOne(t => t.credencial);

            modelBuilder.Entity<Categoria>().HasKey(t => t.Id);

            modelBuilder.Entity<Prioridade>().HasKey(t => t.Id);

            modelBuilder.Entity<StatusChamado>().HasKey(t => t.Id);

            modelBuilder.Entity<Setor>().HasKey(t => t.Id);

            modelBuilder.Entity<Credencial>().HasKey(t => t.Id);

        }
    }
}
