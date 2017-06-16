using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScannTechSDK.Utils.Excecoes
{
    public class LocalEmpresaInvalidoExcecao : Exception
    {
        private const string MESSAGE = "o código do local informado({0}) deve ser maior que zero";
        public LocalEmpresaInvalidoExcecao(int local): base(string.Format(MESSAGE, local)) { }
    }
}
