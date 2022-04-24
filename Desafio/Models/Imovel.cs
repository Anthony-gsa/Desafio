using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Imovel
    {
        [Key]
        public int IdImovel { get; set; }
        [Display(Name = "Tipo do Imóvel")]
        public string TipoImovel { get; set; }
        [Display(Name = "Valor da Venda")]
        public decimal ValorVenda { get; set; }
        [Display(Name = "Valor de Locação")]
        public decimal ValorLocacao { get; set; }
        [Display(Name = "Área Construída")]
        public decimal AreaConstruida { get; set; }
        [Display(Name = "Número")]
        public string Numero { get; set; }
        [Display(Name = "Complemento")]
        public string Complemento { get; set; }
        [Display(Name = "Bairro")]
        public string Bairro { get; set; }
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }
        [Display(Name = "Estado")]
        public string Estado { get; set; }        
        [Display(Name = "CEP")]
        public int Cep { get; set; }
    }
}
