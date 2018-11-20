using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurante.Api.Models
{
    public class InformacionContext : DbContext
    {
        public InformacionContext() : base("InformacionConnection")
        {

        }

        public DbSet<Informacion> Informacions  { get; set; }
        public DbSet<Detalle> Detalles { get; set; }
        public DbSet<Usuarios> Usuarios  { get; set; }
        public DbSet<Validar> Validaciones { get; set; }
    }
}