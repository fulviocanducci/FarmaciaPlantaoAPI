using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmaciaPlantao.Api.DTOs
{
    public class FarmaciaDTO
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Whatsapp { get; set; }
        public string UrlImagem { get; set; }
        public string Cidade { get; set; }
        public string CidadeId { get; set; }
        public string Estado { get; set; }
        public string EstadoId { get; set; }
        public string UF { get; set; }
    }
}
