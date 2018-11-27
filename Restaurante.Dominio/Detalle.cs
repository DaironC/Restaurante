using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante.Dominio
{
    [Table("Detalle")]
    public class Detalle
    {
        public int Id { get; set; }

        public int Informacion_Id { get; set; }

        [MaxLength(50)]
        public string Domicilios { get; set; }

        [MaxLength(50)]
        public string Reservas { get; set; }

        [MaxLength(50)]
        public string Descuentos { get; set; }

        [MaxLength(200)]
        public string Ubicacion { get; set; }

        public double Latitud { get; set; }

        public double Longitud { get; set; }

    }
}
