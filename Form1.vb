Public Class Form1
    Private Async Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnSearch.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim fone As String = txtFone.Text

        If fone.Length < 15 Then
            MsgBox("Digite um número de telefone válido.")
            btnSearch.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim viagem As Viagem = Await BuscarViagem(fone)

        If viagem Is Nothing Or viagem.Vazia Then
            MsgBox("Não foi encontrado viagem com este número de telefone.")
            btnSearch.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim formViagem As New Form2(viagem)

        AddHandler formViagem.FormClosed, Sub()
                                              btnSearch.Enabled = True
                                              Me.Cursor = Cursors.Default
                                          End Sub

        formViagem.ShowDialog()
    End Sub
End Class
