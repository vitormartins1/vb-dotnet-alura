<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_03
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
        Me.Btn_Char = New System.Windows.Forms.Button()
        Me.Txt_NumeroChar = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btn_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.Btn_Lista = New System.Windows.Forms.Button()
        Me.Btn_GuardarVariaveis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_Principal
        '
        Me.Btn_Principal.Location = New System.Drawing.Point(12, 56)
        Me.Btn_Principal.Name = "Btn_Principal"
        Me.Btn_Principal.Size = New System.Drawing.Size(120, 62)
        Me.Btn_Principal.TabIndex = 0
        Me.Btn_Principal.Text = "Clique Aqui"
        Me.Btn_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeDoProjeto
        '
        Me.Lbl_NomeDoProjeto.AutoSize = True
        Me.Lbl_NomeDoProjeto.Location = New System.Drawing.Point(25, 23)
        Me.Lbl_NomeDoProjeto.Name = "Lbl_NomeDoProjeto"
        Me.Lbl_NomeDoProjeto.Size = New System.Drawing.Size(98, 15)
        Me.Lbl_NomeDoProjeto.TabIndex = 1
        Me.Lbl_NomeDoProjeto.Text = "Nome do projeto"
        '
        'Btn_Char
        '
        Me.Btn_Char.Location = New System.Drawing.Point(186, 85)
        Me.Btn_Char.Name = "Btn_Char"
        Me.Btn_Char.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Char.TabIndex = 2
        Me.Btn_Char.Text = "Button1"
        Me.Btn_Char.UseVisualStyleBackColor = True
        '
        'Txt_NumeroChar
        '
        Me.Txt_NumeroChar.Location = New System.Drawing.Point(173, 56)
        Me.Txt_NumeroChar.Name = "Txt_NumeroChar"
        Me.Txt_NumeroChar.Size = New System.Drawing.Size(100, 23)
        Me.Txt_NumeroChar.TabIndex = 3
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(12, 132)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(41, 15)
        Me.Lbl_Curso.TabIndex = 4
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(13, 160)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(260, 23)
        Me.Txt_Curso.TabIndex = 5
        '
        'Btn_Adicionar
        '
        Me.Btn_Adicionar.Location = New System.Drawing.Point(303, 160)
        Me.Btn_Adicionar.Name = "Btn_Adicionar"
        Me.Btn_Adicionar.Size = New System.Drawing.Size(191, 23)
        Me.Btn_Adicionar.TabIndex = 6
        Me.Btn_Adicionar.Text = "Button1"
        Me.Btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(13, 190)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(260, 142)
        Me.Txt_Lista.TabIndex = 7
        '
        'Btn_Lista
        '
        Me.Btn_Lista.Location = New System.Drawing.Point(303, 190)
        Me.Btn_Lista.Name = "Btn_Lista"
        Me.Btn_Lista.Size = New System.Drawing.Size(191, 23)
        Me.Btn_Lista.TabIndex = 8
        Me.Btn_Lista.Text = "Button1"
        Me.Btn_Lista.UseVisualStyleBackColor = True
        '
        'Btn_GuardarVariaveis
        '
        Me.Btn_GuardarVariaveis.Location = New System.Drawing.Point(303, 220)
        Me.Btn_GuardarVariaveis.Name = "Btn_GuardarVariaveis"
        Me.Btn_GuardarVariaveis.Size = New System.Drawing.Size(191, 23)
        Me.Btn_GuardarVariaveis.TabIndex = 9
        Me.Btn_GuardarVariaveis.Text = "Button1"
        Me.Btn_GuardarVariaveis.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 442)
        Me.Controls.Add(Me.Btn_GuardarVariaveis)
        Me.Controls.Add(Me.Btn_Lista)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btn_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txt_NumeroChar)
        Me.Controls.Add(Me.Btn_Char)
        Me.Controls.Add(Me.Lbl_NomeDoProjeto)
        Me.Controls.Add(Me.Btn_Principal)
        Me.Name = "Frm_TelaPrincipal_03"
        Me.Text = "Titulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Principal As Button
    Friend WithEvents Lbl_NomeDoProjeto As Label
    Friend WithEvents Btn_Char As Button
    Friend WithEvents Txt_NumeroChar As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btn_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
    Friend WithEvents Btn_Lista As Button
    Friend WithEvents Btn_GuardarVariaveis As Button
End Class
