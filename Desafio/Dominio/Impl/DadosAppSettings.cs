using Desafio.Dominio.Interface;
using Desafio.Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using Polly;
using Polly.Retry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Dominio.Impl
{
    public class DadosAppSettings : IDadosAppSettings
    {
        public IConfiguration _configuration { get; set; }
        public string BaseUrlMock { get; set; }
        public DadosAppSettings(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DadosAppSettings RetornarDadosAppSettings()
        {
            this.BaseUrlMock = _configuration.GetSection("MockApiRest").GetSection("baseUrl").Value;
            return this;
        }       
    }
}
