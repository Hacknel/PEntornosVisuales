Public Class CalculadoraDescImpu

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chbImpuesto.CheckedChanged
        'Comprobaciones sobre si estan seleccionadas las check box
        'Si esta seleccionada la de impuesto no se puede seleccionar la de descuento
        'Tambien no se puede calcular si no se selecciona una opcion
        If chbImpuesto.Checked = True Then

            comboxImpuest.Enabled = True
            chbDescuento.Enabled = False
            btnCalcular.Enabled = True
        End If

        If chbImpuesto.Checked = False Then
            comboxImpuest.Enabled = False
            chbDescuento.Enabled = True
            btnCalcular.Enabled = False
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        End
    End Sub

    Private Sub chbDescuento_CheckedChanged(sender As Object, e As EventArgs) Handles chbDescuento.CheckedChanged
        'Comprobaciones sobre si estan seleccionadas las check box
        'Si esta seleccionada la de descuento no se puede seleccionar la de impuesto
        'Tambien no se puede calcular si no se selecciona una opcion
        If chbDescuento.Checked = True Then

            comboxDesc.Enabled = True
            chbImpuesto.Enabled = False
            btnCalcular.Enabled = True
        End If

        If chbDescuento.Checked = False Then
            comboxDesc.Enabled = False
            chbImpuesto.Enabled = True
            btnCalcular.Enabled = False
        End If

    End Sub

    Private Sub comboxDesc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxDesc.SelectedIndexChanged

    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click

        'Declaracion de variables
        Dim PrecioUnitario As Double = Val(txtPUnitario.Text)
        Dim Cantidad As Double = Val(txtCantidad.Text)

        Dim SubTotal As Double
        Dim Descuento As Double
        Dim ISV As Double = 0
        Dim Total As Double = 0

        'Comprueba si la informacion ingresada en los campos es correcta
        'Comprueba que no este vacio
        If (txtPUnitario.Text = "") Or (txtCantidad.Text = "") Then
            MsgBox("Ingrese un Valor!", vbInformation)

            'comprueba que sean numeros
        ElseIf Not IsNumeric(txtPUnitario.Text) Or Not IsNumeric(txtCantidad.Text) Then
            MsgBox("Ingrese un valor numerico!", vbInformation)

            'comprueba que sean positivos
        ElseIf txtPUnitario.Text < 0 And txtCantidad.Text < 0 Then
            MsgBox("Ingrese Valores Positivos!", vbInformation)

            'Comprueba que se haya seleccionado la casilla correcta
        ElseIf chbDescuento.Checked = True Then
            'calculo del subtotal
            SubTotal = PrecioUnitario * Cantidad

            'Verficaciones y selector para el Combo Box
            If comboxDesc.SelectedItem = "DESCUENTO POR TERCERA EDAD (25%)" Then
                Descuento = SubTotal * 0.25


            ElseIf comboxDesc.SelectedItem = "DESCUENTO POR TEMPORADA (10%)" Then
                Descuento = SubTotal * 0.1


            ElseIf comboxDesc.SelectedItem = "DESCUENTO POR PAGO PRONTO (5%)" Then
                Descuento = SubTotal * 0.05


            ElseIf comboxDesc.SelectedItem = "DESCUENTO POR MEMBRESIA (12%)" Then
                Descuento = SubTotal * 0.12


            ElseIf comboxDesc.SelectedItem = "DESCUENTO POR LIQUIDACION (15%)" Then
                Descuento = SubTotal * 0.15


            ElseIf comboxDesc.SelectedItem = "DESCUENTO POR FIN DEL MUNDO (100%)" Then
                Descuento = SubTotal * 1

            Else
                MsgBox("Ha introducido un valor incorrecto!", vbInformation)

            End If

            '<> para que cuando se ingresen valores incorrectos no imprima
            If Descuento <> 0 Then

                Total = SubTotal - Descuento

                txtSubTotal.Text = SubTotal
                txtDesc.Text = Descuento
                txtISV.Text = "NO APLICA"
                txtTotal.Text = Total

            End If

            'Comprobacion y calculos para ISV
        Else
            SubTotal = PrecioUnitario * Cantidad

            If comboxImpuest.SelectedItem = "IMPUESTO SOBRE LA VENTA (15%)" Then
                ISV = SubTotal * 0.15

            ElseIf comboxImpuest.SelectedItem = "IMPUESTO SOBRE LA VENTA (17%)" Then
                ISV = SubTotal * 0.17

            Else
                MsgBox("Ha introducido un valor incorrecto!", vbInformation)
            End If

            If ISV <> 0 Then

                Total = SubTotal + ISV

                txtSubTotal.Text = SubTotal
                txtDesc.Text = "NO APLICA"
                txtISV.Text = ISV
                txtTotal.Text = Total

            End If
        End If

        'Reinicio del Combo box
        comboxDesc.Text = "SELECCIONE UN DESCUENTO"
        comboxImpuest.Text = "SELECCIONE UN IMPUESTO"
        'Se habilita el boton nuevo, solo despues de haber utilizado una vez la calculardora
        btnNuevo.Enabled = True

    End Sub

    Private Sub comboxDescuento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Esto es al inicio de la ejecucion, todos los botones estan desabilitados
        comboxDesc.Enabled = False
        comboxImpuest.Enabled = False

        btnCalcular.Enabled = False
        btnNuevo.Enabled = False

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click

        'Invesigacion'
        'Estructura que limpia todos los textBox del programa
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = String.Empty
            End If
        Next

        'Se deshabilitan los checkbox para la nueva ejecucion
        chbDescuento.Checked = False
        chbImpuesto.Checked = False

    End Sub
End Class
