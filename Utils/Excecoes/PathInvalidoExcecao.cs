using System;

namespace ScannTechSDK.Utils.Excecoes
{
    public class PathInvalidoExcecao: Exception
    {
        private const string MESSAGE = "o path informado para a requisição({0}) é inválido";
        public PathInvalidoExcecao(string path): base(string.Format(MESSAGE, path)) { }
    }
}
