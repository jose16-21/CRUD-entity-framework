'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Archivo
    Public Property id_archivo As Integer
    Public Property numero_cuenta As Nullable(Of Integer)
    Public Property fecha As Nullable(Of Date)
    Public Property tipo_transaccion As Nullable(Of Integer)
    Public Property descripcion As String
    Public Property agencia As Nullable(Of Integer)
    Public Property documento As Nullable(Of Integer)
    Public Property valor As Nullable(Of Decimal)
    Public Property secuencia As Nullable(Of Integer)
    Public Property saldo As Nullable(Of Decimal)

    Public Overridable Property Cuenta As Cuenta
    Public Overridable Property tipo_transaccion1 As tipo_transaccion

End Class
