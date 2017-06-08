using System;
using System.Net.Http;
using System.Text;

namespace ScannTechSDK.Servicos
{
    public class ServicoBase: IDisposable
    {
        public static readonly string URL_BASE = "http://test.parceiro.scanntech.com/pmkt-rest-api/minoristas/";

        static ServicoBase()
        {
            var env = Environment.GetEnvironmentVariable("ENVIRONMENT") ?? "PRODUCAO";
            if (env.Equals("PRODUCAO"))
                return;
        }

        private string Usuario { get; }
        private string Senha { get; }
        private int CodigoEmpresa { get; }
        private int CodigoLocal { get; }

        public string BaseUrl
        {
            get
            {
                return $"{URL_BASE}{CodigoEmpresa}/locales/{CodigoLocal}/";
            }
        }

        protected HttpClient client { get; } = new HttpClient();

        public ServicoBase(string usuario, string senha, int Codigo_Empresa, int Codigo_Local)
        {
            Usuario = usuario;
            Senha = senha;
            CodigoEmpresa = Codigo_Empresa;
            CodigoLocal = Codigo_Local;
        }

        public HttpRequestMessage MakeAuthenticated(string url, HttpMethod method)
        {
            var result = default(HttpRequestMessage);
            try
            {
                result = new HttpRequestMessage(method, url);
                result.Headers.TryAddWithoutValidation("Content-Type", "application/json");
                result.Headers.TryAddWithoutValidation("Accept", "application/json");
                result.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("basic", MakeBase64String(Usuario + ":" + Senha));
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected string MakeBase64String(string input) => Convert.ToBase64String(Encoding.UTF8.GetBytes(input));

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
