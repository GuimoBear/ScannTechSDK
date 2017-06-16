using ScannTechSDK.Utils.Excecoes;
using ScannTechSDK.Utils.Validadores;
using System;
using System.Net.Http;
using System.Text;

namespace ScannTechSDK.Entidades
{
    public class Empresa
    {
        public static readonly string URL_BASE = "http://test.parceiro.scanntech.com/pmkt-rest-api/minoristas/";

        static Empresa()
        {
            var env = Environment.GetEnvironmentVariable("ENVIRONMENT") ?? "PRODUCAO";
            if (env.Equals("PRODUCAO"))
                return;
        }

        public int Codigo { get; }
        public int Local { get; }
        public string Usuario { get; }
        public string Senha { get; }

        private string BaseUrl
        {
            get
            {
                return $"{URL_BASE}{Codigo}/locales/{Local}/";
            }
        }

        public Empresa(int codigo, int local, string usuario, string senha)
        {
            if (!codigo.MaiorQueZero())
                throw new CodigoEmpresaInvalidoExcecao(codigo);
            if (!local.MaiorQueZero())
                throw new LocalEmpresaInvalidoExcecao(local);
            if(ValidacaoString.EstaNula(usuario) || usuario.EstaVazia())
                throw new UsuarioEmpresaInvalidoExcecao(usuario);
            if (ValidacaoString.EstaNula(senha) || senha.EstaVazia())
                throw new SenhaEmpresaInvalidaExcecao(senha);
            Codigo = codigo;
            Local = local;
            Usuario = usuario;
            Senha = senha;
        }

        private string MakeBase64String(string input) => Convert.ToBase64String(Encoding.UTF8.GetBytes(input));

        public HttpRequestMessage CriarRequisicao(HttpMethod metodo, string path)
        {
            var result = default(HttpRequestMessage);
            try
            {
                if (ValidacaoString.EstaNula(path) || path.EstaVazia())
                    throw new PathInvalidoExcecao(path);
                if (path.StartsWith("/"))
                    path = path.Remove(0, 1);
                result = new HttpRequestMessage(metodo, new Uri($"{BaseUrl}{path}"));
                result.Headers.TryAddWithoutValidation("Content-Type", "application/json");
                result.Headers.TryAddWithoutValidation("Accept", "application/json");
                result.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("basic", MakeBase64String(Usuario + ":" + Senha));
                return result;
            }
            catch (Exception ex)
            {
                throw new CriacaoRequisicaoEmpresaExcecao(ex, Codigo, Local, Usuario);
            }
        }
    }
}
