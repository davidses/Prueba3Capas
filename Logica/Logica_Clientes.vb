Imports System.Data
Imports BaseDatos
Imports Entidades

Public Class Logica_Clientes
    Dim objCli As New DAOCliente

    Public Function ListaClientes() As DataSet
        Return objCli.ListaClientes
    End Function

    Public Function BuscaCliente(ByVal id As String) As eClientes
        Return objCli.BuscaCliente(id)
    End Function

    Public Shared Sub Main()

    End Sub
End Class
