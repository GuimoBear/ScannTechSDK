using Newtonsoft.Json;
using ScannTechSDK.Entidades;
using ScannTechSDK.Enums;
using ScannTechSDK.Utils.Excecoes;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScannTechSDK.Mensagens.Promocao
{
    public class DefinicaoPromocoesRequest: RequestBase
    {
        public DefinicaoPromocoesRequest(Empresa empresa) : base(empresa) { }

        public async Task<DefinicaoPromocoesResponse> ConsultarPromocoes(EstadoPromocao estado)
        {
            try
            {
                var request = Empresa.CriarRequisicao(HttpMethod.Get, $"promociones?estado={estado.ToParameter()}");
                var response = await client.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"A consulta retornou o código {response.StatusCode}");
                var strResponse = await response.Content.ReadAsStringAsync();
                return DefinicaoPromocoesResponse.FromJson(strResponse);
            }
            catch (Exception ex)
            {
                throw new ConsultarPromocoesPorEstadoExcecao(Empresa, estado, ex);
            }
        }
    }
}
