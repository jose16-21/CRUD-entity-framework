Imports DB
Imports System.Text
Imports System.Security.Cryptography
Public Class Identityy


    Implements System.Security.Principal.IIdentity

    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole

    Public ReadOnly Property AuthenticationType As String Implements Security.Principal.IIdentity.AuthenticationType
        Get
            Return "Custom Authentication"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated As Boolean Implements Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    Public ReadOnly Property Name As String Implements Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property
    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    Public Sub New(ByVal strUsuario As String, ByVal Strpassword As String)
        If ValidaUsuario(strUsuario, Strpassword) Then
            Dim db As New ProyectoEntities
            Dim item_usuario As New Usuario
            Dim lngresult As Long
            item_usuario = db.Usuario.FirstOrDefault(Function(x) x.nombre = strUsuario)
            lngresult = item_usuario.rol
            nameValue = strUsuario
            authenticatedValue = True
            roleValue = lngresult
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = -1
        End If

    End Sub
    ''' <summary>
    ''' Valida usuario en base de datos y encripta la contraseña en MD5
    ''' </summary>
    ''' <param name="username">usuario que debe de existir </param>
    ''' <param name="password">contraseña valida en el sistema</param>
    ''' <returns>true si los parametros son validos false si es lo contrario</returns>
    ''' <remarks></remarks>
    Private Function ValidaUsuario(ByVal username As String,
                                   ByVal password As String) As Boolean

        Dim storedHashedPW As String = ObtienePassword(username)

        Dim [source] As String = password
        Using md5Hash As MD5 = MD5.Create()
            Dim resultado As Boolean = VerificaMd5Hash(md5Hash, [source], storedHashedPW)
            Return resultado
        End Using
    End Function

    ''' <summary>
    ''' Obtiene contraseña de la base de datos y la retorna si existe el usuario
    ''' </summary>
    ''' <param name="StrUsuario">Usuario que existe en base de datos</param>
    ''' <returns> si el usuario existe devuelte contraseña sino devuelve "" vacio</returns>
    ''' <remarks></remarks>
    Private Function ObtienePassword(ByVal StrUsuario As String) As String
        Dim item_usuario As New Usuario
        Dim db As New proyectoEntities
        Dim strNombre As String
        item_usuario = db.Usuario.FirstOrDefault(Function(x) x.nombre = StrUsuario)

        If item_usuario Is Nothing Then
            Return ""
        Else
            strNombre = item_usuario.nombre
            If Trim(StrUsuario).ToLower = strNombre Then
                Return item_usuario.contraseña
            End If
        End If
        Return ""
    End Function
    Public Function ObtieneMd5Hash(ByVal md5Hash As MD5, ByVal input As String) As String

        Dim data As Byte() = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input))
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Return sBuilder.ToString()

    End Function

    Public Function VerificaMd5Hash(ByVal md5Hash As MD5, ByVal input As String, ByVal hash As String) As Boolean

        Dim hashOfInput As String = ObtieneMd5Hash(md5Hash, input)
        Dim comparer As StringComparer = StringComparer.OrdinalIgnoreCase
        If 0 = comparer.Compare(hashOfInput, hash) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
