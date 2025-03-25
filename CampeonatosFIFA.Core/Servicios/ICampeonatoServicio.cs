using CampeonatosFIFA.Dominio.Entidades;


namespace CampeonatosFIFA.Core.Servicios
{
    public interface ICampeonatoServicio
    {
        Task<IEnumerable<Campeonato>> ObtenerTodos();
        Task<Campeonato> Obtener(int Id);
        Task<Campeonato> Agregar(Campeonato campeonato);
        Task<Campeonato> Modificar(Campeonato campeonato);
        Task<bool> Eliminar(int Id);
        Task<IEnumerable<Campeonato>> Buscar(int Tipo, string Dato);
    }
}
