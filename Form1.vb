Imports System.Text.RegularExpressions

Public Class Form1
    Private Async Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        btnSearch.Enabled = False
        Me.Cursor = Cursors.WaitCursor
        Dim fone As String = txtFone.Text

        Dim serializedFone As String = Regex.Replace(fone, "\D+", "")
        serializedFone = serializedFone.Trim()

        If serializedFone.Length < 11 Then
            MsgBox("Por favor, insira um número de telefone válido.")
            btnSearch.Enabled = True
            Me.Cursor = Cursors.Default
            Exit Sub
        End If

        Dim viagem As Viagem = Await BuscarViagem(serializedFone)

        If viagem Is Nothing OrElse viagem.Vazia Then
            MsgBox("Não encontramos nenhuma viagem associada a este número.")
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
