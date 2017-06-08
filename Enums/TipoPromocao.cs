using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ScannTechSDK.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TipoPromocao
    {
        [EnumMember(Value = "LLEVA_PAGA")]
        LevaPaga,
        [EnumMember(Value = "ADICIONAL_DESCUENTO")]
        DescontoAdicional,
        [EnumMember(Value = "ADICIONAL_REGALO")]
        PresenteAdicional,
        [EnumMember(Value = "PRECIO_FIJO")]
        PrecoFixo,
        [EnumMember(Value = "DESCUENTO_VARIABLE")]
        DescontoVariado,
        [EnumMember(Value = "DESCUENTO_FIJO")]
        DescontoFixo
    }
}
