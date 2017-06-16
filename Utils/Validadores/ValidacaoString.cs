using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScannTechSDK.Utils.Validadores
{
    public static class ValidacaoString
    {
        public static bool EstaNula(string value) => value == null;
        public static bool EstaVazia(this string value) => string.IsNullOrWhiteSpace(value);
    }
}
