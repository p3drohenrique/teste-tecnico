Imports System.Net.Http
Imports System.Net
Imports Newtonsoft.Json
Module ViagemService
    Private Class ViagemResponse
        <JsonProperty("SincronizarResult")>
        Public Property SincronizarResult As Viagem
    End Class

    Async Function BuscarViagem(fone As String) As Task(Of Viagem)
        Using client As New HttpClient()
            Try
                Const Cookie As String = "NSC_mc_psjpocs-rb3-qsfqspe_iuuq=ffffffff09e44c4045525d5f4f58455e445a4a423660"
                Const URL As String = "https://qa3orionbr-preprod.cevalogistics.com/WCFOrionMobilityMilkRun/Servicos/SincronizarService.svc/Sincronizar"

                Dim request As New HttpRequestMessage(HttpMethod.Post, URL)
                request.Headers.Add("Cookie", Cookie)
                request.Headers.Add("fone", fone)

                Dim response As HttpResponseMessage = Await client.SendAsync(request)
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()

                Dim viagemResponse As ViagemResponse = JsonConvert.DeserializeObject(Of ViagemResponse)(responseBody)

                Return viagemResponse.SincronizarResult
            Catch httpRequestException As HttpRequestException
                If httpRequestException.StatusCode = HttpStatusCode.InternalServerError Then
                    MsgBox("Ocorreu um erro inesperado.")
                    Console.WriteLine("Erro: " & httpRequestException.Message)
                End If
            Catch exception As Exception
                MsgBox("Ocorreu um erro inesperado.")
                Console.WriteLine("Erro: " & exception.Message)
            End Try
        End Using
    End Function
End Module
