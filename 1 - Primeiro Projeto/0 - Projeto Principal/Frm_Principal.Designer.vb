<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btn_01 = New System.Windows.Forms.Button()
        Me.Btn_02 = New System.Windows.Forms.Button()
        Me.Btn_03 = New System.Windows.Forms.Button()
        Me.Btn_04 = New System.Windows.Forms.Button()
        Me.Btn_05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btn_01
        '
        Me.Btn_01.Location = New System.Drawing.Point(33, 40)
        Me.Btn_01.Name = "Btn_01"
        Me.Btn_01.Size = New System.Drawing.Size(202, 23)
        Me.Btn_01.TabIndex = 0
        Me.Btn_01.Text = "Button1"
        Me.Btn_01.UseVisualStyleBackColor = True
        '
        'Btn_02
        '
        Me.Btn_02.Location = New System.Drawing.Point(33, 69)
        Me.Btn_02.Name = "Btn_02"
        Me.Btn_02.Size = New System.Drawing.Size(202, 23)
        Me.Btn_02.TabIndex = 1
        Me.Btn_02.Text = "Button2"
        Me.Btn_02.UseVisualStyleBackColor = True
        '
        'Btn_03
        '
        Me.Btn_03.Location = New System.Drawing.Point(33, 98)
        Me.Btn_03.Name = "Btn_03"
        Me.Btn_03.Size = New System.Drawing.Size(202, 23)
        Me.Btn_03.TabIndex = 2
        Me.Btn_03.Text = "Button3"
        Me.Btn_03.UseVisualStyleBackColor = True
        '
        'Btn_04
        '
        Me.Btn_04.Location = New System.Drawing.Point(33, 127)
        Me.Btn_04.Name = "Btn_04"
        Me.Btn_04.Size = New System.Drawing.Size(202, 23)
        Me.Btn_04.TabIndex = 3
        Me.Btn_04.Text = "Button4"
        Me.Btn_04.UseVisualStyleBackColor = True
        '
        'Btn_05
        '
        Me.Btn_05.Location = New System.Drawing.Point(33, 156)
        Me.Btn_05.Name = "Btn_05"
        Me.Btn_05.Size = New System.Drawing.Size(202, 23)
        Me.Btn_05.TabIndex = 4
        Me.Btn_05.Text = "Button5"
        Me.Btn_05.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 212)
        Me.Controls.Add(Me.Btn_05)
        Me.Controls.Add(Me.Btn_04)
        Me.Controls.Add(Me.Btn_03)
        Me.Controls.Add(Me.Btn_02)
        Me.Controls.Add(Me.Btn_01)
        Me.Name = "Frm_Principal"
        Me.Text = "Frm_Principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btn_01 As Button
    Friend WithEvents Btn_02 As Button
    Friend WithEvents Btn_03 As Button
    Friend WithEvents Btn_04 As Button
    Friend WithEvents Btn_05 As Button
End Class
