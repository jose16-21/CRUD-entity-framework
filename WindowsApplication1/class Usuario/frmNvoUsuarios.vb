Imports DB

Public Class frmNvoUsuarios

    Private Sub frmNvoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Dim db As New proyectoEntities
        Dim list As List(Of Usuario)
        list = db.Usuario.ToList()
        ListBox1.DataSource = list
        ListBox1.ValueMember = "id_usuario"
        ListBox1.DisplayMember = "nombre"

        cbxRolAgregar.DataSource = db.Rol.ToList()
        cbxRolAgregar.ValueMember = "id_rol"
        cbxRolAgregar.DisplayMember = "nombre"        
        
    End Sub

    Private Sub TabControl1_Selecting(ByVal sender As Object, ByVal e As TabControlCancelEventArgs) Handles TabControl1.Selecting
        Dim db As New ProyectoEntities

        If Me.TabControl1.SelectedIndex = 0 Then

            ListBox1.DataSource = db.Usuario.ToList()
            ListBox1.ValueMember = "id_usuario"
            ListBox1.DisplayMember = "nombre"

            cbxRolAgregar.DataSource = db.Rol.ToList()
            cbxRolAgregar.ValueMember = "id_rol"
            cbxRolAgregar.DisplayMember = "nombre"

        End If

        If Me.TabControl1.SelectedIndex = 1 Then

            lstbMostrarEditar.DataSource = db.Usuario.ToList()
            lstbMostrarEditar.ValueMember = "id_usuario"
            lstbMostrarEditar.DisplayMember = "nombre"

        End If

        If Me.TabControl1.SelectedIndex = 2 Then

            lbxmostraEliminar.DataSource = db.Usuario.ToList()
            lbxmostraEliminar.ValueMember = "id_usuario"
            lbxmostraEliminar.DisplayMember = "nombre"

        End If
        If Me.TabControl1.SelectedIndex = 3 Then
            Me.DataGridView1.DataSource = db.listadoUsr.ToList()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptarAgregar.Click
        Dim db As New ProyectoEntities
        If txbContraseñaAgregar.Text = txbConfirmarAgregar.Text Then
            Dim obj As New Class_Usuario
            Dim item_id, lngResultado As Long
            item_id = cbxRolAgregar.SelectedValue
            If txbUsuariAgregar.Text = "" And txbContraseñaAgregar.Text = "" Then
                MessageBox.Show("ingrese datos ")
            Else
                lngResultado = obj.Ingreso_Usuario(txbUsuariAgregar.Text, txbContraseñaAgregar.Text, item_id)
            End If

            If lngResultado = 1 Then

                MessageBox.Show("Ingresado", "Exitoso", MessageBoxButtons.OK)
                Dim a As Control
                For Each a In Me.GroupBox1.Controls
                    If TypeOf a Is TextBox Then
                        a.Text = Nothing
                    End If
                Next
                ListBox1.DataSource = db.Usuario.ToList()
                ListBox1.ValueMember = "id_usuario"
                ListBox1.DisplayMember = "nombre"

            ElseIf lngResultado = -1 Then
            End If

        Else
            MessageBox.Show("Las contraseñas son diferentes")
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnModificarEditar.Click

        Dim item_id As Long
        Dim db As New ProyectoEntities
        Dim item As Usuario
        item_id = lstbMostrarEditar.SelectedValue
        If item_id = Nothing Then
            MessageBox.Show("no a seleccionado")
        Else
            item = db.Usuario.First(Function(x) x.id_usuario = item_id)
            txbUsuarioEditar.Text = item.nombre
            cbxRolEditar.DataSource = db.Rol.ToList()
            cbxRolEditar.ValueMember = "id_rol"
            cbxRolEditar.DisplayMember = "nombre"

            cbxRolEditar.Enabled = True
            txbUsuarioEditar.Enabled = True
            txbContraseñaEditar.Enabled = True
            txbConfirmarEditar.Enabled = True
            BtnGuardarEditar.Enabled = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnGuardarEditar.Click
        Dim db As New ProyectoEntities
        Dim obj As New Class_Usuario
        Dim lng As Long
        If txbUsuarioEditar.Text = "" Then
            MessageBox.Show("Ingresar datos")
            txbUsuarioEditar.Focus()
        ElseIf txbContraseñaEditar.Text = "" Or txbConfirmarEditar.Text = "" Then
            MessageBox.Show("Ingrese datos")

        Else
            lng = obj.Actualizar_Usuario(txbUsuarioEditar.Text, txbContraseñaEditar.Text, 1, cbxRolEditar.SelectedValue, lstbMostrarEditar.SelectedValue)
        End If

        If lng = 1 Then
            MessageBox.Show("exitoso")
            For Each a In Me.GroupBox2.Controls
                If TypeOf a Is TextBox Then
                    a.Text = Nothing
                    a.Enabled = False
                End If
            Next
            BtnGuardarEditar.Enabled = False
            lstbMostrarEditar.DataSource = db.Usuario.ToList()
            lstbMostrarEditar.ValueMember = "id_usuario"
            lstbMostrarEditar.DisplayMember = "nombre"
        ElseIf lng = -1 Then
            MessageBox.Show("error")
        End If
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnEliminarEliminar.Click

        Dim id_rol, resultado As Long
        Dim obj As New Class_Usuario
        Dim db As New ProyectoEntities


        Dim Message As String = "Esta Seguro de Eliminar un Rol"
        Dim Caption As String = "Confirmar"
        Dim Buttons As Integer = MessageBoxButtons.YesNo
        Dim Result As DialogResult
        Result = MessageBox.Show(Me, Message, Caption, MessageBoxButtons.YesNo, _
            MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)

        If Result = System.Windows.Forms.DialogResult.Yes Then

            id_rol = lbxmostraEliminar.SelectedValue
            resultado = obj.Eliminar_usuario(id_rol)
            lbxmostraEliminar.DataSource = db.Usuario.ToList()
            lbxmostraEliminar.ValueMember = "id_usuario"
            lbxmostraEliminar.DisplayMember = "Nombre"
            If resultado = -1 Then
                MessageBox.Show("Es posible que este rol este asignado a un usuario !!!")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Control
        For Each a In Me.GroupBox1.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next
    End Sub

Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

End Sub

Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

End Sub

Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()

End Sub
End Class