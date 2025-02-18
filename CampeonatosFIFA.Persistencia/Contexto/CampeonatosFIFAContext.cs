using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Persistencia.Contexto
{
    public class CampeonatosFIFAContext : DbContext
    {
        public CampeonatosFIFAContext(DbContextOptions<CampeonatosFIFAContext> opcions)
            : base(opcions)
        {

        }

        public DbSet<Seleccion> Selecciones { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Encuentro> Encuentros { get; set; }
        public DbSet<Estadio> Estadios { get; set; }
        public DbSet<Fase> Fases { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<GrupoPais> GruposPaises { get; set; }


        void onModeCreating(ModelBuilder builder)
        {
            builder.Entity<Seleccion>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Campeonato>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Campeonato>()
                .HasOne(e => e.PaisOrganizador)
                .WithMany()
                .HasForeignKey(e => e.IdSeleccion);
        }
    }
}
