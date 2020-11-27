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

        public static Sala Map(SalaBase sala)
        {
            return new Sala
            {
                CodigoSala = sala.CodigoSala,
                NomeSala = sala.NomeSala,
                OrdemMatriz = sala.OrdemMatriz,
                TipoSala = sala.TipoSala.de
                TamanhoSala = sala.TamanhoSala.DescricaoTamanhoSala
            };
        }
    }
}
