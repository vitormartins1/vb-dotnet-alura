Imports ByteBank.ByteBank

Public Class Frm_Principal_02

    Dim ContaDaGabriela As New ContaCorrente(1000)
    Dim ContaDoBruno As New ContaCorrente(500)
    Dim Bruno As New Cliente("Bruno", "15638956789")

    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        Me.Text = "2 - ByteBank"
        Lbl_Principal.Text = "2 - ByteBank"
        Grp_Gabriela.Text = "Gabriela"
        Lbl_Valor_Gabriela.Text = "Valor a ser depositado/sacado"
        Lbl_Saldo_Gabriela.Text = "Novo Saldo"
        Lbl_Resultado_Gabriela.Text = "Resultado do saque"
        Lbl_SaldoAtual_Gabriela.Text = "Saldo Atual"
        Btn_Sacar_Gabriela.Text = "Efetuar Saque"
        Btn_Depositar_Gabriela.Text = "Efetuar Depósito"
        Btn_Transferir_Gabriela.Text = "Efetuar Transferencia"
        Txt_SaldoAtual_Gabriela.ReadOnly = True
        Txt_Saldo_Gabriela.ReadOnly = True
        Txt_Resultado_Gabriela.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True
        Lbl_Nome_Gabriela.Text = "Nome"
        Btn_Nome_Gabriela.Text = "..."

        Grp_Bruno.Text = "Bruno"
        Lbl_Valor_Bruno.Text = "Valor a ser depositado/sacado"
        Lbl_Saldo_Bruno.Text = "Novo Saldo"
        Lbl_Resultado_Bruno.Text = "Resultado do saque"
        Lbl_SaldoAtual_Bruno.Text = "Saldo Atual"
        Btn_Sacar_Bruno.Text = "Efetuar Saque"
        Btn_Depositar_Bruno.Text = "Efetuar Depósito"
        Btn_Transferir_Bruno.Text = "Efetuar Transferencia"
        Txt_SaldoAtual_Bruno.ReadOnly = True
        Txt_Saldo_Bruno.ReadOnly = True
        Txt_Resultado_Bruno.ReadOnly = True
        Txt_Extrato_Bruno.ReadOnly = True
        Lbl_Nome_Bruno.Text = "Nome"
        Btn_Nome_Bruno.Text = "..."

        ContaDaGabriela.Titular = New Cliente("Gabriela", "123456789")
        ContaDaGabriela.Titular.Profissao = "Analista de Sistemas"
        ContaDaGabriela.Titular.Cidade = "Rio de Janeiro"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        Lbl_BemVindo_Gabriela.Text = "Bem Vindo " + ContaDaGabriela.Titular.Nome +
            " Agência: " + ContaDaGabriela.Agencia.ToString +
            " Conta Corrente: " + ContaDaGabriela.Conta.ToString +
            " CPF: " + ContaDaGabriela.Titular.CPF
        Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.GetSaldo().ToString

        Bruno.Profissao = "Advogado"
        Bruno.Cidade = "São Paulo"

        ContaDoBruno.Titular = Bruno
        ContaDoBruno.Agencia = 863
        ContaDoBruno.Conta = 863224

        Lbl_BemVindo_Bruno.Text = "Bem Vindo " + ContaDoBruno.Titular.Nome +
            " Agência: " + ContaDoBruno.Agencia.ToString +
            " Conta Corrente: " + ContaDoBruno.Conta.ToString
        Txt_SaldoAtual_Bruno.Text = ContaDoBruno.GetSaldo().ToString

        Lbl_Numero_Clientes.Text = "O número de clientes é: " + Cliente.NumeroClientes.ToString
    End Sub

    Private Sub Btn_Depositar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Depositar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Gabriela.Text)
        ContaDaGabriela.Depositar(ValorDepositar)

        Txt_Saldo_Gabriela.Text = ContaDaGabriela.GetSaldo().ToString
        Txt_Resultado_Gabriela.Text = "Depósito efetuado com sucesso"
        Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
        ContaDaGabriela.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString +
            " Saldo " + ContaDaGabriela.GetSaldo().ToString + vbCrLf
        Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
    End Sub

    Private Sub Btn_Sacar_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Sacar_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Gabriela.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.GetSaldo().ToString
            Txt_Resultado_Gabriela.Text = "Saque efetuado com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            ContaDaGabriela.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString +
                " Saldo " + ContaDaGabriela.GetSaldo().ToString + vbCrLf
            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato

        End If
    End Sub

    Private Sub Btn_Transferir_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_Gabriela.Click
        Txt_Resultado_Gabriela.Text = ""
        Txt_Saldo_Gabriela.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoTransferencia As Boolean = ContaDaGabriela.Transferir(ValorTransferir, ContaDoBruno)

        If RetornoTransferencia = False Then
            Txt_Resultado_Gabriela.Text = "Transferencia não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.GetSaldo().ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.GetSaldo().ToString

            Txt_Resultado_Gabriela.Text = "Transferencia efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDaGabriela.GetSaldo().ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDoBruno.GetSaldo().ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub

    Private Sub Btn_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Depositar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Bruno.Text)
        ContaDoBruno.Depositar(ValorDepositar)

        Txt_Saldo_Bruno.Text = ContaDoBruno.GetSaldo().ToString
        Txt_Resultado_Bruno.Text = "Depósito efetuado com sucesso"
        Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
        ContaDoBruno.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString +
            " Saldo " + ContaDoBruno.GetSaldo().ToString + vbCrLf
        Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
    End Sub

    Private Sub Btn_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Sacar_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoSaque As Boolean = ContaDoBruno.Sacar(ValorSacar)

        If RetornoSaque = False Then
            Txt_Resultado_Bruno.Text = "Saque não é possível ser feito"
        Else
            Txt_Saldo_Bruno.Text = ContaDoBruno.GetSaldo().ToString
            Txt_Resultado_Bruno.Text = "Saque efetuado com sucesso"
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text
            ContaDoBruno.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString +
                " Saldo " + ContaDoBruno.GetSaldo().ToString + vbCrLf
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub

    Private Sub Btn_Transferir_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Transferir_Bruno.Click
        Txt_Resultado_Bruno.Text = ""
        Txt_Saldo_Bruno.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoTransferencia As Boolean = ContaDoBruno.Transferir(ValorTransferir, ContaDaGabriela)

        If RetornoTransferencia = False Then
            Txt_Resultado_Bruno.Text = "Transferencia não é possível ser feito"
        Else
            Txt_Saldo_Gabriela.Text = ContaDaGabriela.GetSaldo().ToString
            Txt_Saldo_Bruno.Text = ContaDoBruno.GetSaldo().ToString

            Txt_Resultado_Bruno.Text = "Transferencia efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = Txt_Saldo_Gabriela.Text
            Txt_SaldoAtual_Bruno.Text = Txt_Saldo_Bruno.Text

            ContaDaGabriela.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDaGabriela.GetSaldo().ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferencia de " + ValorTransferir.ToString +
                " Saldo " + ContaDoBruno.GetSaldo().ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        End If
    End Sub

    Private Sub Btn_Nome_Gabriela_Click(sender As Object, e As EventArgs) Handles Btn_Nome_Gabriela.Click
        Dim vNome As String = Txt_Nome_Gabriela.Text
        ContaDaGabriela.Titular.Nome = vNome

        Lbl_BemVindo_Gabriela.Text = "Bem Vindo " + ContaDaGabriela.Titular.Nome +
            " Agência: " + ContaDaGabriela.Agencia.ToString +
            " Conta Corrente: " + ContaDaGabriela.Conta.ToString
    End Sub

    Private Sub Btn_Nome_Bruno_Click(sender As Object, e As EventArgs) Handles Btn_Nome_Bruno.Click
        Dim vNome As String = Txt_Nome_Bruno.Text
        ContaDoBruno.Titular.Nome = vNome

        Lbl_BemVindo_Bruno.Text = "Bem Vindo " + ContaDoBruno.Titular.Nome +
            " Agência: " + ContaDoBruno.Agencia.ToString +
            " Conta Corrente: " + ContaDoBruno.Conta.ToString
    End Sub
End Class
