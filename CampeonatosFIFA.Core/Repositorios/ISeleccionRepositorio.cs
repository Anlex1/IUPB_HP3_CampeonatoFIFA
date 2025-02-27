using CampeonatosFIFA.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Core.Repositorios
{
    public interface ISeleccionRepositorio
    {
        Task<IEnumerable<Seleccion>> ObtenerTodos();
        Task<Seleccion> Obtener(int Id);
        Task<Seleccion> Agregar(Seleccion Seleccion);
        Task<Seleccion> Modificar(Seleccion seleccion);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<Seleccion>> Buscar(int Tipo, string Dato);
    }
}
