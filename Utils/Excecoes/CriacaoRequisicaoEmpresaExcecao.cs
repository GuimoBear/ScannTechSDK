using System;

namespace ScannTechSDK.Utils.Excecoes
{
    public class CriacaoRequisicaoEmpresaExcecao : Exception
    {
        private const string MESSAGE = "Ocorreu um erro ao criar a requisição autenticada para a empresa {0} na localização {1} para o usuário {2}";
        public CriacaoRequisicaoEmpresaExcecao(Exception ex, int codigoEmpresa, int localEmpresa, string usuarioEmpresa): base(string.Format(MESSAGE, codigoEmpresa, localEmpresa, usuarioEmpresa), ex) { }
    }
}
