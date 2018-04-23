Imports DB
Imports System.Security.Cryptography
Imports System.Text

Public Class Class_Usuario
    ''' <summary>
    ''' Ingreso de usuario al sistema 
    ''' </summary>
    ''' <param name="strNombre">Nombre de usuario para logiarse</param>
    ''' <param name="strContraseña">contraseña</param>    
    ''' <param name="lngRol">El rol que va asignarse al usuario</param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
    Public Function Ingreso_Usuario(ByVal strNombre As String,
                                    ByVal strContraseña As String,
                                    ByVal lngRol As Long) As Long
        Try
            Dim db As New ProyectoEntities
            Dim usuario As New Usuario


            usuario.nombre = strNombre
            usuario.contraseña = ObtieneMd5Hash(strContraseña)
            usuario.estado = 1
            usuario.asignado = False
            usuario.creacion = Now()
            usuario.rol = lngRol
            db.Usuario.Add(usuario)
            db.SaveChanges()

            Ingreso_Usuario = 1
        Catch ex As Exception
            Ingreso_Usuario = -1
        End Try
    End Function
    ''' <summary>
    ''' Eliminacion de usuario
    ''' </summary>
    ''' <param name="lngId_Usuario"> llave primaria </param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
    Public Function Eliminar_usuario(ByVal lngId_Usuario As Long) As Long
        Try
            Dim item_usuario As New Usuario
            Dim db As New ProyectoEntities

            item_usuario = db.Usuario.First(Function(x) x.id_usuario = lngId_Usuario)
            db.Usuario.Remove(item_usuario)
            db.SaveChanges()

            Eliminar_usuario = 1
        Catch ex As Exception
            Eliminar_usuario = 0
        End Try
    End Function

    Public Function Actualizar_Usuario(ByVal strNombre As String,
                                        ByVal strContraseña As String,
                                        ByVal lngEstado As Long,
                                        ByVal lngRol As Long,
                                        ByVal lngid_usuario As Long) As Long
        Try

            Dim db As New ProyectoEntities
            Dim item_Usua As New Usuario
            Dim old As New Usuario

            item_Usua.nombre = strNombre
            item_Usua.contraseña = ObtieneMd5Hash(strContraseña)
            item_Usua.estado = lngEstado
            item_Usua.creacion = Now()
            item_Usua.rol = lngRol
            old = db.Usuario.FirstOrDefault(Function(x) x.id_usuario = lngid_usuario)
            old.nombre = item_Usua.nombre
            old.contraseña = item_Usua.contraseña
            old.estado = item_Usua.estado
            old.creacion = item_Usua.creacion
            old.rol = item_Usua.rol
            db.SaveChanges()

            Actualizar_Usuario = 1
        Catch ex As Exception
            Actualizar_Usuario = -1
        End Try
    End Function

    Public Function ObtieneMd5Hash(ByVal input As String) As String
        Dim md5Hash As MD5 = MD5.Create()
        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()
    End Function
End Class
