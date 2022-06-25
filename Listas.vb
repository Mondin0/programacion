Public Class Listas
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If txtEemento.Text = "" Then
            MessageBox.Show("ingresa un valor")
        Else
            listbxElementos.Items.Add(txtEemento.Text.Trim())
            txtEemento.Text = ""
        End If
    End Sub

    Private Sub btnVaciar_Click(sender As Object, e As EventArgs) Handles btnVaciar.Click
        listbxElementos.Items.Clear()
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        listbxElementos.Items.Remove(listbxElementos.SelectedItem)
    End Sub

    Private Sub Listas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEemento.MaxLength = 20
        listbxElementos.Items.Add("ij")
        MessageBox.Show("ahora cambimos el valor")
        listbxElementos.Items.Item(0) = "uno"
        'listbxElementos.Items.Item(1) = "dos"
    End Sub
End Class