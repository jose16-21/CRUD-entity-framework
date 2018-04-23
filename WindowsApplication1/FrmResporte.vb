Imports DB
Imports System.IO
Imports System.Data
Imports System.Reflection
Imports iTextSharp.text
Imports iTextSharp.text.pdf
'Imports Microsoft.Office.Interop
'Imports Microsoft.Office.Interop.Excel
Public Class FrmResporte
    Dim db As New proyectoEntities
    Private Sub FrmResporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Me.DataGridView1.AutoGenerateColumns = False
        Dim lista As List(Of Archivo)
        Dim Registros As Long
        Dim strFechaInicial, strFechaFinal As String
        Dim inicial, final As Date
        Dim rowSelected As New List(Of DataGridViewRow)
        Dim listacuentas As New List(Of String)
        Dim listaTipo As New List(Of String)

        If FrmTipoConsulta.RbtnDocumento.Checked = True Then

        lista = db.Archivo.Where(Function(x) x.documento = FrmTipoConsulta.TextBox1.Text).ToList()
        Registros = lista.Count

            If Registros > 0 Then
            Label1.Text = "Registros por Documento"
            FrmTipoConsulta.Visible = False
                DataGridView1.DataSource = lista
            Else
            MsgBox("No existe ni un registro con ese numero de documento ")
            Me.Close()
            End If

        ElseIf FrmTipoConsulta.RbtnCntAhorro.Checked = True Then

         For i As Integer = 0 To FrmTipoConsulta.DGVTipoCuentas.Rows.Count - 1
            If Convert.ToBoolean(FrmTipoConsulta.DGVTipoCuentas.Rows(i).Cells(0).Value) Then
                listacuentas.Add(FrmTipoConsulta.DGVTipoCuentas.Rows(i).Cells(2).Value)
            End If
        Next

        For i As Integer = 0 To FrmTipoConsulta.DGVTipoOperacion.Rows.Count - 1
            If Convert.ToBoolean(FrmTipoConsulta.DGVTipoOperacion.Rows(i).Cells(0).Value) Then
                listaTipo.Add(FrmTipoConsulta.DGVTipoOperacion.Rows(i).Cells(1).Value)
            End If
        Next

            inicial = FrmTipoConsulta.MonthCalendar1.SelectionRange.Start.ToShortDateString()
            final = FrmTipoConsulta.MonthCalendar2.SelectionRange.Start.ToShortDateString()
            Label1.Text = "Desde" & inicial & " Hasta" & final
            strFechaFinal = Format(final, "yyyy/MM/dd")
            strFechaInicial = Format(inicial, "yyyy/MM/dd")
            lista = db.Archivo.Where(Function(X) listacuentas.Contains(X.numero_cuenta.Value) And listaTipo.Contains(X.tipo_transaccion.Value) And X.fecha >= inicial And X.fecha <= final).ToList()
            Registros = lista.Count
            If Registros > 0 Then
            FrmTipoConsulta.Visible = False
            DataGridView1.DataSource = lista
            Else

                MsgBox("No existe ni un registro  ")
                Me.Close()

            End If
        ElseIf FrmTipoConsulta.RbtnCntaMon.Checked = True Then

             For i As Integer = 0 To FrmTipoConsulta.DGVTipoCuentas.Rows.Count - 1
            If Convert.ToBoolean(FrmTipoConsulta.DGVTipoCuentas.Rows(i).Cells(0).Value) Then
                listacuentas.Add(FrmTipoConsulta.DGVTipoCuentas.Rows(i).Cells(2).Value)
            End If
        Next

        For i As Integer = 0 To FrmTipoConsulta.DGVTipoOperacion.Rows.Count - 1
            If Convert.ToBoolean(FrmTipoConsulta.DGVTipoOperacion.Rows(i).Cells(0).Value) Then
                listaTipo.Add(FrmTipoConsulta.DGVTipoOperacion.Rows(i).Cells(2).Value)
            End If
        Next

            inicial = FrmTipoConsulta.MonthCalendar1.SelectionRange.Start.ToShortDateString()
            final = FrmTipoConsulta.MonthCalendar2.SelectionRange.Start.ToShortDateString()
            Label1.Text = "Desde" & inicial & " Hasta" & final
            strFechaFinal = Format(final, "yyyy/MM/dd")
            strFechaInicial = Format(inicial, "yyyy/MM/dd")
            lista = db.Archivo.Include("Cuenta").Where(Function(X) listacuentas.Contains(X.numero_cuenta.Value) And listaTipo.Contains(X.tipo_transaccion.Value) And X.fecha >= inicial And X.fecha <= final).ToList()
            Registros = lista.Count
            If Registros > 0 Then
            FrmTipoConsulta.Visible = False
            DataGridView1.DataSource = lista
            Else

                MsgBox("No existe ni un registro  ")
                Me.Close()
            End If
        End If

        

       

        'Me.DataGridView1.AutoGenerateColumns = False
        ''DataGridView1.DataSource = db.Archivo.Where(Function(x) listacuentas.Contains(x.Cuenta.ToString) And listaTipo.Contains(x.tipo_transaccion.ToString)).ToList()
        'Dim lista As List(Of Archivo)
        'lista = db.Archivo.Include("tipo_transaccion1").Where(Function(x) listacuentas.Contains(x.numero_cuenta.Value) And listaTipo.Contains(x.tipo_transaccion.Value) And x.fecha >= inicial And x.fecha <= final).ToList()
        'DataGridView1.DataSource = lista

    End Sub



Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FrmTipoConsulta.Close()
        Me.Close()
