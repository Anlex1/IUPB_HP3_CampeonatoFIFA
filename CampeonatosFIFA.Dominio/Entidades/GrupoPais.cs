using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("GrupoPais")]
    public class GrupoPais
    {
        [Column("IdGrupo")]
        public int IdGrupo { get; set; }

        [Column("IdPais")]
        public int IdPais { get; set; }

        public Grupo Grupo { get; set; }
        public Seleccion Pais { get; set; }
    }
}
