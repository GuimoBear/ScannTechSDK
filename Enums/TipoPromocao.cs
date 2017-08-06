using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ScannTechSDK.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TipoPromocao
    {
        [EnumMember(Value = "LLEVA_PAGA")]
        LevaPaga = 1,
        [EnumMember(Value = "ADICIONAL_DESCUENTO")]
        DescontoAdicional = 2,
        [EnumMember(Value = "ADICIONAL_REGALO")]
        PresenteAdicional = 3,
        [EnumMember(Value = "PRECIO_FIJO")]
        PrecoFixo = 4,
        [EnumMember(Value = "DESCUENTO_VARIABLE")]
        DescontoVariado = 5,
        [EnumMember(Value = "DESCUENTO_FIJO")]
        DescontoFixo = 6
    }
}
