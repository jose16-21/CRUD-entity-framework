Public Class Inicio

Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

End Sub

Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

End Sub

Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.FrmLogin.ShowDialog()

        If My.User.IsAuthenticated Then
            Dim frm As New MenuPrincipal()
            frm.Show()
            Me.Hide()
        End If
End Sub
End Class