Imports Logica
Imports Entidades

Public Class frmClientes
    Dim objLogica As New Logica_Clientes
    Dim eClientes As New Entidades.eClientes

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargaGrilla()
    End Sub

    Private Sub cargaGrilla()
        dgvClientes.DataSource = objLogica.ListaClientes.Tables("Clientes")
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = 13 Then
            Dim cliente As New eClientes
            cliente = objLogica.BuscaCliente(txtId.Text)
            Call Cargarcliente(cliente)
        End If
    End Sub

    Private Sub Cargarcliente(ByVal eCli As eClientes)
        txtId.Text = eCli.Id
        txtNombre.Text = eCli.Nombre
        txtDireccion.Text = eCli.Domicilio
        txtTelefono.Text = eCli.Telefono
        txtObservaciones.Text = eCli.Observacion
    End Sub

    Private Sub txtId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtId.KeyPress
        ' evitamos el beep
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
        End If
    End Sub
End Class
