Imports DB
Public Class FrmNvoRol

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim obj As New Class_Rol
        Dim lngresultado As Long

        If txbNombre.Text = "" Then
            MessageBox.Show("Ingrese Datos al campo")
            txbNombre.Focus()
        Else
            lngresultado = obj.Ingreso_Rol(txbNombre.Text, txbDescripcion.Text)
        End If


        If lngresultado = 1 Then
            MessageBox.Show("Ingresado Exitosamente")
            Dim a As Control
            For Each a In Me.GroupBoxNvoRol.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next

            Dim db As New ProyectoEntities
            ListBox3.ValueMember = "id_rol"
            ListBox3.DisplayMember = "Nombre"
            ListBox3.DataSource = db.Rol.ToList()

        ElseIf lngresultado = -1 Then
        MessageBox.Show("Error al agregar Rol")
        End If

    End Sub
    Private Sub FrmNvoRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.WindowState = FormWindowState.Maximized
        Dim db As New ProyectoEntities
        ListBox3.DataSource = db.Rol.ToList()
        ListBox3.ValueMember = "id_rol"
        ListBox3.DisplayMember = "Nombre"

    End Sub
    Private Sub TabControl1_Selecting(ByVal sender As Object, ByVal e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Dim db As New ProyectoEntities
        If Me.TabControl1.SelectedIndex = 0 Then
            ListBox3.ValueMember = "id_rol"
            ListBox3.DisplayMember = "Nombre"
            ListBox3.DataSource = DB.Rol.ToList()
        End If
        If Me.TabControl1.SelectedIndex = 1 Then
            ListBox2.ValueMember = "id_rol"
            ListBox2.DisplayMember = "Nombre"
            ListBox2.DataSource = db.Rol.ToList()
            Dim a As Control
            For Each a In Me.GroupBox1.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next
        End If

        If Me.TabControl1.SelectedIndex = 2 Then            
            ListBox1.DataSource = db.Rol.ToList()
            ListBox1.ValueMember = "id_rol"
            ListBox1.DisplayMember = "Nombre"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim id_rol, resultado As Long
        Dim obj As New Class_Rol
        Dim db As New ProyectoEntities

        Dim Message As String = "Esta Seguro de Eliminar un Rol"
        Dim Caption As String = "Confirmar"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            id_rol = ListBox1.SelectedValue
            resultado = obj.Eliminar_rol(id_rol)
            ListBox1.DataSource = db.Rol.ToList()
            ListBox1.ValueMember = "id_rol"
            ListBox1.DisplayMember = "Nombre"
            If resultado = -1 Then
                MessageBox.Show("Es posible que este rol este asignado a un usuario !!!")
            End If
        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Dim db As New ProyectoEntities
        ListBox1.DataSource = db.Rol.ToList()
        ListBox1.ValueMember = "id_rol"
        ListBox1.DisplayMember = "Nombre"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Dim db As New ProyectoEntities
        Dim item_Per As New Rol
        Dim id_rol As Long

        txbDescripcionEditar.Enabled = True
        txbNombreEditar.Enabled = True
        id_rol = ListBox2.SelectedValue

        If id_rol = Nothing Then
            MessageBox.Show("no a seleccionado ")
        Else
            item_Per = db.Rol.First(Function(x) x.id_rol = id_rol)
            txbDescripcionEditar.Text = item_Per.descripcion
            txbNombreEditar.Text = item_Per.nombre
            btnActualizarEditar.Enabled = True
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnActualizarEditar.Click
        Dim db As New ProyectoEntities
        Dim obj As New Class_Rol
        Dim id_rol, lngresult As Long

        id_rol = ListBox2.SelectedValue
        If txbNombreEditar.Text = "" Then
            MessageBox.Show("Ingrese un dato Valido")
            txbNombreEditar.Focus()
        Else
            lngresult = obj.Actualizar_Rol(txbNombreEditar.Text, txbDescripcionEditar.Text, id_rol)
            If lngresult = 1 Then
                MessageBox.Show("exitoso")
                Dim a As Control
                For Each a In Me.GroupBox1.Controls
                    If TypeOf a Is TextBox Then
                        a.Text = Nothing
                        a.Enabled = False
                    End If
                Next
                btnActualizarEditar.Enabled = False

                ListBox2.ValueMember = "id_rol"
                ListBox2.DisplayMember = "Nombre"
                ListBox2.DataSource = db.Rol.ToList()

            ElseIf lngresult = -1 Then
                MessageBox.Show("error")
            End If
        End If




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Control
        For Each a In Me.GroupBoxNvoRol.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged

    End Sub

Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

End Sub

Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()

End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

End Sub
End Class