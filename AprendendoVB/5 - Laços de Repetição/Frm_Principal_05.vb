Public Class Frm_Principal_05
    Public Sub New()
        InitializeComponent()
        Lbl_NomeProjeto.Text = "5 - Laços de Repetição"
        Lbl_Principal.Text = "Valor investido: "
        Lbl_Rendimento.Text = "Juros (%) "
        Btn_While.Text = "Calcular Valor Com While"
        Btn_For.Text = "Calcular Valor Com For"
        Lbl_Periodos.Text = "Períodos"
        Grp_Investimento_While_For.Text = "Cálculo do investimento por WHILE e FOR"
        Grp_Investimento_Anual.Text = "Cálculo do investimento anual"
        Lbl_Princiapal_02.Text = "Valor Investido"
        Lbl_Remdimento_02.Text = "Juros Mensais (%)"
        Lbl_Anos.Text = "Anos Aplicados"
        Lbl_Acrescimo_Rendimento.Text = "Acrescimo Juros (%)"
        Btn_Calcula.Text = "Efetua Cálculo"
        Lbl_Limite.Text = "Limite"
        Me.Text = "5 - Laços de Repetição"
    End Sub

    Private Sub Btn_While_Click(sender As Object, e As EventArgs) Handles Btn_While.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodos
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento do mês " + contador.ToString + " é " + investimento.ToString + vbCrLf

            contador += 1
        End While

        Txt_Extrato_While.Text = extrato
    End Sub

    Private Sub Btn_For_Click(sender As Object, e As EventArgs) Handles Btn_For.Click
        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_Periodos.Text)
        Dim extrato As String = ""

        For i = 1 To periodos
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento do mês " + i.ToString + " é " + investimento.ToString + vbCrLf
        Next

        Txt_Extrato_For.Text = extrato
    End Sub

    Private Sub Btn_Calcula_Click(sender As Object, e As EventArgs) Handles Btn_Calcula.Click
        Dim investimento As Double = Val(Txt_Principal_02.Text)
        Dim rendimento As Double = Val(Txt_Rendimento_02.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimoJuros As Double = Val(Txt_Acrescimo_Rendimento.Text)
        Dim limite As Double = Val(Txt_Limite.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1
        Dim controle As Boolean = False

        For i = 1 To anos
            For j = 1 To 12
                investimento = (investimento + (investimento * (rendimento / 100)))
                extrato += "O saldo do investimento no mês " + contador.ToString + " é " _
                + investimento.ToString + " usando a taxa " + rendimento.ToString + " % mês" + vbCrLf

                If investimento >= limite Then
                    controle = True
                    extrato += "O investimento atingiu o limite" + vbCrLf
                    Exit For
                End If
                If controle Then
                    Exit For
                End If

                contador += 1
            Next
            rendimento = rendimento + (rendimento * acrescimoJuros / 100)
        Next

        Txt_Resultado.Text = extrato
    End Sub
End Class
