﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        tabsWithData = New TabControl()
        TabPage1 = New TabPage()
        lblPhone = New Label()
        lblTitlePhone = New Label()
        lblStatus = New Label()
        lblTitleStatus = New Label()
        lblPlan = New Label()
        lblTitlePlan = New Label()
        lblTrailer2 = New Label()
        lblTitleTrailer2 = New Label()
        lblTrailer1 = New Label()
        lblTitleTrailer1 = New Label()
        lblTruck = New Label()
        lblTitleTruck = New Label()
        lblOperationPoint = New Label()
        lblTitleOperationPoint = New Label()
        lblTravelType = New Label()
        lblTitleTravelType = New Label()
        lblRoute = New Label()
        lblTitleRoute = New Label()
        lblTravelDate = New Label()
        lblTitleTraveDate = New Label()
        lblTravelNumber = New Label()
        lblTitleTravelNumber = New Label()
        TabPage2 = New TabPage()
        dgvSuppliers = New DataGridView()
        FornecedoBindingSource = New BindingSource(components)
        TabPage3 = New TabPage()
        dgvPlants = New DataGridView()
        CNPJDataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        CodigoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        DescricaoDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        PlantaBindingSource = New BindingSource(components)
        CNPJDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Codigo = New DataGridViewTextBoxColumn()
        CodigoGeralDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        NomeEmpresa = New DataGridViewTextBoxColumn()
        OrdemParadaDataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Cidade = New DataGridViewTextBoxColumn()
        Bairro = New DataGridViewTextBoxColumn()
        Logradouro = New DataGridViewTextBoxColumn()
        NumeroEndereco = New DataGridViewTextBoxColumn()
        tabsWithData.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).BeginInit()
        CType(FornecedoBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgvPlants, ComponentModel.ISupportInitialize).BeginInit()
        CType(PlantaBindingSource, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tabsWithData
        ' 
        tabsWithData.Controls.Add(TabPage1)
        tabsWithData.Controls.Add(TabPage2)
        tabsWithData.Controls.Add(TabPage3)
        tabsWithData.Dock = DockStyle.Fill
        tabsWithData.Font = New Font("JetBrainsMonoNL NF", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        tabsWithData.Location = New Point(0, 0)
        tabsWithData.Name = "tabsWithData"
        tabsWithData.SelectedIndex = 0
        tabsWithData.Size = New Size(533, 480)
        tabsWithData.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(lblPhone)
        TabPage1.Controls.Add(lblTitlePhone)
        TabPage1.Controls.Add(lblStatus)
        TabPage1.Controls.Add(lblTitleStatus)
        TabPage1.Controls.Add(lblPlan)
        TabPage1.Controls.Add(lblTitlePlan)
        TabPage1.Controls.Add(lblTrailer2)
        TabPage1.Controls.Add(lblTitleTrailer2)
        TabPage1.Controls.Add(lblTrailer1)
        TabPage1.Controls.Add(lblTitleTrailer1)
        TabPage1.Controls.Add(lblTruck)
        TabPage1.Controls.Add(lblTitleTruck)
        TabPage1.Controls.Add(lblOperationPoint)
        TabPage1.Controls.Add(lblTitleOperationPoint)
        TabPage1.Controls.Add(lblTravelType)
        TabPage1.Controls.Add(lblTitleTravelType)
        TabPage1.Controls.Add(lblRoute)
        TabPage1.Controls.Add(lblTitleRoute)
        TabPage1.Controls.Add(lblTravelDate)
        TabPage1.Controls.Add(lblTitleTraveDate)
        TabPage1.Controls.Add(lblTravelNumber)
        TabPage1.Controls.Add(lblTitleTravelNumber)
        TabPage1.Location = New Point(4, 25)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(525, 451)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Dados Gerais"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(93, 285)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(48, 17)
        lblPhone.TabIndex = 21
        lblPhone.Text = "Vazio"
        ' 
        ' lblTitlePhone
        ' 
        lblTitlePhone.AutoSize = True
        lblTitlePhone.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitlePhone.Location = New Point(7, 285)
        lblTitlePhone.Name = "lblTitlePhone"
        lblTitlePhone.Size = New Size(80, 17)
        lblTitlePhone.TabIndex = 20
        lblTitlePhone.Text = "Telefone:"
        ' 
        ' lblStatus
        ' 
        lblStatus.AutoSize = True
        lblStatus.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblStatus.Location = New Point(77, 259)
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(48, 17)
        lblStatus.TabIndex = 19
        lblStatus.Text = "Vazio"
        ' 
        ' lblTitleStatus
        ' 
        lblTitleStatus.AutoSize = True
        lblTitleStatus.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleStatus.Location = New Point(7, 259)
        lblTitleStatus.Name = "lblTitleStatus"
        lblTitleStatus.Size = New Size(64, 17)
        lblTitleStatus.TabIndex = 18
        lblTitleStatus.Text = "Status:"
        ' 
        ' lblPlan
        ' 
        lblPlan.AutoSize = True
        lblPlan.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlan.Location = New Point(69, 232)
        lblPlan.Name = "lblPlan"
        lblPlan.Size = New Size(48, 17)
        lblPlan.TabIndex = 17
        lblPlan.Text = "Vazio"
        ' 
        ' lblTitlePlan
        ' 
        lblTitlePlan.AutoSize = True
        lblTitlePlan.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitlePlan.Location = New Point(7, 232)
        lblTitlePlan.Name = "lblTitlePlan"
        lblTitlePlan.Size = New Size(56, 17)
        lblTitlePlan.TabIndex = 16
        lblTitlePlan.Text = "Plano:"
        ' 
        ' lblTrailer2
        ' 
        lblTrailer2.AutoSize = True
        lblTrailer2.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrailer2.Location = New Point(221, 204)
        lblTrailer2.Name = "lblTrailer2"
        lblTrailer2.Size = New Size(48, 17)
        lblTrailer2.TabIndex = 15
        lblTrailer2.Text = "Vazio"
        ' 
        ' lblTitleTrailer2
        ' 
        lblTitleTrailer2.AutoSize = True
        lblTitleTrailer2.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTrailer2.Location = New Point(7, 204)
        lblTitleTrailer2.Name = "lblTitleTrailer2"
        lblTitleTrailer2.Size = New Size(208, 17)
        lblTitleTrailer2.TabIndex = 14
        lblTitleTrailer2.Text = "Placa da Segunda Carreta:"
        ' 
        ' lblTrailer1
        ' 
        lblTrailer1.AutoSize = True
        lblTrailer1.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTrailer1.Location = New Point(228, 177)
        lblTrailer1.Name = "lblTrailer1"
        lblTrailer1.Size = New Size(48, 17)
        lblTrailer1.TabIndex = 13
        lblTrailer1.Text = "Vazio"
        ' 
        ' lblTitleTrailer1
        ' 
        lblTitleTrailer1.AutoSize = True
        lblTitleTrailer1.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTrailer1.Location = New Point(6, 177)
        lblTitleTrailer1.Name = "lblTitleTrailer1"
        lblTitleTrailer1.Size = New Size(216, 17)
        lblTitleTrailer1.TabIndex = 12
        lblTitleTrailer1.Text = "Placa da Primeira Carreta:"
        ' 
        ' lblTruck
        ' 
        lblTruck.AutoSize = True
        lblTruck.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTruck.Location = New Point(149, 150)
        lblTruck.Name = "lblTruck"
        lblTruck.Size = New Size(48, 17)
        lblTruck.TabIndex = 11
        lblTruck.Text = "Vazio"
        ' 
        ' lblTitleTruck
        ' 
        lblTitleTruck.AutoSize = True
        lblTitleTruck.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTruck.Location = New Point(7, 150)
        lblTitleTruck.Name = "lblTitleTruck"
        lblTitleTruck.Size = New Size(136, 17)
        lblTitleTruck.TabIndex = 10
        lblTitleTruck.Text = "Placa do Cavalo:"
        ' 
        ' lblOperationPoint
        ' 
        lblOperationPoint.AutoSize = True
        lblOperationPoint.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblOperationPoint.Location = New Point(165, 120)
        lblOperationPoint.Name = "lblOperationPoint"
        lblOperationPoint.Size = New Size(48, 17)
        lblOperationPoint.TabIndex = 9
        lblOperationPoint.Text = "Vazio"
        ' 
        ' lblTitleOperationPoint
        ' 
        lblTitleOperationPoint.AutoSize = True
        lblTitleOperationPoint.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleOperationPoint.Location = New Point(7, 120)
        lblTitleOperationPoint.Name = "lblTitleOperationPoint"
        lblTitleOperationPoint.Size = New Size(152, 17)
        lblTitleOperationPoint.TabIndex = 8
        lblTitleOperationPoint.Text = "Ponto Operacional:"
        ' 
        ' lblTravelType
        ' 
        lblTravelType.AutoSize = True
        lblTravelType.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTravelType.Location = New Point(141, 92)
        lblTravelType.Name = "lblTravelType"
        lblTravelType.Size = New Size(48, 17)
        lblTravelType.TabIndex = 7
        lblTravelType.Text = "Vazio"
        ' 
        ' lblTitleTravelType
        ' 
        lblTitleTravelType.AutoSize = True
        lblTitleTravelType.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTravelType.Location = New Point(7, 92)
        lblTitleTravelType.Name = "lblTitleTravelType"
        lblTitleTravelType.Size = New Size(128, 17)
        lblTitleTravelType.TabIndex = 6
        lblTitleTravelType.Text = "Tipo de Viagem:"
        ' 
        ' lblRoute
        ' 
        lblRoute.AutoSize = True
        lblRoute.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblRoute.Location = New Point(61, 66)
        lblRoute.Name = "lblRoute"
        lblRoute.Size = New Size(48, 17)
        lblRoute.TabIndex = 5
        lblRoute.Text = "Vazio"
        ' 
        ' lblTitleRoute
        ' 
        lblTitleRoute.AutoSize = True
        lblTitleRoute.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleRoute.Location = New Point(7, 66)
        lblTitleRoute.Name = "lblTitleRoute"
        lblTitleRoute.Size = New Size(48, 17)
        lblTitleRoute.TabIndex = 4
        lblTitleRoute.Text = "Rota:"
        ' 
        ' lblTravelDate
        ' 
        lblTravelDate.AutoSize = True
        lblTravelDate.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTravelDate.Location = New Point(140, 39)
        lblTravelDate.Name = "lblTravelDate"
        lblTravelDate.Size = New Size(48, 17)
        lblTravelDate.TabIndex = 3
        lblTravelDate.Text = "Vazio"
        ' 
        ' lblTitleTraveDate
        ' 
        lblTitleTraveDate.AutoSize = True
        lblTitleTraveDate.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTraveDate.Location = New Point(6, 39)
        lblTitleTraveDate.Name = "lblTitleTraveDate"
        lblTitleTraveDate.Size = New Size(128, 17)
        lblTitleTraveDate.TabIndex = 2
        lblTitleTraveDate.Text = "Data da Viagem:"
        ' 
        ' lblTravelNumber
        ' 
        lblTravelNumber.AutoSize = True
        lblTravelNumber.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTravelNumber.Location = New Point(157, 13)
        lblTravelNumber.Name = "lblTravelNumber"
        lblTravelNumber.Size = New Size(48, 17)
        lblTravelNumber.TabIndex = 1
        lblTravelNumber.Text = "Vazio"
        ' 
        ' lblTitleTravelNumber
        ' 
        lblTitleTravelNumber.AutoSize = True
        lblTitleTravelNumber.Font = New Font("JetBrainsMonoNL NF", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitleTravelNumber.Location = New Point(7, 13)
        lblTitleTravelNumber.Name = "lblTitleTravelNumber"
        lblTitleTravelNumber.Size = New Size(144, 17)
        lblTitleTravelNumber.TabIndex = 0
        lblTitleTravelNumber.Text = "Número da Viagem:"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(dgvSuppliers)
        TabPage2.Location = New Point(4, 25)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(525, 451)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Fornecedores"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' dgvSuppliers
        ' 
        dgvSuppliers.AccessibleRole = AccessibleRole.TitleBar
        dgvSuppliers.AllowUserToAddRows = False
        dgvSuppliers.AllowUserToDeleteRows = False
        dgvSuppliers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvSuppliers.AutoGenerateColumns = False
        dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvSuppliers.Columns.AddRange(New DataGridViewColumn() {CNPJDataGridViewTextBoxColumn, Codigo, CodigoGeralDataGridViewTextBoxColumn, NomeEmpresa, OrdemParadaDataGridViewTextBoxColumn, Cidade, Bairro, Logradouro, NumeroEndereco})
        dgvSuppliers.DataSource = FornecedoBindingSource
        dgvSuppliers.Location = New Point(3, 3)
        dgvSuppliers.Name = "dgvSuppliers"
        dgvSuppliers.ReadOnly = True
        dgvSuppliers.Size = New Size(519, 445)
        dgvSuppliers.TabIndex = 0
        ' 
        ' FornecedoBindingSource
        ' 
        FornecedoBindingSource.DataSource = GetType(Fornecedo)
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(dgvPlants)
        TabPage3.Location = New Point(4, 25)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(525, 451)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Plantas"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' dgvPlants
        ' 
        dgvPlants.AllowUserToAddRows = False
        dgvPlants.AllowUserToDeleteRows = False
        dgvPlants.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvPlants.AutoGenerateColumns = False
        dgvPlants.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvPlants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvPlants.Columns.AddRange(New DataGridViewColumn() {CNPJDataGridViewTextBoxColumn1, CodigoDataGridViewTextBoxColumn, DescricaoDataGridViewTextBoxColumn})
        dgvPlants.DataSource = PlantaBindingSource
        dgvPlants.Location = New Point(3, 3)
        dgvPlants.Name = "dgvPlants"
        dgvPlants.Size = New Size(516, 433)
        dgvPlants.TabIndex = 0
        ' 
        ' CNPJDataGridViewTextBoxColumn1
        ' 
        CNPJDataGridViewTextBoxColumn1.DataPropertyName = "CNPJ"
        CNPJDataGridViewTextBoxColumn1.HeaderText = "CNPJ"
        CNPJDataGridViewTextBoxColumn1.Name = "CNPJDataGridViewTextBoxColumn1"
        ' 
        ' CodigoDataGridViewTextBoxColumn
        ' 
        CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        CodigoDataGridViewTextBoxColumn.HeaderText = "Código"
        CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        ' 
        ' DescricaoDataGridViewTextBoxColumn
        ' 
        DescricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao"
        DescricaoDataGridViewTextBoxColumn.HeaderText = "Descrição"
        DescricaoDataGridViewTextBoxColumn.Name = "DescricaoDataGridViewTextBoxColumn"
        ' 
        ' PlantaBindingSource
        ' 
        PlantaBindingSource.DataSource = GetType(Planta)
        ' 
        ' CNPJDataGridViewTextBoxColumn
        ' 
        CNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ"
        CNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ"
        CNPJDataGridViewTextBoxColumn.Name = "CNPJDataGridViewTextBoxColumn"
        CNPJDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' Codigo
        ' 
        Codigo.DataPropertyName = "Codigo"
        Codigo.HeaderText = "Código"
        Codigo.Name = "Codigo"
        Codigo.ReadOnly = True
        ' 
        ' CodigoGeralDataGridViewTextBoxColumn
        ' 
        CodigoGeralDataGridViewTextBoxColumn.DataPropertyName = "CodigoGeral"
        CodigoGeralDataGridViewTextBoxColumn.HeaderText = "Código Geral"
        CodigoGeralDataGridViewTextBoxColumn.Name = "CodigoGeralDataGridViewTextBoxColumn"
        CodigoGeralDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' NomeEmpresa
        ' 
        NomeEmpresa.DataPropertyName = "NomeEmpresa"
        NomeEmpresa.HeaderText = "Nome Empresa"
        NomeEmpresa.Name = "NomeEmpresa"
        NomeEmpresa.ReadOnly = True
        ' 
        ' OrdemParadaDataGridViewTextBoxColumn
        ' 
        OrdemParadaDataGridViewTextBoxColumn.DataPropertyName = "OrdemParada"
        OrdemParadaDataGridViewTextBoxColumn.HeaderText = "Ordem de Parada"
        OrdemParadaDataGridViewTextBoxColumn.Name = "OrdemParadaDataGridViewTextBoxColumn"
        OrdemParadaDataGridViewTextBoxColumn.ReadOnly = True
        ' 
        ' Cidade
        ' 
        Cidade.DataPropertyName = "Cidade"
        Cidade.HeaderText = "Cidade"
        Cidade.Name = "Cidade"
        Cidade.ReadOnly = True
        ' 
        ' Bairro
        ' 
        Bairro.DataPropertyName = "Bairro"
        Bairro.HeaderText = "Bairro"
        Bairro.Name = "Bairro"
        Bairro.ReadOnly = True
        ' 
        ' Logradouro
        ' 
        Logradouro.DataPropertyName = "Logradouro"
        Logradouro.HeaderText = "Logradouro"
        Logradouro.Name = "Logradouro"
        Logradouro.ReadOnly = True
        ' 
        ' NumeroEndereco
        ' 
        NumeroEndereco.DataPropertyName = "NumeroEndereco"
        NumeroEndereco.HeaderText = "Número do Endereço"
        NumeroEndereco.Name = "NumeroEndereco"
        NumeroEndereco.ReadOnly = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(533, 480)
        Controls.Add(tabsWithData)
        Font = New Font("JetBrainsMonoNL NF", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form2"
        Text = "Dados da Viagem"
        tabsWithData.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        CType(dgvSuppliers, ComponentModel.ISupportInitialize).EndInit()
        CType(FornecedoBindingSource, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(dgvPlants, ComponentModel.ISupportInitialize).EndInit()
        CType(PlantaBindingSource, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tabsWithData As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents lblTitleTravelNumber As Label
    Friend WithEvents lblTravelNumber As Label
    Friend WithEvents lblTravelDate As Label
    Friend WithEvents lblTitleTraveDate As Label
    Friend WithEvents lblTravelType As Label
    Friend WithEvents lblTitleTravelType As Label
    Friend WithEvents lblRoute As Label
    Friend WithEvents lblTitleRoute As Label
    Friend WithEvents lblOperationPoint As Label
    Friend WithEvents lblTitleOperationPoint As Label
    Friend WithEvents lblTruck As Label
    Friend WithEvents lblTitleTruck As Label
    Friend WithEvents lblTrailer2 As Label
    Friend WithEvents lblTitleTrailer2 As Label
    Friend WithEvents lblTrailer1 As Label
    Friend WithEvents lblTitleTrailer1 As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblTitlePhone As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblTitleStatus As Label
    Friend WithEvents lblPlan As Label
    Friend WithEvents lblTitlePlan As Label
    Friend WithEvents dgvSuppliers As DataGridView
    Friend WithEvents FornecedoBindingSource As BindingSource
    Friend WithEvents dgvPlants As DataGridView
    Friend WithEvents PlantaBindingSource As BindingSource
    Friend WithEvents CNPJDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CNPJDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents CodigoGeralDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeEmpresa As DataGridViewTextBoxColumn
    Friend WithEvents OrdemParadaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cidade As DataGridViewTextBoxColumn
    Friend WithEvents Bairro As DataGridViewTextBoxColumn
    Friend WithEvents Logradouro As DataGridViewTextBoxColumn
    Friend WithEvents NumeroEndereco As DataGridViewTextBoxColumn
End Class
