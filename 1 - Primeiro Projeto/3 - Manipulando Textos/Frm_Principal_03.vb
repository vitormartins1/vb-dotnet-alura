Public Class Frm_Principal_03

    Dim listaCurso As String

    Public Sub New()
        InitializeComponent()

        Lbl_NomeDoProjeto.Text = "3 - Manipulando Textos"
        Btn_Char.Text = "Clique para obter Char"
        Btn_Adicionar.Text = "Adicione a sua lista"
        Btn_Lista.Text = "Mostrar Lista de Cursos"
        Btn_GuardarVariaveis.Text = "Guardar Variáveis"
        Me.Text = "3 - Manipulando Textos"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Dim primeiraLetra As Char = "a"
        MsgBox("O character da variavel primeiraLetra é " + primeiraLetra)

        Dim segundaLetra As Char = Chr(65)
        MsgBox("O Character numero 65 é " + segundaLetra)

        Dim numeroChar As Integer
        numeroChar = 65
        Dim terceiraLetra As Char = Chr(numeroChar)

        numeroChar = numeroChar + 1
        Dim quartaLetra As Char = Chr(numeroChar)

        MsgBox("O character numero 65 é " + terceiraLetra + " e o 66 é " + quartaLetra)
    End Sub

    Private Sub Btn_Char_Click(sender As Object, e As EventArgs) Handles Btn_Char.Click
        Dim valorChar As Integer = Val(Txt_NumeroChar.Text)
        Dim quintaLetra As Char = Chr(valorChar)

        MsgBox("O character para o número " + valorChar.ToString() + " é " + quintaLetra)
    End Sub

    Private Sub Btn_Adicionar_Click(sender As Object, e As EventArgs) Handles Btn_Adicionar.Click
        Dim cursoDigitado As String = Txt_Curso.Text
        listaCurso = listaCurso + cursoDigitado + vbCrLf

        Txt_Lista.Text = listaCurso

    End Sub

    Private Sub Btn_Lista_Click(sender As Object, e As EventArgs) Handles Btn_Lista.Click
        MsgBox(listaCurso)
    End Sub

    Private Sub Btn_GuardarVariaveis_Click(sender As Object, e As EventArgs) Handles Btn_GuardarVariaveis.Click
        Dim idade As Integer = 12
        Dim idadeGustavo As Integer

        idadeGustavo = idade

        MsgBox("Idade é igual a " + idade.ToString + " enquanto idade gustavo é " + idadeGustavo.ToString)
        idade = 20
        MsgBox("Idade é igual a " + idade.ToString + " enquanto idade gustavo é " + idadeGustavo.ToString)
    End Sub
End Class
