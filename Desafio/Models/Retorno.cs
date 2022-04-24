using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Models
{
    public class Retorno
    {
        public StatusCode StatusCode { get; set; }
        public string Mensagem { get; set; }
    }
}
