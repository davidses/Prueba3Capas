Imports System.Data
Imports System.Data.OleDb
Imports Entidades

Public Class DAOCliente

    Dim objCon As New Conexion
    Dim eClientes As New eClientes
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

    Public Function BuscaCliente(ByVal id As String) As eClientes
        Dim ds As New DataSet
        Dim dr As OleDbDataReader
        Dim eCli As New eClientes

        If IsNumeric(id) Then
            cn = objCon.Conectar
            cn.Open()
            da = New OleDbDataAdapter("SELECT * FROM Clientes WHERE Id=" & id, cn)
            dr = da.SelectCommand.ExecuteReader

            If dr.HasRows Then
                Do While dr.Read
                    If Not IsDBNull(dr.Item("Id")) Then eCli.Id = dr.Item("Id")
                    If Not IsDBNull(dr.Item("Nombre")) Then eCli.Nombre = dr.Item("Nombre")
                    If Not IsDBNull(dr.Item("Domicilio")) Then eCli.Domicilio = dr.Item("Domicilio")
                    If Not IsDBNull(dr.Item("Telefono")) Then eCli.Telefono = dr.Item("Telefono")
                    If Not IsDBNull(dr.Item("Observacion")) Then eCli.Observacion = dr.Item("Observacion")
                Loop
            End If
        End If

        Return eCli
        ds.Dispose()
        da.Dispose()
        cn.Dispose()
    End Function

    'Public Function BuscaCliente(ByVal id As String) As DataSet
    '    Dim ds As New DataSet
    '    cn = objCon.Conectar
    '    da = New OleDbDataAdapter("SELECT * FROM Clientes WHERE Id=" & id, cn)
    '    da.Fill(ds, "Clientes")

    '    Return ds

    '    ds.Dispose()
    '    da.Dispose()
    '    cn.Dispose()
    'End Function

End Class
