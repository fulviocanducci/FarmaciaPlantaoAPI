using Newtonsoft.Json;
using System.Collections.Generic;

namespace FarmaciaPlantao.Api.DTOs
{
    public class ErrorDto
    {
        [JsonProperty("erros")]
        public List<string> Erros { get; set; } = new List<string>();

        public void AdicionarErro(string erro)
        {
            if (string.IsNullOrEmpty(erro?.Trim()))
                return;

            Erros.Add(erro);
        }
    }
}
