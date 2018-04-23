Imports System

Namespace e_Solutions.e_Manager.FS.DataCentro.Entidades
    Public Class clsRegistroDetalle
        ' Properties
        Public Property dblCredito As Double
            Get
                Return Me.mCredito
            End Get
            Set(ByVal Value As Double)
                Me.mCredito = Value
            End Set
        End Property

        Public Property dblDebito As Double
            Get
                Return Me.mDebito
            End Get
            Set(ByVal Value As Double)
                Me.mDebito = Value
            End Set
        End Property

        Public Property dblSaldo As Double
            Get
                Return Me.mSaldo
            End Get
            Set(ByVal Value As Double)
                Me.mSaldo = Value
            End Set
        End Property

        Public Property intDia As Integer
            Get
                Return Me.mDia
            End Get
            Set(ByVal Value As Integer)
                Me.mDia = Value
            End Set
        End Property

        Public Property intMes As Integer
            Get
                Return Me.mMes
            End Get
            Set(ByVal Value As Integer)
                Me.mMes = Value
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

        Public Property strDescripcion As String
            Get
                Return Me.mDescripcion
            End Get
            Set(ByVal Value As String)
                Me.mDescripcion = Value
            End Set
        End Property

        Public Property strDocumento As String
            Get
                Return Me.mDocumento
            End Get
            Set(ByVal Value As String)
                Me.mDocumento = Value
            End Set
        End Property

        Public Property strLegajo As String
            Get
                Return Me.mLegajo
            End Get
            Set(ByVal Value As String)
                Me.mLegajo = Value
            End Set
        End Property

        Public Property strMes As String
            Get
                Return Me.msMes
            End Get
            Set(ByVal Value As String)
                Me.msMes = Value
            End Set
        End Property


        ' Fields
        Private mCredito As Double = 0
        Private mDebito As Double = 0
        Private mDescripcion As String = ""
        Private mDia As Integer = 0
        Private mDocumento As String = ""
        Private mID As Long
        Private mLegajo As String = ""
        Private mMes As Integer
        Private mSaldo As Double = 0
        Private msMes As String
    End Class
End Namespace

