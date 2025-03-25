using Azure.Core;
using CampeonatoFIFA.Infraestructura.Repositorios;
using CampeonatosFIFA.Aplicacion;
using CampeonatosFIFA.Core.Repositorios;
using CampeonatosFIFA.Core.Servicios;
using CampeonatosFIFA.Infraestructura.Repositorios;
using CampeonatosFIFA.Persistencia.Contexto;
using Microsoft.EntityFrameworkCore;

namespace CampeonatosFIFA.Presentacion.DI
{
    public static class InyeccionDependencias
    {
        public static IServiceCollection AgregarDependencias(this IServiceCollection servicios,
                                                            IConfiguration configuracion)
        {
            servicios.AddDbContext<CampeonatosFIFAContext>(opciones =>
            {
                opciones.UseSqlServer(configuracion.GetConnectionString("CampeonatosFIFA"));
            });

            //agregar repositorios
            servicios.AddTransient<ISeleccionRepositorio, SeleccionRepositorio>();
            servicios.AddTransient<ICampeonatoRepositorio, CampeonatoRepositorio>();
            servicios.AddTransient<ICiudadRepositorio, CiudadRepositorio>();
            servicios.AddTransient<IEstadioRepositorio, EstadioRepositorio>();
            servicios.AddTransient<IGrupoRepositorio, GrupoRepositorio>();
            servicios.AddTransient<IGrupoPaisRepositorio, GrupoPaisRepositorio>();
            servicios.AddTransient<IFaseRepositorio, FaseRepositorio>();
            servicios.AddTransient<IEncuentroRepositorio, EncuentroRepositorio>();

            //agregar servicios
            servicios.AddTransient<ISeleccionServicio, SeleccionServicio>();
            servicios.AddTransient<ICampeonatoServicio, CampeonatoServicio>();
            servicios.AddTransient<ICiudadServicio, CiudadServicio>();
            servicios.AddTransient<IEstadioServicio, EstadioServicio>();
            servicios.AddTransient<IGrupoServicio, GrupoServicio>();
            servicios.AddTransient<IFaseServicio, FaseServicio>();
            servicios.AddTransient<IEncuentroServicio, EncuentroServicio>();

            return servicios;
        }
    }
}
