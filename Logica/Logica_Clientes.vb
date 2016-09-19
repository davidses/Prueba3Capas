Imports System.Data
Imports BaseDatos

Public Class Logica_Clientes
    Dim objCli As New DAOCliente

    Public Function ListaClientes() As DataSet
        Return objCli.ListaClientes
    End Function

    Public Shared Sub Main()

    End Sub
End Class
