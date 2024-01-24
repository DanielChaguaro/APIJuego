using APIJuego.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.Common;
using System.Reflection.Emit;

namespace APIJuego.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(
            DbContextOptions<AppDBContext> options) : base(options)
        {
        }

        public DbSet<Juego> fechasganada { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Juego>().HasData(



                new Juego
                {
                    IdJuego=1,
                    fechaganada = DateTime.Now,

                });


        }
        }
    }
