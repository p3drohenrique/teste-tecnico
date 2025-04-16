﻿Public Class Form2
    Private _viagem As Viagem

    Public Sub New(viagem As Viagem)
        InitializeComponent()
        _viagem = viagem
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTravelNumber.Text = _viagem.NumeroViagem
        lblTravelDate.Text = _viagem.DataViagem
        lblRoute.Text = _viagem.Rota
        lblTravelType.Text = _viagem.TipoViagem
        lblOperationPoint.Text = _viagem.PontoOperacional
        lblTruck.Text = _viagem.PlacaCavalo
        lblTrailer1.Text = If(_viagem.PlacaCarreta1 Is Nothing OrElse _viagem.PlacaCarreta1.Length < 1, "Sem placa", _viagem.PlacaCarreta1)
        lblTrailer2.Text = If(_viagem.PlacaCarreta2, "Sem placa")
        lblPlan.Text = If(_viagem.Plano Is Nothing OrElse _viagem.Plano.Length < 1, "Sem plano", _viagem.Plano)
        lblStatus.Text = If(_viagem.Status, "Sem status")
        lblPhone.Text = If(_viagem.NumeroFone, "Sem número telefone")

        dgvSuppliers.DataSource = _viagem.Fornecedores
        dgvPlants.DataSource = _viagem.Plantas
    End Sub
End Class