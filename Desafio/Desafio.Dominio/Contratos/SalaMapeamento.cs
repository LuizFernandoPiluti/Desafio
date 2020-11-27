using Desafio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Desafio.Dominio.Contratos
{
    public static class SalaMapeamento
    {
        public static SalaBase Map(Sala sala)
        {
            return new SalaBase
            {
                Id = sala.IdSala,
                cod_sala = sala.CodigoSala,
                sala = sala.NomeSala,
                ordem_matriz = sala.OrdemMatriz,
                tipo_sala = sala.TipoSala,
                tamanho_sala = sala.TamanhoSala
            };
        }

        public static Sala Map(SalaBase sala)
        {
            if (sala.Id > 0)
            {
                return new Sala
                {
                    IdSala = sala.Id,
                    CodigoSala = sala.cod_sala,
                    NomeSala = sala.sala,
                    OrdemMatriz = sala.ordem_matriz,
                    TipoSala = sala.tipo_sala,
                    TamanhoSala = sala.tamanho_sala
              
                };
            }
            else
            {
                return new Sala
                {

                    CodigoSala = sala.cod_sala,
                    NomeSala = sala.sala,
                    OrdemMatriz = sala.ordem_matriz,
                    TipoSala = sala.tipo_sala,
                    TamanhoSala = sala.tamanho_sala
                };
            }


        }
    }
}
