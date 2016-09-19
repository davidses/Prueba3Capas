Imports System.Data
Imports BaseDatos

Public Class Logica_Clientes
    Dim objCli As New DAOCliente

    Public Function ListaClientes() As DataSet
        Return objCli.ListaClientes
    End Function

    Public Function BuscaCliente(ByVal id As String) As DataSet
        Return objCli.BuscaCliente(id)
    End Function

    Public Shared Sub Main()

    End Sub
End Class
