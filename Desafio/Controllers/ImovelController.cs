using Desafio.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace Desafio.Controllers
{
    public class ImovelController : Controller
    {
        public IActionResult CadastroImovel()
        {
            return View();
        }
        public async Task<ActionResult> CadastrarImovel(Imovel imovel)
        {
            Imovel dadosImovel = new Imovel
            {
                IdImovel = imovel.IdImovel,
                TipoImovel = imovel.TipoImovel,
                AreaConstruida = imovel.AreaConstruida,
                ValorLocacao = imovel.ValorLocacao,
                ValorVenda = imovel.ValorVenda,
                Bairro = imovel.Bairro,
                Cep = imovel.Cep,
                Cidade = imovel.Cidade,
                Complemento = imovel.Complemento,
                Estado = imovel.Estado,
                Numero = imovel.Numero

            };
            //consumo da api Post
            bool resultado = await SalvarImovelMock(dadosImovel);
            if (resultado)
            {
                var model = await BuscarImoveisMock();
                return View("BuscarImoveis", model);
            } 
            else//criar mensagem de erro
                return null;
        }
        [HttpPost]
        public async Task<bool> SalvarImovelMock(Imovel dadosImovel)
        {            
            using (HttpClient cliente = new HttpClient())
            {
                bool retornoSucesso = false;
                var json = JsonConvert.SerializeObject(dadosImovel);
                cliente.BaseAddress = new Uri("https://6261a57473499e9af90fb611.mockapi.io");
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var testePegarJson = await content.ReadAsStringAsync();
                var result = await cliente.PostAsync("api/v1/CadastroImovel", content);
                Task<string> resultContent = result.Content.ReadAsStringAsync();
                var codigoRetorno = (int)result.StatusCode;
                var JsonRetorno = resultContent.Result;
                if (codigoRetorno == 201)
                {
                    retornoSucesso = true;
                    return retornoSucesso;
                }
                return retornoSucesso;
            }


        }
        public async Task<ActionResult> BuscarImoveis()
        {
            var model = await BuscarImoveisMock();
            return View(model);
        }
        [HttpGet]
        //consumo da api Get
        public async Task<List<RetornoImoveis>> BuscarImoveisMock()
        {
            List<RetornoImoveis> listaImoveis = new List<RetornoImoveis>();
            using (HttpClient cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("https://6261a57473499e9af90fb611.mockapi.io");
                var content = new StringContent("application/json");
                var testePegarJson = await content.ReadAsStringAsync();
                var resposta = await cliente.GetAsync("api/v1/CadastroImovel");
                var retornoMock = await resposta.Content.ReadAsStringAsync();
                listaImoveis = JsonConvert.DeserializeObject<List<RetornoImoveis>>(retornoMock);
                return listaImoveis;
            }
        }
    }
}
