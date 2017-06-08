using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ScannTechSDK.Enums;
using System;
using System.Collections.Generic;

namespace ScannTechSDK.Mensagens.Promocao
{
    public class DefinicaoPromocoesResponse
    {
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringToIntConverter))]
        public int Total { get; private set; }
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ResultadoPromocao> Resultados { get; private set; }

        public static DefinicaoPromocoesResponse FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DefinicaoPromocoesResponse>(json);
        }
    }

    public class ResultadoPromocao
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore), JsonConverter(typeof(StringToIntConverter))]
        public int Id { get; private set; }
        [JsonProperty("titulo", NullValueHandling = NullValueHandling.Ignore)]
        public string Titulo { get; private set; }
        [JsonProperty("descripcion", NullValueHandling = NullValueHandling.Ignore)]
        public string Descricao { get; private set; }
        [JsonProperty("tipo", NullValueHandling = NullValueHandling.Ignore)]
        public TipoPromocao Tipo { get; private set; }
        [JsonProperty("detalle", NullValueHandling = NullValueHandling.Ignore)]
        public DetalhePromocao Detalhes { get; set; }
        [JsonProperty("autor", NullValueHandling = NullValueHandling.Ignore)]
        public AutorPromocao Autor { get; private set; }
        [JsonProperty("vigenciaDesde", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime VigenteDesde { get; private set; }
        [JsonProperty("vigenciaHasta", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime VigenteAte { get; private set; }
    }

    public class AutorPromocao
    {
        [JsonProperty("descripcion", NullValueHandling = NullValueHandling.Ignore)]
        public string Descricao { get; private set; }
    }

    public class DetalhePromocao
    {
        [JsonProperty("condiciones", NullValueHandling = NullValueHandling.Ignore)]
        public CondicaoBeneficioPromocao Condicao { get; private set; }
        [JsonProperty("beneficios", NullValueHandling = NullValueHandling.Ignore)]
        public CondicaoBeneficioPromocao Beneficio { get; private set; }
        [JsonProperty("precio", NullValueHandling = NullValueHandling.Ignore)]
        public double? Preco { get; private set; }
        [JsonProperty("descuento", NullValueHandling = NullValueHandling.Ignore)]
        public double? Desconto { get; private set; }
        [JsonProperty("paga", NullValueHandling = NullValueHandling.Ignore)]
        public double? Paga { get; private set; }
    }

    public class CondicaoBeneficioPromocao
    {
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ItemPromocao> Itens { get; private set; }
    }

    public class ItemPromocao
    {
        [JsonProperty("cantidad", NullValueHandling = NullValueHandling.Ignore)]
        public double Quantidade { get; private set; }
        [JsonProperty("articulos", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ArtigoPromocao> Artigos { get; private set; }
    }

    public class ArtigoPromocao
    {
        [JsonProperty("codigoBarras", NullValueHandling = NullValueHandling.Ignore)]
        public string CodigoBarras { get; private set; }
        [JsonProperty("nombre", NullValueHandling = NullValueHandling.Ignore)]
        public string Nome { get; private set; }
    }
}
