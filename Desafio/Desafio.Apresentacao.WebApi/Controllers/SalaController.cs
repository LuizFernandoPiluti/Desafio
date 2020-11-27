using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Desafio.Aplicacao;
using Desafio.Dominio.Contratos;
using Desafio.Dominio.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Apresentacao.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        protected readonly ServicoAplicacaoDados<Sala> _aplicacao;
        // GET: api/Sala
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Sala/5
        [HttpGet("{id}", Name = "Get")]
        public SalaBase Get(int id)
        {
            try
            {
                return SalaMapeamento.Map(_aplicacao.RecuperarporId(id));
            }
            catch (Exception)
            {

                throw;
            }
        }

        // POST: api/Sala
        [HttpPost]
        public ActionResult Post([FromBody] SalaBase sala)
        {
            try
            {
                _aplicacao.Inserir(SalaMapeamento)
            }
            catch (Exception)
            {

                throw;
            }
            return Ok();
        }

        // PUT: api/Sala/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
