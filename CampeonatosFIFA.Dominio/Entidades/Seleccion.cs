using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Pais")]
    public class Seleccion
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Pais"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("Entidad"), StringLength(100)]
        public required string Entidad {  get; set; }
    }
}
