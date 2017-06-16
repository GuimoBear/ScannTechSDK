using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScannTechSDK.Utils.Excecoes
{
    public class SenhaEmpresaInvalidaExcecao : Exception
    {
        private const string MESSAGE = "a senha informada({0}) deve ser preenchida";
        public SenhaEmpresaInvalidaExcecao(string senha): base(string.Format(MESSAGE, senha)) { }
    }
}
