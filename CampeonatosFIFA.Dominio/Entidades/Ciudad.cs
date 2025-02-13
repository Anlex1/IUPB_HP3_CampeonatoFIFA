using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonatosFIFA.Dominio.Entidades
{
    [Table("Ciudad")]
    public class Ciudad
    {
        [Column("Id")]
        public int Id { get; set; }

        [Column("Ciudad"), StringLength(100)]
        public required string Nombre { get; set; }

        [Column("IdPais")]
        public int IdPais { get; set; }

        public Seleccion Pais { get; set; }
    }
}
