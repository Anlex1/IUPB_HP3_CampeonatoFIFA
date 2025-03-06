using Azure.Core;
using CampeonatoFIFA.Infraestructura.Repositorios;
using CampeonatosFIFA.Aplicacion;
using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Core.Servicios;
using CampeonatosFIFA.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Presentacion.DI
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarDependencias(this IServiceCollection servicios, 
                                                                  IConfiguration configuracion)
        {
            // Agregar la instancia del Dbcontext
            servicios.AddDbContext<CampeonatosFIFAContext>(opciones =>
            {
                opciones.UseSqlServer(configuracion.GetConnectionString("CampeonatosFIFA"));
            });

            // Agregar repositorios
            servicios.AddTransient<ISeleccionRepositorio, SeleccionRepositorio>();

            // Agregar Servicios --
            servicios.AddTransient<ISeleccionServicio, SeleccionServicio>();




            return servicios;
        }
    }
}
