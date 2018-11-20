using Restaurante.Api.Models;
using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restaurante.Api.Controllers
{
    public class InformacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Informacion> Get()
        {
            using (InformacionContext context = new InformacionContext())
            {
                context.Detalles.ToList();
                return context.Informacions.ToList();
            }
        }
    }
}
