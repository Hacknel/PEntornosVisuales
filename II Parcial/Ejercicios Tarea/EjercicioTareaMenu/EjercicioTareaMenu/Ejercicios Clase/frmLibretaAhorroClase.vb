Imports System.ComponentModel

Public Class frmLibretaAhorroClase
    'Procedimientos
    Private contador As Integer
    Private contadorDepo As Integer
    Private contadorReti As Integer

    Public clientes(30, 7) As String
    Public historialDepo(30, 25) As String
    Public historialReti(30, 25) As String
    Dim monto As Double

    Private Sub activarControles()
        mtxtIdentidad.Enabled = False
        txtNombre.Enabled = False
        txtApellido.Enabled = False
        cmbPais.Enabled = False
        txtCiudad.Enabled = False
        mtxtEdad.Enabled = False
        txtMonto.Enabled = False
        cmbInteres.Enabled = False
        btnAperturar.Enabled = False
        btnDepositar.Enabled = True
        btnRetirar.Enabled = True
    End Sub

    Private Sub desactivarControles()
        mtxtIdentidad.Enabled = True
        txtNombre.Enabled = True
        txtApellido.Enabled = True
        cmbPais.Enabled = True
        txtCiudad.Enabled = True
        mtxtEdad.Enabled = True
        txtMonto.Enabled = True
        cmbInteres.Enabled = True
        btnAperturar.Enabled = True
        btnDepositar.Enabled = False
        btnRetirar.Enabled = False
    End Sub

    Private Sub limpiar()
        desactivarControles()
        txtMonto.Clear()
        txtNombre.Clear()
        txtSaldo.Clear()
        LstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
    End Sub

    Private Sub frmLibretaAhorroClase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivarControles()
    End Sub

    Private Sub btnAperturar_Click(sender As Object, e As EventArgs) Handles btnAperturar.Click

        'Dim identidad, nombre, apellido, pais, edad, monto As String
        If mtxtIdentidad.Text.Length > 0 And mtxtIdentidad.Text.Length <= 15 Then
            clientes(contador, 0) = mtxtIdentidad.Text
            If txtNombre.Text <> String.Empty And txtApellido.Text <> String.Empty And cmbPais.SelectedItem <> String.Empty And mtxtEdad.Text <> String.Empty And txtMonto.Text <> String.Empty And cmbInteres.SelectedItem <> String.Empty And txtCiudad.Text <> String.Empty Then

                If IsNumeric(txtNombre.Text) = False And IsNumeric(txtApellido.Text) = False And IsNumeric(txtCiudad) = False And Val(mtxtEdad.Text) >= 18 Then
                    clientes(contador, 1) = txtNombre.Text
                    clientes(contador, 2) = txtApellido.Text
                    clientes(contador, 3) = cmbPais.SelectedItem
                    clientes(contador, 7) = txtCiudad.Text
                    clientes(contador, 4) = mtxtEdad.Text
                    clientes(contador, 5) = txtMonto.Text
                    clientes(contador, 6) = cmbInteres.Text
                    monto = Val(txtMonto.Text)

                    If monto > 0 Then
                        contadorDepo = 0
                        contadorReti = 0
                        activarControles()
                        cmbInfoAll.Items.Add(mtxtIdentidad.Text)
                        contador += 1
                    Else
                        MessageBox.Show("Ingrese un monto mayor a 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Else
                    MessageBox.Show("Ingrese valores correctos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Else
                MessageBox.Show("Ingrese los campos necesarios!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Ingrese un numero de identidad valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub mostrarSaldo()
        txtSaldo.Text = monto
    End Sub

    Private Function leer(mensaje As String)
        Dim cantidad As Double
        Dim tempo As String
        Try
            tempo = InputBox("Ingrese el monto a " & mensaje, "Operacion")
            If IsNumeric(tempo) = True And tempo <> String.Empty Then
                cantidad = Val(tempo)
            Else
                MessageBox.Show("Ingrese Valores Correctos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            mostrarSaldo()

            Return cantidad
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub btnDepositar_Click(sender As Object, e As EventArgs) Handles btnDepositar.Click
        Dim deposito As Double = leer("Depositar")
        monto += deposito
        clientes(contador - 1, 5) = monto
        historialDepo(contador - 1, contadorDepo) = deposito
        LstDepositos.Items.Add(deposito)
        mostrarSaldo()
        contadorDepo += 1
    End Sub

    Private Sub btnRetirar_Click(sender As Object, e As EventArgs) Handles btnRetirar.Click
        Dim retiro As Double
        retiro = leer("Retirar")
        If retiro > monto Then
            MessageBox.Show("Saldo Insuficiente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            monto -= retiro
            clientes(contador - 1, 5) = monto
            historialReti(contador - 1, contadorReti) = retiro
            lstRetiros.Items.Add(retiro)
            mostrarSaldo()
            contadorReti += 1
        End If

    End Sub

    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        For Each control As Control In ingresoInfo.Controls
            If TypeOf control Is TextBox Or TypeOf control Is MaskedTextBox Or TypeOf control Is ComboBox Then
                control.Text = String.Empty
            End If
        Next
        lstRetiros.Items.Clear()
        LstDepositos.Items.Clear()
        desactivarControles()
    End Sub

    Private Sub cmbInfoAll_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbInfoAll.SelectedIndexChanged
        LstDepositos.Items.Clear()
        lstRetiros.Items.Clear()
        Dim j As Integer
        Dim k As Integer

        For i = 0 To 30 Step 1
            If cmbInfoAll.SelectedItem = clientes(i, 0) Then
                mtxtIdentidad.Text = clientes(i, 0)
                txtNombre.Text = clientes(i, 1)
                txtApellido.Text = clientes(i, 2)
                cmbPais.Text = clientes(i, 3)
                mtxtEdad.Text = clientes(i, 4)
                txtMonto.Text = clientes(i, 5)
                cmbInteres.Text = clientes(i, 6)
                txtCiudad.Text = clientes(i, 7)

                Do While historialDepo(i, j) <> ""
                    LstDepositos.Items.Add(historialDepo(i, j))
                    j += 1
                Loop

                Do While historialReti(i, k) <> ""
                    lstRetiros.Items.Add(historialReti(i, k))
                    k += 1
                Loop

            End If
        Next
    End Sub

    Private Sub mtxtIdentidad_MouseHover(sender As Object, e As EventArgs) Handles mtxtIdentidad.MouseHover
        ToolTipHoo.SetToolTip(mtxtIdentidad, "Ingrese su numero de Identdad")
        ToolTipHoo.ToolTipTitle = "ID"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtNombre_MouseHover(sender As Object, e As EventArgs) Handles txtNombre.MouseHover
        ToolTipHoo.SetToolTip(txtNombre, "Ingrese su nombre sin numeros")
        ToolTipHoo.ToolTipTitle = "NOMBRE"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtApellido_MouseHover(sender As Object, e As EventArgs) Handles txtApellido.MouseHover
        ToolTipHoo.SetToolTip(txtNombre, "Ingrese su Apellido sin numeros")
        ToolTipHoo.ToolTipTitle = "APELLIDO"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mtxtEdad_MouseHover(sender As Object, e As EventArgs) Handles mtxtEdad.MouseHover
        ToolTipHoo.SetToolTip(mtxtEdad, "Ingrese su edad en años")
        ToolTipHoo.ToolTipTitle = "AÑOS"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtCiudad_MouseHover(sender As Object, e As EventArgs) Handles txtCiudad.MouseHover
        ToolTipHoo.SetToolTip(txtCiudad, "Ingrese su ciudad de residencia")
        ToolTipHoo.ToolTipTitle = "CIUDAD"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMonto_MouseHover(sender As Object, e As EventArgs) Handles txtMonto.MouseHover
        ToolTipHoo.SetToolTip(txtMonto, "Ingrese su valor de ingreso")
        ToolTipHoo.ToolTipTitle = "DEPOSITO INICIAL"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbInfoAll_MouseHover(sender As Object, e As EventArgs) Handles cmbInfoAll.MouseHover
        ToolTipHoo.SetToolTip(cmbInfoAll, "Seleccione el numero de ID del que desea ver registros")
        ToolTipHoo.ToolTipTitle = "REGISTROS"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbPais_MouseHover(sender As Object, e As EventArgs) Handles cmbPais.MouseHover
        ToolTipHoo.SetToolTip(cmbPais, "Ingrese su pais de residencia")
        ToolTipHoo.ToolTipTitle = "PAIS"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbInteres_MouseHover(sender As Object, e As EventArgs) Handles cmbInteres.MouseHover
        ToolTipHoo.SetToolTip(cmbInteres, "Ingrese tasa de interes anual")
        ToolTipHoo.ToolTipTitle = "INTERES"
        ToolTipHoo.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub errorsText(sender As Object)
        If DirectCast(sender, TextBox).TextLength > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")
        End If
    End Sub

    Private Sub mtxtIdentidad_Validating(sender As Object, e As CancelEventArgs) Handles mtxtIdentidad.Validating
        errorsText(sender)
    End Sub

    Private Sub mtxtEdad_Validating(sender As Object, e As CancelEventArgs) Handles mtxtEdad.Validating
        errorsText(sender)
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        errorsText(sender)
    End Sub

    Private Sub txtCiudad_Validating(sender As Object, e As CancelEventArgs) Handles txtCiudad.Validating
        errorsText(sender)
    End Sub

    Private Sub txtMonto_Validating(sender As Object, e As CancelEventArgs) Handles txtMonto.Validating
        errorsText(sender)
    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        errorsText(sender)
    End Sub

    Private Sub txtSaldo_Validating(sender As Object, e As CancelEventArgs) Handles txtSaldo.Validating
        errorsText(sender)
    End Sub
End Class