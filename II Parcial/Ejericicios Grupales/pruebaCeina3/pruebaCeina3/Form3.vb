Public Class Form3
    Dim FilaActual As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarDGVHistorial(dgvEstadoTraba, "select idTrabajador as 'Codigo Trabajador', nombres as 'Nombre', telefonoTrabajador as 'Numero Telefono', estado as 'Estado' from ENTIDADES e inner join PERSONAL p on e.telefono = p.telefonoTrabajador")
        LlenarDGVHistorial(dgvPedidos, "select idFactura as 'Numero Pedido', r.estado as 'Estado Pedido', nombres as 'Nombre Trabajador', p.estado as 'Estado Trabajador' from REGISTROS_HISTORIAL r inner  join PERSONAL p on r.idTrabajador = p.idTrabajador inner join ENTIDADES e on P.telefonoTrabajador = e.telefono")
        LlenarDGVHistorial(dgvNiIdea, "select idFactura as 'Numero Pedido', r.estado as 'Estado Pedido', p.estado as 'Estado Personal' from PERSONAL p inner join REGISTROS_HISTORIAL r on p.idTrabajador = r.idTrabajador where p.estado <> 'Libre' and r.estado <> 'Entregado' ")
    End Sub

    Sub dgvNiIdea_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNiIdea.CellClick

        FilaActual = dgvNiIdea.CurrentRow.Index

        cmbCambioPedido.Text = dgvNiIdea.Rows(FilaActual).Cells(1).Value
        cmbCambioPersonal.Text = dgvNiIdea.Rows(FilaActual).Cells(2).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim idFact As Integer = dgvNiIdea.Rows(FilaActual).Cells(0).Value
        Dim idTrab As Integer = obtenerVariableEntera("select idTrabajador from REGISTROS_HISTORIAL where idFactura = '" & idFact & "'", "")

        EjecutarComando("update REGISTROS_HISTORIAL set estado = '" & cmbCambioPedido.Text & "' where idFactura = '" & idFact & "' ")
        EjecutarComando("update PERSONAL set estado = '" & cmbCambioPersonal.Text & "' where idTrabajador = '" & idTrab & "' ")
        LlenarDGVHistorial(dgvNiIdea, "select idFactura as 'Numero Pedido', r.estado as 'Estado Pedido', p.estado as 'Estado Personal' from PERSONAL p inner join REGISTROS_HISTORIAL r on p.idTrabajador = r.idTrabajador where p.estado <> 'Libre' and r.estado <> 'Entregado' ")

    End Sub
End Class