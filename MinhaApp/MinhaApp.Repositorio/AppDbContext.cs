using Microsoft.EntityFrameworkCore;
using MinhaApp.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaApp.Repositorio
{
    public class AppDbContext: DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
    }
}
