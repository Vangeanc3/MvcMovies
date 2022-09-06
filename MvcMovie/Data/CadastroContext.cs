using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class CadastroContext : DbContext
    {
        public CadastroContext(DbContextOptions<CadastroContext> opt)
            : base(opt)
        {
        }

        public DbSet<Cadastro> Cadastros { get; set; } = default!;
    }
}
