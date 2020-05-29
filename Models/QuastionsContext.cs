using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AskDispaly.Models
{
    public class QuastionsContext : DbContext
    {
        public DbSet<Asq> asqs { get; set; }
        public DbSet<Quastions> quastions { get; set; }
        public QuastionsContext(DbContextOptions<QuastionsContext> options) : base(options) { Database.EnsureCreated(); }
    }
}
