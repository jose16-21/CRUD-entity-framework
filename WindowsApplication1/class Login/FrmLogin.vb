Public Class FrmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim samplePrincipal As New SampleIPrincipal(Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        Me.PasswordTextBox.Text = ""
        If (Not samplePrincipal.Identity.IsAuthenticated) Then
            MsgBox("Datos incorrectos")
        Else
            My.User.CurrentPrincipal = samplePrincipal
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click

End Sub
End Class
