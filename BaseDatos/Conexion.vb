Imports System.Configuration
Imports System.Data.OleDb

Public Class Conexion
    ' https://www.youtube.com/watch?v=hkZd6abBasI
    Dim Conexion As OleDbConnection

    Public Function Conectar() As OleDbConnection
        Conexion = New OleDbConnection(ConfigurationManager.ConnectionStrings("cn").ConnectionString)
        Return Conexion
    End Function

    Public Shared Sub Main()

    End Sub

End Class
