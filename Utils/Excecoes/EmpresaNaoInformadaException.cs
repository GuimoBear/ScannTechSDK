using System;

namespace ScannTechSDK.Utils.Excecoes
{
    public class EmpresaNaoInformadaException: Exception
    {
        private const string MESSAGE = "É necessário informar o objeto empresa";
        public EmpresaNaoInformadaException(): base(MESSAGE) { }
    }
}
