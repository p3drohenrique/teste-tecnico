<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        txtFone = New MaskedTextBox()
        btnSearch = New Button()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("JetBrainsMonoNL NF", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(26, 32)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(420, 31)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Consultar dados de uma viagem"
        ' 
        ' txtFone
        ' 
        txtFone.Font = New Font("JetBrainsMonoNL NF", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtFone.Location = New Point(119, 111)
        txtFone.Mask = "(99) 00000-0000"
        txtFone.Name = "txtFone"
        txtFone.Size = New Size(148, 27)
        txtFone.TabIndex = 1
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.FromArgb(CByte(77), CByte(147), CByte(231))
        btnSearch.BackgroundImageLayout = ImageLayout.None
        btnSearch.FlatAppearance.BorderSize = 0
        btnSearch.FlatStyle = FlatStyle.Flat
        btnSearch.Font = New Font("JetBrainsMonoNL NF SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.ForeColor = Color.White
        btnSearch.Location = New Point(273, 111)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(81, 29)
        btnSearch.TabIndex = 2
        btnSearch.Text = "Buscar"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(473, 191)
        Controls.Add(btnSearch)
        Controls.Add(txtFone)
        Controls.Add(lblTitle)
        Font = New Font("JetBrainsMonoNL NF", 8.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Consultar dados de uma viagem"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents txtFone As MaskedTextBox
    Friend WithEvents btnSearch As Button

End Class
