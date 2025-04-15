Imports Newtonsoft.Json

Public Class Fornecedo
    <JsonProperty("cnpj")>
    Public Property CNPJ As String

    <JsonProperty("codigoGeral")>
    Public Property CodigoGeral As String

    <JsonProperty("descricaoParada")>
    Public Property DescricaoParada As String

    <JsonProperty("endereco")>
    Public Property Endereco As String

    <JsonProperty("ordemParada")>
    Public Property OrdemParada As String

    <JsonProperty("razaoSocial")>
    Public Property RazaoSocial As String
End Class

Public Class Planta
    <JsonProperty("cnpj")>
    Public Property CNPJ As String

    <JsonProperty("codigo")>
    Public Property Codigo As String

    <JsonProperty("descricao")>
    Public Property Descricao As String
End Class

Public Class Viagem
    <JsonProperty("ExecutouOK")>
    Public Property ExecutouOk As Boolean

    <JsonProperty("Vazia")>
    Public Property Vazia As Boolean

    <JsonProperty("NumeroViagem")>
    Public Property NumeroViagem As String

    <JsonProperty("DataViagem")>
    Public Property DataViagem As String

    <JsonProperty("Manifestar")>
    Public Property Manifestar As String

    <JsonProperty("NumeroFone")>
    Public Property NumeroFone As String

    <JsonProperty("NumeroFoneMudou")>
    Public Property NumeroFoneMudou As Boolean

    <JsonProperty("PlacaCarreta1")>
    Public Property PlacaCarreta1 As String

    <JsonProperty("PlacaCarreta2")>
    Public Property PlacaCarreta2 As String

    <JsonProperty("PlacaCavalo")>
    Public Property PlacaCavalo As String

    <JsonProperty("Plano")>
    Public Property Plano As String

    <JsonProperty("PontoOperacional")>
    Public Property PontoOperacional As String

    <JsonProperty("Rota")>
    Public Property Rota As String

    <JsonProperty("TipoViagem")>
    Public Property TipoViagem As String

    <JsonProperty("Status")>
    Public Property Status As String

    <JsonProperty("Fornecedores")>
    Public Property Fornecedores As Fornecedo()

    <JsonProperty("plantas")>
    Public Property Plantas As Planta()
End Class
