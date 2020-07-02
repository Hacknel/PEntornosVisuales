Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarComboBox(cmbIdFacturas, "select * from REGISTROS_HISTORIAL", "idFactura")
        cmbIdFacturas.Items.Add("Todos")
    End Sub
    Private Sub Consultar_Click(sender As Object, e As EventArgs) Handles Consultar.Click

        Try
            LlenarDGVHistorial(dgvProcedencia, "select idFactura as 'N Fact', REGISTROS_HISTORIAL.telefono as 'Tel/ID Envio', nombres as 'Nombre Envio', ENTIDADES.idSector as 'Sector Envio', barrio as 'Barrio Envio', referenciasDireccion as 'Ref Envio' from REGISTROS_HISTORIAL inner join ENTIDADES on REGISTROS_HISTORIAL.telefono = ENTIDADES.telefono inner join DIRECCIONES on ENTIDADES.idSector = DIRECCIONES.idSector idFactura = " & txtFactura.Text & "")
            LlenarDGVHistorial(dgvRecepc, "select idFactura, telefonoRecepcion as 'Tel/ID Recep', nombres as 'Nombre Rec', ENTIDADES.idSector as 'Sector Recep', barrio as 'Barrio Recep', referenciasDireccion as 'Ref Recep' from REGISTROS_HISTORIAL inner join ENTIDADES on REGISTROS_HISTORIAL.telefonoRecepcion = ENTIDADES.telefono inner join DIRECCIONES on ENTIDADES.idSector = DIRECCIONES.idSector where idFactura = " & txtFactura.Text & "")
            LlenarDGVHistorial(dgvEncarga, "select idFactura as 'N Fact', PERSONAL.telefonoTrabajador as 'Tel Enca', ENTIDADES.nombres as 'Nombre Enca', detallesMandado as 'Detalles', MOTO.matricula as 'Matricula Motoclicleta', detalle as 'Tipo Mandado', fecha as 'Fecha', pagoEnvio as 'Pago Efectivo' from REGISTROS_HISTORIAL inner join MANDADOS on  REGISTROS_HISTORIAL.idMandado = MANDADOS.idMandado inner join PERSONAL on REGISTROS_HISTORIAL.idTrabajador = PERSONAL.idTrabajador inner join MOTO on PERSONAL.idTransporte = MOTO.idTransporte inner join ENTIDADES on PERSONAL.telefonoTrabajador = ENTIDADES.telefono where idFactura = " & txtFactura.Text & "")


        Catch ex As Exception
            MessageBox.Show("Error al llenar el DGV" + ex.ToString)

        End Try
    End Sub

    Private Sub cmbIdFacturas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbIdFacturas.SelectedIndexChanged

        If cmbIdFacturas.Text = "Todos" Then
            LlenarDGVHistorial(dgvProcedencia, "select idFactura as 'N Fact', REGISTROS_HISTORIAL.telefono as 'Tel/ID Envio', nombres as 'Nombre Envio', ENTIDADES.idSector as 'Sector Envio', barrio as 'Barrio Envio', referenciasDireccion as 'Ref Envio' from REGISTROS_HISTORIAL inner join ENTIDADES on REGISTROS_HISTORIAL.telefono = ENTIDADES.telefono inner join DIRECCIONES on ENTIDADES.idSector = DIRECCIONES.idSector")
            LlenarDGVHistorial(dgvRecepc, "select idFactura, telefonoRecepcion as 'Tel/ID Recep', nombres as 'Nombre Rec', ENTIDADES.idSector as 'Sector Recep', barrio as 'Barrio Recep', referenciasDireccion as 'Ref Recep' from REGISTROS_HISTORIAL inner join ENTIDADES on REGISTROS_HISTORIAL.telefonoRecepcion = ENTIDADES.telefono inner join DIRECCIONES on ENTIDADES.idSector = DIRECCIONES.idSector")
            LlenarDGVHistorial(dgvEncarga, "select idFactura as 'N Fact', PERSONAL.telefonoTrabajador as 'Tel Enca', ENTIDADES.nombres as 'Nombre Enca', detallesMandado as 'Detalles', MOTO.matricula as 'Matricula Motoclicleta', detalle as 'Tipo Mandado', fecha as 'Fecha', pagoEnvio as 'Pago Efectivo' from REGISTROS_HISTORIAL inner join MANDADOS on  REGISTROS_HISTORIAL.idMandado = MANDADOS.idMandado inner join PERSONAL on REGISTROS_HISTORIAL.idTrabajador = PERSONAL.idTrabajador inner join MOTO on PERSONAL.idTransporte = MOTO.idTransporte inner join ENTIDADES on PERSONAL.telefonoTrabajador = ENTIDADES.telefono")
        Else
            LlenarDGVHistorial(dgvProcedencia, "select idFactura as 'N Fact', REGISTROS_HISTORIAL.telefono as 'Tel/ID Envio', nombres as 'Nombre Envio', ENTIDADES.idSector as 'Sector Envio', barrio as 'Barrio Envio', referenciasDireccion as 'Ref Envio' from REGISTROS_HISTORIAL inner join ENTIDADES on REGISTROS_HISTORIAL.telefono = ENTIDADES.telefono inner join DIRECCIONES on ENTIDADES.idSector = DIRECCIONES.idSector where idFactura = " & cmbIdFacturas.Text & "")
            LlenarDGVHistorial(dgvRecepc, "select idFactura, telefonoRecepcion as 'Tel/ID Recep', nombres as 'Nombre Rec', ENTIDADES.idSector as 'Sector Recep', barrio as 'Barrio Recep', referenciasDireccion as 'Ref Recep' from REGISTROS_HISTORIAL inner join ENTIDADES on REGISTROS_HISTORIAL.telefonoRecepcion = ENTIDADES.telefono inner join DIRECCIONES on ENTIDADES.idSector = DIRECCIONES.idSector where idFactura = " & cmbIdFacturas.Text & "")
            LlenarDGVHistorial(dgvEncarga, "select idFactura as 'N Fact', PERSONAL.telefonoTrabajador as 'Tel Enca', ENTIDADES.nombres as 'Nombre Enca', detallesMandado as 'Detalles', MOTO.matricula as 'Matricula Motoclicleta', detalle as 'Tipo Mandado', fecha as 'Fecha', pagoEnvio as 'Pago Efectivo' from REGISTROS_HISTORIAL inner join MANDADOS on  REGISTROS_HISTORIAL.idMandado = MANDADOS.idMandado inner join PERSONAL on REGISTROS_HISTORIAL.idTrabajador = PERSONAL.idTrabajador inner join MOTO on PERSONAL.idTransporte = MOTO.idTransporte inner join ENTIDADES on PERSONAL.telefonoTrabajador = ENTIDADES.telefono where idFactura = " & cmbIdFacturas.Text & "")
        End If
    End Sub
End Class
