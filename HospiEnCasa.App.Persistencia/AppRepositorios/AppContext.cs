using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;
namespace HospiEnCasa.App.Persistencia
{
 public class AppContext : DbContext
 {
   public DbSet<Persona> personas { get; set;}
   public DbSet<Paciente> Pacientes { get; set;}
   public DbSet<Medico> Medicos { get; set;}
   public DbSet<Enfermera> Enfermeras { get; set;}
   public DbSet<FamiliarDesignado> FamiliarDesignados { get; set;}
   public DbSet<SignoVital> SignoVitales { get; set;}
   public DbSet<Historia> Historias { get; set;}
   public DbSet<SugerenciaCuidado> SugerenciasCuidado { get; set;}

   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
    if(!optionsBuilder.IsConfigured)
    {
        optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HospiEnCasaData");
    }

   }    
    }
}