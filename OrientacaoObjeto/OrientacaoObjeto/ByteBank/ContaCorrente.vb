﻿Imports ByteBank.ByteBank

Public Class ContaCorrente

    Public Sub New(m_Saldo As Double)
        Saldo = m_Saldo
    End Sub

    Private m_Extrato As String = ""
    Public Property Extrato As String
        Get
            Return m_Extrato
        End Get
        Set(value As String)
            m_Extrato = value
        End Set
    End Property

    Public Property Conta As Integer

    Public Property Agencia As Integer

    Private m_Titular As Cliente
    Public Property Titular As Cliente
        Get
            Return m_Titular
        End Get
        Set(value As Cliente)
            m_Titular = value
        End Set
    End Property

    Private m_Saldo As Double = 100
    Public Property Saldo As Double
        Get
            Return m_Saldo
        End Get
        Set(value As Double)
            If value < 0 Then
                m_Saldo = 0
            Else
                m_Saldo = value
            End If
        End Set
    End Property

    Public Function GetSaldo() As Double
        Return m_Saldo
    End Function

    Public Sub SetSaldo(saldoInicial As Double)
        If saldoInicial < 0 Then
            m_Saldo = 0
        Else
            m_Saldo = saldoInicial
        End If
    End Sub

    Public Function Sacar(ValorSacar As Double) As Boolean

        Dim Retorno As Boolean
        If m_Saldo < ValorSacar Then
            Retorno = False
        Else
            m_Saldo -= ValorSacar
            Retorno = True
        End If
        Return Retorno

    End Function

    Public Sub Depositar(ValorDepositar As Double)
        m_Saldo += ValorDepositar
    End Sub

    Public Function Transferir(ValorTransferencia As Double, ByRef ContaDestino As ContaCorrente) As Boolean

        Dim Retorno As Boolean
        If m_Saldo < ValorTransferencia Then
            Retorno = False
        Else
            m_Saldo -= ValorTransferencia
            ContaDestino.Depositar(ValorTransferencia)
            Retorno = True
        End If
        Return Retorno

    End Function

End Class