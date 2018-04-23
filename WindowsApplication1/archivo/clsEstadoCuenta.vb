
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.Data.SqlClient
Imports System.IO

Namespace e_Solutions.e_Manager.FS.DataCentro.Entidades
    Public Class clsEstadoCuenta
        ' Methods
        Public Sub Add(ByVal pRegistroDetalle As clsRegistroDetalle)
            Me.mDetalles.Add(pRegistroDetalle)
        End Sub

        Public Sub Grabar(ByVal objConexion As SqlConnection, ByVal objTransaccion As SqlTransaction)
            Try 
                objTransaccion = objConexion.BeginTransaction
                'Me.mID = New AccesoDatos(objConexion, objTransaccion).Insertar_sp_fs_Estado_Cuenta_Ins(Me.mCuenta, Me.mAnio, Me.mMes, Me.mIMes, 1, StringType.FromLong(Me.mCorrelativo), Me.mNombreCliente, Me.mDireccion, Me.mTotalDebito, Me.mTotalCredito, Me.mTotalSaldo, Me.mSaldoAnterior, Me.mTarjeta)
                Dim _Vb_t_i4_0 As Integer = (Me.mDetalles.Count - 1)
                Dim intContFila As Integer = 0
                Do While (intContFila <= _Vb_t_i4_0)
                    Dim objDetalle As clsRegistroDetalle = DirectCast(Me.mDetalles.Item(intContFila), clsRegistroDetalle)
                    intContFila += 1
                Loop
                objTransaccion.Commit
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                objTransaccion.Rollback
                Throw New Exception((ex.Message & " --Guardar BDD.--"))
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Sub Grabar(ByVal writerDetEstCta As StreamWriter, ByVal writerEstCta As StreamWriter)
            Try 
                If Me.Verifica Then
                    Dim linea As String = "0|"
                    linea = (((((((((((((linea & Me.mCuenta & "|") & StringType.FromInteger(Me.mAnio) & "|") & Me.mMes & "|") & StringType.FromInteger(Me.mIMes) & "|") & "1|") & StringType.FromLong(Me.mCorrelativo) & "|") & Me.mNombreCliente & "|") & Me.mDireccion & "|") & StringType.FromDouble(Me.mTotalDebito) & "|") & StringType.FromDouble(Me.mTotalCredito) & "|") & StringType.FromDouble(Me.mTotalSaldo) & "|") & StringType.FromDouble(Me.mSaldoAnterior) & "|") & Me.mTarjeta)
                    writerEstCta.WriteLine(linea)
                    Dim _Vb_t_i4_0 As Integer = (Me.mDetalles.Count - 1)
                    Dim intContFila As Integer = 0
                    Do While (intContFila <= _Vb_t_i4_0)
                        Dim objDetalle As clsRegistroDetalle = DirectCast(Me.mDetalles.Item(intContFila), clsRegistroDetalle)
                        linea = "0|"
                        linea = ((((((((((linea & Me.mCuenta & "|") & StringType.FromInteger(Me.mIMes) & "|") & objDetalle.intDia.ToString & "|") & objDetalle.strDocumento & "|") & objDetalle.strDescripcion & "|") & StringType.FromDouble(objDetalle.dblDebito) & "|") & StringType.FromDouble(objDetalle.dblCredito) & "|") & StringType.FromDouble(objDetalle.dblSaldo) & "|") & StringType.FromLong(Me.mID) & "|") & objDetalle.strLegajo)
                        writerDetEstCta.WriteLine(linea)
                        intContFila += 1
                    Loop
                End If
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Throw New Exception((ex.Message & " --Guardar BDD.--"))
                ProjectData.ClearProjectError
            End Try
        End Sub

        Public Function Verifica() As Boolean
            Dim Verificas As Boolean = True
            Dim blnVerifica As Boolean = True
            Try 
                Dim linea As String = "0|"
                linea = (((((((((((((linea & Me.mCuenta & "|") & StringType.FromInteger(Me.mAnio) & "|") & Me.mMes & "|") & StringType.FromInteger(Me.mIMes) & "|") & "1|") & StringType.FromLong(Me.mCorrelativo) & "|") & Me.mNombreCliente & "|") & Me.mDireccion & "|") & StringType.FromDouble(Me.mTotalDebito) & "|") & StringType.FromDouble(Me.mTotalCredito) & "|") & StringType.FromDouble(Me.mTotalSaldo) & "|") & StringType.FromDouble(Me.mSaldoAnterior) & "|") & Me.mTarjeta)
                blnVerifica = Me.Verifica_Encabezado(linea)
                If blnVerifica Then
                    Dim _Vb_t_i4_0 As Integer = (Me.mDetalles.Count - 1)
                    Dim intContFila As Integer = 0
                    Do While (intContFila <= _Vb_t_i4_0)
                        Dim objDetalle As clsRegistroDetalle = DirectCast(Me.mDetalles.Item(intContFila), clsRegistroDetalle)
                        linea = "0|"
                        linea = ((((((((((linea & Me.mCuenta & "|") & StringType.FromInteger(Me.mIMes) & "|") & objDetalle.intDia.ToString & "|") & objDetalle.strDocumento & "|") & objDetalle.strDescripcion & "|") & StringType.FromDouble(objDetalle.dblDebito) & "|") & StringType.FromDouble(objDetalle.dblCredito) & "|") & StringType.FromDouble(objDetalle.dblSaldo) & "|") & StringType.FromLong(Me.mID) & "|") & objDetalle.strLegajo)
                        blnVerifica = Me.Verifica_Detalle(linea)
                        If Not blnVerifica Then
                            Exit Do
                        End If
                        intContFila += 1
                    Loop
                End If
                Verifica = blnVerifica
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim ex As Exception = exception1
                Throw New Exception((ex.Message & " --Guardar BDD.--"))
                ProjectData.ClearProjectError
            End Try
            Return Verifica
        End Function

        Public Function Verifica_Detalle(ByVal linea As String) As Boolean
            Dim bVerifica As Boolean = True
            Dim nDatos As String() = linea.Split(New Char() { "|"c })
            If (nDatos.Length <> 11) Then
                bVerifica = False
            End If
            If (bVerifica And (DoubleType.FromString(nDatos(0)) <> 0)) Then
                bVerifica = False
            End If
            If (bVerifica And (StringType.StrCmp(nDatos(1), "", False) = 0)) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(2))) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(3))) Then
                bVerifica = False
            End If
            If (bVerifica And (StringType.StrCmp(nDatos(4), "", False) = 0)) Then
                bVerifica = False
            End If
            If (bVerifica And (StringType.StrCmp(nDatos(5), "", False) = 0)) Then
                bVerifica = False
            End If
            If (bVerifica And (StringType.StrCmp(nDatos(6), "", False) = 0)) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(7))) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(8))) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(9))) Then
                bVerifica = False
            End If
            Return bVerifica
        End Function

        Private Function Verifica_Encabezado(ByVal linea As String) As Boolean
            Dim bVerifica As Boolean = True
            Dim nDatos As String() = linea.Split(New Char() { "|"c })
            If (nDatos.Length <> 14) Then
                bVerifica = False
            End If
            If (bVerifica And (DoubleType.FromString(nDatos(0)) <> 0)) Then
                bVerifica = False
            End If
            If (bVerifica And (StringType.StrCmp(nDatos(1), "", False) = 0)) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(2))) Then
                bVerifica = False
            End If
            If (bVerifica And (StringType.StrCmp(nDatos(3), "", False) = 0)) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(4))) Then
                bVerifica = False
            End If
            If (bVerifica And Not Information.IsNumeric(nDatos(5))) Then
                bVerifica = False
            End If
            Return bVerifica
        End Function


        ' Properties
        Public Property dblSaldoAnterior As Double
            Get
                Return Me.mSaldoAnterior
            End Get
            Set(ByVal Value As Double)
                Me.mSaldoAnterior = Value
            End Set
        End Property

        Public Property dblTotalCredito As Double
            Get
                Return Me.mTotalCredito
            End Get
            Set(ByVal Value As Double)
                Me.mTotalCredito = Value
            End Set
        End Property

        Public Property dblTotalDebito As Double
            Get
                Return Me.mTotalDebito
            End Get
            Set(ByVal Value As Double)
                Me.mTotalDebito = Value
            End Set
        End Property

        Public Property dblTotalSaldo As Double
            Get
                Return Me.mTotalSaldo
            End Get
            Set(ByVal Value As Double)
                Me.mTotalSaldo = Value
            End Set
        End Property

        Public ReadOnly Property Detalle As ArrayList
            Get
                Return Me.mDetalles
            End Get
        End Property

        Public Property intAnio As Integer
            Get
                Return Me.mAnio
            End Get
            Set(ByVal Value As Integer)
                Me.mAnio = Value
            End Set
        End Property

        Public Property intMes As Integer
            Get
                Return Me.mIMes
            End Get
            Set(ByVal Value As Integer)
                Me.mIMes = Value
            End Set
        End Property

        Public Property lngCorrelativo As Long
            Get
                Return Me.mCorrelativo
            End Get
            Set(ByVal Value As Long)
                Me.mCorrelativo = Value
            End Set
        End Property

        Public Property lngID As Long
            Get
                Return Me.mID
            End Get
            Set(ByVal Value As Long)
                Me.mID = Value
            End Set
        End Property

        Public Property strCuenta As String
            Get
                Return Me.mCuenta
            End Get
            Set(ByVal Value As String)
                Me.mCuenta = Value
            End Set
        End Property

        Public Property strDireccion As String
            Get
                Return Me.mDireccion
            End Get
            Set(ByVal Value As String)
                Me.mDireccion = Value
            End Set
        End Property

        Public Property strMes As String
            Get
                Return Me.mMes
            End Get
            Set(ByVal Value As String)
                Me.mMes = Value
            End Set
        End Property

        Public Property strNombreCliente As String
            Get
                Return Me.mNombreCliente
            End Get
            Set(ByVal Value As String)
                Me.mNombreCliente = Value
            End Set
        End Property

        Public Property strTarjeta As String
            Get
                Return Me.mTarjeta
            End Get
            Set(ByVal Value As String)
                Me.mTarjeta = Value
            End Set
        End Property


        ' Fields
        Private mAnio As Integer
        Private mCorrelativo As Long
        Private mCuenta As String
        Private mDetalles As ArrayList = New ArrayList
        Private mDireccion As String
        Private mID As Long
        Private mIMes As Integer
        Private mMes As String
        Private mNombreCliente As String
        Private mSaldoAnterior As Double
        Private mTarjeta As String
        Private mTotalCredito As Double
        Private mTotalDebito As Double
        Private mTotalSaldo As Double
    End Class
End Namespace

