using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgendaTelefonica_Prueba.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // El connectionString debe venir de un archivo de configuraciones!
        //    optionsBuilder.UseSqlServer("Data Source=GRIMLOCK\\DESARROLLO;Initial Catalog=AgendaTelefonica;Integrated Security=True")
        //        .EnableSensitiveDataLogging(true)
        //        .UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information && category == DbLoggerCategory.Database.Command.Name, true));
        //}

        public DbSet<Persona> Personas { get; set; }
    }
}