
using Microsoft.EntityFrameworkCore;

namespace Model
{
    public class TrelloContext : DbContext
    {

        public DbSet<User> Users => Set<User>();
        public DbSet<Board> Boards => Set<Board>();
        public DbSet<Todo> Todos => Set<Todo>();

       

        public string DbPath { get; }

        public TrelloContext(DbContextOptions<TrelloContext> options)
             : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }

   
    }
}