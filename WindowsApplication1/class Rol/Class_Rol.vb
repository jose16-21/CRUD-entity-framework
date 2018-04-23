Imports DB

Public Class Class_Rol
    ''' <summary>
    ''' Ingreso de Rol con dos parametros nombre y descripcion
    ''' </summary>
    ''' <param name="strNombre">Ingreso de Nombre del Rol</param>
    ''' <param name="strDescripcon">Breve descripcion del Rol</param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
    Public Function Ingreso_Rol(ByVal strNombre As String,
                                 ByVal strDescripcon As String) As Long
        Try

            Dim item_Rol As New Rol
            Dim db As New ProyectoEntities

            item_Rol.nombre = strNombre
            item_Rol.descripcion = strDescripcon
            db.Rol.Add(item_Rol)
            db.SaveChanges()

            Ingreso_Rol = 1

        Catch ex As Exception
            Ingreso_Rol = -1
        End Try

    End Function
    ''' <summary>
    ''' Eliminacion de Rol del Sistema
    ''' </summary>
    ''' <param name="lngId_Rol"> llave primaria</param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
  
    Public Function Eliminar_rol(ByVal lngId_Rol As Long) As Long
        Try
            Dim db As New ProyectoEntities
            Dim item_Per As New Rol

            item_Per = db.Rol.First(Function(x) x.id_rol = lngId_Rol)
            db.Rol.Remove(item_Per)
            db.SaveChanges()

            Eliminar_rol = 1
        Catch ex As Exception
            Eliminar_rol = -1
        End Try

    End Function
    ''' <summary>
    ''' Actualiza nombres y descripcion de los roles
    ''' </summary>
    ''' <param name="strNombre"> nombre del rol</param>
    ''' <param name="strDescripcion">descripcion del rol</param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
    Public Function Actualizar_Rol(ByVal strNombre As String,
                                   ByVal strDescripcion As String,
                                   ByVal lngId_Rol As Long) As Long
        Try
            Dim Rol As New Rol
            Dim DB As New ProyectoEntities
            Dim old As New Rol

            Rol.descripcion = strDescripcion
            Rol.nombre = strNombre

            old = DB.Rol.FirstOrDefault(Function(x) x.id_rol = lngId_Rol)

            old.nombre = Rol.nombre
            old.descripcion = Rol.descripcion
            DB.SaveChanges()

            Actualizar_Rol = 1
        Catch ex As Exception
            Actualizar_Rol = -1
        End Try
    End Function

End Class
