using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    [Table("Informacion")]
    public class Informacion
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(30)]
        public string Especilidad { get; set; }

        [Required]
        [MaxLength(30)]
        public string Horario { get; set; }

        [Required]
        [MaxLength(30)]
        public string Direccion { get; set; }

        public string Imagen { get; set; }

        public List<Detalle> Detalles  { get; set; }
    }
}
