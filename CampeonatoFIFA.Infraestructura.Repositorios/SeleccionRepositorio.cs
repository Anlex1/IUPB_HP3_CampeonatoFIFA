using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Dominio.Entidades;
using CampeonatosFIFA.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatoFIFA.Infraestructura.Repositorios
{
    public class SeleccionRepositorio : ISeleccionRepositorio
    {
        private readonly CampeonatosFIFAContext context;
        public SeleccionRepositorio(CampeonatosFIFAContext context)
        {
            this.context = context;
        }
        public async Task<Seleccion> Agregar(Seleccion Seleccion)
        {
            context.Selecciones.Add(Seleccion);
            await context.SaveChangesAsync();
            return Seleccion;
        }

        public async Task<IEnumerable<Seleccion>> Buscar(int Tipo, string Dato)
        {
            return await context.Selecciones.Where(item => (Tipo == 0 && item.Nombre.Contains(Dato))||
            (Tipo == 1 && item.Entidad.Contains(Dato))).ToListAsync();
        }

        public async Task<bool> Eliminar(int Id)
        {
            var seleccionexistente = await context.Selecciones.FindAsync(Id);
            if (seleccionexistente == null)
            {
                return false;
            }
            try
            {
                context.Selecciones.Remove(seleccionexistente);
                await context.SaveChangesAsync();
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<Seleccion> Modificar(Seleccion Seleccion)
        {
            var seleccionexistente = await context.Selecciones.FindAsync(Seleccion.Id);
            if (seleccionexistente == null)
            {
                return null;
            }
            context.Entry(seleccionexistente).CurrentValues.SetValues(Seleccion);
            await context.SaveChangesAsync();
            return await context.Selecciones.FindAsync(Seleccion.Id);
        }

        public async Task<IEnumerable<Seleccion>> ObtenerTodos()
        {
            return await context.Selecciones.ToArrayAsync();
        }

        public async Task<Seleccion> Obtener(int Id)
        {
            return await context.Selecciones.FindAsync(Id);
        }
    }
}