End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FrmTipoConsulta.Show()
        Me.Close()

End Sub


Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Dim credito = New Integer() {1, 2, 3, 5, 6, 7}
        'Dim devito = New Integer() {51, 52, 53, 54, 55, 56}

        'Dim app As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        'Dim workbook As Microsoft.Office.Interop.Excel._Workbook = app.Workbooks.Add(Type.Missing)
        'Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing
        'worksheet = workbook.Sheets("Hoja1")
        'Worksheet = workbook.ActiveSheet
        ''Aca se agregan las cabeceras de nuestro datagrid. 
        'For i As Integer = 1 To Me.DataGridView1.Columns.Count
        'worksheet.Cells(1, i) = Me.DataGridView1.Columns(i - 1).HeaderText
        'Next
        'worksheet.Cells(1, 9) = "DEBE"
        'worksheet.Cells(1, 10) = "HABER"

        ''Aca se ingresa el detalle recorrera la tabla celda por celda 

        'For i As Integer = 0 To Me.DataGridView1.Rows.Count - 1
        '    For j As Integer = 0 To Me.DataGridView1.Columns.Count - 1
        '        worksheet.Cells(i + 2, j + 1) = Me.DataGridView1.Rows(i).Cells(j).Value.ToString()

        '        For index = 0 To credito.GetUpperBound(0)
        '            If Me.DataGridView1.Rows(i).Cells(7).Value.ToString() = credito(index) Then
        '                 worksheet.Cells(i + 2, 10) = Me.DataGridView1.Rows(i).Cells(3).Value.ToString()
        '            End If
        '        Next

        '        For index = 0 To devito.GetUpperBound(0)
        '            If Me.DataGridView1.Rows(i).Cells(7).Value.ToString() = devito(index) Then
        '                 worksheet.Cells(i + 2, 9) = Me.DataGridView1.Rows(i).Cells(3).Value.ToString()
        '            End If
        '        Next


        '    Next
        'Next
        ''Aca le damos el formato a nuestro excel 
        'worksheet.Rows.Item(1).Font.Bold = 1
        'worksheet.Rows.Item(1).HorizontalAlignment = 3
        'worksheet.Columns.AutoFit()
        'worksheet.Columns.HorizontalAlignment = 2
        'app.Visible = True
        'app = Nothing
        'workbook = Nothing
        'worksheet = Nothing
        'FileClose(1)
        'GC.Collect()
    End Sub
End Class