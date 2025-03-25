using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface IFaseRepositorio
    {
        Task<IEnumerable<Fase>> ObtenerTodos();

        Task<Fase> Obtener(int Id);

        Task<Fase> Agregar(Fase Fase);

        Task<Fase> Modificar(Fase Fase);

        Task<bool> Eliminar(int Id);

        Task<IEnumerable<Fase>> Buscar(int Tipo, string Dato);
    }
}
