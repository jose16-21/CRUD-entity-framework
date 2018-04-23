Imports DB
'2	Personas
'3	Roles

'7	Bitacora de Archivos
Public Class MenuPrincipal
    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Label1.Text = My.User.Name
    End Sub
    Private Sub MantenimientoDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeUsuariosToolStripMenuItem.Click
        'If permisos(1) = True Then
        Dim NewMDIChild As New frmNvoUsuarios()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        'Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If
    End Sub
    Private Sub MantenimientoDeRolesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeRolesToolStripMenuItem.Click
        '  If permisos(3) = True Then
        Dim NewMDIChild As New FrmNvoRol()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        ''Else
        ''MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        '' End If
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click

        Dim f2 As New Inicio
        f2.Show()
        Me.Hide()
        FrmTipoConsulta.Close()

    End Sub

    Private Sub MantenimientoDePersonasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDePersonasToolStripMenuItem.Click
        'If permisos(2) Then
        Dim NewMDIChild As New frmNvaPersona()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        'Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If
    End Sub

    Private Sub MantenimientoDePermisosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDePermisosToolStripMenuItem.Click
        'If permisos(4) Then
        Dim NewMDIChild As New frmPermiso()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        'Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If
    End Sub

    Private Function permisos(ByVal lngPermiso As Long) As Boolean
        Dim db As New ProyectoEntities
        Dim item_usuario As New Usuario
        Dim item_permiso As New List(Of permiso_asignado)
        Try
            item_usuario = DB.Usuario.Include("Rol1").Include("Rol1.permiso_asignado").Where(Function(x) x.nombre = My.User.Name).FirstOrDefault()
            If My.User.IsInRole(CStr(item_usuario.rol)) Then
                item_permiso = item_usuario.Rol1.permiso_asignado.ToList()
                For Each a As permiso_asignado In item_permiso
                    If a.fk_permiso = lngPermiso Then
                        permisos = True
                    End If
                Next
            End If
            permisos = permisos
        Catch ex As Exception
            permisos = False
        End Try
    End Function



    Private Sub GeneracionMasivaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneracionMasivaToolStripMenuItem.Click
        'If permisos(5) Then
        FrmTipoConsulta.Show()
        'Dim NewMDIChild As New FrmTipoConsulta()
        'NewMDIChild.MdiParent = Me
        'NewMDIChild.Show()
        'Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If
    End Sub

    Private Sub ConsultaDeEstadoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'If permisos(9) Then
        FrmTipoConsulta.Show()

        'Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If
    End Sub



    Private Sub GestionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionesToolStripMenuItem.Click

    End Sub

    Private Sub MantenimientoDeCuentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoDeCuentasToolStripMenuItem.Click
        'If permisos(6) Then
        Dim NewMDIChild As New frmMantenimientoCuenta()
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        'Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click
        'If permisos(7) Then
        Dim NewMDIChild As New frmArchivo
        NewMDIChild.MdiParent = Me
        NewMDIChild.Show()
        ' Else
        'MessageBox.Show("Actualmente no cuenta con permisos Para acceder", "Alerta", MessageBoxButtons.OK)
        'End If

    End Sub
End Class