using Desafio.Dominio.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio.Dominio.Interface
{
    public interface IDadosAppSettings
    {
        DadosAppSettings RetornarDadosAppSettings();
    }
}

