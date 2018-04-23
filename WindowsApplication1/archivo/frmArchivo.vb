Imports DB

Public Class frmArchivo

    Private Sub frmArchivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New proyectoEntities
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = db.bitacora1.ToList()
        DataGridView2.AutoGenerateColumns = False
        DataGridView2.DataSource = db.FTPCARGA.ToList()


End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub
End Class