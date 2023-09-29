Imports System.Globalization

Public Class Tiempo
    Private nSegundo As Double = 1 / 60 / 60
    Private nMinuto As Double = 1 / 60
    Private nHora As Double = 1
    Private nDia As Double = 24
    Private nSemana As Double = 168
    Private nMes30 As Double = 5040

    Function GetSegundo() As Double
        Return nSegundo
    End Function
    Function GetMinuto() As Double
        Return nMinuto
    End Function
    Function GetHora() As Double
        Return nHora
    End Function
    Function GetDia() As Double
        Return nDia
    End Function
    Function GetSemana() As Double
        Return nSemana
    End Function
    Function GetMes30Dias() As Double
        Return nMes30
    End Function

    Function Medidas() As String()
        Return New String() {"Segundo", "Minuto", "Hora", "Dia", "Semana", "Mes30Dias"}
    End Function

    Function Convertir(ByVal valor As Double, ByVal origen As String, ByVal destino As String) As String
        Dim valorOrigen As Double = CallByName(Me, "Get" + origen, CallType.Get)
        Dim valorDestino As Double = CallByName(Me, "Get" + destino, CallType.Get)
        Dim retorno = ""
        If valorOrigen < valorDestino Then
            retorno = ((valor * valorOrigen) / valorDestino).ToString("#,##0.00000", CultureInfo.InvariantCulture)
        Else
            retorno = ((valor * valorOrigen) / valorDestino).ToString("N", CultureInfo.InvariantCulture)
        End If
        Return retorno
    End Function

End Class
