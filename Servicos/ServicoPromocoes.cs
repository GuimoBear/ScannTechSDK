using ScannTechSDK.Enums;
using ScannTechSDK.Mensagens.Promocao;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ScannTechSDK.Servicos
{
    public class ServicoPromocoes : ServicoBase
    {
        public ServicoPromocoes(string usuario, string senha, int Codigo_Empresa, int Codigo_Local) : base(usuario, senha, Codigo_Empresa, Codigo_Local) { }

        public async Task<DefinicaoPromocoesResponse> ConsultarPromocoesAsync(EstadoPromocao estado)
        {
            try
            {
                var request = MakeAuthenticated($"{BaseUrl}promociones?estado={estado.ToParameter()}", HttpMethod.Get);
                var response = await client.SendAsync(request);
                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Ocorreu um erro ao consultar o estado das promoções, StatusCode {response.StatusCode}");
                var json = await response.Content.ReadAsStringAsync();
                return DefinicaoPromocoesResponse.FromJson(json);
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao consultar", ex);
            }
        }
    }
}
