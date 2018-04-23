Imports DB
Public Class Class_permisos
    ''' <summary>
    ''' Funcion que elimina un permiso asignado a un rol en especifico
    ''' </summary>
    ''' <param name="lngId_permiso"> id del permiso a eliminar </param>
    ''' <returns>devulve 1 si es exitoso y -1 si ha ocurrido un error</returns>
    ''' <remarks></remarks>
    Public Function Eliminar_permiso(ByVal lngId_permiso As Long, ByVal lngRol As Long) As Long
        Try

            Dim item_usuario As New permiso_asignado
            Dim db As New ProyectoEntities

            item_usuario = db.permiso_asignado.First(Function(x) x.fk_permiso = lngId_permiso And x.fk_rol = lngRol)
            db.permiso_asignado.Remove(item_usuario)
            db.SaveChanges()


            Eliminar_permiso = 1
        Catch ex As Exception
            Eliminar_permiso = -1
        End Try
    End Function

    Public Function Eliminar_permisos(ByVal lngIdRol As Long) As Long
        Try
            Dim db As New ProyectoEntities
            Dim obj As New List(Of permiso_asignado)
            obj = db.permiso_asignado.Where(Function(x) x.fk_rol = lngIdRol).ToList

            For Each a As Object In obj
                db.permiso_asignado.Remove(a)
                db.SaveChanges()
            Next
            
            Eliminar_permisos = 1
        Catch ex As Exception
            Eliminar_permisos = -1
        End Try
    End Function

    Public Function ingreso_permisos(ByVal lngRol As Long, ByVal lngPermiso As Long) As Long
        Try
            Dim db As New ProyectoEntities
            Dim obj As New permiso_asignado
            obj.fk_rol = lngRol
            obj.fk_permiso = lngPermiso
            obj = db.permiso_asignado.Add(obj)
            db.SaveChanges()
            ingreso_permisos = 1
        Catch ex As Exception
            ingreso_permisos = -1
        End Try
    End Function

End Class
