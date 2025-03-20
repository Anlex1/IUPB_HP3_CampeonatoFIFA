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
        Task<IEnumerable<GrupoPais>> ObtenerTodos();
        Task<GrupoPais> Obtener(int Id);
        Task<GrupoPais> Agregar(GrupoPais GrupoPais);
        Task<GrupoPais> Modificar(GrupoPais GrupoPais);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<GrupoPais>> Buscar(int Tipo, string Dato);
    }
}
