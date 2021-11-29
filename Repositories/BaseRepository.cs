using HelpDesk.Data;
using HelpDesk.Models;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Repositories
{
    public class BaseRepository<T> where T:BaseModel
    {
        protected readonly ApplicationDbContext context;
        protected readonly DbSet<T> dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<T>();
        }

    }
}