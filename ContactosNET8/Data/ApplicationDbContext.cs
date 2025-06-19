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
}
