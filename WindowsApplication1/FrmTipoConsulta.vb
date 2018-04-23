Imports DB
Public Class FrmTipoConsulta
    Dim db As New proyectoEntities
    Private Sub frmConsultaEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Me.DGVTipoOperacion.AutoGenerateColumns = False
        Me.DGVTipoOperacion.DataSource = DB.tipo_transaccion.ToList()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If RbtnDocumento.Checked = True And TextBox1.Text <> "" Then        
        FrmResporte.Show()        
        ElseIf RbtnCntAhorro.Checked = True Then
          Dim lngseleccionadosOpe, lngSeleccionadosCuenta As Long
            For i As Integer = 0 To DGVTipoOperacion.RowCount - 1
              If DGVTipoOperacion.Rows(i).Cells(0).Value = True Then
                    lngseleccionadosOpe = lngseleccionadosOpe + 1
              End If
            Next
            For i As Integer = 0 To DGVTipoCuentas.RowCount - 1
              If DGVTipoCuentas.Rows(i).Cells(0).Value = True Then
                    lngSeleccionadosCuenta = lngSeleccionadosCuenta + 1
              End If
            Next
            If lngseleccionadosOpe >= 1 And lngSeleccionadosCuenta >= 1 Then
                    FrmResporte.Show()
            Else
                 MsgBox("Seleccione un tipo de Transaccion y una Cuenta")
            End If
        ElseIf RbtnCntaMon.Checked = True Then
            Dim lngseleccionadosOpe, lngSeleccionadosCuenta As Long
            For i As Integer = 0 To DGVTipoOperacion.RowCount - 1
              If DGVTipoOperacion.Rows(i).Cells(0).Value = True Then
                    lngseleccionadosOpe = lngseleccionadosOpe + 1
              End If
            Next
            For i As Integer = 0 To DGVTipoCuentas.RowCount - 1
              If DGVTipoCuentas.Rows(i).Cells(0).Value = True Then
                    lngSeleccionadosCuenta = lngSeleccionadosCuenta + 1
              End If
            Next
            If lngseleccionadosOpe >= 1 And lngSeleccionadosCuenta >= 1 Then
                  Dim rs As New FrmResporte
                  rs.ShowDialog()
            Else
                 MsgBox("Seleccione un tipo de Transaccion y una Cuenta")
            End If
        Else
            MsgBox("Seleccione una opcion")
        End If

       
    End Sub

    Private Sub RbtnDocumento_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnDocumento.CheckedChanged
        TextBox1.Enabled = True
    End Sub

    Private Sub RbtnCntAhorro_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCntAhorro.CheckedChanged
        TextBox1.Text = ""
        TextBox1.Enabled = False
        DGVTipoCuentas.AutoGenerateColumns = False
        'DataGridView1.DataSource = obj.Archivo.Where(Function(x) x.fecha >= CDate(inicial) And x.fecha <= CDate(final)).ToList()
        DGVTipoCuentas.DataSource = db.Cuenta.Where(Function(x) x.fk_tipo_cuenta = 2).ToList()
    End Sub

    Private Sub RbtnCntaMon_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCntaMon.CheckedChanged
        TextBox1.Enabled = False
        TextBox1.Text = ""
        DGVTipoCuentas.AutoGenerateColumns = False
        'DataGridView1.DataSource = obj.Archivo.Where(Function(x) x.fecha >= CDate(inicial) And x.fecha <= CDate(final)).ToList()
        DGVTipoCuentas.DataSource = db.Cuenta.Where(Function(x) x.fk_tipo_cuenta = 1).ToList()

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
        For i As Integer = 0 To DGVTipoOperacion.RowCount - 1
            DGVTipoOperacion.Rows(i).Cells(0).Value = True
        Next
        ElseIf CheckBox3.Checked = False Then
        For i As Integer = 0 To DGVTipoOperacion.RowCount - 1
            DGVTipoOperacion.Rows(i).Cells(0).Value = False
        Next
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
    If CheckBox1.Checked = True Then
        For i As Integer = 0 To DGVTipoCuentas.RowCount - 1
            DGVTipoCuentas.Rows(i).Cells(0).Value = True
        Next
        ElseIf CheckBox1.Checked = False Then
            For i As Integer = 0 To DGVTipoCuentas.RowCount - 1
            DGVTipoCuentas.Rows(i).Cells(0).Value = False
        Next
        End If
    End Sub



    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        Dim inicio, dia, mes, año As String

        dia = Me.MonthCalendar1.SelectionRange.Start.Day
        mes = Me.MonthCalendar1.SelectionRange.Start.Month
        año = Me.MonthCalendar1.SelectionRange.Start.Year
        inicio = año & "-" & mes.PadLeft(2, "0") & "-" & dia.PadLeft(2, "0")
        Label1.Text = inicio


    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        Dim dia, fin, mes, año As String

        dia = Me.MonthCalendar2.SelectionRange.Start.Day
        mes = Me.MonthCalendar2.SelectionRange.Start.Month
        año = Me.MonthCalendar2.SelectionRange.Start.Year
        fin = año & "-" & mes.PadLeft(2, "0") & "-" & dia.PadLeft(2, "0")
        Label2.Text = fin
    End Sub


End Class