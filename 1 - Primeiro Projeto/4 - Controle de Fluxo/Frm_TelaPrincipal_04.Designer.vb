<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal_04
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
        Me.Btn_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeDoProjeto = New System.Windows.Forms.Label()
        Me.Lbl_idade = New System.Windows.Forms.Label()
        Me.Txt_Idade = New System.Windows.Forms.TextBox()
        Me.Txt_Resultado = New System.Windows.Forms.TextBox()
        Me.Lbl_Resultado = New System.Windows.Forms.Label()
        Me.Grp_Pais = New System.Windows.Forms.GroupBox()
        Me.Rdb_Sim = New System.Windows.Forms.RadioButton()
        Me.Rdb_Nao = New System.Windows.Forms.RadioButton()
        Me.Grp_Pais.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(25, 130)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(363, 44)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Clique Aqui"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeDoProjeto
        '
        Me.Lbl_NomeDoProjeto.AutoSize = True
        Me.Lbl_NomeDoProjeto.Location = New System.Drawing.Point(25, 23)
        Me.Lbl_NomeDoProjeto.Name = "Lbl_NomeDoProjeto"
        Me.Lbl_NomeDoProjeto.Size = New System.Drawing.Size(110, 15)
        Me.Lbl_NomeDoProjeto.TabIndex = 1
        Me.Lbl_NomeDoProjeto.Text = "1 - Primeiro Projeto"
        '
        'Lbl_idade
        '
        Me.Lbl_idade.AutoSize = True
        Me.Lbl_idade.Location = New System.Drawing.Point(25, 84)
        Me.Lbl_idade.Name = "Lbl_idade"
        Me.Lbl_idade.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_idade.TabIndex = 2
        Me.Lbl_idade.Text = "Label1"
        '
        'Txt_Idade
        '
        Me.Txt_Idade.Location = New System.Drawing.Point(25, 103)
        Me.Txt_Idade.Name = "Txt_Idade"
        Me.Txt_Idade.Size = New System.Drawing.Size(100, 23)
        Me.Txt_Idade.TabIndex = 3
        '
        'Txt_Resultado
        '
        Me.Txt_Resultado.Location = New System.Drawing.Point(25, 195)
        Me.Txt_Resultado.Multiline = True
        Me.Txt_Resultado.Name = "Txt_Resultado"
        Me.Txt_Resultado.Size = New System.Drawing.Size(363, 167)
        Me.Txt_Resultado.TabIndex = 4
        '
        'Lbl_Resultado
        '
        Me.Lbl_Resultado.AutoSize = True
        Me.Lbl_Resultado.Location = New System.Drawing.Point(25, 177)
        Me.Lbl_Resultado.Name = "Lbl_Resultado"
        Me.Lbl_Resultado.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_Resultado.TabIndex = 5
        Me.Lbl_Resultado.Text = "Label1"
        '
        'Grp_Pais
        '
        Me.Grp_Pais.Controls.Add(Me.Rdb_Nao)
        Me.Grp_Pais.Controls.Add(Me.Rdb_Sim)
        Me.Grp_Pais.Location = New System.Drawing.Point(143, 69)
        Me.Grp_Pais.Name = "Grp_Pais"
        Me.Grp_Pais.Size = New System.Drawing.Size(225, 57)
        Me.Grp_Pais.TabIndex = 6
        Me.Grp_Pais.TabStop = False
        Me.Grp_Pais.Text = "GroupBox1"
        '
        'Rdb_Sim
        '
        Me.Rdb_Sim.AutoSize = True
        Me.Rdb_Sim.Location = New System.Drawing.Point(7, 23)
        Me.Rdb_Sim.Name = "Rdb_Sim"
        Me.Rdb_Sim.Size = New System.Drawing.Size(97, 19)
        Me.Rdb_Sim.TabIndex = 0
        Me.Rdb_Sim.TabStop = True
        Me.Rdb_Sim.Text = "RadioButton1"
        Me.Rdb_Sim.UseVisualStyleBackColor = True
        '
        'Rdb_Nao
        '
        Me.Rdb_Nao.AutoSize = True
        Me.Rdb_Nao.Location = New System.Drawing.Point(110, 23)
        Me.Rdb_Nao.Name = "Rdb_Nao"
        Me.Rdb_Nao.Size = New System.Drawing.Size(97, 19)
        Me.Rdb_Nao.TabIndex = 1
        Me.Rdb_Nao.TabStop = True
        Me.Rdb_Nao.Text = "RadioButton1"
        Me.Rdb_Nao.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 442)
        Me.Controls.Add(Me.Grp_Pais)
        Me.Controls.Add(Me.Lbl_Resultado)
        Me.Controls.Add(Me.Txt_Resultado)
        Me.Controls.Add(Me.Txt_Idade)
        Me.Controls.Add(Me.Lbl_idade)
        Me.Controls.Add(Me.Lbl_NomeDoProjeto)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Name = "Frm_TelaPrincipal_04"
        Me.Text = "Titulo"
        Me.Grp_Pais.ResumeLayout(False)
        Me.Grp_Pais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_NomeDoProjeto As Label
    Friend WithEvents Lbl_idade As Label
    Friend WithEvents Txt_Idade As TextBox
    Friend WithEvents Txt_Resultado As TextBox
    Friend WithEvents Lbl_Resultado As Label
    Friend WithEvents Grp_Pais As GroupBox
    Friend WithEvents Rdb_Sim As RadioButton
    Friend WithEvents Rdb_Nao As RadioButton
End Class
