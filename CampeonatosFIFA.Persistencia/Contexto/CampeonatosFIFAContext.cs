using CampeonatosFIFA.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
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


        protected override void OnModelCreating(ModelBuilder builder)
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
                entidad.HasIndex(e => new {e.IdPais, e.Nombre}).IsUnique();
            });

            builder.Entity<Ciudad>()
                .HasOne(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

            //Campo Grupo
            builder.Entity<Grupo>(entidad => 
            {
                entidad.HasKey(e => e.Id);
                entidad.HasIndex(e => new { e.IdCampeonato, e.Nombre}).IsUnique();
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
            builder.Entity<GrupoPais>(entidad =>
            {
                entidad.HasKey(e => new { e.IdGrupo, e.IdPais });
            });

            builder.Entity<GrupoPais>()
            .HasOne(e => e.Grupo)
            .WithMany()
            .HasForeignKey(e => e.IdGrupo);

            builder.Entity<GrupoPais>()
                .HasOne(e => e.Pais)
                .WithMany()
                .HasForeignKey(e => e.IdPais);

        
            
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
            entidad.HasIndex(e => new {e.IdCampeonato, e.IdFase, e.IdPais1, e.IdPais2}).IsUnique();
                entidad.HasOne<Seleccion>()
                    .WithMany()
                    .HasForeignKey(e => e.IdPais1);
                entidad.HasOne<Seleccion>()
                    .WithMany()
                    .HasForeignKey(e => e.IdPais2);
                entidad.HasOne<Fase>()
                    .WithMany()
                    .HasForeignKey(e => e.IdFase);
                entidad.HasOne<Campeonato>()
                    .WithMany()
                    .HasForeignKey(e => e.IdCampeonato);
                entidad.HasOne<Estadio>()
                    .WithMany()
                    .HasForeignKey(e => e.IdEstadio);               
            });

            //----------------------------------
        }
    }
}
