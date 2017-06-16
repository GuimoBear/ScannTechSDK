using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ScannTechSDK.Entidades;
using ScannTechSDK.Enums;
using System;

namespace ScannTechSDK.Mensagens.Promocao
{
    public class VendaRequest : RequestBase
    {
        [JsonProperty("fecha")]
        public DateTime DataHoraMovimentacao { get; set; }
        [JsonProperty("numero"), JsonConverter(typeof(StringToIntConverter))]
        public int Numero { get; set; }
        [JsonProperty("descuentoTotal")]
        public double DescontoTotal { get; set; }
        [JsonProperty("recargoTotal")]
        public double SobretaxaTotal { get; set; }
        [JsonProperty("codigoMoneda")]
        public CodigoMoeda CodigoMoeda { get; set; } = CodigoMoeda.BRL;
        [JsonProperty("cotizacion")]
        public double ContribuicaoTributaria { get; set; }
        [JsonProperty("total")]
        public double Total { get; set; }
        [JsonProperty("cancelacion")]
        public bool Cancelamento { get; set; } = false;

        public VendaRequest(Empresa empresa) : base(empresa) { }
    }
}
