Imports System.Globalization

Public Class Longitud
    Private nmilimetro As Double = 0.001
    Private ncentimetro As Double = 0.01
    Private ndecimetro As Double = 0.1
    Private npulgada As Double = 0.0254
    Private npie As Double = 0.3048
    Private nyarda As Double = 0.9144
    Private nmetro As Double = 1
    Private ndecametro As Double = 10
    Private nhectometro As Double = 100
    Private nkilometro As Double = 1000
    Function GetMilimetro() As Double
        Return nmilimetro
    End Function
    Function GetCentimetro() As Double
        Return ncentimetro
    End Function
    Function GetDecimetro() As Double
        Return ndecimetro
    End Function
    Function GetPulgada() As Double
        Return npulgada
    End Function
    Function GetPie() As Double
        Return npie
    End Function
    Function GetYarda() As Double
        Return nyarda
    End Function
    Function GetMetro() As Double
        Return nmetro
    End Function
    Function GetDecametro() As Double
        Return ndecametro
    End Function
    Function GetHectometro() As Double
        Return nhectometro
    End Function
    Function GetKilometro() As Double
        Return nkilometro
    End Function
    Public Function Medidas() As String()
        Return New String() {"Milimetro", "Centimetro", "Decimetro", "Pulgada", "Pie", "Yarda", "Metro", "Decametro", "Hectometro", "Kilometro"}
    End Function

    Public Function Convertir(ByVal valor As Double, ByVal origen As String, ByVal destino As String) As String
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
