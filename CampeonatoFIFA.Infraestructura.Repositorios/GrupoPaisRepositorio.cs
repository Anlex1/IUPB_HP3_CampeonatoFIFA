using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Dominio.Entidades;
using CampeonatosFIFA.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;

namespace CampeonatoFIFA.Infraestructura.Repositorios
{
    public class GrupoPaisRepositorio : IGrupoPaisRepositorio
    {
        private readonly CampeonatosFIFAContext context;
        public GrupoPaisRepositorio(CampeonatosFIFAContext context)
        {
            this.context = context;
        }

        public async Task<GrupoPais> Agregar(GrupoPais GrupoPais)
        {
            context.GruposPaises.Add(GrupoPais);
            await context.SaveChangesAsync();
            return GrupoPais;
        }

        public async Task<bool> Eliminar(int IdGrupo, int IdPais)
        {
            var GrupoPaisExistente = await context.GruposPaises.FindAsync(IdGrupo, IdPais);
            if (GrupoPaisExistente == null)
            {
                return false;
            }
            try
            {
                context.GruposPaises.Remove(GrupoPaisExistente);
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<GrupoPais> Modificar(GrupoPais GrupoPais)
        {
            var GrupoPaisExistente = await context.GruposPaises.FindAsync(GrupoPais.IdGrupo, GrupoPais.IdPais);
            if (GrupoPaisExistente == null)
            {
                return null;
            }

            context.Entry(GrupoPaisExistente).CurrentValues.SetValues(GrupoPais);
            await context.SaveChangesAsync();

            return await context.GruposPaises.FindAsync(GrupoPais.IdGrupo, GrupoPais.IdPais);
        }

        public async Task<GrupoPais> Obtener(int IdGrupo, int IdPais)
        {
            return await context.GruposPaises.FindAsync(IdGrupo, IdPais);
        }

        public async Task<IEnumerable<GrupoPais>> ObtenerPaises(int IdGrupo)
        {
            return await context.GruposPaises
                .Where(item => item.IdGrupo == IdGrupo)
                .Include(e => e.Grupo)   // Incluir el objeto Grupo
                .Include(e => e.Pais)   // Incluir el objeto Seleccion
                .ToArrayAsync();
        }
    }
}
