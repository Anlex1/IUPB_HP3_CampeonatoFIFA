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
            //------------------------
            
            // Campo Seleccion
            builder.Entity<Seleccion>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Campo Campeonato
            builder.Entity<Campeonato>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Campeonato>()
                .HasOne(e => e.PaisOrganizador)
                .WithMany()
                .HasForeignKey(e => e.IdSeleccion);

            // Campo Ciudad
            builder.Entity<Ciudad>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Ciudad>()
                .HasOne(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

            //Campo Grupo
            builder.Entity<Grupo>(entidad => 
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Grupo>()
                .HasOne(e => e.Campeonato)
                .WithMany()
                .HasForeignKey(e => e.IdCampeonato);

            // Campo Estadio
            builder.Entity<Estadio>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            builder.Entity<Estadio>()
                .HasOne(e => e.Ciudad)
                .WithMany()
                .HasForeignKey(e => e.IdCiudad);

            // Campo Grupo Pais
            builder.Entity<GrupoPais>()
                .HasOne(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

            builder.Entity<GrupoPais>()
                .HasOne(e => e.Grupo)
                .WithMany()
                .HasForeignKey(e => e.IdGrupo);

            // Campo Fase
            builder.Entity<Fase>(entidad =>
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => e.Nombre).IsUnique();
            });

            // Campo Encuentro
            builder.Entity<Encuentro>(entidad =>
{
    entidad.HasKey(e => e.Id);

    entidad.HasOne(e => e.Seleccion1)
        .WithMany()
        .HasForeignKey(e => e.IdPais1);

    entidad.HasOne(e => e.Seleccion2)
        .WithMany()
        .HasForeignKey(e => e.IdPais2);

    entidad.HasOne(e => e.Estadio)
        .WithMany()
        .HasForeignKey(e => e.IdEstadio);

    entidad.HasOne(e => e.Fase)
        .WithMany()
        .HasForeignKey(e => e.IdFase);

    entidad.HasOne(e => e.Campeonato)
        .WithMany()
        .HasForeignKey(e => e.IdCampeonato);
});

            //----------------------------------
        }
    }
}
