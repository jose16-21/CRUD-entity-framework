Imports DB
Public Class frmNvaPersona

    Private Sub frmNvaPersona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New proyectoEntities
        Dim obj As New Class_Persona
        'Me.WindowState = FormWindowState.Maximized
        cmbUsuarioAgregar.DataSource = db.Usuario.Where(Function(x) x.asignado = False).ToList()

        cmbUsuarioAgregar.ValueMember = "id_usuario"
        cmbUsuarioAgregar.DisplayMember = "nombre"
        ListBox1.DataSource = db.persona.ToList()
        ListBox1.ValueMember = "id_persona"
        ListBox1.DisplayMember = "nombres"

    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As Object, ByVal e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Dim db As New proyectoEntities
        Dim obj As New Class_Persona
        If Me.TabControl1.SelectedIndex = 0 Then
            ListBox1.DataSource = db.persona.ToList()
            ListBox1.ValueMember = "id_persona"
            ListBox1.DisplayMember = "nombres"
        End If
        If Me.TabControl1.SelectedIndex = 1 Then
            lsbMostrarEditarPersona.DataSource = db.persona.ToList()
            lsbMostrarEditarPersona.ValueMember = "id_persona"
            lsbMostrarEditarPersona.DisplayMember = "nombres"
            Dim a As Control
            For Each a In Me.GroupBox1.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next

        End If

        If Me.TabControl1.SelectedIndex = 2 Then
            lstbEliminar.DataSource = db.persona.ToList()
            lstbEliminar.ValueMember = "id_persona"
            lstbEliminar.DisplayMember = "nombres"

        End If
        If Me.TabControl1.SelectedIndex = 3 Then
            DataGridView1.DataSource = db.ListaPer.ToList()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim db As New proyectoEntities
        Dim obj As New Class_Persona
        Dim lng As Long
        If txbNombreAgregar.Text = "" Then
            MessageBox.Show("Ingrese Datos ")
            txbNombreAgregar.Focus()
        ElseIf txbApellidoAgregar.Text = "" Then
            MessageBox.Show("Ingrese Datos ")
            txbApellidoAgregar.Focus()
        Else
            lng = obj.Ingreso_Personas(txbNombreAgregar.Text, txbApellidoAgregar.Text, 1, cmbUsuarioAgregar.SelectedValue())
        End If

        If lng = 1 Then
            MessageBox.Show("Guardado Exitosamente", "", MessageBoxButtons.OK)
            Dim a As Control
            For Each a In Me.GroupBox1.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                End If
            Next
            ListBox1.DataSource = db.persona.ToList()
            ListBox1.ValueMember = "id_persona"
            ListBox1.DisplayMember = "nombres,apellidos"
        ElseIf lng = -1 Then
            MessageBox.Show("Error")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Control
        For Each a In Me.GroupBox1.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim item_Per As New persona
        Dim db As New proyectoEntities
        Dim obj As New Class_Persona
        Dim id_rol As Long

        id_rol = lsbMostrarEditarPersona.SelectedValue
        If id_rol = Nothing Then
            MessageBox.Show("no a seleccionado ")
        Else

            item_Per = db.persona.First(Function(x) x.id_persona = id_rol)

            txbNombreEditar.Text = item_Per.nombres
            txbApellidoEditar.Text = item_Per.apellidos
        End If

        txbNombreEditar.Enabled = True
        txbApellidoEditar.Enabled = True
        btnActualizarEditar.Enabled = True

        cmbUsuarioEditar.Enabled = True
        cmbUsuarioEditar.DataSource = db.Usuario.ToList()
        cmbUsuarioEditar.ValueMember = "id_usuario"
        cmbUsuarioEditar.DisplayMember = "nombre"



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnActualizarEditar.Click
        Dim db As New proyectoEntities
        Dim obj As New Class_Persona
        Dim lngResultado As Long
        lngResultado = obj.Actualizar_persona(txbNombreEditar.Text, txbNombreEditar.Text, cmbUsuarioEditar.SelectedValue, lsbMostrarEditarPersona.SelectedValue())
        If lngResultado = 1 Then
            MessageBox.Show("Modificado Exitosamente", "", MessageBoxButtons.OK)
            For Each a In Me.GroupBox3.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                    a.enabled = False
                End If
            Next
            btnActualizarEditar.Enabled = False
            cmbUsuarioEditar.Enabled = False
            lsbMostrarEditarPersona.DataSource = db.persona.ToList()
            lsbMostrarEditarPersona.ValueMember = "id_persona"
            lsbMostrarEditarPersona.DisplayMember = "nombres"
        ElseIf lngResultado = -1 Then
            MessageBox.Show("error")
        End If

    End Sub


    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim db As New proyectoEntities
        Dim obj As New Class_Persona
        Dim lngResult As New Long
        Dim Message As String = "Esta Seguro de Eliminar "
        Dim Caption As String = "Confirmar"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo,
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        If Result = System.Windows.Forms.DialogResult.Yes Then
            lngResult = obj.eliminar_persona(lstbEliminar.SelectedValue)
            If lngResult = 1 Then
                lstbEliminar.DataSource = DB.persona.ToList()
                lstbEliminar.ValueMember = "id_persona"
                lstbEliminar.DisplayMember = "nombres"

            ElseIf lngResult = -1 Then
                MessageBox.Show("error")
            End If

        End If

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

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