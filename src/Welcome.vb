Public Class Welcome

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Form1.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Form2.ShowDialog()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Opacity = 0
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Form3.ShowDialog()
    End Sub
End Class