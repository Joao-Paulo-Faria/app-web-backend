using Microsoft.EntityFrameworkCore;

namespace app_web_backend.Models
{
    public class ApplicationDbContext : DbContext
    {
#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
        }
        public  DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Consumo> Consumos { get; set; }
    }
}
