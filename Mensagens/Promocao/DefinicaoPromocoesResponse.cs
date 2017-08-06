using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ScannTechSDK.Enums;
using System;
using System.Collections.Generic;

namespace ScannTechSDK.Mensagens.Promocao
{
    public class DefinicaoPromocoesResponse
    {
        [JsonProperty("totalResults", NullValueHandling = NullValueHandling.Ignore)]
        public int Total { get; private set; }
        [JsonProperty("start", NullValueHandling = NullValueHandling.Ignore)]
        public int Inicio { get; private set; }
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ResultadoPromocao> Resultados { get; private set; }

        public static DefinicaoPromocoesResponse FromJson(string json)
        {
            return JsonConvert.DeserializeObject<DefinicaoPromocoesResponse>(json);
        }
    }

    public class ResultadoPromocao
    {
        [JsonProperty("codigoInterno", NullValueHandling = NullValueHandling.Ignore)]
        public int CodigoInterno { get; private set; }
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; private set; }
        [JsonProperty("titulo", NullValueHandling = NullValueHandling.Ignore)]
        public string Titulo { get; private set; }
        [JsonProperty("imgUrl", NullValueHandling = NullValueHandling.Ignore)]
        public string UrlImagem { get; private set; }
        [JsonProperty("descripcion", NullValueHandling = NullValueHandling.Ignore)]
        public string Descricao { get; private set; }
        [JsonProperty("estado", NullValueHandling = NullValueHandling.Ignore)]
        public string Estado { get; private set; }
        [JsonProperty("tipo", NullValueHandling = NullValueHandling.Ignore)]
        public TipoPromocao Tipo { get; private set; }
        [JsonProperty("detalles", NullValueHandling = NullValueHandling.Ignore)]
        public DetalhePromocao Detalhes { get; private set; }
        [JsonProperty("autor", NullValueHandling = NullValueHandling.Ignore)]
        public AutorPromocao Autor { get; private set; }
        [JsonProperty("vigenciaDesde", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime VigenteDesde { get; private set; }
        [JsonProperty("vigenciaHasta", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime VigenteAte { get; private set; }
        [JsonProperty("reintegros", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ItemReintegro> Reintrgros { get; private set; }
        [JsonProperty("parametrosPromocion", NullValueHandling = NullValueHandling.Ignore)]
        public ParametrosPromocao Parametros { get; private set; }
    }

    public class AutorPromocao
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long Id { get; private set; }
        [JsonProperty("descripcion", NullValueHandling = NullValueHandling.Ignore)]
        public string Descricao { get; private set; }
        [JsonProperty("tipoEmpresa", NullValueHandling = NullValueHandling.Ignore)]
        public string TipoEmpresa { get; private set; }
    }

    public class DetalhePromocao
    {
        [JsonProperty("packA", NullValueHandling = NullValueHandling.Ignore)]
        public CondicaoBeneficioPromocao Condicao { get; private set; }
        [JsonProperty("packB", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; private set; }
        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ItemPromocao> Itens { get; private set; }
    }

    public class ItemPromocao
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; private set; }
        [JsonProperty("cantidad", NullValueHandling = NullValueHandling.Ignore)]
        public double Quantidade { get; private set; }
        [JsonProperty("articulosPosibles", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ArtigoPromocao> Artigos { get; private set; }
    }

    public class ArtigoPromocao
    {
        [JsonProperty("codigo", NullValueHandling = NullValueHandling.Ignore)]
        public string Codigo { get; private set; }
        [JsonProperty("codigoExterno", NullValueHandling = NullValueHandling.Ignore)]
        public string CodigoExterno { get; private set; }
        [JsonProperty("codigoBarras", NullValueHandling = NullValueHandling.Ignore)]
        public string CodigoBarras { get; private set; }
        [JsonProperty("nombre", NullValueHandling = NullValueHandling.Ignore)]
        public string Nome { get; private set; }
    }

    public class ItemReintegro
    {
        [JsonProperty("articulo", NullValueHandling = NullValueHandling.Ignore)]
        public ArtigoPromocao Artigo { get; private set; }
        [JsonProperty("reintegros", NullValueHandling = NullValueHandling.Ignore)]
        public Reintegro Reintegros { get; private set; }
    }

    public class Reintegro
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; private set; }
        [JsonProperty("tipo", NullValueHandling = NullValueHandling.Ignore)]
        public int Tipo { get; private set; }
    }

    public class ParametrosPromocao
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; private set; }
        [JsonProperty("pideTelefono", NullValueHandling = NullValueHandling.Ignore)]
        public bool PedirTelefone { get; private set; }
        [JsonProperty("maximoTickets", NullValueHandling = NullValueHandling.Ignore)]
        public int MaximoTicketsPorCupom { get; private set; }
        [JsonProperty("aceptacionAutomatica", NullValueHandling = NullValueHandling.Ignore)]
        public bool AceitacaoAutomatica { get; private set; }
    }
}
