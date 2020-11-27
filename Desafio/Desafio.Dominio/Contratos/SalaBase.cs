using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Desafio.Dominio.Contratos
{
    [Serializable]
    public class SalaBase
    {
        public int Id { get; set; }
        [JsonProperty(PropertyName = "cod_sala")]
        public string CodigoSala { get; set; }

        [JsonProperty(PropertyName = "sala")]
        public string NomeSala { get; set; }

        [JsonProperty(PropertyName = "ordem_matriz")]
        public int OrdemMatriz { get; set; }

        [JsonProperty(PropertyName = "tipo_sala")]
        public string TipoSala { get; set; }

        [JsonProperty(PropertyName = "tamanho_sala")]
        public string TamanhoSala { get; set; }
    }
}
