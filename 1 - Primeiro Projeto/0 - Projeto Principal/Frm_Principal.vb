Imports _1___Primeiro_Projeto
Imports _2___Criando_Variáveis
Imports _3___Manipulando_Textos
Imports _4___Controle_de_Fluxo
Imports _5___Laços_de_Repetição

Public Class Frm_Principal
    Public Sub New()
        InitializeComponent()

        Me.Text = "Projeto Principal"
        Btn_01.Text = "1 - Primeiro Projeto"
        Btn_02.Text = "2 - Criando Variáveis"
        Btn_03.Text = "3 - Manipulando Textos"
        Btn_04.Text = "4 - Controle de Fluxo"
        Btn_05.Text = "5 - Laços de Repetição"
    End Sub

    Private Sub Btn_01_Click(sender As Object, e As EventArgs) Handles Btn_01.Click
        Dim f As New Frm_TelaPrincipal
        f.ShowDialog()
    End Sub

    Private Sub Btn_02_Click(sender As Object, e As EventArgs) Handles Btn_02.Click
        Dim f As New Frm_Principal_02
        f.ShowDialog()
    End Sub

    Private Sub Btn_03_Click(sender As Object, e As EventArgs) Handles Btn_03.Click
        Dim f As New Frm_Principal_03
        f.ShowDialog()
    End Sub

    Private Sub Btn_04_Click(sender As Object, e As EventArgs) Handles Btn_04.Click
        Dim f As New Frm_Principal_04
        f.ShowDialog()
    End Sub

    Private Sub Btn_05_Click(sender As Object, e As EventArgs) Handles Btn_05.Click
        Dim f As New Frm_Principal_05
        f.ShowDialog()
    End Sub
End Class