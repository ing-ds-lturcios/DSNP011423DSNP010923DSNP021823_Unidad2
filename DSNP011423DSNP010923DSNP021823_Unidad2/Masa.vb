Imports System.Globalization

Public Class Masa
    Private nLibra As Double = 1
    Private nOnza As Double = 0.0625
    Private nGramo As Double = 0.00220462
    Private nKilogramo As Double = 2.2
    Private nTonelada As Double = 2204.62

    Function GetLibra() As Double
        Return nLibra
    End Function
    Function GetOnza() As Double
        Return nOnza
    End Function
    Function GetGramo() As Double
        Return nGramo
    End Function
    Function GetKilogramo() As Double
        Return nKilogramo
    End Function
    Function GetTonelada() As Double
        Return nTonelada
    End Function

    Function Medidas() As String()
        Return New String() {"Libra", "Onza", "Gramo", "Kilogramo", "Tonelada"}
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
