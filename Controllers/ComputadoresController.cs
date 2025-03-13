using ComputadoresITM.Clases;
using ComputadoresITM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ComputadoresITM.Controllers
{
    [RoutePrefix("api/Computadores")]
    public class ComputadoresController : ApiController
    {
        [HttpGet]
        [Route("ConsultarTodos")]
        public List<Computador> ConsultarTodos()
        {
            clsComputador Computador = new clsComputador();
            return Computador.ConsultarTodos();
        }

        [HttpGet]
        [Route("ConsultarXCodigo")]
        public Computador ConsultarXCodigo(int codigo)
        {
            clsComputador Computador = new clsComputador();
            return Computador.ConsultarXCodigo(codigo);
        }

        [HttpPost]
        [Route("Insertar")]
        public string Insertar([FromBody] Computador computador)
        {
            clsComputador Computador = new clsComputador();
            Computador.computador = computador;
            return Computador.Insertar();
        }

        [HttpPut]
        [Route("Actualizar")]
        public string Actualizar([FromBody] Computador computador)
        {
            clsComputador Computador = new clsComputador();
            Computador.computador = computador;
            return Computador.Actualizar();
        }

        [HttpDelete]
        [Route("Eliminar")]
        public string Eliminar([FromBody] Computador computador)
        {
            clsComputador Computador = new clsComputador();
            Computador.computador = computador;
            return Computador.Eliminar();
        }


    }
}