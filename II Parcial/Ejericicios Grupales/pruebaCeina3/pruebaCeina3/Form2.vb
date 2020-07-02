Imports System.Data.SqlClient
Public Class Form2
	Dim tipoRegistro As Integer
	Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		abrirConexion()
		llenarComboBox(cmbEmpresas, "select nombres from ENTIDADES where telefono>=1 and telefono<=100", "nombres")
		llenarComboBox(cmbEmpresasR, "select nombres from ENTIDADES where telefono>=1 and telefono<=100", "nombres")
		llenarComboBox(cmbEncargado, "select nombres from ENTIDADES e inner join PERSONAL p on e.telefono = p.telefonoTrabajador", "nombres")
		llenarComboBox(cmbTipoEnvio, "select detalle from MANDADOS", "detalle")
		cmbEmpresas.Items.Add("Ninguno")
		cmbEmpresasR.Items.Add("Ninguno")
	End Sub

	Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
		comprobarYLlenarTel(txtTelefono, txtNombre, txtIdSector, txtBarrio, txtRef)
	End Sub

	Private Sub cmbEmpresas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresas.SelectedIndexChanged
		comprobarYLlenarEmpre(txtNombre, txtIdSector, txtBarrio, txtRef, cmbEmpresas)

		If cmbEmpresas.Text <> "Ninguno" Then
			txtTelefono.ReadOnly = True
		End If
		If cmbEmpresas.Text = "Ninguno" Then
			txtTelefono.ReadOnly = False
			limpiar(Me)
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConsultarR.Click
		comprobarYLlenarTel(txtTelefonoR, txtNombreR, txtIdSectorR, txtBarrioR, txtRefR)
	End Sub

	Private Sub cmbEmpresasR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpresasR.SelectedIndexChanged
		comprobarYLlenarEmpre(txtNombreR, txtIdSectorR, txtBarrioR, txtRefR, cmbEmpresasR)

		If cmbEmpresasR.Text <> "Ninguno" Then
			txtTelefonoR.ReadOnly = True
		End If
		If cmbEmpresasR.Text = "Ninguno" Then
			txtTelefonoR.ReadOnly = False
			limpiar(Me)
		End If
	End Sub

	Sub comprobarYLlenarTel(ByVal txt0 As TextBox, ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox)
		Dim resultado As Integer


		resultado = comprobarExistenciaTelefono(txt0.Text)

		If resultado = 1 Then
			llenarTextBox(txt1, "select nombres from ENTIDADES where telefono = '" & txt0.Text & "' ", "nombres")
			llenarTextBox(txt2, "select idSector from ENTIDADES where telefono = '" & txt0.Text & "' ", "idSector")
			llenarTextBox(txt3, "select barrio from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where telefono = '" & txt0.Text & "' ", "barrio")
			llenarTextBox(txt4, "select referenciasDireccion from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where telefono = '" & txt0.Text & "' ", "referenciasDireccion")

		ElseIf resultado = 2 Then
			MsgBox("tellevoelrio")

		End If
	End Sub

	Sub comprobarYLlenarEmpre(ByVal txt1 As TextBox, ByVal txt2 As TextBox, ByVal txt3 As TextBox, ByVal txt4 As TextBox, cmb As ComboBox)
		llenarTextBox(txt1, "select nombres from ENTIDADES where nombres = '" & cmb.Text & "' ", "nombres")
		llenarTextBox(txt2, "select idSector from ENTIDADES where nombres = '" & cmb.Text & "' ", "idSector")
		llenarTextBox(txt3, "select barrio from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where nombres = '" & cmb.Text & "' ", "barrio")
		llenarTextBox(txt4, "select referenciasDireccion from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where nombres = '" & cmb.Text & "' ", "referenciasDireccion")
	End Sub

	Private Sub cmbEncargado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEncargado.SelectedIndexChanged
		'llenarTextBox(txtVehiculo, "select  from ", "")
	End Sub

	Private Sub RealizarPedido_Click(sender As Object, e As EventArgs) Handles RealizarPedido.Click
		Dim codigoTrabajador As Integer = obtenerVariableEntera("select idTrabajador from PERSONAL p inner join ENTIDADES e on p.telefonoTrabajador = e.telefono where nombres = '" & cmbEncargado.Text & "' ", "idTrabajador")
		Dim codigoMandado As Integer = obtenerVariableEntera("select idMandado from MANDADOS where detalle = '" & cmbTipoEnvio.Text & "'", "idMandado")
		MsgBox(codigoMandado)
		If cmbEmpresas.Enabled = True Then
			txtTelefono.Text = obtenerVariableCadena("select telefono from ENTIDADES where nombres = '" & cmbEmpresas.Text & "' ", "telefono")
		End If

		If cmbEmpresasR.Enabled = True Then
			txtTelefonoR.Text = obtenerVariableCadena("select telefono from ENTIDADES where nombres = '" & cmbEmpresasR.Text & "' ", "telefono")
		End If

		Dim precioPagar As Double
		Dim valorKM1 As Double = obtenerVariableDecimal("select distancia from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where e.Telefono = '" & txtTelefono.Text & "'", "distancia")
		Dim valorKM2 As Double = obtenerVariableDecimal("select distancia from DIRECCIONES d inner join ENTIDADES e on d.idSector = e.idSector where e.Telefono = '" & txtTelefonoR.Text & "'", "distancia")
		Dim calculo As Double = valorKM1 + valorKM2
		If calculo >= 1 And calculo <= 3 Then
			precioPagar = 15.0
		End If
		If calculo >= 3.1 And calculo <= 5 Then
			precioPagar = 25.0
		End If
		If calculo >= 5.1 Then
			precioPagar = 45.0
		End If

		Dim sumador As Integer = obtenerVariableEntera("select frecuencia from ENTIDADES where telefono = '" & txtTelefonoR.Text & "' ", "frecuencia")
		MsgBox(sumador)

		If MessageBox.Show("El Precio a pagar es Lps. " + precioPagar.ToString + " ¿Desea confirmar pedido? ", "CONSULTA", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

			If insertarPedidoDB(txtTelefono, txtTelefonoR, txtDetalles, codigoMandado, cmbEstadoPaquete, codigoTrabajador, precioPagar) = 0 Then
				EjecutarComando("update PERSONAL set estado = '" & cmbEstadoPersona.Text & "' where idTrabajador = '" & codigoTrabajador & "' ")
				sumador += 1
				EjecutarComando("update ENTIDADES set frecuencia = '" & sumador & "' where telefono = '" & txtTelefonoR.Text & "'")
			Else
				MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
			End If
		Else
			limpiar(Me)

		End If


		txtTelefono.Clear()
		txtTelefonoR.Clear()

	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Form1.Show()
	End Sub

	Private Sub btnDesplejarHist_Click(sender As Object, e As EventArgs) Handles btnDesplejarHist.Click
		Form3.Show()
	End Sub

	Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged
		If txtTelefono.TextLength > 0 Then
			cmbEmpresas.Enabled = False
		Else
			cmbEmpresas.Enabled = True
		End If
	End Sub

	Private Sub txtTelefonoR_TextChanged(sender As Object, e As EventArgs) Handles txtTelefonoR.TextChanged
		If txtTelefonoR.TextLength > 0 Then
			cmbEmpresasR.Enabled = False
		Else
			cmbEmpresasR.Enabled = True
		End If
	End Sub

	Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

	End Sub
End Class