Imports System
Imports System.IO
Imports System.Collections
Imports DB
Public Class Class_Archivo
    Dim db As New proyectoEntities

    Public Function lee_archivo()
        Dim objStreamReader As StreamReader
        Dim strLine As String
        Dim tipo_line, linea_archivo As Long
        tipo_line = 2
        Dim obj As New List(Of Cuenta)

        obj = db.Cuenta.ToList()
        Dim fecha_archivo As String
        fecha_archivo = Format(Now(), "yyyyMMdd")

        'objStreamReader = New StreamReader("C:\Ap\BANCA." & fecha_archivo)
        objStreamReader = New StreamReader("C:\Ap\BANCA.20150607")

        strLine = objStreamReader.ReadLine

        Do While Not strLine Is Nothing
            linea_archivo = Mid(strLine, 1, 1)

            If linea_archivo = tipo_line Then
                For Each a As Cuenta In obj
                    Dim numero As String = a.Numero
                    numero = numero.PadLeft(10, "0")
                    Dim numero_archivo As String = Mid(strLine, 2, 10)                    
                    If numero = numero_archivo Then
                        Dim fecha_fina As Date
                        Dim tipo_transaccion, agencia, documento, secuencia, dia, mes, año As String
                        Dim Movimiento_descripcion As String
                        Dim valor, valor1, saldo1, saldo As String
                        Dim lngresultado As Long
                        numero = Mid(strLine, 2, 10)
                        '     03 REG-MOVTO-DIA                 PIC 9(002).  
                        dia = Mid(strLine, 12, 2)
                        '     03 REG-MOVTO-TIPO-TRANSAC        PIC 9(002).
                        tipo_transaccion = Mid(strLine, 14, 2)
                        '     03 REG-MOVTO-DESCRIPCION         PIC X(015).
                        Movimiento_descripcion = Mid(strLine, 16, 15)
                        '     03 REG-MOVTO-AGENCIA             PIC 9(003). 
                        agencia = Mid(strLine, 31, 3)
                        '     03 REG-MOVTO-DOCUMENTO           PIC 9(010).   
                        documento = Mid(strLine, 34, 10)
                        '     03 REG-MOVTO-VALOR               PIC 9(009)V99.  
                        valor = Mid(strLine, 44, 11)
                        If valor Then
                            valor1 = Mid(valor, 1, 9)
                            valor = valor1 & "." & Mid(valor, 10, 2)
                        End If
                        '     03 REG-MOVTO-MONTH               PIC 9(002). 
                        mes = Mid(strLine, 55, 2)
                        '     03 REG-MOVTO-YEAR                PIC 9(004).
                        año = Mid(strLine, 57, 4)
                        '     03 REG-MOVTO-SECUENCIA           PIC 9(004). 
                        secuencia = Mid(strLine, 61, 4)
                        '     03 REG-MOVTO-SALDO               PIC 9(009)V99.         
                        saldo = Mid(strLine, 65, 11)
                        If saldo Then
                            saldo1 = Mid(saldo, 1, 9)
                            saldo = saldo1 & "." & Mid(saldo, 10, 2)
                        End If
                        fecha_fina = dia & "-" & mes & "-" & año

                        lngresultado = almacenar_registros(numero, fecha_fina, tipo_transaccion, Movimiento_descripcion, agencia, documento, valor, secuencia, saldo)
                    End If
                Next
            End If      
            strLine = objStreamReader.ReadLine
        Loop
        MsgBox("finalizo el rrecorrido")
        objStreamReader.Close()
        Return 1
    End Function
    Function almacenar_registros(ByVal Numero As Integer,
                                ByVal fecha As Date,
                                ByVal tipo_transaccion As Integer,
                                ByVal Movimiento_descripcion As String,
                                ByVal agencia As Integer,
                                ByVal documento As Integer,
                                ByVal valor As Decimal,
                                ByVal secuencia As Integer,
                                ByVal saldo As Decimal)
        Try
            Dim obj As New Archivo
            obj.numero_cuenta = Numero
            obj.agencia = agencia
            obj.documento = documento
            obj.fecha = fecha
            obj.descripcion = Movimiento_descripcion
            obj.saldo = saldo
            obj.secuencia = secuencia
            obj.tipo_transaccion = tipo_transaccion
            obj.valor = valor
            db.Archivo.Add(obj)
            db.SaveChanges()
            almacenar_registros = 1
        Catch ex As Exception
            almacenar_registros = -1
        End Try
    End Function

End Class
