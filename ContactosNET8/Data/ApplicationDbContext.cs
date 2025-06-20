using System;
using ContactosNET8.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactosNET8.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        //
    }

    // Agregar los modelos (tablas de BBDD)
    public DbSet<Contacto> Contactos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configura la propiedad FechaCreacion para que no sea actualizada
        modelBuilder.Entity<Contacto>()
            .Property(e => e.FechaCreacion)
            .ValueGeneratedOnAdd() // Indica que el valor se genera en la adición
            .Metadata.SetAfterSaveBehavior(Microsoft.EntityFrameworkCore.Metadata.PropertySaveBehavior.Ignore); // Ignora el valor en actualizaciones
    }
}
