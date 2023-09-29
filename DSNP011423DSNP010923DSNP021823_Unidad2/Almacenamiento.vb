Imports System.Globalization

Public Class Almacenamiento
    Private nByte As Double = 1
    Private nKilobyte As Double = Math.Pow(1024, 1)
    Private nMegabyte As Double = Math.Pow(1024, 2)
    Private nGigabyte As Double = Math.Pow(1024, 3)
    Private nTerabyte As Double = Math.Pow(1024, 4)
    Private nPetabyte As Double = Math.Pow(1024, 5)
    Public Function GetByte() As Double
        Return nByte
    End Function
    Public Function GetKiloByte() As Double
        Return nKilobyte
    End Function
    Public Function GetMegaByte() As Double
        Return nMegabyte
    End Function
    Public Function GetGigaByte() As Double
        Return nGigabyte
    End Function
    Public Function GetTeraByte() As Double
        Return nTerabyte
    End Function
    Public Function GetPetaByte() As Double
        Return nPetabyte
    End Function

    Public Function Medidas() As String()
        Return New String() {"Byte", "KiloByte", "MegaByte", "GigaByte", "TeraByte", "PetaByte"}
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
