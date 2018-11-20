using Newtonsoft.Json;
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
    public class LoginController : ApiController
    {
        [HttpPost]
        public Validar Post(Usuarios usuario)
        {
            using(var context = new InformacionContext())
            {
                Validar validar = new Validar();
                var usuarios = context.Usuarios.Count(x => x.Usuario == usuario.Usuario);
                var password = context.Usuarios.Count(x => x.Password == usuario.Password);
                
                if(usuarios >=1 && password >= 1)
                {
                    validar.Espermitido = true;
                    validar.Mensaje = "ok";
                }
                else
                {
                    validar.Espermitido = false;
                    validar.Mensaje = "Vuelve A Intentarlo Joven";
                }
                JsonConvert.SerializeObject(validar);
                return validar;
            }
        }
    }
}
