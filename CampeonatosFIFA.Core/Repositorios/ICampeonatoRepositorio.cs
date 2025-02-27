using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface ICampeonatoRepositorio
    {
        Task<IEnumerable<Campeonato>> ObtenerTodos();
        Task<Campeonato> Obtener(int Id);
        Task<Campeonato> Agregar(Campeonato campeonato);
        Task<Campeonato> Modificar(Campeonato campeonato);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<Campeonato>> Buscar(int Tipo, string Dato);
    }
}
