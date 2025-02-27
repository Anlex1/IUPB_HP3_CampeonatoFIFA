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
        public Task<Seleccion> Agregar(Seleccion Seleccion)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Seleccion>> Buscar(int Tipo, string Dato)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Seleccion> Modificar(Seleccion seleccion)
        {
            throw new NotImplementedException();
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
