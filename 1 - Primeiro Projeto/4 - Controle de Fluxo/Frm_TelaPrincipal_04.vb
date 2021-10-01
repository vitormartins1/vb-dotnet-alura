Public Class Frm_TelaPrincipal_04
    Public Sub New()
        InitializeComponent()

        Lbl_NomeDoProjeto.Text = "4 - Controle de Fluxo"
        Btn_Principal.Text = "Checagem da Permissão de Entrada"
        Me.Text = "4 - Controle de Fluxo"

        'Inicialização dos componentes da aplicação'

        Lbl_idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"
        Grp_Pais.Text = "Acompanhado dos Pais?"
        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"
    End Sub

    Private Sub Btn_Principal_Click(sender As Object, e As EventArgs) Handles Btn_Principal.Click
        Txt_Resultado.Text = ""
        Dim idade As Integer
        idade = Txt_Idade.Text

        Dim acompanhadoDosPais As String
        If Rdb_Sim.Checked Then
            acompanhadoDosPais = "S"
        Else
            acompanhadoDosPais = "N"
        End If

        Dim podeEntrar As Boolean = ((idade >= 18) Or (acompanhadoDosPais = "S" And idade >= 16))
        Dim naoPodeEntrar As Boolean = ((acompanhadoDosPais = "N" And idade >= 16) Or (idade < 16))

        Dim msgAdicional As String = ""
        If acompanhadoDosPais = "S" Then
            msgAdicional = "Está acompanhado dos pais."
        Else
            msgAdicional = "Não está acompanhado dos pais."
        End If

        If podeEntrar Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "Pode entrar. " + msgAdicional
        Else
            If naoPodeEntrar Then
                Txt_Resultado.ForeColor = Color.Red
                Txt_Resultado.Text = "Não pode entrar. " + msgAdicional
            End If
        End If
    End Sub
End Class
