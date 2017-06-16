using System;

namespace ScannTechSDK.Utils.Excecoes
{
    public class CodigoEmpresaInvalidoExcecao: Exception
    {
        private const string MESSAGE = "o código informado({0}) deve ser maior que zero";
        public CodigoEmpresaInvalidoExcecao(int codigo): base(string.Format(MESSAGE, codigo)) { }
    }
}
