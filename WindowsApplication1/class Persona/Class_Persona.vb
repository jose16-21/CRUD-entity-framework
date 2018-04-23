Imports DB

Public Class Class_Persona
    ''' <summary>
    ''' Ingreso de persona al sistema
    ''' </summary>
    ''' <param name="strNombres">Nombre o nombres del usuario</param>
    ''' <param name="strApellidos">Apellido o apellidos del usuario</param>
    ''' <param name="lngCodigoEmp">codigo de empleado</param>
    ''' <param name="lngUsuario">Seleccionar un usuario ya creado para esta persona</param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
    Public Function Ingreso_Personas(ByVal strNombres As String,
                                      ByVal strApellidos As String,
                                      ByVal lngCodigoEmp As Long,
                                      ByVal lngUsuario As Long) As Long
        Try
            Dim db As New ProyectoEntities
            Dim item_Per As New persona

            Dim item_Usua As New Usuario
            Dim old As New Usuario


            item_Per.nombres = strNombres
            item_Per.apellidos = strApellidos
            item_Per.codigo_empleado = lngCodigoEmp
            item_Per.fk_usuario = lngUsuario
            db.persona.Add(item_Per)
            db.SaveChanges()

            item_Usua.asignado = 1
            old = db.Usuario.FirstOrDefault(Function(x) x.id_usuario = lngUsuario)
            old.asignado = item_Usua.asignado
            db.SaveChanges()

            Ingreso_Personas = 1
        Catch ex As Exception
            Ingreso_Personas = -1
        End Try
    End Function
    ''' <summary>
    ''' Eliminacion de una persona
    ''' </summary>
    ''' <param name="lngId_persona">llave primaria</param>
    ''' <returns>1 si es completada correctamente , -1 si sucede un error</returns>
    ''' <remarks></remarks>
    Public Function eliminar_persona(ByVal lngId_persona As Long) As Long
        Try
            Dim db As New ProyectoEntities
            Dim item_Per As New persona
            Dim item_Usua As New Usuario
            Dim old As New Usuario
            Dim lngusuario As Long

            item_Per = db.persona.First(Function(x) x.id_persona = lngId_persona)
            lngusuario = item_Per.fk_usuario
            db.persona.Remove(item_Per)
            db.SaveChanges()

            item_Usua.asignado = False
            old = db.Usuario.FirstOrDefault(Function(x) x.id_usuario = lngUsuario)
            old.asignado = item_Usua.asignado
            db.SaveChanges()

            eliminar_persona = 1
        Catch ex As Exception
            eliminar_persona = -1
        End Try

    End Function
    ''' <summary>
    ''' Actualizacion de personas en el sistema
    ''' </summary>
    ''' <param name="strNomres">Nombres de usuarios</param>
    ''' <param name="strApellidos">Apellidos de usuarios</param>
    ''' <param name="lngUsuario">llave foranea la tabla usuario</param>    
    ''' <param name="lngIdPersona">llave primaria de la persona</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Actualizar_persona(ByVal strNomres As String,
                                       ByVal strApellidos As String,
                                       ByVal lngUsuario As Long,                                      
                                       ByVal lngIdPersona As Long) As Long
        Try
            Dim Persona As New persona
            Dim db As New ProyectoEntities
            Dim old As New persona
            Persona.nombres = strNomres
            Persona.apellidos = strApellidos
            Persona.fk_usuario = lngUsuario            
            old = db.persona.FirstOrDefault(Function(x) x.id_persona = lngIdPersona)
            old.nombres = Persona.nombres
            old.apellidos = Persona.apellidos
            old.fk_usuario = Persona.fk_usuario
            old.codigo_empleado = Persona.codigo_empleado
            db.SaveChanges()

            Actualizar_persona = 1
        Catch ex As Exception
            Actualizar_persona = -1

        End Try
    End Function



End Class
