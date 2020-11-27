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
                CodigoSala = sala.CodigoSala,
                NomeSala = sala.NomeSala,
                OrdemMatriz = sala.OrdemMatriz,
                TipoSala = sala.TipoSala.DescricaoTipoSala,
                TamanhoSala = sala.TamanhoSala.DescricaoTamanhoSala
            };
        }

        public static Sala Map(SalaBase sala, TipoSala tipo, TamanhoSala tamanho)
        {
            if (sala.Id > 0)
            {
                return new Sala
                {
                    IdSala = sala.Id,
                    CodigoSala = sala.CodigoSala,
                    NomeSala = sala.NomeSala,
                    OrdemMatriz = sala.OrdemMatriz,
                    IdTipoSala = tipo.IdTipoSala,
                    IdTamanhoSala = tamanho.IdTamanhoSala,
                    TipoSala = tipo,
                    TamanhoSala = tamanho
                };
            }
            else
            {
                return new Sala
                {

                    CodigoSala = sala.CodigoSala,
                    NomeSala = sala.NomeSala,
                    OrdemMatriz = sala.OrdemMatriz,
                    IdTipoSala = tipo.IdTipoSala,
                    IdTamanhoSala = tamanho.IdTamanhoSala,
                    TipoSala = tipo,
                    TamanhoSala = tamanho
                };
            }


        }
    }
}
