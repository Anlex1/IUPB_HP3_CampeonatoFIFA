using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Servicios
{
    public interface IEstadioServicio
    {
        Task<IEnumerable<Estadio>> ObtenerTodos();

        Task<Estadio> Obtener(int Id);

        Task<Estadio> Agregar(Estadio Estadio);

        Task<Estadio> Modificar(Estadio Estadio);

        Task<bool> Eliminar(int Id);

        Task<IEnumerable<Estadio>> Buscar(int Tipo, string Dato);
    }
}
