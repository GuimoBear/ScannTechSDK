using Newtonsoft.Json;
using ScannTechSDK.Entidades;
using ScannTechSDK.Utils.Excecoes;
using System;
using System.Net.Http;

namespace ScannTechSDK.Mensagens
{
    public class RequestBase: IDisposable
    {
        [JsonIgnore]
        protected HttpClient client = new HttpClient();
        [JsonIgnore]
        public Empresa Empresa { get; }

        public RequestBase(Empresa empresa)
        {
            if (empresa == default(Empresa))
                throw new EmpresaNaoInformadaException();
            this.Empresa = empresa;
        }

        public void Dispose()
        {
            client.Dispose();
        }
    }
}
