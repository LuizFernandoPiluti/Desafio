using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Desafio.Aplicacao;
using Desafio.Dominio.Contratos;
using Desafio.Dominio.Entidades;
using Desafio.Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Desafio.Apresentacao.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaController : ControllerBase
    {
        protected readonly IServicoAplicacaoDados<Sala> _aplicacaoSala;

        public SalaController(IServicoAplicacaoDados<Sala> servicoAplicacaoDados)
        {
            _aplicacaoSala = servicoAplicacaoDados;
        }
        // GET: api/Sala
        [HttpGet]
        public ActionResult Get()
        {
            try
            {

                var salas = _aplicacaoSala.RecuperarTodos();

                List<SalaBase> list = new List<SalaBase>();

                if (salas != null && salas.Count  >0)
                {
                    foreach (var sala in salas)
                    {
                        list.Add(SalaMapeamento.Map(sala));
                    }
                  
                    return StatusCode(200, list);
                }
                else
                {
                    return NotFound("Nenhuma sala localizada");
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
                    return NotFound("Sala não localizada");
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

                var salaDomain = SalaMapeamento.Map(sala);
                _aplicacaoSala.Inserir(salaDomain);
                return StatusCode(201, salaDomain);
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


                salaDomain.NomeSala = sala.sala;
                salaDomain.CodigoSala = sala.cod_sala;
                salaDomain.OrdemMatriz = sala.ordem_matriz;
                salaDomain.TipoSala = sala.tipo_sala;
                salaDomain.TamanhoSala = sala.tamanho_sala;

            
                _aplicacaoSala.Alterar(salaDomain);
                return StatusCode(200, salaDomain);
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
                return StatusCode(200);
            }
            catch (Exception)
            {

                return StatusCode(500);
            }
        }
    }
}
