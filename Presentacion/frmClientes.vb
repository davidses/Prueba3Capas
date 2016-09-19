Imports Logica

Public Class frmClientes
    Dim objLogica As New Logica_Clientes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargaGrilla()
    End Sub

    Private Sub cargaGrilla()
        dgvClientes.DataSource = objLogica.ListaClientes.Tables("Clientes")
    End Sub

    Private Sub txtId_TextChanged(sender As Object, e As EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = 13 Then
            Dim row As DataRow
            row = objLogica.BuscaCliente(1).Tables("Clientes").Rows(0)
        End If
    End Sub
End Class
