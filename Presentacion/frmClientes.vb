Imports Logica

Public Class frmClientes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargaGrilla()
    End Sub

    Private Sub cargaGrilla()
        Dim objLogica As New Logica_Clientes
        dgvClientes.DataSource = objLogica.ListaClientes.Tables("Clientes")
    End Sub
End Class
