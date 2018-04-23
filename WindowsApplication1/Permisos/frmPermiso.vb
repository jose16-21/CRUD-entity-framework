Imports DB
Public Class frmPermiso
    Dim db As New ProyectoEntities
    Dim obj As New Class_permisos
    Private Sub frmPermiso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        ListBox1.DataSource = db.Rol.ToList()
        ListBox1.DisplayMember = "nombre"
        ListBox1.ValueMember = "id_rol"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id_item_asignado, id_item_rol, lngResultado As Long
        id_item_asignado = ListBox3.SelectedValue
        id_item_rol = ListBox1.SelectedValue
        lngResultado = obj.Eliminar_permiso(id_item_asignado, id_item_rol)
        If lngResultado = 1 Then
            LlenaAsignados()
            llenarPermisos()
        End If
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.Click
        llenarPermisos()
        LlenaAsignados()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.Click
        Dim id_item_rol, id_item_permiso, lngResultado As Long
        id_item_rol = ListBox1.SelectedValue
        id_item_permiso = ListBox2.SelectedValue
        lngResultado = obj.ingreso_permisos(id_item_rol, id_item_permiso)
        If lngResultado = 1 Then
            LlenaAsignados()
            llenarPermisos()
        End If
    End Sub
    Public Function LlenaAsignados() As Long
        Try
            Dim id_rol As Long
            id_rol = ListBox1.SelectedValue
            Dim lista = New List(Of permiso)
            lista = db.permiso_asignado.Include("Permiso").Where(Function(x) x.fk_rol = id_rol).Select(Function(x) x.permiso).ToList()
            ListBox3.DataSource = lista
            ListBox3.DisplayMember = "nombre"
            ListBox3.ValueMember = "id_permiso"
            LlenaAsignados = 1
        Catch ex As Exception
            LlenaAsignados = -1
        End Try
    End Function
    Public Function llenarPermisos()
        Try
            Dim valor As Long
            valor = ListBox1.SelectedValue
            Dim per = New List(Of permiso)
            per = db.permiso.Where(Function(x) x.permiso_asignado.Where(Function(y) y.fk_rol = valor).Count() < 1).ToList()
            ListBox2.DataSource = per
            ListBox2.ValueMember = "id_permiso"
            ListBox2.DisplayMember = "nombre"
            llenarPermisos = 1
        Catch ex As Exception
            llenarPermisos = -1
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id_item, lngResultado As Long
        id_item = ListBox1.SelectedValue
        lngResultado = obj.Eliminar_permisos(id_item)
        If lngResultado = 1 Then
            LlenaAsignados()
            llenarPermisos()
        End If
    End Sub

    Private Sub ListBoxRol_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

End Sub
End Class