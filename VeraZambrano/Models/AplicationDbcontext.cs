using VeraZambrano.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace VeraZambrano.Data;


public class ApplicationDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // El connectionString debe venir de un archivo de configuraciones
        optionsBuilder.UseSqlServer("Server=DESKTOP-T50DV92\\SQLEXPRESS;Database=VeraZambrano;Trusted_Connection=True")
            .EnableSensitiveDataLogging(true)
            .UseLoggerFactory(LoggerFactory.Create(builder =>
            {
                builder.AddConsole().SetMinimumLevel(LogLevel.Information);
            }));
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Genero> Generos { get; set; }
}
