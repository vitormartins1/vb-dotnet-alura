Public Class Frm_Principal_01
    Public Sub New()
        InitializeComponent()
        Me.Text = "1 - Primeira Classe"
        Lbl_Principal.Text = "1 - Primeira Classe"
        Btn_Acao.Text = "Conta Gabriela"
        Lbl_Saldo.Text = "Saldo"
        Lbl_Incremento.Text = "Incremento"
        Btn_Acao2.Text = "Conta Bruno"
        Btn_ValRef.Text = "Clique aqui"
    End Sub

    Private Sub Btn_Acao_Click(sender As Object, e As EventArgs) Handles Btn_Acao.Click
        Dim ContaDaGabriela As New ContaCorrente

        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141
        ContaDaGabriela.Saldo = Val(Txt_Saldo.Text)

        MsgBox("O Saldo da " + ContaDaGabriela.Titular + " na C/C " +
            ContaDaGabriela.Agencia.ToString + " - " + ContaDaGabriela.Conta.ToString +
        " é " + ContaDaGabriela.Saldo.ToString)

        Dim vIncremento As Double = Val(Txt_Incremento.Text)
        ContaDaGabriela.Saldo += vIncremento

        MsgBox("O Saldo da " + ContaDaGabriela.Titular + " na C/C " +
            ContaDaGabriela.Agencia.ToString + " - " + ContaDaGabriela.Conta.ToString +
        " é " + ContaDaGabriela.Saldo.ToString)
    End Sub

    Private Sub Btn_Acao2_Click(sender As Object, e As EventArgs) Handles Btn_Acao2.Click
        Dim ContaDoBruno As New ContaCorrente

        MsgBox(ContaDoBruno.Titular)
        MsgBox(ContaDoBruno.Agencia)
        MsgBox(ContaDoBruno.Conta)
        MsgBox(ContaDoBruno.Saldo)

        ContaDoBruno.Saldo += 100

        MsgBox(ContaDoBruno.Saldo)
    End Sub

    Private Sub Btn_ValRef_Click(sender As Object, e As EventArgs) Handles Btn_ValRef.Click
        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("Valor da idade " + idade.ToString + " idade2 " + idade2.ToString)

        idade = 30

        MsgBox("Valor da idade " + idade.ToString + " idade2 " + idade2.ToString)
    End Sub
End Class