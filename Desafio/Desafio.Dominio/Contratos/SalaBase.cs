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
        public string cod_sala { get; set; }

        [JsonProperty(PropertyName = "sala")]
        public string sala { get; set; }

        [JsonProperty(PropertyName = "ordem_matriz")]
        public int ordem_matriz { get; set; }

        [JsonProperty(PropertyName = "tipo_sala")]
        public string tipo_sala { get; set; }

        [JsonProperty(PropertyName = "tamanho_sala")]
        public string tamanho_sala { get; set; }
    }
}
