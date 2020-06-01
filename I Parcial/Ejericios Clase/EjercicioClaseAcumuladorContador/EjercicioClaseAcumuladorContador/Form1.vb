Public Class CalculadoraPedidos
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnOrden_Click(sender As Object, e As EventArgs) Handles btnOrden.Click
        Try
            Dim precio, total, totalPagar, orden As Integer

            orden = txtPedido.Text

            For i = 1 To orden Step 1
                precio = InputBox("Ingresa el precio del platilli No." & i, "Precio del Platillo")
                totalPagar += precio

            Next
            txtTotal.Text = totalPagar

            total = totalPagar / orden

            txtTotalIndividual.Text = total

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtTotalIndividual.Clear()
        txtTotal.Clear()
        txtPedido.Clear()
    End Sub
End Class
