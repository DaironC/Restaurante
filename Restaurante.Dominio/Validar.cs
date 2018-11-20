using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    [Table("Validar")]
    public class Validar
    {
        public int Id { get; set; }
        [Required]
        public bool Espermitido { get; set; }
        [Required]
        [MaxLength(50)]
        public string Mensaje { get; set; }
    }
}
