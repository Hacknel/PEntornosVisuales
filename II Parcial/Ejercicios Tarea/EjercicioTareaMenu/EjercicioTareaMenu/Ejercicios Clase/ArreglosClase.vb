Public Class ArreglosClase
    Private mComputadoras(,) As String
    Private cantComputadoras As Integer
    Private index As Byte
    Private encuentra As Boolean
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim computadoras(3) As String
        Dim cantCompu As Integer
        ReDim computadoras(cantCompu)

        computadoras(0) = "Toshiba"
        computadoras(1) = "DELL"
        computadoras(2) = "ASUS"
        computadoras(3) = "MAC"

        For i = 0 To computadoras.Length - 1 Step 1
            CmbComputadoras.Items.Add(computadoras(i))
        Next

    End Sub

    Private Sub btnPrecio_Click(sender As Object, e As EventArgs) Handles btnPrecio.Click
        Dim precio(3) As Integer
        precio(0) = 22500
        precio(1) = 2100
        precio(2) = 29000
        precio(3) = 42000

        For i = 0 To precio.Length - 1 Step 1
            cmbPrecios.Items.Add(precio(i))
        Next

    End Sub

    Private Sub btnSolicitarMul_Click(sender As Object, e As EventArgs) Handles btnSolicitarMul.Click
        Dim cant As Integer
        Dim comp() As String
        cant = Val(cmbMostarCompMult.Text)
        ReDim comp(cant)

        For i = 0 To cant Step 1
            comp(i) = InputBox("Ingrese Marca de PC", "Ingreso")
        Next

        For j = 0 To cant Step 1
            cmbMostarCompMult.Items.Add(comp(j))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CmbComputadoras.Items.Clear()
        txtCant.Clear()
    End Sub

    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        cantComputadoras = Val(txtCantIngresar.Text)
        ReDim mComputadoras(cantComputadoras, 3)
        '3X3 COMIENZA A CONTAR DESDE 0 
        For i = 0 To (cantComputadoras - 1) Step 1
            mComputadoras(i, 0) = InputBox("Ingrese la marca N" & (i + 1), "Registro")
            mComputadoras(i, 1) = InputBox("Ingrese el modelo N" & (i + 1), "Registro")
            mComputadoras(i, 2) = InputBox("Ingrese el precio N" & (i + 1), "Registro")
            mComputadoras(i, 3) = InputBox("Ingrese la cantidad N" & (i + 1), "Registro")

        Next
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim marca As String = txtMarca.Text

        If txtMarca.Text <> String.Empty Then

            For i = 0 To cantComputadoras - 1 Step 1
                If mComputadoras(i, 0) = marca Then
                    txtMOdelo.Text = mComputadoras(i, 1)
                    txtPrecio.Text = mComputadoras(i, 2)
                    txtCantCon.Text = mComputadoras(i, 3)
                    encuentra = True

                End If
            Next
            If encuentra = False Then
                MessageBox.Show("No existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MsgBox("Ingrese Valores")
        End If

    End Sub

    Private Sub ArreglosClase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtMOdelo.Enabled = False
        txtPrecio.Enabled = False
        txtCantCon.Enabled = False
    End Sub

    Private Sub btnVender_Click(sender As Object, e As EventArgs) Handles btnVender.Click
        Dim cantVender, stock As Integer
        cantVender = Val(txtVender.text)
        stock = mComputadoras(index, 3)
        If cantVender >= stock Then
            MessageBox.Show("Sin Stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            mComputadoras(index, 3) = stock - cantVender
            MessageBox.Show("Venta realizada correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtCantCon.Text = mComputadoras(index, 3)
        End If
    End Sub
End Class