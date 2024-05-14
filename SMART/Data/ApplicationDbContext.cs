using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SMART.Data.Entities;

namespace SMART.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<OrigemModalidades> OrigemModalidades { get; set; }
        public DbSet<Modalidade> Modalidade { get; set; }
        public DbSet<Conteudo> Conteudo { get; set; }
        public DbSet<GrupoConteudo> GrupoConteudo { get; set; }
    }
}
