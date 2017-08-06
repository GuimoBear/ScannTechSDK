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
        /// Promoção oferecida e já aceita
        /// </summary>
        [EnumMember(Value = "ofrecida_aceptada")]
        OferecidaEAceita,

        /// <summary>
        /// Promoção oferecida e ainda não aceita
        /// </summary>
        [EnumMember(Value = "ofrecida_pendiente")]
        OferecidaEPendente,

        /// <summary>
        /// Promoção oferecida e rejeitada
        /// </summary>
        [EnumMember(Value = "ofrecida_rechazada")]
        OferecidaERejeitada,

        /// <summary>
        /// Promoção própria criada como esboço
        /// </summary>
        [EnumMember(Value = "propia_borrador")]
        PropriaEsboco,

        /// <summary>
        /// Promoção própria já ativa
        /// </summary>
        [EnumMember(Value = "propia_activa")]
        PropriaAtiva
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
