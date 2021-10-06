<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_02
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
        Me.Btn_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_PontoFlutuante = New System.Windows.Forms.Button()
        Me.Btn_ConversaoNumeros = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btn_Resultado = New System.Windows.Forms.Button()
        Me.Txt_ResultadoDouble = New System.Windows.Forms.TextBox()
        Me.Txt_ResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_NumerosInteiros
        '
        Me.Btn_NumerosInteiros.Location = New System.Drawing.Point(12, 36)
        Me.Btn_NumerosInteiros.Name = "Btn_NumerosInteiros"
        Me.Btn_NumerosInteiros.Size = New System.Drawing.Size(120, 62)
        Me.Btn_NumerosInteiros.TabIndex = 0
        Me.Btn_NumerosInteiros.Text = "Exemplo Números Inteiros"
        Me.Btn_NumerosInteiros.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Tag = "2"
        Me.Label1.Text = "2 - Criando Variáveis"
        '
        'Btn_PontoFlutuante
        '
        Me.Btn_PontoFlutuante.Location = New System.Drawing.Point(12, 104)
        Me.Btn_PontoFlutuante.Name = "Btn_PontoFlutuante"
        Me.Btn_PontoFlutuante.Size = New System.Drawing.Size(120, 61)
        Me.Btn_PontoFlutuante.TabIndex = 3
        Me.Btn_PontoFlutuante.Text = "Exemplo Números Ponto Flutuante"
        Me.Btn_PontoFlutuante.UseVisualStyleBackColor = True
        '
        'Btn_ConversaoNumeros
        '
        Me.Btn_ConversaoNumeros.Location = New System.Drawing.Point(12, 171)
        Me.Btn_ConversaoNumeros.Name = "Btn_ConversaoNumeros"
        Me.Btn_ConversaoNumeros.Size = New System.Drawing.Size(120, 61)
        Me.Btn_ConversaoNumeros.TabIndex = 4
        Me.Btn_ConversaoNumeros.Text = "Exemplo de Conversão de Números"
        Me.Btn_ConversaoNumeros.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(185, 48)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(182, 23)
        Me.Txt_Numerador.TabIndex = 5
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(185, 77)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(182, 23)
        Me.Txt_Denominador.TabIndex = 6
        '
        'Btn_Resultado
        '
        Me.Btn_Resultado.Location = New System.Drawing.Point(185, 106)
        Me.Btn_Resultado.Name = "Btn_Resultado"
        Me.Btn_Resultado.Size = New System.Drawing.Size(182, 23)
        Me.Btn_Resultado.TabIndex = 7
        Me.Btn_Resultado.Text = "Resultado"
        Me.Btn_Resultado.UseVisualStyleBackColor = True
        '
        'Txt_ResultadoDouble
        '
        Me.Txt_ResultadoDouble.Location = New System.Drawing.Point(185, 171)
        Me.Txt_ResultadoDouble.Name = "Txt_ResultadoDouble"
        Me.Txt_ResultadoDouble.Size = New System.Drawing.Size(332, 23)
        Me.Txt_ResultadoDouble.TabIndex = 9
        '
        'Txt_ResultadoDecimal
        '
        Me.Txt_ResultadoDecimal.Location = New System.Drawing.Point(185, 142)
        Me.Txt_ResultadoDecimal.Name = "Txt_ResultadoDecimal"
        Me.Txt_ResultadoDecimal.Size = New System.Drawing.Size(332, 23)
        Me.Txt_ResultadoDecimal.TabIndex = 8
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 442)
        Me.Controls.Add(Me.Txt_ResultadoDouble)
        Me.Controls.Add(Me.Txt_ResultadoDecimal)
        Me.Controls.Add(Me.Btn_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btn_ConversaoNumeros)
        Me.Controls.Add(Me.Btn_PontoFlutuante)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_NumerosInteiros)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.Text = "Titulo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_NumerosInteiros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_PontoFlutuante As Button
    Friend WithEvents Btn_ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btn_Resultado As Button
    Friend WithEvents Txt_ResultadoDouble As TextBox
    Friend WithEvents Txt_ResultadoDecimal As TextBox
End Class
