Public Class Form1
    Private Async Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim fone As String = txtFone.Text

        If fone.Length < 15 Then
            MsgBox("Digite um número de telefone válido.")
            Exit Sub
        End If

        Dim viagem As Viagem = Await BuscarViagem(fone)

        If viagem Is Nothing Or viagem.Vazia Then
            MsgBox("Não foi encontrado viagem com este número de telefone.")
            Exit Sub
        End If

        Dim formViagem As New Form2(viagem)
        formViagem.ShowDialog()
    End Sub
End Class
