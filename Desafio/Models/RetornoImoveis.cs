using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{    
    public class RetornoImoveis
    {
        public int IdImovel { get; set; }
        public string TipoImovel { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorLocacao { get; set; }
        public decimal AreaConstruida { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int Cep { get; set; }
    }
}