using System;

namespace ScannTechSDK.Utils.Excecoes
{
    public class UsuarioEmpresaInvalidoExcecao : Exception
    {
        private const string MESSAGE = "o usuario informado({0}) deve ser preenchido";
        public UsuarioEmpresaInvalidoExcecao(string usuario): base(string.Format(MESSAGE, usuario)) { }
    }
}
