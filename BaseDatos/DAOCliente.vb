Imports System.Data
Imports System.Data.OleDb

Public Class DAOCliente

    Dim objCon As New Conexion
    Dim cn As OleDbConnection
    Dim da As OleDbDataAdapter

    Public Function ListaClientes() As DataSet
        Dim ds As New DataSet
        cn = objCon.Conectar
        da = New OleDbDataAdapter("SELECT * FROM Clientes", cn)
        da.Fill(ds, "Clientes")

        Return ds

        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

End Class
