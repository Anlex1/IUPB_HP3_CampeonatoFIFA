using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface IGrupoPaisRepositorio
    {
        Task<IEnumerable<GrupoPais>> ObtenerPaises(int IdGrupo);

        Task<GrupoPais> Obtener(int IdGrupo, int IdPais);

        Task<GrupoPais> Agregar(GrupoPais GrupoPais);

        Task<GrupoPais> Modificar(GrupoPais GrupoPais);

        Task<bool> Eliminar(int IdGrupo, int IdPais);
    }
}
