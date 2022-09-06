using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcMovie.Data
{
    public class GerenteContext : DbContext
    {
        public GerenteContext (DbContextOptions<GerenteContext> options)
            : base(options)
        {
        }

        public DbSet<Gerente> Gerente { get; set; } = default!;
    }
}
