using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Reflection;

namespace ScannTechSDK.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EstadoPromocao
    {
        /// <summary>
        /// Promoções que não foram aceitadas ou rejeitadas pelo minorista.
        /// </summary>
        [EnumMember(Value = "PENDIENTE")]
        Pendentes,
        /// <summary>
        /// Promoções aceitas pelo minorista.
        /// </summary>
        [EnumMember(Value = "ACEPTADA")]
        Aceitas,
        /// <summary>
        /// Promoções rejeitadas pelo minorista.
        /// </summary>
        [EnumMember(Value = "RECHAZADA")]
        Rejeitadas
    }

    public static class EstadoPromocaoExtensions
    {
        public static string ToParameter(this EstadoPromocao estado)
        {
            var type = typeof(EstadoPromocao);
            var memInfo = type.GetMember(estado.ToString());
            var attribute = ((EnumMemberAttribute)memInfo[0].GetCustomAttribute(typeof(EnumMemberAttribute), false));
            return attribute?.Value ?? estado.ToString();
        }
    }
}
