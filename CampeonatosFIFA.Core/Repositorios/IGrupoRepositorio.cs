using CampeonatosFIFA.Dominio.DTOs;
using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface IGrupoRepositorio
    {
        Task<IEnumerable<Grupo>> ObtenerTodos();
        Task<Grupo> Obtener(int Id);
        Task<Grupo> Agregar(Grupo Grupo);
        Task<Grupo> Modificar(Grupo Grupo);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<Grupo>> Buscar(int Tipo, string Dato);
        Task<IEnumerable<Grupo>> ObtenerCampeonato(int idCampeonato);

       Task<IEnumerable<TablaPosicionesDto>> ObtenerTablaPosicionesGrupo(int IdGrupo);
    }
}
