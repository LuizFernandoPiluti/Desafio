using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
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
        protected readonly ServicoAplicacaoDados<Sala> _aplicacaoSala;
        protected readonly ServicoAplicacaoDados<TipoSala> _aplicacaoTipoSala;
        protected readonly ServicoAplicacaoDados<TamanhoSala> _aplicacaoTamanhoSala;
        // GET: api/Sala
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                var salas = _aplicacaoSala.RecuperarTodos();

                List<SalaBase> list = new List<SalaBase>();

                if (salas != null)
                {
                    foreach (var sala in salas)
                    {
                        list.Add(SalaMapeamento.Map(sala));
                    }
                  
                    return StatusCode(200, list);
                }
                else
                {
                    return BadRequest("Tipo de sala invalido");
                }

            }
            catch (Exception)
            {
                return StatusCode(500, "Erro ao consultar sala");
            }
        }

        // GET: api/Sala/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            try
            {

                var sala = _aplicacaoSala.RecuperarporId(id);

                if (sala!= null)
                {
                    return  StatusCode(200,SalaMapeamento.Map(sala));
                }
                else
                {
                    return BadRequest("Tipo de sala invalido");
                }
               
            }
            catch (Exception)
            {
               return StatusCode(500,"Erro ao consultar sala");
            }
        }

        // POST: api/Sala
        [HttpPost]
        public ActionResult Post([FromBody] SalaBase sala)
        {
            try
            {
                var tipo = _aplicacaoTipoSala.RecuperarTodos().Where(x => x.DescricaoTipoSala.ToLower().Trim().Equals(sala.TipoSala.ToLower().Trim())).FirstOrDefault();

                if (tipo == null)
                {
                    return BadRequest("Tipo de sala invalido");
                }

                var tamanho = _aplicacaoTamanhoSala.RecuperarTodos().Where(x => x.DescricaoTamanhoSala.ToLower().Trim().Equals(sala.TamanhoSala.ToLower().Trim())).FirstOrDefault();

                if (tamanho == null)
                {
                    return BadRequest("Tamanho de sala invalido");
                }
                _aplicacaoSala.Inserir(SalaMapeamento.Map(sala, tipo, tamanho));
                return StatusCode(201);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
           
        }

        // PUT: api/Sala/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]  SalaBase sala)
        {
            try
            {

                var salaDomain = _aplicacaoSala.RecuperarporId(id);
                if (salaDomain == null)
                {
                    return BadRequest("Sala não localizada");
                }

                var tipo = _aplicacaoTipoSala.RecuperarTodos().Where(x => x.DescricaoTipoSala.ToLower().Trim().Equals(sala.TipoSala.ToLower().Trim())).FirstOrDefault();

                if (tipo == null)
                {
                    return BadRequest("Tipo de sala invalido");
                }

                var tamanho = _aplicacaoTamanhoSala.RecuperarTodos().Where(x => x.DescricaoTamanhoSala.ToLower().Trim().Equals(sala.TamanhoSala.ToLower().Trim())).FirstOrDefault();

                if (tamanho == null)
                {
                    return BadRequest("Tamanho de sala invalido");
                }

                sala.Id = salaDomain.IdSala;

                _aplicacaoSala.Alterar(SalaMapeamento.Map(sala, tipo, tamanho));
                return StatusCode(201);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _aplicacaoSala.Remover(id);
                return StatusCode(201);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
