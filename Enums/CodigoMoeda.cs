using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace ScannTechSDK.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CodigoMoeda
    {
        /// <summary>
        /// Dirham dos Emirados  Emirados Árabes Unidos
        /// </summary>
        [EnumMember(Value = "784")]
        AED, 
        /// <summary>
        /// Afegane	 Afeganistão
        /// </summary>
        [EnumMember(Value = "971")]
        AFN,
        /// <summary>
        /// Lek	 Albânia
        /// </summary>
        [EnumMember(Value = "008")]
        ALL,
        /// <summary>
        /// Dram	 Armênia
        /// </summary>
        [EnumMember(Value = "051")]
        AMD,
        /// <summary>
        /// Florim	 Antilhas Holandesas
        /// </summary>
        [EnumMember(Value = "532")]
        ANG,
        /// <summary>
        /// Kwanza	 Angola
        /// </summary>
        [EnumMember(Value = "973")]
        AOA,
        /// <summary>
        /// Peso Argentino	 Argentina
        /// </summary>
        [EnumMember(Value = "032")]
        ARS,
        /// <summary>
        /// Dólar australiano	 Austrália, Ilha Christmas, Ilhas Cocos (Keeling), Ilha Heard e Ilhas McDonald, Kiribati, Nauru, Ilha Norfolk, Tuvalu
        /// </summary>
        [EnumMember(Value = "036")]
        AUD,
        /// <summary>
        /// Florim de Aruba	 Aruba
        /// </summary>
        [EnumMember(Value = "533")]
        AWG,
        /// <summary>
        /// Manat do Azerbaijão	 Azerbaijão
        /// </summary>
        [EnumMember(Value = "944")]
        AZN,
        /// <summary>
        /// Marco convertível	 Bósnia e Herzegovina
        /// </summary>
        [EnumMember(Value = "977")]
        BAM,
        /// <summary>
        /// Dólar de Barbados	 Barbados
        /// </summary>
        [EnumMember(Value = "052")]
        BBD,
        /// <summary>
        /// Taka	 Bangladesh
        /// </summary>
        [EnumMember(Value = "050")]
        BDT,
        /// <summary>
        /// Lev búlgaro	 Bulgária
        /// </summary>
        [EnumMember(Value = "975")]
        BGN,
        /// <summary>
        /// Dinar do Bahrein	 Bahrein
        /// </summary>
        [EnumMember(Value = "048")]
        BHD,
        /// <summary>
        /// Franco do Burundi	 Burundi
        /// </summary>
        [EnumMember(Value = "108")]
        BIF,
        /// <summary>
        /// Dólar das Bermudas	 Bermudas
        /// </summary>
        [EnumMember(Value = "060")]
        BMD,
        /// <summary>
        /// Dólar do Brunei	 Brunei
        /// </summary>
        [EnumMember(Value = "096")]
        BND,
        /// <summary>
        /// Boliviano	 Bolívia
        /// </summary>
        [EnumMember(Value = "068")]
        BOB,
        /// <summary>
        /// Boliviano Mvdol	 Bolívia
        /// </summary>
        [EnumMember(Value = "984")]
        BOV,
        /// <summary>
        /// Real	 Brasil
        /// </summary>
        [EnumMember(Value = "986")]
        BRL,
        /// <summary>
        /// Dólar das Bahamas	 Bahamas
        /// </summary>
        [EnumMember(Value = "044")]
        BSD,
        /// <summary>
        /// Ngultrum	 Butão
        /// </summary>
        [EnumMember(Value = "064")]
        BTN,
        /// <summary>
        /// Pula	 Botswana
        /// </summary>
        [EnumMember(Value = "072")]
        BWP,
        /// <summary>
        /// Rublo bielorrusso	 Bielorrússia
        /// </summary>
        [EnumMember(Value = "974")]
        BYR,
        /// <summary>
        /// Dólar do Belize	 Belize
        /// </summary>
        [EnumMember(Value = "084")]
        BZD,
        /// <summary>
        /// Dólar canadense	 Canadá
        /// </summary>
        [EnumMember(Value = "124")]
        CAD,
        /// <summary>
        /// Franco congolês	 República Democrática do Congo
        /// </summary>
        [EnumMember(Value = "976")]
        CDF,
        /// <summary>
        /// WIR euro (moeda complementar)	 Suíça
        /// </summary>
        [EnumMember(Value = "947")]
        CHE,
        /// <summary>
        /// Franco suíço	 Suíça
        /// </summary>
        [EnumMember(Value = "756")]
        CHF,
        /// <summary>
        /// WIR franc (moeda complementar)	 Suíça
        /// </summary>
        [EnumMember(Value = "948")]
        CHW,
        /// <summary>
        /// Unidade de Fomento (código de fundos)	 Chile
        /// </summary>
        [EnumMember(Value = "990")]
        CLF,
        /// <summary>
        /// Peso chileno	 Chile
        /// </summary>
        [EnumMember(Value = "152")]
        CLP,
        /// <summary>
        /// Renminbi	 China
        /// </summary>
        [EnumMember(Value = "156")]
        CNY,
        /// <summary>
        /// Peso colombiano	 Colômbia
        /// </summary>
        [EnumMember(Value = "170")]
        COP,
        /// <summary>
        /// Unidade de Valor Real	 Colômbia
        /// </summary>
        [EnumMember(Value = "970")]
        COU,
        /// <summary>
        /// Colon da Costa Rica	 Costa Rica
        /// </summary>
        [EnumMember(Value = "188")]
        CRC,
        /// <summary>
        /// Peso cubano convertível	 Cuba
        /// </summary>
        [EnumMember(Value = "931")]
        CUC,
        /// <summary>
        /// Peso cubano	 Cuba
        /// </summary>
        [EnumMember(Value = "192")]
        CUP,
        /// <summary>
        /// Escudo cabo-verdiano	Cabo Verde Cabo Verde
        /// </summary>
        [EnumMember(Value = "132")]
        CVE,
        /// <summary>
        /// Coroa checa	 República Checa
        /// </summary>
        [EnumMember(Value = "203")]
        CZK,
        /// <summary>
        /// Franco do Djibouti	 Djibouti
        /// </summary>
        [EnumMember(Value = "262")]
        DJF,
        /// <summary>
        /// Coroa dinamarquesa	 Dinamarca, incluindo as  Ilhas Feroé,  Gronelândia
        /// </summary>
        [EnumMember(Value = "208")]
        DKK,
        /// <summary>
        /// Peso	 República Dominicana
        /// </summary>
        [EnumMember(Value = "214")]
        DOP,
        /// <summary>
        /// Dinar argelino	 Argélia
        /// </summary>
        [EnumMember(Value = "012")]
        DZD,
        /// <summary>
        /// Sucre (O dólar americano USD é a moeda corrente no país)	 Equador
        /// </summary>
        [EnumMember(Value = "895")]
        ECS,
        /// <summary>
        /// Libra egípcia	 Egito
        /// </summary>
        [EnumMember(Value = "818")]
        EGP,
        /// <summary>
        /// Nakfa	 Eritreia
        /// </summary>
        [EnumMember(Value = "232")]
        ERN,
        /// <summary>
        /// Birr etíope	 Etiópia
        /// </summary>
        [EnumMember(Value = "230")]
        ETB,
        /// <summary>
        /// Euro	 Itália,  Áustria,  Bélgica,  Chipre, Flag of Spain.svg Espanha,  Estónia,  Finlândia,  Alemanha,  Grécia,   Irlanda,  Andorra,  Luxemburgo,  Letônia,  Lituânia,  Malta,  Montenegro,  Mónaco,  Países Baixos,  Portugal,  Eslovênia,  Eslováquia,  San Marino,  França incl. Guadalupe, Martinica, Mayotte, Reunião, Saint Pierre e Miquelon e São Bartolomeu.
        /// </summary>
        [EnumMember(Value = "978")]
        EUR,
        /// <summary>
        /// Dólar das Fiji	 Fiji
        /// </summary>
        [EnumMember(Value = "242")]
        FJD,
        /// <summary>
        /// Libra das Malvinas	 Ilhas Malvinas
        /// </summary>
        [EnumMember(Value = "238")]
        FKP,
        /// <summary>
        /// Libra Esterlina	 Reino Unido, Ilha de Man, Guernsey, Jersey
        /// </summary>
        [EnumMember(Value = "826")]
        GBP,
        /// <summary>
        /// Lari	 Geórgia
        /// </summary>
        [EnumMember(Value = "981")]
        GEL,
        /// <summary>
        /// Cedi	 Gana
        /// </summary>
        [EnumMember(Value = "936")]
        GHS,
        /// <summary>
        /// Libra de Gibraltar	 Gibraltar
        /// </summary>
        [EnumMember(Value = "292")]
        GIP,
        /// <summary>
        /// Dalasi	 Gâmbia
        /// </summary>
        [EnumMember(Value = "270")]
        GMD,
        /// <summary>
        /// Franco da Guiné	 Guiné
        /// </summary>
        [EnumMember(Value = "324")]
        GNF,
        /// <summary>
        /// Quetzal guatemalteco	 Guatemala
        /// </summary>
        [EnumMember(Value = "320")]
        GTQ,
        /// <summary>
        /// Dólar da Guiana	 Guiana
        /// </summary>
        [EnumMember(Value = "328")]
        GYD,
        /// <summary>
        /// Dólar de Hong Kong	 Hong Kong
        /// </summary>
        [EnumMember(Value = "344")]
        HKD,
        /// <summary>
        /// Lempira	 Honduras
        /// </summary>
        [EnumMember(Value = "340")]
        HNL,
        /// <summary>
        /// Kuna croata	 Croácia
        /// </summary>
        [EnumMember(Value = "191")]
        HRK,
        /// <summary>
        /// Gourde	 Haiti
        /// </summary>
        [EnumMember(Value = "332")]
        HTG,
        /// <summary>
        /// Forint	 Hungria
        /// </summary>
        [EnumMember(Value = "348")]
        HUF,
        /// <summary>
        /// Rupia indonésia	 Indonésia
        /// </summary>
        [EnumMember(Value = "360")]
        IDR,
        /// <summary>
        /// Shekel	 Israel
        /// </summary>
        [EnumMember(Value = "376")]
        ILS,
        /// <summary>
        /// Rupia indiana	 Índia,  Butão
        /// </summary>
        [EnumMember(Value = "356")]
        INR,
        /// <summary>
        /// Dinar iraquiano	 Iraque
        /// </summary>
        [EnumMember(Value = "368")]
        IQD,
        /// <summary>
        /// Rial iraniano	 Irão
        /// </summary>
        [EnumMember(Value = "364")]
        IRR,
        /// <summary>
        /// Coroa islandesa	 Islândia
        /// </summary>
        [EnumMember(Value = "352")]
        ISK,
        /// <summary>
        /// Dólar jamaicano	 Jamaica
        /// </summary>
        [EnumMember(Value = "388")]
        JMD,
        /// <summary>
        /// Dinar jordano	 Jordânia
        /// </summary>
        [EnumMember(Value = "400")]
        JOD,
        /// <summary>
        /// Iene	 Japão
        /// </summary>
        [EnumMember(Value = "392")]
        JPY,
        /// <summary>
        /// Xelim queniano	 Quênia
        /// </summary>
        [EnumMember(Value = "404")]
        KES,
        /// <summary>
        /// Som	 Quirguistão
        /// </summary>
        [EnumMember(Value = "417")]
        KGS,
        /// <summary>
        /// Riel	 Camboja
        /// </summary>
        [EnumMember(Value = "116")]
        KHR,
        /// <summary>
        /// Franco das Comoros	 Comores
        /// </summary>
        [EnumMember(Value = "174")]
        KMF,
        /// <summary>
        /// Won norte coreano	 Coreia do Norte
        /// </summary>
        [EnumMember(Value = "408")]
        KPW,
        /// <summary>
        /// Won sul coreano	 Coreia do Sul
        /// </summary>
        [EnumMember(Value = "410")]
        KRW,
        /// <summary>
        /// Dinar do Kuwait	 Kuwait
        /// </summary>
        [EnumMember(Value = "414")]
        KWD,
        /// <summary>
        /// Dólar das Ilhas Cayman	 Ilhas Cayman
        /// </summary>
        [EnumMember(Value = "136")]
        KYD,
        /// <summary>
        /// Tenge	 Cazaquistão
        /// </summary>
        [EnumMember(Value = "398")]
        KZT,
        /// <summary>
        /// Kip	 Laos
        /// </summary>
        [EnumMember(Value = "418")]
        LAK,
        /// <summary>
        /// Libra libanesa	 Líbano
        /// </summary>
        [EnumMember(Value = "422")]
        LBP,
        /// <summary>
        /// Rupia do Sri Lanka	 Sri Lanka
        /// </summary>
        [EnumMember(Value = "144")]
        LKR,
        /// <summary>
        /// Dólar da Libéria	 Libéria
        /// </summary>
        [EnumMember(Value = "430")]
        LRD,
        /// <summary>
        /// Loti	 Lesoto
        /// </summary>
        [EnumMember(Value = "426")]
        LSL,
        /// <summary>
        /// Litas	 Lituânia
        /// </summary>
        [EnumMember(Value = "440")]
        LTL,
        /// <summary>
        /// Lats	 Letônia
        /// </summary>
        [EnumMember(Value = "428")]
        LVL,
        /// <summary>
        /// Dinar da Líbia	 Líbia
        /// </summary>
        [EnumMember(Value = "434")]
        LYD,
        /// <summary>
        /// Dirham marroquino	 Marrocos,  Saara Ocidental
        /// </summary>
        [EnumMember(Value = "504")]
        MAD,
        /// <summary>
        /// Leu moldávio	 Moldávia
        /// </summary>
        [EnumMember(Value = "498")]
        MDL,
        /// <summary>
        /// Ariary Madagáscar
        /// </summary>
        [EnumMember(Value = "969")]
        MGA, 
        /// <summary>
        /// Denar	 Macedônia
        /// </summary>
        [EnumMember(Value = "807")]
        MKD,
        /// <summary>
        /// Kyat	 Mianmar
        /// </summary>
        [EnumMember(Value = "104")]
        MMK,
        /// <summary>
        /// Tugrik	 Mongólia
        /// </summary>
        [EnumMember(Value = "496")]
        MNT,
        /// <summary>
        /// Pataca	 Macau Região Administrativa Especial
        /// </summary>
        [EnumMember(Value = "446")]
        MOP,
        /// <summary>
        /// Ouguiya  Mauritânia
        /// </summary>
        [EnumMember(Value = "478")]
        MRO, 
        /// <summary>
        /// Rupia da Maurícia	 Maurícia
        /// </summary>
        [EnumMember(Value = "480")]
        MUR,
        /// <summary>
        /// Rufiyaa	 Maldivas
        /// </summary>
        [EnumMember(Value = "462")]
        MVR,
        /// <summary>
        /// Kwacha	 Malawi
        /// </summary>
        [EnumMember(Value = "454")]
        MWK,
        /// <summary>
        /// Peso mexicano	 México
        /// </summary>
        [EnumMember(Value = "484")]
        MXN,
        /// <summary>
        /// Unidade Mexicana de Investimento	 México
        /// </summary>
        [EnumMember(Value = "979")]
        MXV,
        /// <summary>
        /// Ringgit	 Malásia
        /// </summary>
        [EnumMember(Value = "458")]
        MYR,
        /// <summary>
        /// Metical	 Moçambique
        /// </summary>
        [EnumMember(Value = "943")]
        MZN,
        /// <summary>
        /// Dólar da Namíbia	 Namíbia
        /// </summary>
        [EnumMember(Value = "516")]
        NAD,
        /// <summary>
        /// Naira	 Nigéria
        /// </summary>
        [EnumMember(Value = "566")]
        NGN,
        /// <summary>
        /// Cordoba Oro	 Nicarágua
        /// </summary>
        [EnumMember(Value = "558")]
        NIO,
        /// <summary>
        /// Coroa norueguesa	 Noruega, Ilha Bouvet, Queen Maud Land, Ilha Peter I
        /// </summary>
        [EnumMember(Value = "578")]
        NOK,
        /// <summary>
        /// Rupia nepalesa	Flag of Nepal.svg Nepal
        /// </summary>
        [EnumMember(Value = "524")]
        NPR,
        /// <summary>
        /// Dólar da Nova Zelândia	 Nova Zelândia, incl.  Ilhas Cook,  Niue,  Pitcairn,  Toquelau
        /// </summary>
        [EnumMember(Value = "554")]
        NZD,
        /// <summary>
        /// Rial Omani	 Omã
        /// </summary>
        [EnumMember(Value = "512")]
        OMR,
        /// <summary>
        /// Balboa (O dólar americano USD é a moeda corrente no país)	 Panamá
        /// </summary>
        [EnumMember(Value = "590")]
        PAB,
        /// <summary>
        /// Nuevo Sol	 Peru
        /// </summary>
        [EnumMember(Value = "604")]
        PEN,
        /// <summary>
        /// Kina	 Papua-Nova Guiné
        /// </summary>
        [EnumMember(Value = "598")]
        PGK,
        /// <summary>
        /// Peso filipino	 Filipinas
        /// </summary>
        [EnumMember(Value = "608")]
        PHP,
        /// <summary>
        /// Rupia paquistanesa	 Paquistão
        /// </summary>
        [EnumMember(Value = "586")]
        PKR,
        /// <summary>
        /// Zloty	 Polónia
        /// </summary>
        [EnumMember(Value = "985")]
        PLN,
        /// <summary>
        /// Guarani	 Paraguai
        /// </summary>
        [EnumMember(Value = "600")]
        PYG,
        /// <summary>
        /// Rial do Qatar	 Catar
        /// </summary>
        [EnumMember(Value = "634")]
        QAR,
        /// <summary>
        /// Leu romeno	 Roménia
        /// </summary>
        [EnumMember(Value = "946")]
        RON,
        /// <summary>
        /// Dinar Sérvio	 Sérvia
        /// </summary>
        [EnumMember(Value = "941")]
        RSD,
        /// <summary>
        /// Rublo	 Rússia, Abkhazia, Ossétia do Sul
        /// </summary>
        [EnumMember(Value = "643")]
        RUB,
        /// <summary>
        /// Franco do Ruanda	 Ruanda
        /// </summary>
        [EnumMember(Value = "646")]
        RWF,
        /// <summary>
        /// Riyal	 Arábia Saudita
        /// </summary>
        [EnumMember(Value = "682")]
        SAR,
        /// <summary>
        /// Dólar das Ilhas Salomão	 Ilhas Salomão
        /// </summary>
        [EnumMember(Value = "090")]
        SBD,
        /// <summary>
        /// Rupia das Seychelles	 Seicheles
        /// </summary>
        [EnumMember(Value = "690")]
        SCR,
        /// <summary>
        /// Dinar sudanês	 Sudão
        /// </summary>
        [EnumMember(Value = "938")]
        SDG,
        /// <summary>
        /// Coroa Sueca	 Suécia
        /// </summary>
        [EnumMember(Value = "752")]
        SEK,
        /// <summary>
        /// Dólar de Singapura	 Singapura
        /// </summary>
        [EnumMember(Value = "702")]
        SGD,
        /// <summary>
        /// Libra de Santa Helena	 Santa Helena, Ascensão e Tristão da Cunha
        /// </summary>
        [EnumMember(Value = "654")]
        SHP,
        /// <summary>
        /// Leone	 Serra Leoa
        /// </summary>
        [EnumMember(Value = "694")]
        SLL,
        /// <summary>
        /// Xelim somali	 Somália
        /// </summary>
        [EnumMember(Value = "706")]
        SOS,
        /// <summary>
        /// Dólar do Suriname	 Suriname
        /// </summary>
        [EnumMember(Value = "968")]
        SRD,
        /// <summary>
        /// Dobra	 São Tomé e Príncipe
        /// </summary>
        [EnumMember(Value = "678")]
        STD,
        /// <summary>
        /// Colon de El Salvador	 El Salvador
        /// </summary>
        [EnumMember(Value = "222")]
        SVC,
        /// <summary>
        /// Libra da Síria	 Síria
        /// </summary>
        [EnumMember(Value = "760")]
        SYP,
        /// <summary>
        /// Lilangeni	 Suazilândia
        /// </summary>
        [EnumMember(Value = "748")]
        SZL,
        /// <summary>
        /// Baht	 Tailândia
        /// </summary>
        [EnumMember(Value = "764")]
        THB,
        /// <summary>
        /// Somoni	 Tajiquistão
        /// </summary>
        [EnumMember(Value = "972")]
        TJS,
        /// <summary>
        /// Manat turcomano	 Turquemenistão
        /// </summary>
        [EnumMember(Value = "934")]
        TMT,
        /// <summary>
        /// Dinar tunisino	 Tunísia
        /// </summary>
        [EnumMember(Value = "788")]
        TND,
        /// <summary>
        /// Pa'anga	 Tonga
        /// </summary>
        [EnumMember(Value = "776")]
        TOP,
        /// <summary>
        /// Nova Lira turca	 Turquia
        /// </summary>
        [EnumMember(Value = "949")]
        TRY,
        /// <summary>
        /// Dólar de Trindade e Tobago	 Trinidad e Tobago
        /// </summary>
        [EnumMember(Value = "780")]
        TTD,
        /// <summary>
        /// Novo dólar de Taiwan	 Taiwan and other islands that are under the effective control of the Republic of China (ROC)
        /// </summary>
        [EnumMember(Value = "901")]
        TWD,
        /// <summary>
        /// Xelim da Tanzânia	 Tanzânia
        /// </summary>
        [EnumMember(Value = "834")]
        TZS,
        /// <summary>
        /// Grívnia	 Ucrânia
        /// </summary>
        [EnumMember(Value = "980")]
        UAH,
        /// <summary>
        /// Xelim do Uganda	 Uganda
        /// </summary>
        [EnumMember(Value = "800")]
        UGX,
        /// <summary>
        /// Dólar americano	 Estados Unidos e também:  Equador,  El Salvador,  Guam,  Haiti,  Ilhas Marshall,  Estados Federados da Micronésia,  Marianas Setentrionais,  Palau,  Panamá,  Timor-Leste, Flag of the Turks and Caicos Islands.svg Turks e Caicos,  Ilhas Virgens Americanas,  Samoa,  Samoa Americana,  Território Britânico do Oceano Índico
        /// </summary>
        [EnumMember(Value = "840")]
        USD,
        /// <summary>
        /// Dólar americano "next day"	 Estados Unidos
        /// </summary>
        [EnumMember(Value = "997")]
        USN,
        /// <summary>
        /// Dólar americano "same day"	 Estados Unidos
        /// </summary>
        [EnumMember(Value = "998")]
        USS,
        /// <summary>
        /// Peso do Uruguay em Unidades Indexadas	 Uruguai
        /// </summary>
        [EnumMember(Value = "940")]
        UYI,
        /// <summary>
        /// Peso Uruguaio	 Uruguai
        /// </summary>
        [EnumMember(Value = "858")]
        UYU,
        /// <summary>
        /// Som Uzbeque	 Uzbequistão
        /// </summary>
        [EnumMember(Value = "860")]
        UZS,
        /// <summary>
        /// Venezuelan bolívar fuerte	 Venezuela
        /// </summary>
        [EnumMember(Value = "937")]
        VEF,
        /// <summary>
        /// Dong	 Vietnã
        /// </summary>
        [EnumMember(Value = "704")]
        VND,
        /// <summary>
        /// Vatu	 Vanuatu
        /// </summary>
        [EnumMember(Value = "548")]
        VUV,
        /// <summary>
        /// Tala	 Samoa
        /// </summary>
        [EnumMember(Value = "882")]
        WST,
        /// <summary>
        /// Franco CFA central	 Camarões,  República Centro-Africana,  República do Congo,  Chade,  Guiné Equatorial, Gabão
        /// </summary>
        [EnumMember(Value = "950")]
        XAF,
        /// <summary>
        /// Prata	uma onça Troy
        /// </summary>
        [EnumMember(Value = "961")]
        XAG,
        /// <summary>
        /// Ouro	uma onça Troy
        /// </summary>
        [EnumMember(Value = "959")]
        XAU,
        /// <summary>
        /// European Composite Unit (EURCO) (bond market unit)	
        /// </summary>
        [EnumMember(Value = "955")]
        XBA,
        /// <summary>
        /// European Monetary Unit (E.M.U.-6) (bond market unit)	
        /// </summary>
        [EnumMember(Value = "956")]
        XBB,
        /// <summary>
        /// European Unit of Account 9 (E.U.A.-9) (bond market unit)	
        /// </summary>
        [EnumMember(Value = "957")]
        XBC,
        /// <summary>
        /// European Unit of Account 17 (E.U.A.-17) (bond market unit)	
        /// </summary>
        [EnumMember(Value = "958")]
        XBD,
        /// <summary>
        /// Dólar das Caraíbas Orientais	 Anguilla,  Antígua e Barbuda,  Dominica,  Granada,  Montserrat,  São Cristóvão e Nevis, Santa Lúcia,  São Vicente e Granadinas
        /// </summary>
        [EnumMember(Value = "951")]
        XCD,
        /// <summary>
        /// Special Drawing Rights	International Monetary Fund
        /// </summary>
        [EnumMember(Value = "960")]
        XDR,
        /// <summary>
        /// UIC franc (special settlement currency)	International Union of Railways
        /// </summary>
        [EnumMember(Value = "Nil")]
        XFU,
        /// <summary>
        /// Franco CFA ocidental	 Benim,  Burkina Faso,  Costa do Marfim,  Guiné-Bissau,  Mali,  Níger,  Senegal,  Togo
        /// </summary>
        [EnumMember(Value = "952")]
        XOF,
        /// <summary>
        /// Paládio	uma onça Troy
        /// </summary>
        [EnumMember(Value = "964")]
        XPD,
        /// <summary>
        /// Franco CFP	 Polinésia Francesa,  Nova Caledônia,  Wallis e Futuna
        /// </summary>
        [EnumMember(Value = "953")]
        XPF,
        /// <summary>
        /// Platina	uma onça Troy
        /// </summary>
        [EnumMember(Value = "962")]
        XPT,
        /// <summary>
        /// Reservado para efeitos de teste	
        /// </summary>
        [EnumMember(Value = "963")]
        XTS,
        /// <summary>
        /// No currency	
        /// </summary>
        [EnumMember(Value = "999")]
        XXX,
        /// <summary>
        /// Rial iemenita	 Iêmen
        /// </summary>
        [EnumMember(Value = "886")]
        YER,
        /// <summary>
        /// Rand	 Lesoto,  Namíbia,  África do Sul
        /// </summary>
        [EnumMember(Value = "710")]
        ZAR,
        /// <summary>
        /// Kwacha	 Zâmbia
        /// </summary>
        [EnumMember(Value = "894")]
        ZMW,
        /// <summary>
        /// Zimbabwe dollar	 Zimbabwe
        /// </summary>
        [EnumMember(Value = "932")]
        ZWL
    }
}
