using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Fase")]
    public class Fase
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Fase"), StringLength(50)]
        public required string Nombre { get; set; }
    }
}
