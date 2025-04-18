﻿Public Class Form2
    Private _viagem As Viagem

    Public Sub New(viagem As Viagem)
        InitializeComponent()
        _viagem = viagem
    End Sub

    Private Class FornecedorSerialzied
        Inherits Fornecedo

        Public Property Codigo As String
        Public Property NomeEmpresa As String
    End Class

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTravelNumber.Text = _viagem.NumeroViagem
        lblTravelDate.Text = _viagem.DataViagem
        lblRoute.Text = _viagem.Rota
        lblTravelType.Text = _viagem.TipoViagem
        lblOperationPoint.Text = _viagem.PontoOperacional
        lblTruck.Text = _viagem.PlacaCavalo
        lblTrailer1.Text = If(_viagem.PlacaCarreta1 Is Nothing OrElse _viagem.PlacaCarreta1.Length < 1, "Sem placa", _viagem.PlacaCarreta1)
        lblTrailer2.Text = If(_viagem.PlacaCarreta2 Is Nothing OrElse _viagem.PlacaCarreta2.Length < 1, "Sem placa", _viagem.PlacaCarreta2)
        lblPlan.Text = If(_viagem.Plano Is Nothing OrElse _viagem.Plano.Length < 1, "Sem plano", _viagem.Plano)
        lblStatus.Text = If(_viagem.Status Is Nothing OrElse _viagem.Status.Length < 1, "Sem status", _viagem.Status)
        lblPhone.Text = If(_viagem.NumeroFone Is Nothing OrElse _viagem.NumeroFone.Length < 1, "Sem número telefone", _viagem.NumeroFone)

        Dim index As Integer
        Dim serializedFornecedor(_viagem.Fornecedores.Length) As FornecedorSerialzied

        For index = 0 To _viagem.Fornecedores.Length - 1
            Dim DescricaoParada As String = _viagem.Fornecedores(index).DescricaoParada
            Dim Codigo As String = DescricaoParada.Split("_")(0)
            Dim NomeEmpresa As String = DescricaoParada.Split("_")(1)

            serializedFornecedor(index) = New FornecedorSerialzied With {
              .CNPJ = _viagem.Fornecedores(index).CNPJ,
              .Codigo = Codigo,
              .NomeEmpresa = NomeEmpresa,
              .OrdemParada = _viagem.Fornecedores(index).OrdemParada,
              .CodigoGeral = _viagem.Fornecedores(index).CodigoGeral,
              .Endereco = _viagem.Fornecedores(index).Endereco
            }

        Next

        dgvSuppliers.DataSource = serializedFornecedor
        dgvPlants.DataSource = _viagem.Plantas
    End Sub
End Class