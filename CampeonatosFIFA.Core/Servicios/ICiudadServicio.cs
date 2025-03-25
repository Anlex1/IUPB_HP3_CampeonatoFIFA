using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Servicios
{
    public interface ICiudadServicio
    {
        Task<IEnumerable<Ciudad>> ObtenerTodos();

        Task<Ciudad> Obtener(int Id);

        Task<Ciudad> Agregar(Ciudad Ciudad);

        Task<Ciudad> Modificar(Ciudad Ciudad);

        Task<bool> Eliminar(int Id);

        Task<IEnumerable<Ciudad>> Buscar(int Tipo, string Dato);
    }
}
