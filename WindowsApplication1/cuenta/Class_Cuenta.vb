Imports DB
Public Class Class_Cuenta
    Public Function Ingreso_Cuenta(ByVal strNombre As String,
                                      ByVal strNumero As String,
                                      ByVal lngTipo As Long) As Long
        Try
            Dim db As New proyectoEntities
            Dim item_Per As New Cuenta

            item_Per.Nombre = strNombre
            item_Per.Numero = strNumero
            item_Per.fk_tipo_cuenta = lngTipo


            db.Cuenta.Add(item_Per)
            db.SaveChanges()

            Ingreso_Cuenta = 1
        Catch ex As Exception
            Ingreso_Cuenta = -1
        End Try
    End Function
    Public Function eliminar_cuenta(ByVal lngId_Cuenta As Long) As Long
        Try
            Dim db As New proyectoEntities
            Dim item_Per As New Cuenta

            item_Per = db.Cuenta.First(Function(x) x.Numero = lngId_Cuenta)
            db.Cuenta.Remove(item_Per)
            db.SaveChanges()

            eliminar_cuenta = 1
        Catch ex As Exception
            eliminar_cuenta = -1
        End Try

    End Function
    Public Function Actualizar_Cuenta(ByVal strNombre As String,
                                       ByVal strnumero As String,
                                       ByVal lngTipo As Long,
                                       ByVal lngID As Long) As Long
        Try
            Dim Cuenta As New Cuenta
            Dim db As New proyectoEntities
            Dim old As New Cuenta
            Cuenta.Nombre = strNombre
            Cuenta.Numero = strnumero
            Cuenta.fk_tipo_cuenta = lngTipo
            old = db.Cuenta.FirstOrDefault(Function(x) x.Numero = lngID)
            old.Nombre = Cuenta.Nombre
            old.Numero = Cuenta.Numero
            old.tipo_cuenta = Cuenta.tipo_cuenta
            db.SaveChanges()
            Actualizar_Cuenta = 1
        Catch ex As Exception
            Actualizar_Cuenta = -1

        End Try
    End Function

End Class
