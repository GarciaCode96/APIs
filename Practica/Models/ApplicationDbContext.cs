using Microsoft.EntityFrameworkCore;
using Practica.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // Constructor donde se pasa las opciones del DbContext
        }
        
        public DbSet<PersonaEntity> Personas { get; set; }
    }
}
