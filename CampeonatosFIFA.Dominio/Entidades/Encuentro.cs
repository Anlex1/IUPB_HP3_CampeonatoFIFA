using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Encuentro")]
    public class Encuentro
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("IdPais1")]
        public int IdPais1 { get; set; }

        [Column("IdPais2")]
        public int IdPais2 { get; set; }

        [Column("IdEstadio")]
        public int IdEstadio { get; set; }

        [Column("IdFase")]
        public int IdFase { get; set; }

        [Column("IdCampeonato")]
        public int IdCampeonato { get; set; }

        [Column("Fecha")]
        public DateTime Fecha { get; set; }

        [Column("Goles1")]
        public int Goles1 { get; set; }

        [Column("Goles2")]
        public int Goles2 { get; set; }

        public Seleccion Pais1 { get; set; }
        public Seleccion Pais2 { get; set; }
        public Estadio Estadio { get; set; }
        public Fase Fase { get; set; }
        public Campeonato Campeonato { get; set; }
    }
}
