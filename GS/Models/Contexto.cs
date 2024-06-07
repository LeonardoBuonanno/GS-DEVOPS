using Microsoft.EntityFrameworkCore;

namespace GS.Models
{
    public class Contexto : DbContext
    {

         public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
         
            

        }

        public DbSet<GS.Models.Cliente> Cliente { get; set; } = default!;

    }
}
