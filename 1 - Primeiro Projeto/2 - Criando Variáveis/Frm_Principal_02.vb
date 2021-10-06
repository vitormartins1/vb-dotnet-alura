Public Class Frm_Principal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_NumerosInteiros.Click
        Dim Idade = 12
        MsgBox("Idade é " + Idade.ToString(), MsgBoxStyle.Critical)
    End Sub

    Private Sub Btn_PontoFlutuante_Click(sender As Object, e As EventArgs) Handles Btn_PontoFlutuante.Click
        Dim valor As Double
        valor = 9.2
        MsgBox("avariavel e igual a " + valor.ToString(), MsgBoxStyle.Critical)

        valor = 5 / 2
        MsgBox("O valor de 5 / 2 é " + valor.ToString(), MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador

        MsgBox("O valor de 5 / 2 é " + valor.ToString(), MsgBoxStyle.Critical)

    End Sub

    Private Sub Btn_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btn_ConversaoNumeros.Click
        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do salario é " + salario.ToString() + " e do salario inteiro é " + salarioInteiro.ToString())
    End Sub

    Private Sub Btn_Resultado_Click(sender As Object, e As EventArgs) Handles Btn_Resultado.Click
        Dim numerador As Decimal
        Dim denominador As Decimal

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim resultado As Double
        resultado = numerador / denominador

        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador

        MsgBox("O resultado entre a divisão de " + numerador.ToString() + " por " + denominador.ToString() + " é: " + resultado.ToString())

        Txt_ResultadoDecimal.Text = resultadoDecimal.ToString()
        Txt_ResultadoDouble.Text = resultado.ToString()


    End Sub
End Class
