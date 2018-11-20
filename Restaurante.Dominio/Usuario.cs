using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    [Table("Usuarios")]
    public class Usuarios
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Usuario { get; set; }

        [Required]
        [MaxLength(50)]
        public string Password { get; set; }
    }
}
