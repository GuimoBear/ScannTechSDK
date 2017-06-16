using ScannTechSDK.Entidades;
using ScannTechSDK.Enums;
using System;

namespace ScannTechSDK.Utils.Excecoes
{
    public class ConsultarPromocoesPorEstadoExcecao : Exception
    {
        private const string MESSAGE = "Ocorreu um erro ao consultar as promoções com o estado '{0}' para o usuario {1} da empresa {2} do local {3}";
        public ConsultarPromocoesPorEstadoExcecao(Empresa empresa, EstadoPromocao estado, Exception ex) : base(string.Format(MESSAGE, estado.ToParameter(), empresa.Usuario, empresa.Codigo, empresa.Local), ex) { }
    }
}
