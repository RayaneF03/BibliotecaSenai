using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BibliotecaSenai.Models;

namespace BibliotecaSenai.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<BibliotecaSenai.Models.Livro> Livro { get; set; } = default!;
        public DbSet<BibliotecaSenai.Models.Biblioteca> Biblioteca { get; set; } = default!;
        public DbSet<BibliotecaSenai.Models.Alunos> Alunos { get; set; } = default!;
    }
}
