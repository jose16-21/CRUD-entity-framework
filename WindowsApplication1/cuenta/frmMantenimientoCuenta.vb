Imports DB
Public Class frmMantenimientoCuenta
    
    Private Sub frmMantenimientoCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New proyectoEntities
        Dim obj As New Class_Cuenta
        ListBox1.DataSource = DB.Cuenta.ToList()
        ListBox1.ValueMember = "Numero"
        ListBox1.DisplayMember = "nombre"
        cmbTipoCuenta.DataSource = db.tipo_cuenta.ToList()
        cmbTipoCuenta.ValueMember = "id_tipo_cuenta"
        cmbTipoCuenta.DisplayMember = "nombre"
    End Sub
    Private Sub TabControl1_Selecting(ByVal sender As Object, ByVal e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Dim db As New proyectoEntities
        Dim obj As New Class_Cuenta
        If Me.TabControl1.SelectedIndex = 0 Then
            ListBox1.DataSource = db.Cuenta.ToList()
            ListBox1.ValueMember = "Numero"
            ListBox1.DisplayMember = "nombre"
            cmbTipoCuenta.DataSource = db.tipo_cuenta.ToList()
            cmbTipoCuenta.ValueMember = "id_tipo_cuenta"
            cmbTipoCuenta.DisplayMember = "nombre"
        End If
        If Me.TabControl1.SelectedIndex = 1 Then
            cmbTipoCuenta.DataSource = db.tipo_cuenta.ToList()
            cmbTipoCuenta.ValueMember = "id_tipo_cuenta"
            cmbTipoCuenta.DisplayMember = "nombre"
            lsbMostrarEditarCuenta.DataSource = db.Cuenta.ToList()
            lsbMostrarEditarCuenta.ValueMember = "Numero"
            lsbMostrarEditarCuenta.DisplayMember = "nombre"
            Dim a As Control
            For Each a In Me.GroupBox1.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next

        End If

        If Me.TabControl1.SelectedIndex = 2 Then

            lstbEliminar.DataSource = db.Cuenta.ToList()
            lstbEliminar.ValueMember = "Numero"
            lstbEliminar.DisplayMember = "nombre"

        End If
        If Me.TabControl1.SelectedIndex = 3 Then
            DataGridView1.DataSource = db.ListaCuentas.ToList()
        End If
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim lng As Long
        Dim db As New proyectoEntities
        Dim obj As New Class_Cuenta
        If txbNombreCuenta.Text = "" Then
            MessageBox.Show("Ingrese Datos ")
            txbNombreCuenta.Focus()
        ElseIf txbNumeroCuenta.Text = "" Then
            MessageBox.Show("Ingrese Datos ")
            txbNumeroCuenta.Focus()
        Else
            lng = obj.Ingreso_Cuenta(txbNombreCuenta.Text, txbNumeroCuenta.Text, cmbTipoCuenta.SelectedValue())
        End If

        If lng = 1 Then
            MessageBox.Show("Guardado Exitosamente", "", MessageBoxButtons.OK)
            Dim a As Control
            For Each a In Me.GroupBox1.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next
            ListBox1.DataSource = db.Cuenta.ToList()
            ListBox1.ValueMember = ""
            ListBox1.DisplayMember = "nombre"
        ElseIf lng = -1 Then
            MessageBox.Show("Error")
        End If
    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim item_Per As New Cuenta
        Dim db As New proyectoEntities
        Dim obj As New Class_Cuenta

        Dim id_cuenta As Long

        id_cuenta = lsbMostrarEditarCuenta.SelectedValue
        If id_cuenta = Nothing Then
            MessageBox.Show("no a seleccionado ")
        Else

            item_Per = db.Cuenta.First(Function(x) x.Numero = id_cuenta)

            txbNombreEditar.Text = item_Per.Nombre
            txbNumeroEditar.Text = item_Per.Numero
        End If

        txbNombreEditar.Enabled = True
        txbNumeroEditar.Enabled = True
        btnActualizarEditar.Enabled = True

        cmbEditarTipo.Enabled = True
        cmbEditarTipo.DataSource = db.tipo_cuenta.ToList()
        cmbEditarTipo.ValueMember = "id_tipo_cuenta"
        cmbEditarTipo.DisplayMember = "nombre"
    End Sub

    Private Sub btnActualizarEditar_Click(sender As Object, e As EventArgs) Handles btnActualizarEditar.Click
        Dim db As New proyectoEntities
        Dim obj As New Class_Cuenta
        Dim lngResultado As Long
        lngResultado = obj.Actualizar_Cuenta(txbNombreEditar.Text, txbNumeroEditar.Text, cmbEditarTipo.SelectedValue, lsbMostrarEditarCuenta.SelectedValue())
        If lngResultado = 1 Then

            btnActualizarEditar.Enabled = False
            cmbEditarTipo.Enabled = False

            lsbMostrarEditarCuenta.DataSource = db.Cuenta.ToList()
            lsbMostrarEditarCuenta.ValueMember = "Numero"
            lsbMostrarEditarCuenta.DisplayMember = "nombre"
            MessageBox.Show("Modificado Exitosamente", "", MessageBoxButtons.OK)
            For Each a In Me.GroupBox3.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                    a.enabled = False
                End If
            Next



        ElseIf lngResultado = -1 Then
            MessageBox.Show("error")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim lngResult As New Long
        Dim db As New proyectoEntities
        Dim obj As New Class_Cuenta
        Dim Message As String = "Esta Seguro de Eliminar "
        Dim Caption As String = "Confirmar"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            lngResult = obj.eliminar_cuenta(lstbEliminar.SelectedValue)
            If lngResult = 1 Then
                lstbEliminar.DataSource = db.Cuenta.ToList()
                lstbEliminar.ValueMember = "Numero"
                lstbEliminar.DisplayMember = "nombre"

            ElseIf lngResult = -1 Then
                MessageBox.Show("error")
            End If

        End If

    End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

End Sub
End Class